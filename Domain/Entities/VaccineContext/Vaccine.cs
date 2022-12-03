using Domain.Validations;
using Domain.Validations.Interfaces;

namespace Domain.Entities.VaccineContext
{
    public class Vaccine : BaseEntity, IContract
    {
        public Vaccine(string description, Guid categoryId, Guid petId)
            : base(description)
        {
            CategoryId = categoryId;
            PetId = petId;
        }

        public Guid CategoryId { get; private set; }
        public Guid PetId { get; private set; }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
        }

        public override bool Validate()
        {
            var contract = new ContractValidation<Vaccine>()
                .DescriptionIsOk(this.Description, 64, 12, "The description nedded to contains between 64 and 12 characters", "Description")
                .IsGuid(this.CategoryId, "The category nedded to be a guid", "CategoryId")
                .IsGuid(this.PetId, "The pet nedded to be a guid", "PetId");

            return contract.IsValid();
        }
    }
}