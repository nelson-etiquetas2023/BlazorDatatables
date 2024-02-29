using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Datatables.net.Models
{
    public class UsersPonches
    {
        public int IsUser { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int ShiftId { get; set; }
        public DateTime Ponche1 { get; set; }
        public DateTime Ponche2 { get; set; }
        public DateTime Ponche3 { get; set; }
        public DateTime Ponche4 { get; set; }

    }
}
