using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace watchers_test_site
{
    public static class InternalServerErrorFunction
    {
        [FunctionName("InternalServerErrorFunction")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "InternalServerError")] HttpRequest req,
            ILogger log)
        {
            return new InternalServerErrorResult();
        }
    }
}
