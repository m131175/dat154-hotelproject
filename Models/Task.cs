using System;
using System.Collections.Generic;

namespace FrontDesk.Models;

public partial class Task
{
    public int Id { get; set; }

    public int? Roomnumber { get; set; }

    public string? Task1 { get; set; }

    public string? Note { get; set; }

    public virtual Room? RoomnumberNavigation { get; set; }
}
