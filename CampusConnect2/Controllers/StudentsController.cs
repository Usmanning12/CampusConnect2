using CampusConnect2.Data;
using CampusConnect2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CampusConnect2.Controllers;

public class StudentController : Controller
{
    private readonly ApplicationDbContext _context;

    public StudentController(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task<IActionResult> Index()
    {
        var students = await _context.Students
            .Include(s => s.Meetings)
            .ToListAsync();

        return View(students);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Student student)
    {
        if (!ModelState.IsValid)
        {
            return View(student);
        }

        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
    
}
