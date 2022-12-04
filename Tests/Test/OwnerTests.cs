using Microsoft.VisualStudio.TestTools.UnitTesting;

using Domain.Enums;
using Domain.ValueObjects;
using Domain.Entities.PetContext;

namespace Tests.Test
{
    [TestClass]
    public class OwnerTests
    {
        [TestMethod]
        public void TestIfTheOwnerPropertyIsValid()
        {
            var owner = new Owner(name: new Name("António", "Gabriel"), email: "antoniogabriel@gmail.com",
                document: new Document("003764756LA037", EDocumentType.BI));

            Assert.AreEqual(true, owner.Validate());
        }
    }
}