using System;
using System.Collections.Generic;

namespace demo0212.Models;

public partial class Emplyee
{
    public int Employeecode { get; set; }

    public string Employee { get; set; } = null!;

    public virtual ICollection<Employee1> Employee1s { get; set; } = new List<Employee1>();
}
