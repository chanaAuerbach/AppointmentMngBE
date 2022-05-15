using System;
using System.Collections.Generic;

namespace AppointmentMngBE.Models
{
    public partial class BusinessConfiguration
    {
        public int BusinessConfigurationId { get; set; }
        public int BusinessId { get; set; }
        public TimeSpan OpeningHoursFromtime { get; set; }
        public TimeSpan OpeningHoursUntiltime { get; set; }

        public virtual Business Business { get; set; } = null!;
    }
}
