﻿using System.Threading.Tasks;
using Pharamacy.Services.Contracts.Identity;
using Pharamacy.ViewModels.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Pharamacy.Areas.Identity.ViewComponents
{
    public class TodayBirthDaysViewComponent : ViewComponent
    {
        private readonly ISiteStatService _siteStatService;

        public TodayBirthDaysViewComponent(ISiteStatService siteStatService)
        {
            _siteStatService = siteStatService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var usersList = await _siteStatService.GetTodayBirthdayListAsync();
            var usersAverageAge = await _siteStatService.GetUsersAverageAge();

            return View(viewName: "~/Areas/Identity/Views/Shared/Components/TodayBirthDays/Default.cshtml",
                        model: new TodayBirthDaysViewModel
                        {
                            Users = usersList,
                            AgeStat = usersAverageAge
                        });
        }
    }
}