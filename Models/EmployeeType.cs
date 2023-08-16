using System;
using System.Collections.Generic;

namespace CodeExitosProyect.Models;

public partial class EmployeeType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Salary { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
