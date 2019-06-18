using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veresiye.Model
{
    public enum ActivityType
    {
        Dept = 1, //Borç
        Payment = 2, //Ödeme
        Credit = 3, //Alacak
        Collection = 4 //Tahsilat
    }
}
