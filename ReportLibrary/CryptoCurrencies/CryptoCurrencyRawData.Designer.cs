namespace Telerik.Reporting.Examples.CSharp
{
    partial class CryptoCurrencyRawData
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.SortingAction sortingAction1 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.SortingAction sortingAction2 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.SortingAction sortingAction3 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.SortingAction sortingAction4 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            this.table1 = new Telerik.Reporting.Table();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.details = new Telerik.Reporting.ObjectDataSource();
            this.CurrenciesList = new Telerik.Reporting.ObjectDataSource();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.detailSection1 = new Telerik.Reporting.DetailSection();
            this.htmlTextBox1 = new Telerik.Reporting.HtmlTextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // table1
            // 
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.2984793186187744D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.2984793186187744D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.2984793186187744D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.9045616388320923D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.31248036026954651D)));
            this.table1.Body.SetCellContent(0, 0, this.textBox5);
            this.table1.Body.SetCellContent(0, 1, this.textBox6);
            this.table1.Body.SetCellContent(0, 2, this.textBox7);
            this.table1.Body.SetCellContent(0, 3, this.textBox8);
            tableGroup1.Name = "date";
            tableGroup1.ReportItem = this.textBox1;
            tableGroup2.Name = "price";
            tableGroup2.ReportItem = this.textBox2;
            tableGroup3.Name = "coins";
            tableGroup3.ReportItem = this.textBox3;
            tableGroup4.Name = "marketCap";
            tableGroup4.ReportItem = this.textBox4;
            this.table1.ColumnGroups.Add(tableGroup1);
            this.table1.ColumnGroups.Add(tableGroup2);
            this.table1.ColumnGroups.Add(tableGroup3);
            this.table1.ColumnGroups.Add(tableGroup4);
            this.table1.DataSource = this.details;
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox5,
            this.textBox6,
            this.textBox7,
            this.textBox8,
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox4});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10000002384185791D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.table1.Name = "table1";
            tableGroup5.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup5.Name = "detail";
            this.table1.RowGroups.Add(tableGroup5);
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.7999997138977051D), Telerik.Reporting.Drawing.Unit.Inch(0.593710720539093D));
            this.table1.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.table1.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.table1.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.table1.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.table1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.table1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.table1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.table1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.table1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.table1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.table1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.table1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.table1.StyleName = "Apex.TableNormal";
            // 
            // textBox5
            // 
            this.textBox5.Format = "{0:d}";
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064D), Telerik.Reporting.Drawing.Unit.Inch(0.31248036026954651D));
            this.textBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox5.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.StyleName = "Apex.TableBody";
            this.textBox5.Value = "= Fields.Date";
            // 
            // textBox6
            // 
            this.textBox6.Format = "{0:C2}";
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064D), Telerik.Reporting.Drawing.Unit.Inch(0.31248036026954651D));
            this.textBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox6.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.StyleName = "Apex.TableBody";
            this.textBox6.Value = "= Fields.Price";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064D), Telerik.Reporting.Drawing.Unit.Inch(0.31248036026954651D));
            this.textBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox7.StyleName = "Apex.TableBody";
            this.textBox7.Value = "= Fields.Coins";
            // 
            // textBox8
            // 
            this.textBox8.Format = "{0:C0}";
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9045618772506714D), Telerik.Reporting.Drawing.Unit.Inch(0.31248036026954651D));
            this.textBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox8.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox8.StyleName = "Apex.TableBody";
            this.textBox8.Value = "= Fields.MarketCap";
            // 
            // textBox1
            // 
            sortingAction1.SortingExpression = "= Fields.Date";
            sortingAction1.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            this.table1});
            this.textBox1.Action = sortingAction1;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064D), Telerik.Reporting.Drawing.Unit.Inch(0.28123036026954651D));
            this.textBox1.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Style.Color = System.Drawing.Color.White;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.StyleName = "Apex.TableHeader";
            this.textBox1.Value = "Date";
            // 
            // textBox2
            // 
            sortingAction2.SortingExpression = "= Fields.Price";
            sortingAction2.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            this.table1});
            this.textBox2.Action = sortingAction2;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064D), Telerik.Reporting.Drawing.Unit.Inch(0.28123036026954651D));
            this.textBox2.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Style.Color = System.Drawing.Color.White;
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.StyleName = "Apex.TableHeader";
            this.textBox2.Value = "Price";
            // 
            // textBox3
            // 
            sortingAction3.SortingExpression = "= Fields.Coins";
            sortingAction3.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            this.table1});
            this.textBox3.Action = sortingAction3;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064D), Telerik.Reporting.Drawing.Unit.Inch(0.28123036026954651D));
            this.textBox3.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.Style.Color = System.Drawing.Color.White;
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13D);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.StyleName = "Apex.TableHeader";
            this.textBox3.Value = "Coins";
            // 
            // textBox4
            // 
            sortingAction4.SortingExpression = "= Fields.MarketCap";
            sortingAction4.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            this.table1});
            this.textBox4.Action = sortingAction4;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9045617580413818D), Telerik.Reporting.Drawing.Unit.Inch(0.28123036026954651D));
            this.textBox4.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.Style.Color = System.Drawing.Color.White;
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13D);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.StyleName = "Apex.TableHeader";
            this.textBox4.Value = "Market Cap";
            // 
            // details
            // 
            this.details.CalculatedFields.AddRange(new Telerik.Reporting.CalculatedField[] {
            new Telerik.Reporting.CalculatedField("MarketCapInThous", typeof(uint), "= Fields.MarketCap/1000")});
            this.details.DataMember = "GetDetails";
            this.details.DataSource = typeof(Telerik.Reporting.Examples.CSharp.CryptoDataResolver);
            this.details.Name = "details";
            this.details.Parameters.AddRange(new Telerik.Reporting.ObjectDataSourceParameter[] {
            new Telerik.Reporting.ObjectDataSourceParameter("currencyCode", typeof(string), "btc")});
            // 
            // CurrenciesList
            // 
            this.CurrenciesList.DataMember = "GetData";
            this.CurrenciesList.DataSource = typeof(Telerik.Reporting.Examples.CSharp.CryptoDataResolver);
            this.CurrenciesList.Name = "CurrenciesList";
            this.CurrenciesList.Parameters.AddRange(new Telerik.Reporting.ObjectDataSourceParameter[] {
            new Telerik.Reporting.ObjectDataSourceParameter("forDate", typeof(System.DateTime), "=today()")});
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40003934502601624D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox9});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10000002384185791D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.8000006675720215D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox9.Value = "= \"Raw Data for \" + ToUpper(Parameters.currencyCode.Value)";
            // 
            // detailSection1
            // 
            this.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054D);
            this.detailSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.table1,
            this.htmlTextBox1});
            this.detailSection1.Name = "detailSection1";
            this.detailSection1.Style.Font.Name = "Segoe UI";
            // 
            // htmlTextBox1
            // 
            this.htmlTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0.79996079206466675D));
            this.htmlTextBox1.Name = "htmlTextBox1";
            this.htmlTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4999606609344482D), Telerik.Reporting.Drawing.Unit.Inch(0.40000009536743164D));
            this.htmlTextBox1.Value = "Reference:<br /><a href=\"https://coinmetrics.io/data-downloads/\">https://coinmetr" +
    "ics.io/data-downloads/</a>";
            // 
            // CryptoCurrencyRawData
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detailSection1});
            this.Name = "CryptoCurrenciesRawData";
            this.PageSettings.ColumnCount = 1;
            this.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.AutoRefresh = true;
            reportParameter1.AvailableValues.DataSource = this.CurrenciesList;
            reportParameter1.AvailableValues.DisplayMember = "= Fields.Name";
            reportParameter1.AvailableValues.ValueMember = "= Fields.Code";
            reportParameter1.Name = "currencyCode";
            reportParameter1.Text = "Cryptocurrency";
            reportParameter1.Value = "btc";
            reportParameter1.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.Style.Font.Name = "Segoe UI";
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6.5D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private ObjectDataSource CurrenciesList;
        private ObjectDataSource details;
        private PageHeaderSection pageHeaderSection1;
        private TextBox textBox9;
        private DetailSection detailSection1;
        private Table table1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private HtmlTextBox htmlTextBox1;
    }
}