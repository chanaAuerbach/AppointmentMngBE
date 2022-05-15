using System;
using System.Collections.Generic;

namespace AppointmentMngBE.Models
{
    public partial class ServiceType
    {
        public int ServiceId { get; set; }
        public int DurationInMinutes { get; set; }
        public decimal? Price { get; set; }
        public string? Discription { get; set; }
        public int? ColorId { get; set; }
    }
}
