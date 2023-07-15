using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Sipay.Bootcamp.ECE_ERKCİ.FluentValidationDemo.Models;

namespace Sipay.Bootcamp.ECE_ERKCİ.FluentValidationDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    [HttpPost]
    public IActionResult Post(Person person)
    {
        var validator = new PersonValidator();
        var validationResult = validator.Validate(person);

        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        // Doğrulama başarılı olduğunda burada işlemlerinizi gerçekleştirin.

        return Ok();
    }
}
