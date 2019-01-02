using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYPJ4.Models
{
    public class News
    {
        public int ID { get; set; }
        public string ReportAsAt { get; set; }
        public string AccountCode { get; set; }
        public string AccountDesc { get; set; }
        public string FYBudget { get; set; }
        public string FYSpent { get; set; }
        public string FYSpentPercent { get; set; }
        public string FYBalance { get; set; }
        public string Encumbrance { get; set; }
        public string Actual { get; set; }
    }
}
