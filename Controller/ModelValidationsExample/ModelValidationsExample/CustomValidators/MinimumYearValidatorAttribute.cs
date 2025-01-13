using System.ComponentModel.DataAnnotations;

namespace ModelValidationsExample.CustomValidators
{
    public class MinimumYearValidatorAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)

            {
                DateTime date = (DateTime)value;
                if (date.Year >= 2000)
                {

                    return new ValidationResult("Mimimun year allowed is 2000");
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