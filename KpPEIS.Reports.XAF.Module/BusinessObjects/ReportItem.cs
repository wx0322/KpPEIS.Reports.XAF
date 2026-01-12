using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpPEIS.Reports.XAF.Module.BusinessObjects {
  public class ReportItem : BaseObject {
    public ReportItem(Session aSession) : base(aSession) {
    }

    public virtual string ProjectName { get; set; } // 项目名
    public virtual string Result { get; set; }      // 结果
    public virtual string Unit { get; set; }        // 单位
    public virtual string Reference { get; set; }   // 参考值
    public virtual bool IsAbnormal { get; set; }    // 是否异常
  }
}
