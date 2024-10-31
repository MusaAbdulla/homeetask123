using System.Numerics;

namespace Pratice;



    internal class Program
    {
        static void Main(string[] args)
        {

           
            Appointment appointment = new Appointment()
            {
                No = 1,
                Patient = new Patient {PatientName="Senan",PatientSurName="Nagizade" },
                Doctor = new Doctor { Name="Nizami",SurName="Haciyev"},
                StartDate = new DateTime(2024, 10, 31, 8, 00, 00),
                EndDate = new DateTime(2024, 10, 31, 10, 00, 00)


            };
            Appointment appointment1 = new Appointment()
            {
                No = 2,
                Patient = new Patient { PatientName = "Sema", PatientSurName = "Memmədova" },
                Doctor = new Doctor { Name = "Musa",SurName = "Abdullayev"},
                StartDate = new DateTime(2024,10,28,9,00,00),
                EndDate = new DateTime(2024,10,28,11,00,00)

            };
            Appointment appointment2 = new Appointment()
            {
                No = 3,
                Patient = new Patient { PatientName="Elvin",PatientSurName="Huseynli" },
                Doctor = new Doctor { Name="Huseyn",SurName="Eyvazli" },
                StartDate = new DateTime(2024,10,21,10,00,00),
                EndDate = new DateTime(2024,10,21,12,00,00)

            };
            Appointment appointment3 = new Appointment()
            {
                No = 4,
                Patient = new Patient {PatientName="Real",PatientSurName="Pasayev"},
                Doctor = new Doctor { Name="Kamran",SurName="Ebilov" },
                StartDate = new DateTime(2024,10,18,12,00,00),
                EndDate = new DateTime(2024,10,18,14,00,00)

            };
        Hospital.AddAppointment(appointment);
        Hospital.AddAppointment(appointment1);
        Hospital.AddAppointment(appointment2);
        Hospital.AddAppointment(appointment3);

        foreach (var item in Hospital.appointments)
        {
            Console.WriteLine(item.Patient.PatientName + " " + item.EndDate);
        }
        Console.WriteLine("------------------------------------------------------------");
        Hospital.EndAppointment(2);

        foreach (var item in Hospital.appointments)
        {
            Console.WriteLine(item.Patient.PatientName + " " + item.EndDate);
        }
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine(Hospital.GetAppointment(3).Patient.PatientName);
        Console.WriteLine("------------------------------------------------------------");



        Hospital.GetAllAppointments();
        foreach (var item in Hospital.appointments)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------------------");
        var weeklyAppointments = Hospital.GetWeeklyAppointments( );
        foreach (var app in weeklyAppointments)
        {
            Console.WriteLine($"{app.Patient} - {app.Doctor} - {app.StartDate}");
        }
        // yazaaaaa bilmedimm 1 noyabr 2024 gece saat 3:53//
    }
}





