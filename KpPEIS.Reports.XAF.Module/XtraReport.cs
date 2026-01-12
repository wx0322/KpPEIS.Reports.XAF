using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace KpPEIS.Reports.XAF.Module {
  public partial class XtraReport : DevExpress.XtraReports.UI.XtraReport {
    public XtraReport() {
      InitializeComponent();
    }

    private void XtraReport_BeforePrint(object sender, CancelEventArgs e) {
      Console.WriteLine("打印前输出！");
    }
  }
}
