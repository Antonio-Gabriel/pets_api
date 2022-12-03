using Domain.Validations;
using Domain.ValueObjects;
using Domain.Validations.Interfaces;

namespace Domain.Entities.PetContext
{
    public class Owner : BaseEntity, IContract
    {
        public Owner(Name name, string email, Document document)
            : base(name)
        {
            Email = email;
            Document = document;
        }

        public string Email { get; private set; }
        public Document Document { get; private set; }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public override bool Validate()
        {
            var contract = new ContractValidation<Owner>()
                .FirstNameIsOk(this.Name, 20, 5, "The first name needed to has between 5 and 20 charecters", "FirstName")
                .LastNameIsOk(this.Name, 20, 5, "The last name needed to has between 5 and 20 charecters", "LastName")
                .EmailIsValid(this.Email, "Invalid email, please check", "Email");

            return contract.IsValid();
        }
    }
}