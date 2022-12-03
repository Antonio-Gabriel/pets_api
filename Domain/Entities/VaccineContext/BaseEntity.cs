using System;

namespace Domain.Entities.VaccineContext
{
    public class BaseEntity
    {
        public BaseEntity(string description)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            Description = description;
        }

        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public virtual void SetDescription(string description)
        {
            Description = description;
        }
    }
}