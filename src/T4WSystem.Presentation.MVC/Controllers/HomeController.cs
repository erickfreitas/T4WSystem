using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using T4WSystem.Application.Interfaces;
using T4WSystem.Application.ViewModels;

namespace T4WSystem.Presentation.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICangoorooBookingAppService _cangoorooBookingAppService;

        public HomeController(ICangoorooBookingAppService cangoorooBookingAppService)
        {
            _cangoorooBookingAppService = cangoorooBookingAppService;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {            
            var rooms = await _cangoorooBookingAppService.GetRamdomRooms(12);
            return View(rooms);
        }

        [HttpPost]
        public async Task<ActionResult> Index(CriteriaViewModel criteriaViewModel)
        {
            var rooms = await _cangoorooBookingAppService.GetRooms(criteriaViewModel);
            return View(rooms.Take(16));
        }
    }
}