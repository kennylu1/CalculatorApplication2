using System.ComponentModel.DataAnnotations;

namespace ModelValidationsExample.CustomValidators
{
    public class MinimumYearValidatorAttribute : ValidationAttribute
    {
        public int MinimumYear { get; set; }
        public MinimumYearValidatorAttribute() { }
        public MinimumYearValidatorAttribute(int minimumYear) {
            MinimumYear = minimumYear;
        
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)

            {
                DateTime date = (DateTime)value;
                if (date.Year >= 2000)
                {

                    return new ValidationResult(ErrorMessage);
                }
                 
                
                else
                {
                    return ValidationResult.Success;
                }
            }
            return null;
            

        }
    }
}