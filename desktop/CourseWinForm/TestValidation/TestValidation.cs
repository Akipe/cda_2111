using LibValidationInput;

namespace TestValidation
{
    [TestClass]
    public class TestValidation
    {
        [TestMethod] // Permet d'inclure les resultats dans le test
        public void TestValidName()
        {
            NameValidation nameValidation = new NameValidation();

            // On vérifie si le resultat est bien celui qu'on attend
            Assert.IsTrue(nameValidation.IsValid("toto"));
            // ou, similaire à au dessus
            Assert.IsTrue(nameValidation.IsValid("jean-toto"));
        }

        [TestMethod]
        public void TestInvalidName()
        {
            NameValidation nameValidation = new NameValidation();

            // On vérifie si le resultat est bien celui qu'on attend
            Assert.IsFalse(nameValidation.IsValid("toto#007"));
            Assert.IsFalse(nameValidation.IsValid("toto  "));
            Assert.IsFalse(nameValidation.IsValid(""));
            Assert.IsFalse(nameValidation.IsValid("toto--tata"));
        }
    }
}