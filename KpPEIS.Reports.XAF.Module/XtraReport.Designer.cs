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
      DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo2 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
      DevExpress.DataAccess.ObjectBinding.Parameter parameter2 = new DevExpress.DataAccess.ObjectBinding.Parameter();
      DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo3 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
      DevExpress.DataAccess.ObjectBinding.Parameter parameter3 = new DevExpress.DataAccess.ObjectBinding.Parameter();
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.Detail = new DevExpress.XtraReports.UI.DetailBand();
      this.xrLabel = new DevExpress.XtraReports.UI.XRLabel();
      this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
      this.objectDataSource2 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
      this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
      this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // TopMargin
      // 
      this.TopMargin.Dpi = 1F;
      this.TopMargin.HeightF = 1.03125F;
      this.TopMargin.Name = "TopMargin";
      // 
      // BottomMargin
      // 
      this.BottomMargin.Dpi = 1F;
      this.BottomMargin.HeightF = 1F;
      this.BottomMargin.Name = "BottomMargin";
      // 
      // Detail
      // 
      this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrPictureBox1,
            this.xrLabel});
      this.Detail.Dpi = 1F;
      this.Detail.HeightF = 1F;
      this.Detail.Name = "Detail";
      // 
      // xrLabel
      // 
      this.xrLabel.Dpi = 1F;
      this.xrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.125F, 0.125F);
      this.xrLabel.Multiline = true;
      this.xrLabel.Name = "xrLabel";
      this.xrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0.02083333F, 0.02083333F, 0F, 0F, 1F);
      this.xrLabel.SizeF = new System.Drawing.SizeF(1F, 0.25F);
      this.xrLabel.StylePriority.UseTextAlignment = false;
      this.xrLabel.Text = "标签值";
      this.xrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
      // 
      // objectDataSource1
      // 
      parameter2.Name = "aSession";
      parameter2.Type = typeof(global::DevExpress.Xpo.Session);
      objectConstructorInfo2.Parameters.AddRange(new DevExpress.DataAccess.ObjectBinding.Parameter[] {
            parameter2});
      this.objectDataSource1.Constructor = objectConstructorInfo2;
      this.objectDataSource1.DataSource = typeof(global::KpPEIS.Reports.XAF.Module.BusinessObjects.ReportItem);
      this.objectDataSource1.Name = "objectDataSource1";
      // 
      // objectDataSource2
      // 
      parameter3.Name = "aSession";
      parameter3.Type = typeof(global::DevExpress.Xpo.Session);
      objectConstructorInfo3.Parameters.AddRange(new DevExpress.DataAccess.ObjectBinding.Parameter[] {
            parameter3});
      this.objectDataSource2.Constructor = objectConstructorInfo3;
      this.objectDataSource2.DataSource = typeof(global::KpPEIS.Reports.XAF.Module.BusinessObjects.MedicalReport);
      this.objectDataSource2.Name = "objectDataSource2";
      // 
      // xrPictureBox1
      // 
      this.xrPictureBox1.Dpi = 1F;
      this.xrPictureBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[EKGImage]")});
      this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(5.4F, 0F);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new System.Drawing.SizeF(1F, 1F);
      this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
      // 
      // xrLabel1
      // 
      this.xrLabel1.Dpi = 1F;
      this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PatientName]")});
      this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(1.25F, 0.125F);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0.02083333F, 0.02083333F, 0F, 0F, 1F);
      this.xrLabel1.SizeF = new System.Drawing.SizeF(1F, 0.25F);
      this.xrLabel1.Text = "xrLabel1";
      // 
      // XtraReport
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
      this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1,
            this.objectDataSource2});
      this.DataSource = this.objectDataSource2;
      this.Dpi = 1F;
      this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
      this.Margins = new DevExpress.Drawing.DXMargins(1F, 1F, 1.03125F, 1F);
      this.PageHeightF = 11F;
      this.PageWidthF = 8.5F;
      this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Inches;
      this.SnapGridSize = 0.125F;
      this.Version = "25.2";
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.objectDataSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.XRLabel xrLabel;
    private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
    private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource2;
  }
}
