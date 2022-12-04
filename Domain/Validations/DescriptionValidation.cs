using Domain.Notifications;

namespace Domain.Validations
{
    public partial class ContractValidation<T>
    {
        public ContractValidation<T> DescriptionIsOk(string description, short maxLenght, short minLenght, string message, string propertyName)
        {
            if (String.IsNullOrEmpty(description) || (description.Length < minLenght) || (description.Length > maxLenght))
            {
                AddNotification(new Notification(message, propertyName));
            }

            return this;
        }
    }
}