using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class Hospital
    {
        public static List<Appointment> appointments = new List<Appointment>();
        public static void AddAppointment(Appointment newappointment)
        {
            appointments.Add(newappointment);
        }
        public static void EndAppointment(int no)
        {
            Appointment appom = appointments.Find(x => x.No == no);
            if (appom != null)
            {
                appom.EndDate = DateTime.Now;
            }
        }
        public static Appointment GetAppointment(int no)
        {
            Appointment app = appointments.Find(x => x.No == no);
            return app;

        }

        public static List<Appointment> GetAllAppointments()
        {
            return appointments;
        }
        public static void GetWeeklyAppointments(Appointment appointment)
        {
            appointments.FindAll(x=> DateTime.Now.AddDays(-7) <x.StartDate);
        }
        public static void GetTodaysAppointments()
        {

        }
        public static void GetAllContinuingAppointments()
        {

        }
    }
}
