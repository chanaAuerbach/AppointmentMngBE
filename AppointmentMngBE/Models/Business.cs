using System;
using System.Collections.Generic;

namespace AppointmentMngBE.Models
{
    public partial class Business
    {
        public Business()
        {
            Apointments = new HashSet<Apointment>();
            BusinessConfigurations = new HashSet<BusinessConfiguration>();
            Customers = new HashSet<Customer>();
        }

        public int BusinessId { get; set; }
        public string? Phone { get; set; }
        public int? ExtentionNumber { get; set; }

        public virtual ICollection<Apointment> Apointments { get; set; }
        public virtual ICollection<BusinessConfiguration> BusinessConfigurations { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
