using System;
using System.Collections.Generic;

namespace AppointmentMngBE.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Apointments = new HashSet<Apointment>();
        }

        public int CustomerId { get; set; }
        public string Phone { get; set; } = null!;
        public string? FirstNane { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? TokenId { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public int BusinessId { get; set; }
        public string? Remark { get; set; }

        public virtual Business Business { get; set; } = null!;
        public virtual ICollection<Apointment> Apointments { get; set; }
    }
}
