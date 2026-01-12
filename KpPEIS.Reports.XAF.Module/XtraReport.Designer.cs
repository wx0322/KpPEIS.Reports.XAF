namespace KpPEIS.Reports.XAF.Module {
  partial class XtraReport {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo7 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
      DevExpress.DataAccess.ObjectBinding.Parameter parameter7 = new DevExpress.DataAccess.ObjectBinding.Parameter();
      DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo8 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
      DevExpress.DataAccess.ObjectBinding.Parameter parameter8 = new DevExpress.DataAccess.ObjectBinding.Parameter();
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
      this.objectDataSource2 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
      this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
      this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
      this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
      this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
      this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
      this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
      this.Detail = new DevExpress.XtraReports.UI.DetailBand();
      this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
      this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
      this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
      this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
      this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
      this.ReportHeader1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
      this.ReportFooter1 = new DevExpress.XtraReports.UI.ReportFooterBand();
      this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
      this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
      this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
      this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
      this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
      this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // TopMargin
      // 
      this.TopMargin.Dpi = 254F;
      this.TopMargin.HeightF = 261.9375F;
      this.TopMargin.Name = "TopMargin";
      // 
      // BottomMargin
      // 
      this.BottomMargin.Dpi = 254F;
      this.BottomMargin.HeightF = 254F;
      this.BottomMargin.Name = "BottomMargin";
      // 
      // objectDataSource1
      // 
      parameter7.Name = "aSession";
      parameter7.Type = typeof(global::DevExpress.Xpo.Session);
      objectConstructorInfo7.Parameters.AddRange(new DevExpress.DataAccess.ObjectBinding.Parameter[] {
            parameter7});
      this.objectDataSource1.Constructor = objectConstructorInfo7;
      this.objectDataSource1.DataSource = typeof(global::KpPEIS.Reports.XAF.Module.BusinessObjects.ReportItem);
      this.objectDataSource1.Name = "objectDataSource1";
      // 
      // objectDataSource2
      // 
      parameter8.Name = "aSession";
      parameter8.Type = typeof(global::DevExpress.Xpo.Session);
      objectConstructorInfo8.Parameters.AddRange(new DevExpress.DataAccess.ObjectBinding.Parameter[] {
            parameter8});
      this.objectDataSource2.Constructor = objectConstructorInfo8;
      this.objectDataSource2.DataSource = typeof(global::KpPEIS.Reports.XAF.Module.BusinessObjects.MedicalReport);
      this.objectDataSource2.Name = "objectDataSource2";
      // 
      // ReportHeader
      // 
      this.ReportHeader.Dpi = 254F;
      this.ReportHeader.Expanded = false;
      this.ReportHeader.HeightF = 254F;
      this.ReportHeader.Name = "ReportHeader";
      // 
      // ReportFooter
      // 
      this.ReportFooter.Dpi = 254F;
      this.ReportFooter.Expanded = false;
      this.ReportFooter.HeightF = 254F;
      this.ReportFooter.Name = "ReportFooter";
      // 
      // PageHeader
      // 
      this.PageHeader.Dpi = 254F;
      this.PageHeader.Expanded = false;
      this.PageHeader.HeightF = 254F;
      this.PageHeader.Name = "PageHeader";
      // 
      // PageFooter
      // 
      this.PageFooter.Dpi = 254F;
      this.PageFooter.Expanded = false;
      this.PageFooter.HeightF = 254F;
      this.PageFooter.Name = "PageFooter";
      // 
      // GroupHeader1
      // 
      this.GroupHeader1.Dpi = 254F;
      this.GroupHeader1.Expanded = false;
      this.GroupHeader1.HeightF = 254F;
      this.GroupHeader1.Name = "GroupHeader1";
      // 
      // GroupFooter1
      // 
      this.GroupFooter1.Dpi = 254F;
      this.GroupFooter1.Expanded = false;
      this.GroupFooter1.HeightF = 254F;
      this.GroupFooter1.Name = "GroupFooter1";
      // 
      // Detail
      // 
      this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrTable2});
      this.Detail.Dpi = 254F;
      this.Detail.HeightF = 254F;
      this.Detail.HierarchyPrintOptions.Indent = 5080F;
      this.Detail.Name = "Detail";
      this.Detail.Scripts.OnAfterPrint = "Detail_AfterPrint";
      this.Detail.Scripts.OnBeforePrint = "Detail_BeforePrint";
      this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1});
      // 
      // SubBand1
      // 
      this.SubBand1.Dpi = 254F;
      this.SubBand1.HeightF = 254F;
      this.SubBand1.Name = "SubBand1";
      // 
      // DetailReport
      // 
      this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.DetailReport1});
      this.DetailReport.DataMember = "Items";
      this.DetailReport.DataSource = this.objectDataSource2;
      this.DetailReport.Dpi = 254F;
      this.DetailReport.Level = 0;
      this.DetailReport.Name = "DetailReport";
      // 
      // Detail1
      // 
      this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
      this.Detail1.Dpi = 254F;
      this.Detail1.HeightF = 254F;
      this.Detail1.HierarchyPrintOptions.Indent = 50.8F;
      this.Detail1.Name = "Detail1";
      // 
      // DetailReport1
      // 
      this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.ReportHeader1,
            this.ReportFooter1});
      this.DetailReport1.Dpi = 254F;
      this.DetailReport1.Expanded = false;
      this.DetailReport1.Level = 0;
      this.DetailReport1.Name = "DetailReport1";
      // 
      // Detail2
      // 
      this.Detail2.Dpi = 254F;
      this.Detail2.HeightF = 254F;
      this.Detail2.HierarchyPrintOptions.Indent = 50.8F;
      this.Detail2.Name = "Detail2";
      // 
      // ReportHeader1
      // 
      this.ReportHeader1.Dpi = 254F;
      this.ReportHeader1.Expanded = false;
      this.ReportHeader1.HeightF = 254F;
      this.ReportHeader1.Name = "ReportHeader1";
      // 
      // ReportFooter1
      // 
      this.ReportFooter1.Dpi = 254F;
      this.ReportFooter1.Expanded = false;
      this.ReportFooter1.HeightF = 254F;
      this.ReportFooter1.Name = "ReportFooter1";
      // 
      // xrTable1
      // 
      this.xrTable1.Dpi = 254F;
      this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5F, 5F, 0F, 0F, 254F);
      this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
      this.xrTable1.SizeF = new System.Drawing.SizeF(1651F, 63.5F);
      // 
      // xrTableRow1
      // 
      this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
      this.xrTableRow1.Dpi = 254F;
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 0.56097560975609762D;
      // 
      // xrTableCell1
      // 
      this.xrTableCell1.Dpi = 254F;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.Text = "Is Abnormal";
      this.xrTableCell1.Weight = 2D;
      // 
      // xrTableCell2
      // 
      this.xrTableCell2.Dpi = 254F;
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.Text = "Oid";
      this.xrTableCell2.Weight = 2D;
      // 
      // xrTableCell3
      // 
      this.xrTableCell3.Dpi = 254F;
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.Text = "Project Name";
      this.xrTableCell3.Weight = 2D;
      // 
      // xrTableCell4
      // 
      this.xrTableCell4.Dpi = 254F;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.Text = "Reference";
      this.xrTableCell4.Weight = 2D;
      // 
      // xrTableCell5
      // 
      this.xrTableCell5.Dpi = 254F;
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.Text = "Result";
      this.xrTableCell5.Weight = 2D;
      // 
      // xrTableCell6
      // 
      this.xrTableCell6.Dpi = 254F;
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.Text = "Unit";
      this.xrTableCell6.Weight = 2D;
      // 
      // xrPictureBox1
      // 
      this.xrPictureBox1.Dpi = 254F;
      this.xrPictureBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[EKGImage]")});
      this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(55.5625F, 0F);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new System.Drawing.SizeF(254F, 254F);
      this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
      // 
      // xrTable2
      // 
      this.xrTable2.Dpi = 254F;
      this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(608.5417F, 72.6842F);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
      this.xrTable2.SizeF = new System.Drawing.SizeF(698.4999F, 58.41999F);
      // 
      // xrTableRow2
      // 
      this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8});
      this.xrTableRow2.Dpi = 254F;
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 0.64935082278798661D;
      // 
      // xrTableCell7
      // 
      this.xrTableCell7.Dpi = 254F;
      this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PatientName]")});
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5F, 5F, 0F, 0F, 254F);
      this.xrTableCell7.Text = "xrLabel1";
      this.xrTableCell7.Weight = 444.49993896484375D;
      // 
      // xrTableCell8
      // 
      this.xrTableCell8.Dpi = 254F;
      this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReportDate]")});
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5F, 5F, 0F, 0F, 254F);
      this.xrTableCell8.Text = "xrLabel2";
      this.xrTableCell8.TextFormatString = "{0:d}";
      this.xrTableCell8.Weight = 254D;
      // 
      // XtraReport
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter,
            this.PageHeader,
            this.PageFooter,
            this.GroupHeader1,
            this.GroupFooter1,
            this.DetailReport});
      this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1,
            this.objectDataSource2});
      this.DataSource = this.objectDataSource2;
      this.Dpi = 254F;
      this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
      this.Margins = new DevExpress.Drawing.DXMargins(254F, 254F, 261.9375F, 254F);
      this.PageHeightF = 2794F;
      this.PageWidthF = 2159F;
      this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
      this.ScriptsSource = "\r\nprivate void Detail_BeforePrint(object sender, System.ComponentModel.CancelEven" +
    "tArgs e) {\r\n    \r\n}\r\n\r\nprivate void Detail_AfterPrint(object sender, System.Even" +
    "tArgs e) {\r\n    \r\n}\r\n";
      this.SnapGridSize = 31.75F;
      this.Version = "25.2";
      this.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.XtraReport_BeforePrint);
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
    private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource2;
    private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
    private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
    private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
    private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
    private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.SubBand SubBand1;
    private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
    private DevExpress.XtraReports.UI.DetailBand Detail1;
    private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
    private DevExpress.XtraReports.UI.DetailBand Detail2;
    private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader1;
    private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter1;
    private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
    private DevExpress.XtraReports.UI.XRTable xrTable1;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
    private DevExpress.XtraReports.UI.XRTable xrTable2;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
  }
}
