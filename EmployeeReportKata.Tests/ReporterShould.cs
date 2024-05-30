using EmployeeReportKata.Domain;
using FluentAssertions;

namespace EmployeeReportKata.Tests;

public class ReporterShould
{
    [Test]
    public void ShowAllEmployees_OlderOrEqualThan18()
    {
        var sut = new Reporter(new HardcodedRepo());
        
        var result = sut.AllEmployeesAllowedToWorkOnSundays();
        
        result.All(e => e.Age >= 18).Should().BeTrue();
    }

    [Test]
    public void ShowTheListOfEmployees_SortedByName()
    {
        var sut = new Reporter(new HardcodedRepo());
        
        var result = sut.AllEmployeesAllowedToWorkOnSundays();
        
        result.Should().BeInAscendingOrder(e => e.Name);
    }
    
    [Test]
    public void ShowTheListOfEmployees_Capitalized()
    {
        var sut = new Reporter(new HardcodedRepo());
        
        var result = sut.AllEmployeesAllowedToWorkOnSundays();
        
        result.All(e => e.Name == e.Name.ToUpper()).Should().BeTrue();
    }
}