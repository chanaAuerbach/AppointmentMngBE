using AppointmentMngBE.BL;
using AppointmentMngBE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentMngBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : Controller
    {
        AppointmentsMngBL bl;
        public AppointmentsController()
        {
            bl = new AppointmentsMngBL();
        }

        [HttpPost]
        public void PostBussinessAppointments(int x)
        {
            try
            {
                Console.WriteLine(x);
            }
            catch (Exception ex)
            {
              
            }

        }


        [HttpGet("GetBussinessAppointments")]
        public IActionResult GetBussinessAppointments()
        {
            try
            {
                return Ok(bl.GetBussinessAppointments());
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [HttpGet("GetAppointmentsForDateRange")]
        public IActionResult GetAppointmentsForDateRange(int bussiness_id, DateTime fromDate, DateTime toDate)
        {
            try
            {
                return Ok(bl.GetAppointmentsForDateRange(bussiness_id, fromDate, toDate));
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
