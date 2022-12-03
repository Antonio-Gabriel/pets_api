using Domain.Notifications;
using Domain.ValueObjects;

namespace Domain.Validations
{
    public partial class ContractValidation<T>
    {

        public ContractValidation<T> FirstNameIsOk(Name name, short maxLenght, short minLenght, string message, string propertyName)
        {
            if (String.IsNullOrEmpty(name.FirstName) || (name.FirstName.Length < minLenght) || (name.FirstName.Length > maxLenght))
            {
                AddNotification(new Notification(message, propertyName));
            }

            return this;
        }

        public ContractValidation<T> LastNameIsOk(Name name, short maxLenght, short minLenght, string message, string propertyName)
        {
            if (String.IsNullOrEmpty(name.LastName) || (name.LastName.Length < minLenght) || (name.LastName.Length > maxLenght))
            {
                AddNotification(new Notification(message, propertyName));
            }

            return this;
        }
    }
}