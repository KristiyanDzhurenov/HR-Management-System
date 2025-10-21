using Microsoft.AspNetCore.Mvc;
using HRManagementSystem.Models;
using HRManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class LeaveRequestsController : ControllerBase
{
    private readonly HRDbContext _context;

    public LeaveRequestsController(HRDbContext context)
    {
        _context = context;
    }

   [HttpGet]
public IActionResult GetAll()
{
    var requests = _context.LeaveRequests
        .Include(l => l.Employee)
        .Select(l => new {
            l.Id,
            employeeName = l.Employee.Name,
            l.StartDate,
            l.EndDate,
            l.Status
        })
        .ToList();

    return Ok(requests);
}

    [HttpPost]
    public IActionResult Create([FromBody] LeaveRequest leaveRequest)
    {
        _context.LeaveRequests.Add(leaveRequest);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetAll), new { id = leaveRequest.Id }, leaveRequest);
    }
}   