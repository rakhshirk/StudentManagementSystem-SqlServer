using Microsoft.AspNetCore.Mvc;
using WebAppDatabase.Models;

namespace WebAppDatabase.Controllers
{
    public class PersonController : Controller
    {
        private readonly MyContext _context;

        public PersonController()
        {
            _context = new MyContext();
        }

        public IActionResult Index()
        {
            var persons = _context.Persons.ToArray();
            return View(persons);
        }

        public IActionResult Addperson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Addperson(Person pm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Persons.Add(pm);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = "An error occurred: " + ex.Message;
                    return View(pm);
                }
            }
            return View(pm);
        }

        // GET: Edit{id}
        [HttpGet("Person/Edit/{personId}")]
        public IActionResult Editperson(int personId)
        {
            var person = _context.Persons.Find(personId);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        [HttpPost("Person/Edit/{personId}")]
        [ActionName("Edit")]
        public IActionResult Editperson(int personId, Person updatedPerson)
        {
            if (personId != updatedPerson.PersonId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Persons.Update(updatedPerson);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    // Log the exception
                    ViewBag.ErrorMessage = "An error occurred: " + ex.Message;
                    return View(updatedPerson);
                }
            }
            return View(updatedPerson);
        }

    }

}