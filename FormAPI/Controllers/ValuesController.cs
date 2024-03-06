using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/form/details")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            var formData = new FormAPI.Model.Model();


            formData.first_name = Request.Query["first_name"];
            formData.last_name = Request.Query["last_name"];
            formData.EMail = Request.Query["E_Mail"];
            formData.address = Request.Query["address"];


            Console.WriteLine(formData.first_name);

            return NoContent();
        }
    }
}
