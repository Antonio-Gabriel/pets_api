using Domain.Notifications;
using Domain.Validations.Interfaces;

namespace Domain.Entities.VaccineContext
{
    public abstract class BaseEntity : IValidator
    {
        private List<Notification> _notifications;
        public BaseEntity(string description)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            Description = description;
        }

        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        protected void SetNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public virtual void SetDescription(string description)
        {
            Description = description;
        }

        public abstract bool Validate();
    }
}