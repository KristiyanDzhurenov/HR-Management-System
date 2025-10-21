using Microsoft.AspNetCore.Mvc;
using HRManagementSystem.Models;
using HRManagementSystem.Data;

[ApiController]
[Route("api/[controller]")]
public class DepartmentsController : ControllerBase
{
    private readonly HRDbContext _context;

    public DepartmentsController(HRDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var departments = _context.Departments.ToList();
        return Ok(departments);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var department = _context.Departments.Find(id);
        if (department == null)
        {
            return NotFound();
        }
        return Ok(department);
    }

    [HttpPost]
    public IActionResult Create(Department department)
    {
        _context.Departments.Add(department);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = department.Id }, department);
    }
}