using Microsoft.AspNetCore.Mvc;
using Realty_Management_System_Application.Shared.Result;

namespace Realty_Management_System_API.Shared.Extensions
{
    public static class ResultExtensions
    {
        public static IActionResult ToActionResult(this Result result, ControllerBase controller)
        {
            return controller.StatusCode(result.StatusCode, result);
        }
    }
}
