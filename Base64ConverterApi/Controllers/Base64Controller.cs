using Microsoft.AspNetCore.Mvc;

namespace Base64ConverterApi.Controllers
{
    [Route("api/base64")]
    [ApiController]
    public class Base64Controller : ControllerBase
    {
        [HttpGet("encode")]
        public ActionResult<string> Encode(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return BadRequest("Input value cannot be null or empty.");
            }
            var bytes = System.Text.Encoding.UTF8.GetBytes(value);
            var base64 = Convert.ToBase64String(bytes);
            return Ok(base64);
        }
    }
}
