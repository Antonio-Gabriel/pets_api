using Domain.Enums;
using Domain.ValueObjects;
using Domain.Notifications;

using System.Text.RegularExpressions;

namespace Domain.Validations
{
    public partial class ContractValidation<T>
    {
        public ContractValidation<T> IsValidBi(Document document, string message, string propertyName)
        {
            if (document.DocumentType == EDocumentType.BI)
            {
                if (!IsBi(document.DocumentNumber))
                {
                    AddNotification(new Notification(message, propertyName + " BI"));
                }
            }

            return this;
        }

        private bool IsBi(string bi)
        {
            return Regex.IsMatch(bi, @"^(\d){9}[A-Z]{2}(\d){3}$");
        }
    }
}