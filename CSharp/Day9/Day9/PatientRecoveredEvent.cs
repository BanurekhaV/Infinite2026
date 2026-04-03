using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class PatientRecoveredEvent : EventArgs
    {
        public string PatientName { get; set; }
    }

    //publisher class
    public class PatientRecoveryPublisher
    {
        public event EventHandler<PatientRecoveredEvent> PatientRecovered;


        //notifyying the subscribers
        protected virtual void OnPatientRecovered(string patientname)
        {
            PatientRecovered?.Invoke(this, new PatientRecoveredEvent
            {
                PatientName = patientname
            });
        }

        //raising an event
        public void TriggerRecovery(string patientname)
        {
            {
                OnPatientRecovered(patientname);
            }
        }
    }

    //3. subscriber class (that provides methods that match the signature of the delegate)
    public class Doctor
    {
        //event handlers from doctor
        public void OnDoctorsPatientRecovered(object sender, PatientRecoveredEvent e)
        {
            Console.WriteLine($"Doctor notified : Patient :{e.PatientName} has Recovered ");
        }
    }

    public class Nurse
    {
        public void OnNursePatientRecovered(object sender, PatientRecoveredEvent e)
        {
            Console.WriteLine($"Nurse notified : Patient :{e.PatientName} has Recovered ");
            Console.WriteLine("Nurse checking all vital parameters of the patient");
        }
    }

    //create console that connects the publisher and subscribers
    class HMS
    {
        static void Main()
        {
            var publisher = new PatientRecoveryPublisher();
            var doctor = new Doctor();
            var nurse = new Nurse();

            publisher.PatientRecovered += doctor.OnDoctorsPatientRecovered;
            publisher.PatientRecovered += nurse.OnNursePatientRecovered;


            Console.WriteLine("enter Patient name :");
            string pname = Console.ReadLine();

            publisher.TriggerRecovery(pname);
            Console.Read();
        }
    }
}
