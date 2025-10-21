namespace HRManagementSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }
        public required Department Department { get; set; }

        public List<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();
        public required string Name { get; set; }
    }
}
