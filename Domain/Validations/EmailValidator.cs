using System.Text.RegularExpressions;
using Domain.Notifications;

namespace Domain.Validations
{
    public partial class ContractValidation<T>
    {
        public ContractValidation<T> EmailIsValid(string email, string message, string propertyName)
        {
            if (String.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^([a-z0-9\+_\-]+)(\.[a-z0-9\+_\-]+)*@([a-z0-9\-]+\.)+[a-z]{2,6}$"))
            {
                AddNotification(new Notification(message, propertyName));
            }

            return this;
        }
    }
}