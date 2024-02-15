using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prjTravelPlatformV3.Areas.Employee.ViewModels.TravelPlan;
using prjTravelPlatformV3.Models;

namespace prjTravelPlatformV3.Areas.Employee.Controllers.TravelPlan
{
	[Route("/api/TDestination/{action}/{id?}")]
	public class TDestinationController : Controller
	{

		private readonly dbTravalPlatformContext _context;

		public TDestinationController(dbTravalPlatformContext context)
		{
			_context = context;
		}

		[Area("Employee")]
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult GetAllDestionation()
		{
			var Context = (from h in _context.Tdestinations
						   join x in _context.Ttypes on h.FdestinationTypeId equals x.FtypeId
						   join y in _context.TtravelAreas on h.FareaId equals y.FareaId
						   select new { h, x, y }).Select(a => new DestionationView()
						   {
							   FDestinationId = a.h.FdestinationId,
							   FDestinationName = a.h.FdestinationName,
							   FStock = a.h.Fstock,
							   Ftype = a.x.Ftype,
							   FAddress = a.h.Faddress,
							   FAreaName = a.y.FareaName,
							   FPrice = a.h.Fprice,
							   FDestinationContent = a.h.FdestinationContent,
							   FState = a.h.Fstate ? "上架中" : "已下架"
						   });
			return Json(Context);
		}
		public IActionResult GetAllTravelPlan()
		{
			var Context = (from h in _context.TtravelPlans
						   join x in _context.Ttypes on h.FtravelTypeId equals x.FtypeId
						   join y in _context.TtravelAreas on h.FareaId equals y.FareaId
						   select new { h, x, y }).Select(a => new TravelplanView()
						   {
							   FTravelId = a.h.FtravelId,
							   FTravelName = a.h.FtravelName,
							   FType = a.x.Ftype,
							   FDay = a.h.Fday,
							   FTransport = a.h.Ftransport,
							   FAreaName = a.y.FareaName,
							   FPrice = a.h.Fprice,
							   FStock = a.h.Fstock,
							   FState = a.h.Fstate ? "上架中" : "已下架"
						   });
			return Json(Context);
		}

	}
}
