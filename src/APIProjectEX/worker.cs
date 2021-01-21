using APIProjectEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
}
    
//        public static class WorkerDal
//        {
//            public static List<Workers> GatAllWorker()
//            {
//                List<Workers> workers = new List<Workers>();
//            using (var context = new Garage_of_carsEntities4())
//            {
//                var a= (from w in context.Workers
//                        select w).ToList();
//                var wo = (from w in context.Workers
//                           join e in context.Employee_Status on w.employee_code equals e.employee_status_code
//                           select w).ToList();
//                //workers = (from w in context.Workers
//                //           join e in context.Employee_Status on w.employee_code equals e.employee_status_code
//                //           select new
//                //           {
//                           //    id_worker = w.id_worker,
//                           //    first_name = w.first_name,
//                           //    last_name = w.last_name,
//                           //    tel_number = w.tel_number,
//                           //    adress = w.adress,
//                           //    num_of_credits = w.num_of_credits,
//                           //    password = w.password,
//                           //    employee_code = w.employee_code
//                           //    //  employee_Status= description_of_the_status = e.description_of_the_status,
//                           //    // employee_Status.employee_status_code = e.employee_status_code }
//                           //    //{ description_of_the_status = e.description_of_the_status, employee_status_code = e.employee_status_code } }
//                           //}).ToList();
            
//           workers.AddRange(wo);
//}
//            return workers;
//            }

//        }
//    }

