using Domain.Validations;
using Domain.ValueObjects;
using Domain.Validations.Interfaces;

namespace Domain.Entities.PetContext
{
    public class Pet : BaseEntity, IContract
    {
        public Pet(Name name, int identifier)
            : base(name)
        {
            Identifier = identifier;
        }

        public int Identifier { get; private set; }

        public void SetIdentifier(int identifier)
        {
            Identifier = identifier;
        }

        public override bool Validate()
        {
            var contract = new ContractValidation<Pet>()
                .FirstNameIsOk(this.Name, 20, 5, "The first name needed to has between 5 and 20 charecters", "FirstName")
                .LastNameIsOk(this.Name, 20, 5, "The last name needed to has between 5 and 20 charecters", "LastName");

            return true;
        }
    }
}