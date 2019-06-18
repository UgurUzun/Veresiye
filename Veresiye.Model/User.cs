using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veresiye.Model
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

    }
}
