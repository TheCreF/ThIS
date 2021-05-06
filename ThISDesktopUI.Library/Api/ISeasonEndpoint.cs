using System.Collections.Generic;
using System.Threading.Tasks;
using ThISDesktopUI.Library.Models;

namespace ThISDesktopUI.Library.Api
{
    public interface ISeasonEndpoint
    {
        Task<List<SeasonItemModel>> GetAll();
    }
}