using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public enum WorkType { Gotomeetings, GenerateReports,PlayGolf}

    public delegate void WorkPerformedHandler(int hours, WorkType worktype); //1
    internal class EmployeeWork
    {
        public event WorkPerformedHandler WorkPerformed;  //2. define 1st event

        public event EventHandler WorkCompleted;  // 3 define another event

        public void DoWork(int hours, WorkType worktype)
        {
            //raising events
            //if(WorkPerformed != null)
            //{
            //    WorkPerformed(8, WorkType.GenerateReports);
                //or

                // 2. WorkPerformed?.Invoke(8, WorkType.GenerateReports);

                //or
                //3. WorkPerformedHandler del1 = WorkPerformed as WorkPerformedHandler;
                //if(del1 !=null)
                //{
                //    del1(8, WorkType.PlayGolf);
                //}

                //or
                // 4. if(WorkPerformed is  WorkPerformedHandler del2)
                //{
                //    del2.Invoke(8, WorkType.PlayGolf);
                //}
                OnWorkPerformed(hours, worktype);
            }
         public virtual void OnWorkPerformed(int hours, WorkType worktype)
         {
            WorkPerformed?.Invoke(8, WorkType.GenerateReports);
         }

         public EmployeeWork()
        {
            this.WorkPerformed += new WorkPerformedHandler(OnWorkPerformed);
        }
        }
    }

