using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThISDataManager.Library.Models
{
    public class SeasonModel
    {
        //Id, SeasonName, SeasonShortName, [Order]
        public int Id { get; set; }
        public string SeasonName { get; set; }
        public string SeasonShortName { get; set; }
        public int Order { get; set; }
    }
}
