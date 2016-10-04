using System.Web.Mvc;
using WebAppDb.BAL;

namespace WebAppDb.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            var addressService = new AddressService();
                addressService.GetAddress();
            return View();
        }
    }
}