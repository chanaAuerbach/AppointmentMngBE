using AppointmentMngBE.Models;

namespace AppointmentMngBE.BL
{
    public class AppointmentsMngBL
    {
        AppointmentsManagementContext context = new AppointmentsManagementContext();
        internal IEnumerable<Apointment> GetBussinessAppointments()
        {
            try
            {
                return context.Apointments.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal IEnumerable<Apointment> GetAppointmentsForDateRange(int bussiness_id, DateTime fromDate, DateTime toDate)
        {
            try
            {
                //  return context.Apointments.ToList();

                return context.Apointments.Where(a => a.BusinessId == bussiness_id &&
                a.FromDatetime >= fromDate && a.FromDatetime <= toDate).ToList<Apointment>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //internal IEnumerable<Apointment> GetAppointmentsForDateRange()
        //{
        //    try
        //    {
        //        return context.Apointments.ToList();

        //        //return context.Apointments.Where(a => a.BusinessId == bussiness_id &&
        //        //a.FromDatetime >= fromDate && a.FromDatetime <= toDate).ToList<Apointment>();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
