using Pharamacy.Entities.Identity;

namespace Pharamacy.ViewModels.Identity.Emails
{
    public class ChangePasswordNotificationViewModel : EmailsBase
    {
        public User User { set; get; }
    }
}