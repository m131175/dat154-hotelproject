using System;
using System.Collections.Generic;

namespace FrontDesk.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public int? Roomnumber { get; set; }

    public string? Status { get; set; }

    public DateOnly Startdate { get; set; }

    public DateOnly Enddate { get; set; }

    public virtual Room? RoomnumberNavigation { get; set; }

    public virtual Customer? UsernameNavigation { get; set; }
}
