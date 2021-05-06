using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThISDataManager.Library.Internal.DataAccess;
using ThISDataManager.Library.Models;

namespace ThISDataManager.Library.DataAccess
{
    public class SeasonData
    {
        public List<SeasonModel> GetSeasons() 
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<SeasonModel, dynamic>("dbo.spSeasons_GetAll", new { }, "ThISDataConnection");

            return output;
        }
    }
}
