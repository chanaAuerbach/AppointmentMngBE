using System;
using System.Collections.Generic;

namespace AppointmentMngBE.Models
{
    public partial class Alert
    {
        public int AlertId { get; set; }
        public DateTime DateOfAlert { get; set; }
        public string? StatusAlert { get; set; }
        public int ApointmentId { get; set; }

        public virtual Apointment Apointment { get; set; } = null!;
    }
}
