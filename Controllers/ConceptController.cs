using System;
using System.Linq;
using database_for_concept_reports.Data;
using database_for_concept_reports.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult View(int id)
        {
            var concept = _db.Concepts
            .Include(c => c.Group)
            .Include(c => c.ConceptTags)
            .ThenInclude(e => e.Tag)
            .FirstOrDefault(c => c.Id == id);

            var tags = concept.ConceptTags.ToList();
            var tag1Name = tags[0].Tag.Name;
            
            return View(concept);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Concept concept)
        {
            var group = _db.Groups.FirstOrDefault(g => g.Id == concept.GroupId);
            
            
            concept.Group = group;
           

            //TODO: why does this not work from model constructor???
            concept.DateCreated = DateTime.UtcNow;
            concept.Active = true;

            _db.Concepts.Add(concept);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var concept = _db.Concepts.FirstOrDefault(c => c.Id == id);

            if (concept == null)
                throw new Exception("This concept does not exist");

            return View(concept);
        }

        [HttpPost]
        public IActionResult Edit(int id, Concept c)
        {
            var concept = _db.Concepts.FirstOrDefault(_c => _c.Id == id);

            if (concept == null)
            {
                throw new Exception("This post does not exist");
            }

            concept.DateModified = DateTime.UtcNow;

            concept.Title = c.Title;
            concept.ResponsiblePerson = c.ResponsiblePerson;
            concept.GroupId = c.GroupId;
            concept.AdheresToRules = c.AdheresToRules;
            concept.Explanation = c.Explanation;
            concept.Discussion = c.Discussion;
            concept.Conclusion = c.Conclusion;

            _db.Update(concept);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}