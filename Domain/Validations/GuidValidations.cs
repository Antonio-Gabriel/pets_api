using Domain.Notifications;

namespace Domain.Validations
{
    public partial class ContractValidation<T>
    {
        public ContractValidation<T> IsGuid(object guid, string message, string propertyName)
        {
            if (guid! is Guid)
            {
                AddNotification(new Notification(message, propertyName));
            }

            return this;
        }
    }
}