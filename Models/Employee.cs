using System;
using System.Collections.Generic;

namespace CodeExitosProyect.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Telefhone { get; set; }

    public string? Address { get; set; }

    public string? EmploymentDate { get; set; }

    public int Type { get; set; }

    public virtual EmployeeType TypeNavigation { get; set; } = null!;
}
