using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpPEIS.Reports.XAF.Module.BusinessObjects {
  public class MedicalReport : BaseObject {
    public MedicalReport(Session aSession) : base(aSession) {
    }
    public virtual string PatientName { get; set; }
    public virtual DateTime ReportDate { get; set; }
    public virtual byte[] EKGImage { get; set; } // 存储心电图图片
    public virtual string Suggestion { get; set; } // 医生建议

    // 体检明细（如：血压、血糖等）
    [DevExpress.ExpressApp.DC.Aggregated]
    public virtual IList<ReportItem> Items { get; set; } = new List<ReportItem>();
  }
}
