using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FormAPI.Model;
using FormAPI.FormDataDal;

namespace FormAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //[EnableCors("AllowSpecificOrigin")]
    public class ValuesController : ControllerBase
    {
        private readonly FormDataDal1 _dal;
        public ValuesController(FormDataDal1 dal) 
        {
            _dal = dal;
        }
        //[DisableCors]
        [HttpPost]
        public ActionResult<string> PostValues([FromBody] FormModel formData)
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

            var dalresult = _dal.TestDal(formData);
            if (string.IsNullOrEmpty(dalresult))
            {
                return BadRequest(new { status = "error", result = "Empty result" });
            }
            return BadRequest(new { status = "error", result = dalresult });
        }
    }
}
