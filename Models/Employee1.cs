using System;
using System.Collections.Generic;

namespace demo0212.Models;

public partial class Employee1
{
    public int Userid { get; set; }

    public string Usersurname { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Userpatronymic { get; set; } = null!;

    public string Department { get; set; } = null!;

    public int EmployeeCode { get; set; }

    public virtual Emplyee EmployeeCodeNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
