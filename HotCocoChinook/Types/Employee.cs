namespace HotCocoChinook.Types;

public class Employee
{
    public required int EmployeeId { get; set; }
    public required  string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Title { get; set; }
    public int? ReportsTo { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public DateTime? HireDate { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public string? Email { get; set; }
}