namespace Domain.Entities.VaccineContext
{
    public class Category : BaseEntity
    {
        public Category(string description)
            : base(description)
        { }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
        }
    }
}