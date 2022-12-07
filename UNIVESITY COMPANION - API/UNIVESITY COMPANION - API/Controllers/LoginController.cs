using Microsoft.AspNetCore.Mvc;

    namespace UNIVESITY_COMPANION___API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController
    {
        [HttpGet]
        public WeatherForecast Get()
        {
            var obj = new WeatherForecast();
            obj.Value = "This is returned from api";
            return obj;
        }
    }
}
