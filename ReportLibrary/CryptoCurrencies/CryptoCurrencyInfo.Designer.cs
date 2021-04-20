namespace Telerik.Reporting.Examples.CSharp
{
    partial class CryptoCurrencyInfo
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.DataColumn dataColumn1 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn2 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn3 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn4 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn5 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.NavigateToReportAction navigateToReportAction1 = new Telerik.Reporting.NavigateToReportAction();
            Telerik.Reporting.TypeReportSource typeReportSource1 = new Telerik.Reporting.TypeReportSource();
            Telerik.Reporting.GraphGroup graphGroup1 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup2 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.Drawing.ColorPalette colorPalette1 = new Telerik.Reporting.Drawing.ColorPalette();
            Telerik.Reporting.GraphTitle graphTitle1 = new Telerik.Reporting.GraphTitle();
            Telerik.Reporting.DateTimeScale dateTimeScale1 = new Telerik.Reporting.DateTimeScale();
            Telerik.Reporting.DateTimeScaleCrossAxisPosition dateTimeScaleCrossAxisPosition1 = new Telerik.Reporting.DateTimeScaleCrossAxisPosition();
            Telerik.Reporting.DateTimeScaleCrossAxisPosition dateTimeScaleCrossAxisPosition2 = new Telerik.Reporting.DateTimeScaleCrossAxisPosition();
            Telerik.Reporting.NumericalScale numericalScale1 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.NumericalScale numericalScale2 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.GraphGroup graphGroup3 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup4 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.ShapeMapGroup shapeMapGroup1 = new Telerik.Reporting.ShapeMapGroup();
            Telerik.Reporting.GeoLocationMapGroup geoLocationMapGroup1 = new Telerik.Reporting.GeoLocationMapGroup();
            Telerik.Reporting.MapLegend mapLegend1 = new Telerik.Reporting.MapLegend();
            Telerik.Reporting.MercatorProjection mercatorProjection1 = new Telerik.Reporting.MercatorProjection();
            Telerik.Reporting.MapTitle mapTitle1 = new Telerik.Reporting.MapTitle();
            Telerik.Reporting.Drawing.GradientPalette gradientPalette1 = new Telerik.Reporting.Drawing.GradientPalette();
            Telerik.Reporting.MapGroup mapGroup1 = new Telerik.Reporting.MapGroup();
            Telerik.Reporting.EsriShapeFileSourceType esriShapeFileSourceType1 = new Telerik.Reporting.EsriShapeFileSourceType();
            Telerik.Reporting.MapRelationPair mapRelationPair1 = new Telerik.Reporting.MapRelationPair();
            Telerik.Reporting.Drawing.FormattingRule formattingRule1 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule2 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule3 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule4 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.NavigateToReportAction navigateToReportAction2 = new Telerik.Reporting.NavigateToReportAction();
            Telerik.Reporting.TypeReportSource typeReportSource2 = new Telerik.Reporting.TypeReportSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptoCurrencyInfo));
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter3 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector1 = new Telerik.Reporting.Drawing.DescendantSelector();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector2 = new Telerik.Reporting.Drawing.DescendantSelector();
            this.dsData = new Telerik.Reporting.CsvDataSource();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.detailSection1 = new Telerik.Reporting.DetailSection();
            this.graph1 = new Telerik.Reporting.Graph();
            this.cartesianCoordinateSystem1 = new Telerik.Reporting.CartesianCoordinateSystem();
            this.graphAxis2 = new Telerik.Reporting.GraphAxis();
            this.graphAxis1 = new Telerik.Reporting.GraphAxis();
            this.cartesianCoordinateSystem3 = new Telerik.Reporting.CartesianCoordinateSystem();
            this.graphAxis3 = new Telerik.Reporting.GraphAxis();
            this.lineSeriesPrice = new Telerik.Reporting.LineSeries();
            this.lineSeriesCoins = new Telerik.Reporting.LineSeries();
            this.map2 = new Telerik.Reporting.Map();
            this.shapeMapSeries1 = new Telerik.Reporting.ShapeMapSeries();
            this.pointMapSeries1 = new Telerik.Reporting.PointMapSeries();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.htmlTextBox1 = new Telerik.Reporting.HtmlTextBox();
            this.CurrencyDetails = new Telerik.Reporting.ObjectDataSource();
            this.CurrenciesList = new Telerik.Reporting.ObjectDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dsData
            // 
            this.dsData.CalculatedFields.AddRange(new Telerik.Reporting.CalculatedField[] {
            new Telerik.Reporting.CalculatedField("RiskPercent", typeof(int), "= Fields.RiskIndex/5*100")});
            dataColumn1.Name = "Country";
            dataColumn2.Name = "RiskIndex";
            dataColumn2.Type = Telerik.Reporting.SimpleType.Float;
            dataColumn3.Name = "TSI";
            dataColumn3.Type = Telerik.Reporting.SimpleType.Integer;
            dataColumn4.Name = "Lat";
            dataColumn4.Type = Telerik.Reporting.SimpleType.Float;
            dataColumn5.Name = "Long";
            dataColumn5.Type = Telerik.Reporting.SimpleType.Float;
            this.dsData.Columns.Add(dataColumn1);
            this.dsData.Columns.Add(dataColumn2);
            this.dsData.Columns.Add(dataColumn3);
            this.dsData.Columns.Add(dataColumn4);
            this.dsData.Columns.Add(dataColumn5);
            this.dsData.FieldSeparators = new char[] {
        ','};
            this.dsData.HasHeaders = true;
            this.dsData.Name = "dsData";
            this.dsData.RecordSeparators = new char[] {
        '\r',
        '\n'};
            this.dsData.Source = "Country,RiskIndex,TSI,Lat,Long\r\nChina,81,0,40.0, 105.737707\r\nIceland,5,0,64.8, -1" +
    "8.0\r\nJapan,3,0,35.435666, 148.737707\r\nCzech Republic,3,0,53.0,19.467\r\nGeorgia,2." +
    "4,0,38.7,47.8\r\nIndia,2,0,19,78";
            this.dsData.ThousandSeparator = "";
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.500039279460907D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox9});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.5999608039855957D), Telerik.Reporting.Drawing.Unit.Inch(0.49999991059303284D));
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox9.Value = "=\"Details for \" + ToUpper(Parameters.currencyCode.Value)";
            // 
            // detailSection1
            // 
            this.detailSection1.CanShrink = true;
            this.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(10.500000953674316D);
            this.detailSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.graph1,
            this.map2,
            this.textBox2,
            this.htmlTextBox1});
            this.detailSection1.Name = "detailSection1";
            // 
            // graph1
            // 
            typeReportSource1.Parameters.Add(new Telerik.Reporting.Parameter("currencyCode", "= Parameters.currencyCode.Value"));
            typeReportSource1.TypeName = "Telerik.Reporting.Examples.CSharp.CryptoCurrencyRawData, CSharp.ReportLibrary, Ve" +
    "rsion=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            navigateToReportAction1.ReportSource = typeReportSource1;
            this.graph1.Action = navigateToReportAction1;
            graphGroup1.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.Date"));
            graphGroup1.Name = "dateGroup";
            graphGroup1.Sortings.Add(new Telerik.Reporting.Sorting("= Fields.Date", Telerik.Reporting.SortDirection.Asc));
            graphGroup2.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.Date"));
            graphGroup2.Name = "dateGroup1";
            graphGroup2.Sortings.Add(new Telerik.Reporting.Sorting("= Fields.Date", Telerik.Reporting.SortDirection.Asc));
            this.graph1.CategoryGroups.Add(graphGroup1);
            this.graph1.CategoryGroups.Add(graphGroup2);
            colorPalette1.Colors.Add(System.Drawing.Color.DodgerBlue);
            colorPalette1.Colors.Add(System.Drawing.Color.MediumVioletRed);
            this.graph1.ColorPalette = colorPalette1;
            this.graph1.CoordinateSystems.Add(this.cartesianCoordinateSystem1);
            this.graph1.CoordinateSystems.Add(this.cartesianCoordinateSystem3);
            this.graph1.DataSource = this.CurrencyDetails;
            this.graph1.Filters.Add(new Telerik.Reporting.Filter("= Fields.Date", Telerik.Reporting.FilterOperator.GreaterThan, "= Parameters.fromDate.Value"));
            this.graph1.Filters.Add(new Telerik.Reporting.Filter("= Fields.Date", Telerik.Reporting.FilterOperator.LessOrEqual, "= Parameters.toDate.Value"));
            this.graph1.Legend.IsInsidePlotArea = true;
            this.graph1.Legend.Position = Telerik.Reporting.GraphItemPosition.TopCenter;
            this.graph1.Legend.Style.LineColor = System.Drawing.Color.LightGray;
            this.graph1.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.graph1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.graph1.Name = "graph1";
            this.graph1.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray;
            this.graph1.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.graph1.Series.Add(this.lineSeriesPrice);
            this.graph1.Series.Add(this.lineSeriesCoins);
            this.graph1.SeriesGroups.Add(graphGroup3);
            this.graph1.SeriesGroups.Add(graphGroup4);
            this.graph1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.799961090087891D), Telerik.Reporting.Drawing.Unit.Inch(2.5D));
            this.graph1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            graphTitle1.Position = Telerik.Reporting.GraphItemPosition.TopCenter;
            graphTitle1.Style.LineColor = System.Drawing.Color.LightGray;
            graphTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            graphTitle1.Style.Visible = false;
            graphTitle1.Text = "graph1";
            this.graph1.Titles.Add(graphTitle1);
            // 
            // cartesianCoordinateSystem1
            // 
            this.cartesianCoordinateSystem1.Name = "cartesianCoordinateSystem1";
            this.cartesianCoordinateSystem1.XAxis = this.graphAxis2;
            this.cartesianCoordinateSystem1.YAxis = this.graphAxis1;
            // 
            // graphAxis2
            // 
            this.graphAxis2.LabelFormat = "{0:MMM.yy}";
            this.graphAxis2.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis2.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis2.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis2.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis2.MinorGridLineStyle.Visible = false;
            this.graphAxis2.Name = "graphAxis2";
            dateTimeScaleCrossAxisPosition1.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.AtMaximum;
            dateTimeScaleCrossAxisPosition1.Value = new System.DateTime(((long)(0)));
            dateTimeScaleCrossAxisPosition2.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.AtMinimum;
            dateTimeScaleCrossAxisPosition2.Value = new System.DateTime(((long)(0)));
            dateTimeScale1.CrossAxisPositions.Add(dateTimeScaleCrossAxisPosition1);
            dateTimeScale1.CrossAxisPositions.Add(dateTimeScaleCrossAxisPosition2);
            dateTimeScale1.LabelStep = 4;
            dateTimeScale1.LabelUnit = Telerik.Reporting.DateTimeScaleUnits.Months;
            dateTimeScale1.MajorStep = 4;
            dateTimeScale1.MajorUnit = Telerik.Reporting.DateTimeScaleUnits.Months;
            dateTimeScale1.MinorUnit = Telerik.Reporting.DateTimeScaleUnits.Years;
            this.graphAxis2.Scale = dateTimeScale1;
            // 
            // graphAxis1
            // 
            this.graphAxis1.LabelFormat = "{0:$0}";
            this.graphAxis1.MajorGridLineStyle.LineColor = System.Drawing.Color.LightSteelBlue;
            this.graphAxis1.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis1.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis1.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis1.MinorGridLineStyle.Visible = false;
            this.graphAxis1.Name = "graphAxis1";
            this.graphAxis1.Scale = numericalScale1;
            this.graphAxis1.Style.Color = System.Drawing.Color.DodgerBlue;
            this.graphAxis1.Style.LineColor = System.Drawing.Color.DodgerBlue;
            // 
            // cartesianCoordinateSystem3
            // 
            this.cartesianCoordinateSystem3.Name = "cartesianCoordinateSystem3";
            this.cartesianCoordinateSystem3.XAxis = this.graphAxis2;
            this.cartesianCoordinateSystem3.YAxis = this.graphAxis3;
            // 
            // graphAxis3
            // 
            this.graphAxis3.LabelFormat = "{0:#,##0M,,}";
            this.graphAxis3.MajorGridLineStyle.LineColor = System.Drawing.Color.MistyRose;
            this.graphAxis3.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis3.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis3.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis3.MinorGridLineStyle.Visible = false;
            this.graphAxis3.Name = "GraphAxis1";
            this.graphAxis3.Scale = numericalScale2;
            this.graphAxis3.Style.Color = System.Drawing.Color.MediumVioletRed;
            this.graphAxis3.Style.LineColor = System.Drawing.Color.MediumVioletRed;
            // 
            // lineSeriesPrice
            // 
            this.lineSeriesPrice.CategoryGroup = graphGroup1;
            this.lineSeriesPrice.CoordinateSystem = this.cartesianCoordinateSystem1;
            this.lineSeriesPrice.DataPointLabel = "= Sum(Fields.Price)";
            this.lineSeriesPrice.DataPointLabelStyle.Visible = false;
            this.lineSeriesPrice.DataPointStyle.Visible = false;
            this.lineSeriesPrice.LegendItem.Value = "Price";
            this.lineSeriesPrice.LineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.lineSeriesPrice.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Pixel(50D);
            this.lineSeriesPrice.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeriesPrice.MarkerSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeriesPrice.Name = "lineSeriesPrice";
            graphGroup3.Name = "seriesGroup";
            this.lineSeriesPrice.SeriesGroup = graphGroup3;
            this.lineSeriesPrice.Size = null;
            this.lineSeriesPrice.ToolTip.Text = "= Sum(Fields.Price)";
            this.lineSeriesPrice.ToolTip.Title = "Price";
            this.lineSeriesPrice.X = "= Fields.Date";
            this.lineSeriesPrice.Y = "= Sum(Fields.Price)";
            // 
            // lineSeriesCoins
            // 
            this.lineSeriesCoins.CategoryGroup = graphGroup2;
            this.lineSeriesCoins.CoordinateSystem = this.cartesianCoordinateSystem3;
            this.lineSeriesCoins.DataPointLabel = "= Fields.MarketCap";
            this.lineSeriesCoins.DataPointLabelStyle.Visible = false;
            this.lineSeriesCoins.DataPointStyle.Visible = false;
            this.lineSeriesCoins.LegendItem.Value = "Market cap";
            this.lineSeriesCoins.LineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.lineSeriesCoins.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Pixel(50D);
            this.lineSeriesCoins.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeriesCoins.MarkerSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeriesCoins.Name = "lineSeriesCoins";
            graphGroup4.Name = "seriesGroup1";
            this.lineSeriesCoins.SeriesGroup = graphGroup4;
            this.lineSeriesCoins.Size = null;
            this.lineSeriesCoins.ToolTip.Text = "= Fields.MarketCap";
            this.lineSeriesCoins.ToolTip.Title = "Coins";
            this.lineSeriesCoins.X = "= Fields.Date";
            this.lineSeriesCoins.Y = "= Fields.MarketCap";
            // 
            // map2
            // 
            this.map2.Bindings.Add(new Telerik.Reporting.Binding("Visible", "= Parameters.currencyCode.Value = \"btc\""));
            this.map2.ColorPalette = null;
            this.map2.DataSource = this.dsData;
            this.map2.Extent.LatitudeMax = 74.393967649013874D;
            this.map2.Extent.LatitudeMin = -20.886359822167741D;
            this.map2.Extent.LongitudeMax = 169.84247446060181D;
            this.map2.Extent.LongitudeMin = -40.861018896102905D;
            shapeMapGroup1.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.CNTRY_NAME"));
            shapeMapGroup1.Name = "categoryGroup1";
            geoLocationMapGroup1.Filters.Add(new Telerik.Reporting.Filter("= Fields.Country is Null", Telerik.Reporting.FilterOperator.Equal, "=False"));
            geoLocationMapGroup1.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.Country"));
            geoLocationMapGroup1.Name = "geoLocationMapGroup";
            this.map2.GeoLocationGroups.Add(shapeMapGroup1);
            this.map2.GeoLocationGroups.Add(geoLocationMapGroup1);
            mapLegend1.IsInsidePlotArea = true;
            mapLegend1.Position = Telerik.Reporting.GraphItemPosition.TopCenter;
            mapLegend1.Style.LineColor = System.Drawing.Color.LightGray;
            mapLegend1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            mapLegend1.Title = "Mining Pools %";
            mapLegend1.TitleStyle.Font.Bold = true;
            mapLegend1.TitleStyle.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(6D);
            mapLegend1.TitleStyle.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.map2.Legends.Add(mapLegend1);
            this.map2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475D));
            this.map2.Meridians.Style.LineColor = System.Drawing.Color.LightGray;
            this.map2.Name = "map2";
            this.map2.Parallels.Style.LineColor = System.Drawing.Color.LightGray;
            this.map2.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray;
            this.map2.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.map2.Projection = mercatorProjection1;
            this.map2.ScaleLegend.ItemStyle.BorderColor.Default = System.Drawing.Color.White;
            this.map2.ScaleLegend.ItemStyle.LineColor = System.Drawing.Color.DodgerBlue;
            this.map2.ScaleLegend.ItemStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(2D);
            this.map2.ScaleLegend.ItemStyle.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.map2.ScaleLegend.ItemStyle.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.map2.ScaleLegend.ItemStyle.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.map2.ScaleLegend.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            this.map2.Series.Add(this.shapeMapSeries1);
            this.map2.Series.Add(this.pointMapSeries1);
            this.map2.SeriesGroups.Add(mapGroup1);
            this.map2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.236221313476563D), Telerik.Reporting.Drawing.Unit.Cm(18.034002304077148D));
            this.map2.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.map2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.map2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.map2.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            mapTitle1.Style.LineColor = System.Drawing.Color.LightGray;
            mapTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            mapTitle1.Text = "";
            this.map2.Titles.Add(mapTitle1);
            // 
            // shapeMapSeries1
            // 
            this.shapeMapSeries1.ColorData = "= Fields.RiskIndex";
            gradientPalette1.BeginColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(168)))));
            gradientPalette1.EndColor = System.Drawing.Color.Maroon;
            this.shapeMapSeries1.ColorPalette = gradientPalette1;
            this.shapeMapSeries1.ColorsCount = 4;
            this.shapeMapSeries1.DataPointLabel = "{Fields.CNTRY_NAME}\r\n({Sum(Fields.[RiskIndex])})";
            this.shapeMapSeries1.DataPointLabelStyle.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.shapeMapSeries1.DataPointLabelStyle.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.shapeMapSeries1.DataPointLabelStyle.Visible = false;
            this.shapeMapSeries1.DataPointStyle.LineColor = System.Drawing.Color.Gray;
            this.shapeMapSeries1.DataPointStyle.Visible = true;
            this.shapeMapSeries1.LegendItem.Value = "= RangeMax";
            this.shapeMapSeries1.Name = "shapeMapSeries1";
            this.shapeMapSeries1.RangeGrouping = Telerik.Reporting.ShapeMapSeries.RangeGroupings.EqualDistribution;
            mapGroup1.Name = "seriesGroup1";
            this.shapeMapSeries1.SeriesGroup = mapGroup1;
            this.shapeMapSeries1.ShapeMapGroup = shapeMapGroup1;
            esriShapeFileSourceType1.FileName = "./Resources/world.shp";
            mapRelationPair1.AnalyticalField = "= Fields.Country";
            mapRelationPair1.ShapeFileField = "= Fields.CNTRY_NAME";
            esriShapeFileSourceType1.RelationPairs.Add(mapRelationPair1);
            this.shapeMapSeries1.SourceType = esriShapeFileSourceType1;
            // 
            // pointMapSeries1
            // 
            formattingRule1.Filters.Add(new Telerik.Reporting.Filter("= Fields.RiskIndex", Telerik.Reporting.FilterOperator.LessThan, "=2.4"));
            formattingRule1.Style.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(153)))), ((int)(((byte)(145)))));
            formattingRule1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(3D);
            formattingRule2.Filters.Add(new Telerik.Reporting.Filter("= Fields.RiskIndex", Telerik.Reporting.FilterOperator.GreaterOrEqual, "=2.4"));
            formattingRule2.Style.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(79)))));
            formattingRule2.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(3D);
            formattingRule3.Filters.Add(new Telerik.Reporting.Filter("= Fields.RiskIndex", Telerik.Reporting.FilterOperator.GreaterOrEqual, "=3.5"));
            formattingRule3.Style.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(163)))), ((int)(((byte)(79)))));
            formattingRule3.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(3D);
            formattingRule4.Filters.Add(new Telerik.Reporting.Filter("= Fields.RiskIndex", Telerik.Reporting.FilterOperator.GreaterOrEqual, "=4"));
            formattingRule4.Style.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(134)))), ((int)(((byte)(132)))));
            formattingRule4.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(3D);
            this.pointMapSeries1.DataPointConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1,
            formattingRule2,
            formattingRule3,
            formattingRule4});
            this.pointMapSeries1.DataPointLabel = "=Format(\'\r\nRegion: {0}\r\nPools: {1}%, \r\nPH/s: {2}\', \r\nFields.Country, Fields.RiskI" +
    "ndex, 12000*Fields.RiskIndex/100)\r\n";
            this.pointMapSeries1.DataPointLabelAlignment = Telerik.Reporting.LineDataPointLabelAlignment.Center;
            this.pointMapSeries1.DataPointLabelStyle.Color = System.Drawing.Color.White;
            this.pointMapSeries1.DataPointLabelStyle.Font.Bold = false;
            this.pointMapSeries1.DataPointStyle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pointMapSeries1.GeoLocationGroup = geoLocationMapGroup1;
            this.pointMapSeries1.Latitude = "= Fields.Lat";
            this.pointMapSeries1.LegendItem.Style.Visible = false;
            this.pointMapSeries1.Longitude = "= Fields.Long";
            this.pointMapSeries1.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Cm(4D);
            this.pointMapSeries1.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Cm(4D);
            this.pointMapSeries1.MarkerType = Telerik.Reporting.DataPointMarkerType.Circle;
            this.pointMapSeries1.SeriesGroup = mapGroup1;
            this.pointMapSeries1.Size = "= Fields.TSI";
            // 
            // textBox2
            // 
            typeReportSource2.Parameters.Add(new Telerik.Reporting.Parameter("currencyCode", "= Parameters.currencyCode.Value"));
            typeReportSource2.TypeName = "Telerik.Reporting.Examples.CSharp.CryptoCurrencyRawData, CSharp.ReportLibrary, Ve" +
    "rsion=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            navigateToReportAction2.ReportSource = typeReportSource2;
            this.textBox2.Action = navigateToReportAction2;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.5000789165496826D), Telerik.Reporting.Drawing.Unit.Inch(9.90000057220459D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7999998927116394D), Telerik.Reporting.Drawing.Unit.Inch(0.19995880126953125D));
            this.textBox2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(64)))), ((int)(((byte)(97)))));
            this.textBox2.Style.Font.Underline = true;
            this.textBox2.Value = "Raw data.";
            // 
            // htmlTextBox1
            // 
            this.htmlTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(9.7000818252563477D));
            this.htmlTextBox1.Name = "htmlTextBox1";
            this.htmlTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.4999606609344482D), Telerik.Reporting.Drawing.Unit.Inch(0.79987972974777222D));
            this.htmlTextBox1.Value = resources.GetString("htmlTextBox1.Value");
            // 
            // CurrencyDetails
            // 
            this.CurrencyDetails.CalculatedFields.AddRange(new Telerik.Reporting.CalculatedField[] {
            new Telerik.Reporting.CalculatedField("MarketCapInThous", typeof(uint), "= Fields.MarketCap/1000")});
            this.CurrencyDetails.DataMember = "GetDetails";
            this.CurrencyDetails.DataSource = typeof(Telerik.Reporting.Examples.CSharp.CryptoDataResolver);
            this.CurrencyDetails.Name = "CurrencyDetails";
            this.CurrencyDetails.Parameters.AddRange(new Telerik.Reporting.ObjectDataSourceParameter[] {
            new Telerik.Reporting.ObjectDataSourceParameter("currencyCode", typeof(string), "= Parameters.currencyCode.Value")});
            // 
            // CurrenciesList
            // 
            this.CurrenciesList.DataMember = "GetData";
            this.CurrenciesList.DataSource = typeof(Telerik.Reporting.Examples.CSharp.CryptoDataResolver);
            this.CurrenciesList.Name = "CurrenciesList";
            this.CurrenciesList.Parameters.AddRange(new Telerik.Reporting.ObjectDataSourceParameter[] {
            new Telerik.Reporting.ObjectDataSourceParameter("forDate", typeof(System.DateTime), "=AddDays(today(),-2)")});
            // 
            // CryptoCurrencyInfo
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detailSection1});
            this.Name = "CryptoCurrencyDetails";
            this.PageSettings.ColumnCount = 1;
            this.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612D), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612D), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612D), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.AutoRefresh = true;
            reportParameter1.AvailableValues.DataSource = this.CurrenciesList;
            reportParameter1.AvailableValues.DisplayMember = "= Fields.Name";
            reportParameter1.AvailableValues.ValueMember = "= Fields.Code";
            reportParameter1.Name = "currencyCode";
            reportParameter1.Text = "Crypto Currency";
            reportParameter1.Value = "btc";
            reportParameter1.Visible = true;
            reportParameter2.AutoRefresh = true;
            reportParameter2.Name = "fromDate";
            reportParameter2.Text = "From Date";
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter2.Value = "= AddYears(today(), - 1)";
            reportParameter2.Visible = true;
            reportParameter3.AutoRefresh = true;
            reportParameter3.Name = "toDate";
            reportParameter3.Text = "To Date";
            reportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter3.Value = "=today()";
            reportParameter3.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.ReportParameters.Add(reportParameter3);
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
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.Table), "Apex.TableNormal")});
            styleRule3.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule3.Style.Color = System.Drawing.Color.Black;
            styleRule3.Style.Font.Name = "Segoe UI";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Apex.TableBody")});
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector1});
            styleRule4.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule4.Style.Font.Name = "Segoe UI";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Apex.TableHeader")});
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector2});
            styleRule5.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(103)))), ((int)(((byte)(109)))));
            styleRule5.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule5.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(102)))));
            styleRule5.Style.Font.Name = "Segoe UI";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(10.800000190734863D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private ObjectDataSource CurrenciesList;
        private ObjectDataSource CurrencyDetails;
        private CsvDataSource dsData;
        private PageHeaderSection pageHeaderSection1;
        private TextBox textBox9;
        private DetailSection detailSection1;
        private Graph graph1;
        private CartesianCoordinateSystem cartesianCoordinateSystem1;
        private GraphAxis graphAxis2;
        private GraphAxis graphAxis1;
        private CartesianCoordinateSystem cartesianCoordinateSystem3;
        private GraphAxis graphAxis3;
        private LineSeries lineSeriesPrice;
        private LineSeries lineSeriesCoins;
        private Map map2;
        private ShapeMapSeries shapeMapSeries1;
        private PointMapSeries pointMapSeries1;
        private TextBox textBox2;
        private HtmlTextBox htmlTextBox1;
    }
}