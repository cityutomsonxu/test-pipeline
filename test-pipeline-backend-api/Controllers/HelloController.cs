using Microsoft.AspNetCore.Mvc;

namespace test_pipeline_backend_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Dictionary<string, string>> GetHeaders()
        {
            Dictionary<string, string> headerDictionary = Request.Headers
                .ToDictionary(header => header.Key, header => header.Value.ToString());

            headerDictionary.Add("Hello", "8");

            return headerDictionary;
        }
    }
}
