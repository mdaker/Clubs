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

        public IActionResult Add()
        {

            ViewData["Error"] = "0";
            return View();
        }

        [HttpPost]
        public IActionResult Add(Club club)
        {
            if (!String.IsNullOrEmpty(club.Name))
            {
                Club clb = new Club()
                {
                    Name = club.Name,
                    City = club.City
                };
                _clubRepo.Add(clb);
                ViewData["Error"] = "0";
                ViewData["Msg"] = "Success";
            }
            else
            {
                ViewData["Error"] = "1";
                ViewData["Msg"] = "Name is required";
            }


            return View();
        }

        public IActionResult Edit(string Id)
        {
            Club club = _clubRepo.GetClub(int.Parse(Id));

            return View(club);
        }

        [HttpPost]
        public IActionResult Edit(Club club)
        {

            if (!String.IsNullOrEmpty(club.Name))
            {
                Club clb = _clubRepo.Update(club);
                ViewData["Error"] = "0";
                ViewData["Msg"] = "Success";
            }
            else
            {
                ViewData["Error"] = "1";
                ViewData["Msg"] = "Name is required";
            }

            return View(club);
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {

            Club club = _clubRepo.GetClub(Id);
            _clubRepo.Delete(Id);

            return RedirectToAction("index", new { id = club.Id });
        }
    }


}
