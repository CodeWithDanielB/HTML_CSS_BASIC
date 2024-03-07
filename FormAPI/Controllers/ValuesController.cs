using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //[EnableCors("AllowSpecificOrigin")]
    public class ValuesController : ControllerBase
    {
        //[DisableCors]
        [HttpPost]
        public ActionResult<string> PostValues([FromBody] FormAPI.Model.Model formData)
        {
    
            //var formData = new FormAPI.Model.Model
            //{
            //    first_name = Request.Query["first_name"],
            //    last_name = Request.Query["last_name"],
            //    E_Mail = Request.Query["E_Mail"],
            //    address = Request.Query["address"]
            //};

            //Console.WriteLine(formData.address);

            //returning JSON for the client-side
            return Ok(new { message = formData.address });
        }
    }
}
