using Microsoft.AspNetCore.Mvc;
using TechnologyOneTest.Models;

namespace TechnologyOneTest.Controllers
{
    public class ConvertController : Controller
    {
        public IActionResult Index()
        {
            return View(new ConvertModel());
        }

        [HttpGet]
        public IActionResult TryConvert(ConvertModel model)
        {
            if (decimal.TryParse(model.InputNumber.ToString(), out decimal num))
            {
                model.Result = model.ConvertNumberToWords();
                return Content(model.Result);
            }

            model.Result = "Error";
            return Content(model.Result);
        }
    }
}
