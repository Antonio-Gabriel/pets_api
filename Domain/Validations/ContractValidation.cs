using Domain.Notifications;
using Domain.Validations.Interfaces;

namespace Domain.Validations
{
    public partial class ContractValidation<T> where T : IContract
    {
        private List<Notification> _notifications;
        public ContractValidation()
        {
            _notifications = new List<Notification>();
        }

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public bool IsValid()
        {
            return (_notifications.Count == 0 ? true : false);
        }
    }
}