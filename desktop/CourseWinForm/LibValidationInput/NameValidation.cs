using System.Text.RegularExpressions;

namespace LibValidationInput
{
    public class NameValidation
    {
        private string _name;
        private Regex _regex;

        public NameValidation()
        {
            _regex = new Regex(@"^[a-zA-ZÀ-ÿ]{2,30}$");
            _name = String.Empty;
        }
        
        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Boolean IsValid(string name)
        {
            Name = name;
            return _regex.IsMatch(name);
        }
    }
}