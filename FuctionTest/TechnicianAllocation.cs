using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuctionTest
{
    public class TechAllo
    {
        public int Id { get; set; }
        public string TechnicianName { get; set; }
        public string JobCardNumber { get; set; }
      //  public List<AcSche> acSches { get; set; } = new List<AcSche>();
    }

    public class ContMst
    {
        public int Id { get; set; }
        public string JobCardNumber { get; set; }
        public string ContractNumber { get; set; }

    }

    public class AcSche
    {
        public int Id { get; set; }
        public string JobCardNumber { get; set; }
        public string ContractNumber { get; set; }
        public DateTime ScheduleDate { get; set; }  
    }





    // TechnicianAllocation - Single Row / Record - [sigle object]
    // Contact Master - Single Row / Record - [single object]
    // AcSchedule   - Multiple Record - [record List]


   public class DataAccess
   {

        public int CreateAcShedule(TechAllo tech, ContMst con, List<AcSche> scheduleList)
        {
                        
            TechAllo saveTechnician = new TechAllo();
            saveTechnician.Id = tech.Id;
            saveTechnician.JobCardNumber = tech.JobCardNumber;
            saveTechnician.TechnicianName = tech.TechnicianName;
           // saveTechnician.acSches = scheduleList;  

            ContMst newContact = new ContMst
            {
                JobCardNumber = con.JobCardNumber,
                Id = con.Id,
                ContractNumber = con.ContractNumber,

            };

            List<AcSche> saveSchedule = new List<AcSche>();  

            foreach (var item in scheduleList)
            {
                AcSche newSchedule = new AcSche();
                newSchedule.Id = item.Id;
                newSchedule.JobCardNumber = item.JobCardNumber;
                newSchedule.ContractNumber = item.ContractNumber;
                newSchedule.ScheduleDate = item.ScheduleDate;
                
                saveSchedule.Add(newSchedule);

            }


            // sp1.executeNonQueery(saveTechnician)
            // sp1.executeNonQueery(saveTechnician)
            // sp1.executeNonQueery(saveSchedule)

            return 1;
        } 



        public int Calculate(int a, int b)
        {
            return a + b;
        }



        public double CalculateSquare(double height, double length)
        {
            double square = height * length;
            return square;

        }



   }



}
