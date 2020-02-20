using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Reports
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class IncludeToReportAttribute : Attribute
    {
        public IncludeToReportAttribute()
        {
        }
    }
}
