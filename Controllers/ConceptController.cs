using System.Linq;
using database_for_concept_reports.Data;
using Microsoft.AspNetCore.Mvc;

namespace database_for_concept_reports.Controllers
{
    public class ConceptController: Controller
    {
        private ApplicationDbContext _db;

        public ConceptController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var concepts = _db.Concepts.OrderByDescending(c => c.Id);
            return View(concepts.ToList());
        }

        public IActionResult View(int? id)
        {
            var concept = _db.Concepts.FirstOrDefault(c => c.Id == id);
            
            return View(concept);
        }

        public IActionResult Edit(int? id)
        {
            return View();
        }
    }
}