using System.Collections.Generic;
using System.Threading.Tasks;
using Pharamacy.Entities.Identity;
using System.Security.Claims;
using Pharamacy.ViewModels.Identity;

namespace Pharamacy.Services.Contracts.Identity
{
    public interface ISiteStatService
    {
        Task<List<User>> GetOnlineUsersListAsync(int numbersToTake, int minutesToTake);

        Task<List<User>> GetTodayBirthdayListAsync();

        Task UpdateUserLastVisitDateTimeAsync(ClaimsPrincipal claimsPrincipal);

        Task<AgeStatViewModel> GetUsersAverageAge();
    }
}