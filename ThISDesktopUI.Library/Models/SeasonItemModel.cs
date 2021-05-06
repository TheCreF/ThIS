using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThISDesktopUI.Library.Models
{
    public class SeasonItemModel : ISeasonItemModel
    {
        public int Id { get; set; }
        public string SeasonName { get; set; }
        public string SeasonShortName { get; set; }
        public int Order { get; set; }

        public int? IsCurrent { get; set; }
    }
}
