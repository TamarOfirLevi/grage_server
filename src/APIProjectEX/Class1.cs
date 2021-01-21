using APIProjectEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
}
 //   public static class MishapDal
 //   {
 //       public static void InsertMishap(Mishaps mishaps)
 //       {
 //           using (var context = new Garage_of_carsEntities4())
 //           {
 //               context.Mishaps.Add(mishaps);
 //               context.SaveChanges();
 //           }
 //       }


 //       public static List<Mishaps> GatAllMishaps()
 //       {
 //           List<Mishaps> mishaps = new List<Mishaps>();
 //           using (var context = new Garage_of_carsEntities4())
 //           {
 //               mishaps = (from m in context.Mishaps
 //                          join s in context.Mishap_Status on m.mishap_status_code equals s.mishap_status_code
 //                          select new Mishaps()
 //                          {
 //                              MishapsCode = m.MishapsCode,
 //                              Mishap_Status = new Mishap_Status() { description_of_the_status = s.description_of_the_status, mishap_status_code = s.mishap_status_code }
 //                              ,
 //                              mishap_description = m.mishap_description,
 //                              mishap_img = m.mishap_img,
 //                              mishap_urgency = m.mishap_urgency,
 //                              num_of_credits = m.num_of_credits
 //                              ////     MishapsCode = m.MishapsCode,
 //                              ////     mishap_description = m.mishap_description,
 //                              ////     num_of_credits = m.num_of_credits,
 //                              ////     mishap_urgency = m.mishap_urgency,
 //                              ////     Mishap_Status = new Mishap_Status() { mishap_status_code = s.mishap_status_code, description_of_the_status = s.description_of_the_status}
 //                              ////,

 //                              ////     mishap_img = m.mishap_img


 //                          }).ToList();

 //           }
 //           return mishaps;
 //       }

 //   }

 //}
 //   //public static class WorkerDal
 //   //{
 //   //    public static List<Workers> GatAllWorker()
 //   //    {
 //   //        List<Workers> workers = new List<Workers>();
 //   //        using (var context = new Garage_of_carsEntities())
 //   //        {
 //   //            workers = (from w in context.Workers
 //   //                       join e in context.Employee_Status on w.employee_code equals e.employee_status_code
 //   //                       select new Workers()
 //   //                       {
 //   //                           id_worker = w.id_worker,
 //   //                           first_name = w.first_name,
 //   //                           last_name = w.last_name,
 //   //                           tel_number = w.tel_number,
 //   //                           adress = w.adress,
 //   //                           num_of_credits = w.num_of_credits,
 //   //                           password = w.password,
 //   //                           employee_code = w.employee_code,
 //   //                           Employee_Status = new Employee_Status() { description_of_the_status = e.description_of_the_status, employee_status_code = e.employee_status_code }
 //   //                       }).ToList();
 //   //        }
 //   //        return workers;
 //   //    }

 //   //}
   

