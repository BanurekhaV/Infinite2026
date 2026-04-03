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

        protected virtual void OnPatientRecovered(string patientname)
        {
            PatientRecovered?.Invoke(this, new PatientRecoveredEvent
            {
                PatientName = patientname
            });
        }

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
        public void OnPatientRecovered(object sender, PatientRecoveredEvent e)
        {
            Console.WriteLine($"Doctor notified : Patient :{e.PatientName} has Recovered ");
        }
    }

    public class Nurse
    {
        public void OnPatientRecovered(object sender, PatientRecoveredEvent e)
        {
            Console.WriteLine($"Nurse notified : Patient :{e.PatientName} has Recovered ");
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

            publisher.PatientRecovered += doctor.OnPatientRecovered;
            publisher.PatientRecovered += nurse.OnPatientRecovered;


            Console.WriteLine("enter Patient name :");
            string pname = Console.ReadLine();

            publisher.TriggerRecovery(pname);
            Console.Read();
        }
    }
}
