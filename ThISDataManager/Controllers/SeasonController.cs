using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThISDataManager.Library.DataAccess;
using ThISDataManager.Library.Models;

namespace ThISDataManager.Controllers
{
    public class SeasonController : ApiController
    {
        [Authorize]
        public List<SeasonModel> Get()
        {
            SeasonData data = new SeasonData();

            return data.GetSeasons();
        }
    }
}
