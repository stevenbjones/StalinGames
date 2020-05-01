using System.ComponentModel.DataAnnotations;

namespace EmployeeManagment.Utilities
{
    public class ValidEmailDomainAttribute : ValidationAttribute
    {
        private string _allowedDomain;

        public ValidEmailDomainAttribute(string allowedDomain)
        {
            _allowedDomain = allowedDomain;
        }

        public override bool IsValid(object value)
        {
            var val = value.ToString();
            var stringArray = val.Split('@');
            var domain = stringArray[1];
            var isvalid = domain.ToUpper() == _allowedDomain.ToUpper();

            return isvalid;
        }
    }
}
