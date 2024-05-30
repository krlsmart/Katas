namespace EmployeeReportKata.Domain;

public record Employee
{
    public string Name { get; init; }
    public int Age { get; init; }
}