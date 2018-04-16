using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nettolicious.Common.Data.Tests
{
  public partial class JobLog
  {
    public System.Nullable<System.Int32> Duration { get; set; }
    public System.DateTimeOffset Ended { get; set; }
    public System.Nullable<System.Int32> Failures { get; set; }
    public System.Int64 JobId { get; set; } /* foreign key (dbo.Job(JobId)) */
    public System.Int64 JobLogId { get; set; } /* identity, primary key 1 */
    public System.Nullable<System.Int32> Records { get; set; }
    public System.String Result { get; set; }
    public System.DateTimeOffset Started { get; set; }
    public System.DateTimeOffset SysCreated { get; set; }
    public System.String SysCreatedBy { get; set; }
    public System.DateTimeOffset SysLastModified { get; set; }
    public System.String SysLastModifiedBy { get; set; }
  }

}
