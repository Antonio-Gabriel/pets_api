using Domain.Validations;
using Domain.Validations.Interfaces;

namespace Domain.Entities.VaccineContext
{
    public class Category : BaseEntity, IContract
    {
        public Category(string description)
            : base(description)
        { }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
        }

        public override bool Validate()
        {
            var contract = new ContractValidation<Category>()
                .DescriptionIsOk(this.Description, 64, 12, "The description nedded to contains between 64 and 12 characters", "Description");

            return contract.IsValid();
        }
    }
}