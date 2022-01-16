using simpleCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleCRUD.ViewModel
{
    public class VmHome
    {
        public Employee Employee { get; set; }
        public List<Position> Positions { get; set; }
    }
}
