using System.Collections.Generic;
using Pharamacy.Entities.Identity;

namespace Pharamacy.ViewModels.Identity
{
    public class TodayBirthDaysViewModel
    {
        public List<User> Users { set; get; }

        public AgeStatViewModel AgeStat { set; get; }
    }
}