using Microsoft.AspNetCore.Mvc;
using HRManagementSystem.Models;
using HRManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly HRDbContext _context;

    public EmployeesController(HRDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var employees = _context.Employees.Include(e => e.Department).ToList();
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var employee = _context.Employees.Include(e => e.Department).FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            return NotFound();
        }
        return Ok(employee);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
    }
}