using Microsoft.AspNetCore.Mvc;
using EFSalon;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPEFSalon.Controllers
{
    public class HomeController : Controller
    {
        ApplContext db;
        public HomeController(ApplContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Clients.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Client client)
        {
            if (client != null)
            {
                db.Clients.Add(client);
                await db.SaveChangesAsync();
            }
                return RedirectToAction("Index");
        }

        public async Task<IActionResult> IndexM()
        {
            return View(await db.Masters.ToListAsync());
        }
        public IActionResult CreateM()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateM(Master master)
        {
            if (master != null)
            {
                db.Masters.Add(master);
                await db.SaveChangesAsync();
            }
                return RedirectToAction("IndexM");
        }
    }
}
