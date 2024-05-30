namespace EmployeeReportKata.Domain;

public interface EmployeeRepo
{
    IEnumerable<Employee> All();
}

public class HardcodedRepo : EmployeeRepo
{
    public IEnumerable<Employee> All()
        => new List<Employee>
        {
            new() {Name = "Max", Age = 17 },
            new() {Name = "Sep", Age = 18 },
            new() {Name = "Nin", Age = 15 },
            new() {Name = "Mik", Age = 51 }
        };
}