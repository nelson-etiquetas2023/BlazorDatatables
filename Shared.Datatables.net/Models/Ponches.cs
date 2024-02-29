using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Datatables.net.Models
{
    public class Ponches
    {
        public int IdUser { get; set; }
        public DateTime RecordTime { get; set; }
        public int MachineNumber { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int RecordType { get; set; }
    }
}
