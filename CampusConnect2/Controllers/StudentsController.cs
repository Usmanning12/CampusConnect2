using CampusConnect2.Data;
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
}