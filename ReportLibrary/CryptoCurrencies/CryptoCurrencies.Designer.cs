namespace Telerik.Reporting.Examples.CSharp
{
    partial class CryptoCurrencies
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.SortingAction sortingAction1 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup6 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup7 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup8 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.NavigateToReportAction navigateToReportAction1 = new Telerik.Reporting.NavigateToReportAction();
            Telerik.Reporting.TypeReportSource typeReportSource1 = new Telerik.Reporting.TypeReportSource();
            Telerik.Reporting.NavigateToReportAction navigateToReportAction2 = new Telerik.Reporting.NavigateToReportAction();
            Telerik.Reporting.TypeReportSource typeReportSource2 = new Telerik.Reporting.TypeReportSource();
            Telerik.Reporting.SortingAction sortingAction2 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.SortingAction sortingAction3 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.SortingAction sortingAction4 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.SortingAction sortingAction5 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.SortingAction sortingAction6 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.GraphGroup graphGroup1 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphTitle graphTitle1 = new Telerik.Reporting.GraphTitle();
            Telerik.Reporting.NumericalScale numericalScale1 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.NumericalScale numericalScale2 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.Drawing.ColorPalette colorPalette1 = new Telerik.Reporting.Drawing.ColorPalette();
            Telerik.Reporting.GraphGroup graphGroup2 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.Drawing.ColorPalette colorPalette2 = new Telerik.Reporting.Drawing.ColorPalette();
            Telerik.Reporting.GraphGroup graphGroup3 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.NavigateToReportAction navigateToReportAction3 = new Telerik.Reporting.NavigateToReportAction();
            Telerik.Reporting.TypeReportSource typeReportSource3 = new Telerik.Reporting.TypeReportSource();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector1 = new Telerik.Reporting.Drawing.DescendantSelector();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector2 = new Telerik.Reporting.Drawing.DescendantSelector();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.table1 = new Telerik.Reporting.Table();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.CurrenciesData = new Telerik.Reporting.ObjectDataSource();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.detailSection1 = new Telerik.Reporting.DetailSection();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.graph1 = new Telerik.Reporting.Graph();
            this.polarCoordinateSystem1 = new Telerik.Reporting.PolarCoordinateSystem();
            this.angularAxis = new Telerik.Reporting.GraphAxis();
            this.radialAxis1 = new Telerik.Reporting.GraphAxis();
            this.algorithmSeries = new Telerik.Reporting.BarSeries();
            this.codeSeries = new Telerik.Reporting.BarSeries();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.reportFooterSection1 = new Telerik.Reporting.ReportFooterSection();
            this.htmlTextBox1 = new Telerik.Reporting.HtmlTextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // textBox8
            // 
            sortingAction1.SortingExpression = "= Fields.Code";
            sortingAction1.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            this.table1});
            this.textBox8.Action = sortingAction1;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.681D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox8.StyleName = "Apex.TableHeader";
            this.textBox8.Value = "Code";
            // 
            // table1
            // 
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.681D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.093D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.028D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.682D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.925D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.186D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.252D)));
            this.table1.Body.SetCellContent(0, 0, this.textBox13);
            this.table1.Body.SetCellContent(0, 1, this.textBox9);
            this.table1.Body.SetCellContent(0, 3, this.textBox14);
            this.table1.Body.SetCellContent(0, 4, this.textBox5);
            this.table1.Body.SetCellContent(0, 5, this.textBox15);
            this.table1.Body.SetCellContent(0, 2, this.textBox12);
            tableGroup2.Name = "group4";
            tableGroup2.ReportItem = this.textBox8;
            tableGroup3.Name = "group5";
            tableGroup3.ReportItem = this.textBox1;
            tableGroup4.Name = "group7";
            tableGroup4.ReportItem = this.textBox11;
            tableGroup5.Name = "group8";
            tableGroup5.ReportItem = this.textBox2;
            tableGroup6.Name = "group9";
            tableGroup6.ReportItem = this.textBox22;
            tableGroup7.Name = "group10";
            tableGroup7.ReportItem = this.textBox3;
            tableGroup1.ChildGroups.Add(tableGroup2);
            tableGroup1.ChildGroups.Add(tableGroup3);
            tableGroup1.ChildGroups.Add(tableGroup4);
            tableGroup1.ChildGroups.Add(tableGroup5);
            tableGroup1.ChildGroups.Add(tableGroup6);
            tableGroup1.ChildGroups.Add(tableGroup7);
            tableGroup1.Name = "group";
            tableGroup1.ReportItem = this.textBox16;
            this.table1.ColumnGroups.Add(tableGroup1);
            this.table1.DataSource = this.CurrenciesData;
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox13,
            this.textBox9,
            this.textBox12,
            this.textBox14,
            this.textBox5,
            this.textBox15,
            this.textBox16,
            this.textBox8,
            this.textBox1,
            this.textBox11,
            this.textBox2,
            this.textBox22,
            this.textBox3});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.7D));
            this.table1.Name = "table1";
            tableGroup8.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup8.Name = "detail";
            this.table1.RowGroups.Add(tableGroup8);
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.595D), Telerik.Reporting.Drawing.Unit.Inch(0.746D));
            this.table1.Sortings.Add(new Telerik.Reporting.Sorting("= Fields.MarketCap", Telerik.Reporting.SortDirection.Desc));
            this.table1.StyleName = "Apex.TableNormal";
            // 
            // textBox13
            // 
            typeReportSource1.Parameters.Add(new Telerik.Reporting.Parameter("currencyCode", "= Fields.Code"));
            typeReportSource1.TypeName = "Telerik.Reporting.Examples.CSharp.CryptoCurrencyInfo, CSharp.ReportLibrary, Versi" +
    "on=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            navigateToReportAction1.ReportSource = typeReportSource1;
            this.textBox13.Action = navigateToReportAction1;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.681D), Telerik.Reporting.Drawing.Unit.Inch(0.252D));
            this.textBox13.StyleName = "Apex.TableBody";
            this.textBox13.Value = "= ToUpper(Fields.Code)";
            // 
            // textBox9
            // 
            typeReportSource2.Parameters.Add(new Telerik.Reporting.Parameter("currencyCode", "= Fields.Code"));
            typeReportSource2.TypeName = "Telerik.Reporting.Examples.CSharp.CryptoCurrencyInfo, CSharp.ReportLibrary, Versi" +
    "on=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            navigateToReportAction2.ReportSource = typeReportSource2;
            this.textBox9.Action = navigateToReportAction2;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.093D), Telerik.Reporting.Drawing.Unit.Inch(0.252D));
            this.textBox9.StyleName = "Apex.TableBody";
            this.textBox9.Value = "= Fields.Name";
            // 
            // textBox14
            // 
            this.textBox14.Action = navigateToReportAction2;
            this.textBox14.Format = "{0:# ##0k}";
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.682D), Telerik.Reporting.Drawing.Unit.Inch(0.252D));
            this.textBox14.StyleName = "Apex.TableBody";
            this.textBox14.Value = "= Fields.Coins/1000";
            // 
            // textBox5
            // 
            this.textBox5.Action = navigateToReportAction2;
            this.textBox5.Format = "{0:$#,##.00}";
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.925D), Telerik.Reporting.Drawing.Unit.Inch(0.252D));
            this.textBox5.StyleName = "Apex.TableBody";
            this.textBox5.Value = "= Fields.Price";
            // 
            // textBox15
            // 
            this.textBox15.Action = navigateToReportAction2;
            this.textBox15.Format = "{0:$#,##0M,,}";
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.186D), Telerik.Reporting.Drawing.Unit.Inch(0.252D));
            this.textBox15.StyleName = "Apex.TableBody";
            this.textBox15.Value = "= Fields.MarketCap";
            // 
            // textBox12
            // 
            this.textBox12.Action = navigateToReportAction2;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.028D), Telerik.Reporting.Drawing.Unit.Inch(0.252D));
            this.textBox12.StyleName = "Apex.TableBody";
            this.textBox12.Value = "= Fields.Algorithm";
            // 
            // CurrenciesData
            // 
            this.CurrenciesData.DataMember = "GetData";
            this.CurrenciesData.DataSource = typeof(Telerik.Reporting.Examples.CSharp.CryptoDataResolver);
            this.CurrenciesData.Name = "CurrenciesData";
            this.CurrenciesData.Parameters.AddRange(new Telerik.Reporting.ObjectDataSourceParameter[] {
            new Telerik.Reporting.ObjectDataSourceParameter("forDate", typeof(System.DateTime), "= Parameters.date.Value")});
            // 
            // textBox16
            // 
            this.textBox16.Format = "{0:dd.MMM.yy}";
            this.textBox16.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.595D), Telerik.Reporting.Drawing.Unit.Inch(0.294D));
            this.textBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13D);
            this.textBox16.StyleName = "Apex.TableHeader";
            this.textBox16.Value = "=Fields.Date";
            // 
            // textBox1
            // 
            sortingAction2.SortingExpression = "= Fields.Name";
            sortingAction2.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            this.table1});
            this.textBox1.Action = sortingAction2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.093D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox1.StyleName = "Apex.TableHeader";
            this.textBox1.Value = "Currency";
            // 
            // textBox11
            // 
            sortingAction3.SortingExpression = "= Fields.Algorithm";
            sortingAction3.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            this.table1});
            this.textBox11.Action = sortingAction3;
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.028D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox11.StyleName = "Apex.TableHeader";
            this.textBox11.Value = "Algorithm";
            // 
            // textBox2
            // 
            sortingAction4.SortingExpression = "= Fields.Coins";
            sortingAction4.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            this.table1});
            this.textBox2.Action = sortingAction4;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.682D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox2.StyleName = "Apex.TableHeader";
            this.textBox2.Value = "Coins";
            // 
            // textBox22
            // 
            sortingAction5.SortingExpression = "= Fields.Price";
            sortingAction5.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            this.table1});
            this.textBox22.Action = sortingAction5;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.925D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox22.StyleName = "Apex.TableHeader";
            this.textBox22.Value = "Price";
            // 
            // textBox3
            // 
            sortingAction6.SortingExpression = "= Fields.MarketCap";
            sortingAction6.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            this.table1});
            this.textBox3.Action = sortingAction6;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.186D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox3.StyleName = "Apex.TableHeader";
            this.textBox3.Value = "Market Cap";
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox7});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.4D), Telerik.Reporting.Drawing.Unit.Inch(0.5D));
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(24D);
            this.textBox7.Value = "Crypto Currencies";
            // 
            // detailSection1
            // 
            this.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(6.5D);
            this.detailSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox6,
            this.graph1,
            this.table1,
            this.textBox10});
            this.detailSection1.Name = "detailSection1";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.95D), Telerik.Reporting.Drawing.Unit.Inch(0.4D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox6.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.textBox6.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.textBox6.Style.Font.Bold = true;
            this.textBox6.TextWrap = false;
            this.textBox6.Value = "Click on a currency for more details.";
            // 
            // graph1
            // 
            graphGroup1.Name = "categoryGroup";
            this.graph1.CategoryGroups.Add(graphGroup1);
            this.graph1.CoordinateSystems.Add(this.polarCoordinateSystem1);
            this.graph1.DataSource = this.CurrenciesData;
            this.graph1.Legend.IsInsidePlotArea = true;
            this.graph1.Legend.Position = Telerik.Reporting.GraphItemPosition.BottomLeft;
            this.graph1.Legend.Style.LineColor = System.Drawing.Color.LightGray;
            this.graph1.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.graph1.Legend.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0D);
            this.graph1.Legend.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Legend.Title = "Algorithm";
            this.graph1.Legend.TitleStyle.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.graph1.Legend.TitleStyle.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(20D);
            this.graph1.Legend.TitleStyle.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(20D);
            this.graph1.Legend.TitleStyle.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(-10D);
            this.graph1.Legend.TitleStyle.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.graph1.Legend.TitleStyle.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.graph1.Legend.TitleStyle.Visible = true;
            this.graph1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.89D), Telerik.Reporting.Drawing.Unit.Cm(0.508D));
            this.graph1.Name = "graph1";
            this.graph1.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray;
            this.graph1.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.graph1.Series.Add(this.algorithmSeries);
            this.graph1.Series.Add(this.codeSeries);
            this.graph1.SeriesGroups.Add(graphGroup2);
            this.graph1.SeriesGroups.Add(graphGroup3);
            this.graph1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.066D), Telerik.Reporting.Drawing.Unit.Cm(16.002D));
            this.graph1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            graphTitle1.Position = Telerik.Reporting.GraphItemPosition.TopCenter;
            graphTitle1.Style.LineColor = System.Drawing.Color.LightGray;
            graphTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            graphTitle1.Style.Visible = false;
            graphTitle1.Text = "graph1";
            this.graph1.Titles.Add(graphTitle1);
            // 
            // polarCoordinateSystem1
            // 
            this.polarCoordinateSystem1.AngularAxis = this.angularAxis;
            this.polarCoordinateSystem1.Name = "polarCoordinateSystem1";
            this.polarCoordinateSystem1.RadialAxis = this.radialAxis1;
            // 
            // angularAxis
            // 
            this.angularAxis.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.angularAxis.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.angularAxis.MajorGridLineStyle.Visible = false;
            this.angularAxis.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.angularAxis.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.angularAxis.MinorGridLineStyle.Visible = false;
            this.angularAxis.Name = "angularAxis";
            this.angularAxis.Scale = numericalScale1;
            this.angularAxis.Style.Visible = false;
            // 
            // radialAxis1
            // 
            this.radialAxis1.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.radialAxis1.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.radialAxis1.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.radialAxis1.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.radialAxis1.MinorGridLineStyle.Visible = false;
            this.radialAxis1.Name = "radialAxis1";
            numericalScale2.Minimum = 0D;
            this.radialAxis1.Scale = numericalScale2;
            this.radialAxis1.Style.Visible = false;
            // 
            // algorithmSeries
            // 
            this.algorithmSeries.ArrangeByAxis = this.radialAxis1;
            this.algorithmSeries.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked100;
            this.algorithmSeries.CategoryGroup = graphGroup1;
            colorPalette1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145))))));
            colorPalette1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(163)))), ((int)(((byte)(79))))));
            colorPalette1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(79))))));
            colorPalette1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(134)))), ((int)(((byte)(132))))));
            colorPalette1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219))))));
            this.algorithmSeries.ColorPalette = colorPalette1;
            this.algorithmSeries.CoordinateSystem = this.polarCoordinateSystem1;
            this.algorithmSeries.DataPointLabel = "= Fields.Algorithm";
            this.algorithmSeries.DataPointLabelAlignment = Telerik.Reporting.BarDataPointLabelAlignment.Center;
            this.algorithmSeries.DataPointLabelConnectorStyle.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.algorithmSeries.DataPointLabelConnectorStyle.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.algorithmSeries.DataPointLabelConnectorStyle.Visible = false;
            this.algorithmSeries.DataPointLabelOffset = Telerik.Reporting.Drawing.Unit.Mm(5D);
            this.algorithmSeries.DataPointLabelStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.algorithmSeries.DataPointLabelStyle.Visible = true;
            this.algorithmSeries.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.algorithmSeries.DataPointStyle.Visible = true;
            this.algorithmSeries.LegendItem.Value = "= Fields.Algorithm";
            this.algorithmSeries.Name = "algorithmSeries";
            graphGroup2.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.Algorithm"));
            graphGroup2.Name = "algorithmGroup";
            graphGroup2.Sortings.Add(new Telerik.Reporting.Sorting("= Fields.Algorithm", Telerik.Reporting.SortDirection.Asc));
            this.algorithmSeries.SeriesGroup = graphGroup2;
            this.algorithmSeries.ToolTip.Text = "= Format(\'{0:P}\', Sum(Fields.MarketCap) / CDbl(Exec(\'graph1\', Sum(Fields.MarketCa" +
    "p))))";
            this.algorithmSeries.ToolTip.Title = "= Fields.Algorithm";
            this.algorithmSeries.X = "= Sum(Fields.MarketCap)";
            this.algorithmSeries.Y = "=0.8";
            this.algorithmSeries.Y0 = "=0";
            // 
            // codeSeries
            // 
            this.codeSeries.ArrangeByAxis = this.radialAxis1;
            this.codeSeries.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked100;
            this.codeSeries.CategoryGroup = graphGroup1;
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78))))));
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(71)))), ((int)(((byte)(50))))));
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(117)))), ((int)(((byte)(151))))));
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(67)))), ((int)(((byte)(86))))));
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(172)))), ((int)(((byte)(0))))));
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(67)))), ((int)(((byte)(73))))));
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(202)))), ((int)(((byte)(132))))));
            this.codeSeries.ColorPalette = colorPalette2;
            this.codeSeries.CoordinateSystem = this.polarCoordinateSystem1;
            this.codeSeries.DataPointLabel = "= Format(\"{0} {1:P2}\", ToUpper(Fields.Code), Sum(Fields.MarketCap) / CDbl(Exec(\'g" +
    "raph1\', Sum(Fields.MarketCap))))";
            this.codeSeries.DataPointLabelConnectorStyle.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.codeSeries.DataPointLabelConnectorStyle.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.codeSeries.DataPointLabelConnectorStyle.Visible = false;
            this.codeSeries.DataPointLabelOffset = Telerik.Reporting.Drawing.Unit.Mm(2D);
            this.codeSeries.LegendItem.Style.Visible = false;
            this.codeSeries.LegendItem.Value = "= Fields.Code";
            this.codeSeries.Name = "codeSeries";
            typeReportSource3.Parameters.Add(new Telerik.Reporting.Parameter("currencyCode", "= Fields.Code"));
            typeReportSource3.TypeName = "Telerik.Reporting.Examples.CSharp.CryptoCurrencyInfo, CSharp.ReportLibrary, Versi" +
    "on=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            navigateToReportAction3.ReportSource = typeReportSource3;
            graphGroup3.Action = navigateToReportAction3;
            graphGroup3.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.Code"));
            graphGroup3.Name = "codeGroup";
            graphGroup3.Sortings.Add(new Telerik.Reporting.Sorting("= Fields.Algorithm", Telerik.Reporting.SortDirection.Asc));
            this.codeSeries.SeriesGroup = graphGroup3;
            this.codeSeries.ToolTip.Text = "= Format(\'{0:P}\', Sum(Fields.MarketCap) / CDbl(Exec(\'graph1\', Sum(Fields.MarketCa" +
    "p))))";
            this.codeSeries.ToolTip.Title = "= Fields.Name";
            this.codeSeries.X = "=Sum( Fields.MarketCap)";
            this.codeSeries.Y = "=1";
            this.codeSeries.Y0 = "=0.8";
            // 
            // textBox10
            // 
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.2D), Telerik.Reporting.Drawing.Unit.Inch(0.3D));
            this.textBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox10.Value = "Compare crypto currencies based on market cap.";
            // 
            // reportFooterSection1
            // 
            this.reportFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5D);
            this.reportFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.htmlTextBox1});
            this.reportFooterSection1.Name = "reportFooterSection1";
            // 
            // htmlTextBox1
            // 
            this.htmlTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.1D));
            this.htmlTextBox1.Name = "htmlTextBox1";
            this.htmlTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.762D), Telerik.Reporting.Drawing.Unit.Inch(0.4D));
            this.htmlTextBox1.Value = "Reference:<br /><a href=\"https://coinmetrics.io/data-downloads/\">https://coinmetr" +
    "ics.io/data-downloads/</a>";
            // 
            // CryptoCurrencies
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detailSection1,
            this.reportFooterSection1});
            this.Name = "BlockchainCurrencies";
            this.PageSettings.ColumnCount = 1;
            this.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.1D), Telerik.Reporting.Drawing.Unit.Inch(0.1D), Telerik.Reporting.Drawing.Unit.Inch(0.1D), Telerik.Reporting.Drawing.Unit.Inch(0.1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.AutoRefresh = true;
            reportParameter1.Name = "date";
            reportParameter1.Text = "For Date:";
            reportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter1.Value = "= Today()";
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
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.Table), "Apex.TableNormal")});
            styleRule3.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule3.Style.Color = System.Drawing.Color.Black;
            styleRule3.Style.Font.Name = "Segoe UI";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            descendantSelector1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Apex.TableBody")});
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector1});
            styleRule4.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            styleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule4.Style.Color = System.Drawing.Color.Black;
            styleRule4.Style.Font.Name = "Segoe UI";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            descendantSelector2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Apex.TableHeader")});
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector2});
            styleRule5.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            styleRule5.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            styleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule5.Style.Color = System.Drawing.Color.White;
            styleRule5.Style.Font.Name = "Segoe UI";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            styleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(11.4D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private ObjectDataSource CurrenciesData;
        private PageHeaderSection pageHeaderSection1;
        private TextBox textBox7;
        private DetailSection detailSection1;
        private TextBox textBox6;
        private Graph graph1;
        private PolarCoordinateSystem polarCoordinateSystem1;
        private GraphAxis angularAxis;
        private GraphAxis radialAxis1;
        private BarSeries algorithmSeries;
        private BarSeries codeSeries;
        private Table table1;
        private TextBox textBox13;
        private TextBox textBox9;
        private TextBox textBox14;
        private TextBox textBox5;
        private TextBox textBox15;
        private TextBox textBox12;
        private TextBox textBox8;
        private TextBox textBox1;
        private TextBox textBox11;
        private TextBox textBox2;
        private TextBox textBox22;
        private TextBox textBox3;
        private TextBox textBox16;
        private TextBox textBox10;
        private ReportFooterSection reportFooterSection1;
        private HtmlTextBox htmlTextBox1;
    }
}