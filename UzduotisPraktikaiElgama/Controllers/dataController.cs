using Microsoft.AspNetCore.Mvc;
using UzduotisPraktikaiElgama.Models;

namespace UzduotisPraktikaiElgama.Controllers
{
    [Produces("application/json")]
    [Route("api/data")]

    public class dataController : Controller
    {
        [HttpPost]
        [Route("post")]
        public JsonResult Post([FromBody] Data data)
        {
            if (data.sortType == "ASC")
            {
                return Json(new { result = "Hi " + data.name + ", your cars : " + data.cars.car1 + " " + data.cars.car2 + " " + data.cars.car3 });
            }
            else if (data.sortType == "DESC")
            {
                return Json(new { result = "Hi " + data.name + ", your cars : " + data.cars.car3 + " " + data.cars.car2 + " " + data.cars.car1 });
            }
            else
                return Json(new { result = "Error: {sortType} is wrong" });
        }
    }
}
