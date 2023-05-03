using System;
using System.Collections.Generic;

namespace FrontDesk.Models;

public partial class Room
{
    public int Roomnumber { get; set; }

    public int? Numberofbeds { get; set; }

    public string? Roomtype { get; set; }

    public bool? Reserved { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
