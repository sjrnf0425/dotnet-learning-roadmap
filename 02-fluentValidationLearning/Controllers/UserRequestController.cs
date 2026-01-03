using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace fluentValidationLearning.Controllers
{
    public class UserRequestController : ControllerBase
    {
        private readonly IValidator<UserRequest> _validator;
        public UserRequestController(IValidator<UserRequest> validator)
        {
            _validator = validator;
        }

        [HttpPost("api/user")]
        public async Task<IActionResult> CreateUser([FromBody] UserRequest userRequest)
        {
            var validationResult = await _validator.ValidateAsync(userRequest);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            // Proceed with further processing if validation passes
            return Ok("User request is valid.");
        }
    }
}
