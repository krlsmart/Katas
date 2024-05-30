namespace EmployeeReportKata.Domain;

public class Reporter
{
    readonly EmployeeRepo repo;

    public Reporter(EmployeeRepo repo)
    {
        this.repo = repo;
    }

    public IEnumerable<Employee> AllEmployeesAllowedToWorkOnSundays()
        => repo.All()
            .Where(e => e.Age >= 18)
            .OrderBy(e => e.Name)
            .Select(e => e with { Name = e.Name.ToUpper() });
}