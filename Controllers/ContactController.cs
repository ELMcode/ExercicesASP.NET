using Microsoft.AspNetCore.Mvc;
using ExercicesASP.NET.Models;

namespace ExercicesASP.NET.Controllers;

public class ContactController : Controller
{
    // Contact list simulation
    private static List<Contact> _contacts = new()
    {
        new Contact { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@gmail.com", PhoneNumber = "0600000000" },
        new Contact { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@gmail.com", PhoneNumber = "0600000002" },
        new Contact { Id = 3, FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@gmail.com", PhoneNumber = "0600000003" }
    };

    // Action to show all contacts
    public IActionResult Index()
    {
        ViewBag.TotalContacts = _contacts.Count;
        ViewData["PageTitle"] = "Liste des contacts";
        return View(_contacts);
    }

    // Action to show one contact
    public IActionResult Details(int id)
    {
        var contact = _contacts.FirstOrDefault(c => c.Id == id);
        if (contact == null)
        {
            return NotFound();
        }
        return View(contact);
    }

    // Action to create a contact with a form
    public IActionResult Create()
    {
        return View();
    }

    // Action for form creation
    [HttpPost]
    public IActionResult Create(Contact contact)
    {
        if (ModelState.IsValid)
        {
            contact.Id = _contacts.Max(c => c.Id) + 1;
            _contacts.Add(contact);
            return RedirectToAction(nameof(Index));
        }
        return View(contact);
    }
}
