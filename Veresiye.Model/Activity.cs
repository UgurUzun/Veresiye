using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veresiye.Model
{
    public class Activity : BaseEntity
    {
        public string Name { get; set; }
        public string Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public ActivityType ActivityType { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
