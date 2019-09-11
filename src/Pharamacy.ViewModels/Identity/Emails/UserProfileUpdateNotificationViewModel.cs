using Pharamacy.Entities.Identity;

namespace Pharamacy.ViewModels.Identity.Emails
{
    public class UserProfileUpdateNotificationViewModel : EmailsBase
    {
        public User User { set; get; }
    }
}