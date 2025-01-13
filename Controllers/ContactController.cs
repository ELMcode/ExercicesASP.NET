using Microsoft.AspNetCore.Mvc;

public class ContactController : Controller
{
    // Action to show all contacts
    public IActionResult Index()
    {
        return View();
    }

    // Action to show one contact
    public IActionResult Details()
    {
        return View();
    }

    // Action to create a contact
    public IActionResult Create()
    {
        return View();
    }
}
