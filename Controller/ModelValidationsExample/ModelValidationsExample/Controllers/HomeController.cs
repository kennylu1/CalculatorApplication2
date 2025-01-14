using Microsoft.AspNetCore.Mvc;
using ModelValidationsExample.CustomModelBinders;
using ModelValidationsExample.Models;

namespace ModelValidationsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        //[Bind(nameof(Person.PersonName), nameof(Person.Email), nameof(Person.Password), nameof(Person.ConfirmPassword))]
        public IActionResult Index([FromBody][ModelBinder(BinderType=typeof(PersonModelBinder))] Person person)
        {
            if (!ModelState.IsValid)    
            {
                //get error messages from model state
                string errors = string.Join("\n", ModelState.Values.SelectMany(value => value.Errors).Select(err => err.ErrorMessage));

                return BadRequest(errors);
            }

            return Content($"{person}");
        }
    }
}