namespace Telerik.Reporting.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Net;

    public class CryptoDataResolver
    {
        const string tempDataDirKey = "CryptoDataTempDir";

        static readonly string defaultTemptDir;
        static readonly string tempDir;

        static readonly Dictionary<string, CurrencyModel> currencyCodes = new Dictionary<string, CurrencyModel>
        {
            {"btc", new CurrencyModel{Name ="Bitcoin", Algorithm = "PoW"}},
            {"bch", new CurrencyModel{Name ="Bitcoin Cash", Algorithm = "PoW"}},
            {"bnb", new CurrencyModel{Name = "Binance Coin", Algorithm = "PoS"}},
            {"ltc", new CurrencyModel{Name ="Litecoin", Algorithm = "PoW"}},
            {"bsv", new CurrencyModel{Name = "Bitcoin SV", Algorithm = "PoW"}} ,
            {"eth", new CurrencyModel{Name ="Ethereum", Algorithm = "PoS"}},
            {"xrp", new CurrencyModel{Name ="Ripple", Algorithm = "PoC"}},
        };

        static CryptoDataResolver()
        {
            defaultTemptDir = Path.Combine(Path.GetTempPath(), "CryptoCurrenciesData");
            tempDir = ConfigurationManager.AppSettings[tempDataDirKey] ?? defaultTemptDir;
        }
        static readonly object LockObject = new object();

        public IEnumerable<CurrencyDetails> GetDetails(string currencyCode)
        {
            if (null == currencyCode || !currencyCodes.ContainsKey(currencyCode))
            {
                yield break;
            }

            lock (LockObject)
            {
                using (var f = File.OpenText(Path.Combine(tempDir, currencyCode + ".csv")))
                {
                    var headerLine = f.ReadLine();
                    var indexes = FillModelIndexer(headerLine);
                    if (null != indexes)
                    {
                        while (!f.EndOfStream)
                        {
                            var line = f.ReadLine();
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                var currentValues = line.Split(',');
                                if (currentValues.Length > indexes.Ceiling)
                                {
                                    var model = new CurrencyDetails();
                                    FillModel(currentValues, model, indexes, currencyCode);
                                    yield return model;
                                }
                                else
                                {
                                    Debug.Assert(true);
                                }
                            }
                        }
                    }
                    else
                    {
                        Debug.Assert(true);
                    }
                }
            }
        }

        public IEnumerable<CurrencyModel> GetData(DateTime forDate)
        {
            var configs = Path.Combine(tempDir, "configs");
            lock (LockObject)
            {
                if (File.Exists(configs))
                {
                    var lastDateTimeCheck = File.ReadAllText(configs);
                    DateTime dateLastDownload;
                    if (DateTime.TryParse(lastDateTimeCheck, out dateLastDownload))
                    {
                        if ((DateTime.Now - dateLastDownload).TotalHours > 1)
                        {
                            this.UpdateDate(configs);
                        }
                    }
                    else
                    {
                        this.UpdateDate(configs);
                    }
                }
                else
                {
                    this.UpdateDate(configs);
                }
                IList<CurrencyModel> result;
                if (!ExtractData(forDate, out result))
                {
                    if (this.RevertData())
                    {
                        ExtractData(forDate, out result);
                    }
                }

                return result;
            }
        }

        static bool ExtractData(DateTime forDate, out IList<CurrencyModel> result)
        {
            result = new List<CurrencyModel>();
            foreach (var currencyCode in currencyCodes)
            {
                var model = currencyCode.Value;
                model.Code = currencyCode.Key;
                using (var f = File.OpenText(Path.Combine(tempDir, currencyCode.Key + ".csv")))
                {
                    var lastLine = string.Empty;
                    var currentValues = new string[0];
                    var previousValues = new string[0];
                    var headerLine = f.ReadLine();
                    var indexes = FillModelIndexer(headerLine);
                    if (null == indexes)
                    {
                        return false;
                    }

                    while (!f.EndOfStream)
                    {
                        previousValues = (string[])currentValues.Clone();
                        DateTime rowDate;
                        lastLine = f.ReadLine();
                        if (string.IsNullOrWhiteSpace(lastLine))
                        {
                            currentValues = previousValues;
                        }
                        currentValues = lastLine.Split(',');
                        if (currentValues.Length < indexes.Ceiling)
                        {
                            currentValues = previousValues;
                        }
                        if (DateTime.TryParse(currentValues[indexes.ForDate], out rowDate)
                            && forDate.Date == rowDate)
                        {
                            break;
                        }
                    }
                    if (currentValues.Length > 6)
                    {
                        FillModel(currentValues, model, indexes, model.Code);
                        result.Add(model);
                    }
                }
            }

            return true;
        }

        static ModelIndexes FillModelIndexer(string headerLine)
        {
            if(null == headerLine)
            {
                return null;
            }
            var model = new ModelIndexes();
            var columns = headerLine.Split(',');
            const string dateH = "date";
            const string priceH = "PriceUSD";
            const string marketH = "CapMrktCurUSD";
            const string coinsH = "SplyCur";

            for (var i = 0; i < columns.Length; i++)
            {
                switch (columns[i])
                {
                    case priceH:
                        model.Price = i;
                        model.Ceiling = Math.Max(model.Ceiling, i);
                        break;
                    case marketH:
                        model.MarketCap = i;
                        model.Ceiling = Math.Max(model.Ceiling, i);
                        break;
                    case coinsH:
                        model.Coins = i;
                        model.Ceiling = Math.Max(model.Ceiling, i);
                        break;
                    case dateH:
                        model.ForDate = i;
                        model.Ceiling = Math.Max(model.Ceiling, i);
                        break;
                }

            }
            if (model.ForDate != -1 && model.MarketCap != -1 && model.Price != -1)
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        static void FillModel(IList<string> values, CurrencyDetails model, ModelIndexes indexes, string code)
        {
            DateTime forDate;
            DateTime.TryParse(values[indexes.ForDate], out forDate);
            model.Date = forDate;

            uint coins;
            if (indexes.Coins != -1)
            {
                uint.TryParse(values[indexes.Coins].Split('.')[0], out coins);
                model.Coins = coins;
            }

            decimal marketCap;
            decimal.TryParse(values[indexes.MarketCap], NumberStyles.Any, CultureInfo.InvariantCulture, out marketCap);
            model.MarketCap = marketCap;

            decimal price;
            decimal.TryParse(values[indexes.Price], NumberStyles.Any, CultureInfo.InvariantCulture, out price);
            model.Price = price;
        }

        void UpdateDate(string configs)
        {
            try
            {
                if (!Directory.Exists(tempDir))
                {
                    Directory.CreateDirectory(tempDir);
                }
                this.DownloadData();
                if (File.Exists(configs))
                {
                    File.Delete(configs);
                }
                using (var f = File.CreateText(configs))
                {
                    f.WriteLine(DateTime.Now.ToString());
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
            }
        }
        void DownloadData()
        {
            const string dataLocation = "https://coinmetrics.io/newdata/{0}.csv";
            lock (LockObject)
            {
                using (var client = new WebClient())
                {
                    foreach (var code in currencyCodes.Keys)
                    {
                        var source = string.Format(dataLocation, code);
                        var destination = Path.Combine(tempDir, code + ".csv");
                        var backup = destination + ".backup";
                        if (File.Exists(backup))
                        {
                            File.Delete(backup);
                        }
                        if (File.Exists(destination))
                        {
                            File.Move(destination, backup);
                        }
                        client.DownloadFile(source, destination);
                    }
                }
            }
        }

        bool RevertData()
        {
            foreach (var code in currencyCodes)
            {
                var destination = Path.Combine(tempDir, code.Key + ".csv");
                var source = destination + ".backup";
                if (!File.Exists(source))
                {
                    return false;
                }
                if (File.Exists(destination))
                {
                    File.Delete(destination);
                }
                File.Move(source, destination);
            }

            return true;
        }

        class ModelIndexes
        {
            internal int ForDate { get; set; }

            public int Coins { get; set; }

            public int Price { get; set; }

            public int MarketCap { get; set; }

            public int Ceiling { get; set; }

            public ModelIndexes()
            {
                this.ForDate = -1;
                this.Coins = -1;
                this.Price = -1;
                this.MarketCap = -1;
            }

        }
    }
}