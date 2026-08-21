using Football.Models;
using Microsoft.AspNetCore.Mvc;

namespace Football.Controllers
{
    public class ClubsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IClubsRepo _clubRepo;
        public ClubsController(AppDbContext context, IClubsRepo clubRepo)
        {
            _context = context;
            _clubRepo = clubRepo;
        }
        public IActionResult Index()
        {
            Club club = new Club();
            var model = _clubRepo.GetAllClubs();
         
            return View(model);
        }
    }
}
