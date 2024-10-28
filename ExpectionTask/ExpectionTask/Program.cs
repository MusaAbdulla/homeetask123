namespace ExpectionTask
{
    internal class Program
    {
        public static  void Main(string[] args)
        {
            Meeting[] Meetings = new Meeting[3];
            Meeting meeting = new Meeting();       
            meeting.FromDate = DateTime.Parse("11:00");
            meeting.ToDate = DateTime.Parse("14:00");
            MeetingSchedule meetingScheulde = new MeetingSchedule();
            meetingScheulde.SetMeeting(meeting.FromDate, meeting.ToDate, "Moses");
        }
    }
}
/*Meeting class:
-FromDate
-ToDate
-FullName
 
MeetingSchedule class:
Meetings - Meeting array-ı
SetMeeting(fullname,from,to) - gonderilmis deyerlere esasen meeting yaratmaga calisir.
Eger Gonderilmis tarix intervalinda meeting varsa geriye ReservedDateInterval exception qaytarir, 
eger gonderilen fromdate todate-den kicik deyilse WrongDateInterval exception qaytarir, her sey okaydirse meeting obyekti yaradib 
meeting listine add edir
 */