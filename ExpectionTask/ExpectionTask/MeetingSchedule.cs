using System.ComponentModel.Design;
using System.Data;

namespace ExpectionTask;


    public class MeetingSchedule: Meeting
    {
        Meeting[] Meetings = new Meeting[3];
        public void SetMeeting(DateTime from, DateTime to, string fullname)
        {
            DateTime meets = DateTime.Parse("18:00");
            FromDate = from;
            ToDate = to;
            FullName = fullname;
            if (meets > from && to> meets)
            {
                throw new ReservedDateInterval();
            }
            else 
            {
                throw new WrongDateInterval();
            }
            // Add ede bilmedim
            //else 
            //{
            //Console.WriteLine($"Musderi:{FullName} Gorusun baslama vaxti:{FromDate} Gorusun bitme tarixi {ToDate}");
            //}
            
        }
    }
    public class ReservedDateInterval : Exception
    {

        public ReservedDateInterval() : base("Gonderilen tarixde meeting var") { }


    }
    public class WrongDateInterval : Exception
    {
        public WrongDateInterval() : base("ToDate FromDateden kicikdir") { }
    }

