using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThISDesktopUI.Library.Models
{
    public class SeasonItem : ISeasonItem
    {
        public int ID { get; set; }
        public string SeaasonFullName { get; set; }
        public string SeasonShortName { get; set; }
        public int OrderNumb { get; set; }
    }
}
