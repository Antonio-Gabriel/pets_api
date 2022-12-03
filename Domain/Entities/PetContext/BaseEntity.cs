using Domain.Notifications;
using Domain.ValueObjects;
using Domain.Validations.Interfaces;

namespace Domain.Entities.PetContext
{
    public abstract class BaseEntity : IValidator
    {
        private List<Notification> _notifications;
        protected BaseEntity(Name name)
        {
            Id = Guid.NewGuid();
            Name = name;
            CreatedAt = DateTime.UtcNow;
        }

        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        protected void SetNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public abstract bool Validate();
    }
}