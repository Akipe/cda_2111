using System.Text.RegularExpressions;

namespace ValidationTraining.Validation
{
    public static class NameValidation
    {
        public static bool IsValide(string name)
        {
            return
                CommonValidation.DoesExceedCharLimit(name, 1, 20) &&
                CommonValidation.IsAlpha(name)
            ;
        }
    }
}