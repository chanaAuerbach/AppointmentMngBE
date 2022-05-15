using System;
using System.Collections.Generic;

namespace AppointmentMngBE.Models
{
    public partial class Apointment
    {
        public Apointment()
        {
            Alerts = new HashSet<Alert>();
        }

        public int ApointmentId { get; set; }
        public DateTime FromDatetime { get; set; }
        public DateTime UntilDatetime { get; set; }
        public int BusinessId { get; set; }
        public int CustomerId { get; set; }
        public string? Status { get; set; }

        public virtual Business Business { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<Alert> Alerts { get; set; }
    }
}
