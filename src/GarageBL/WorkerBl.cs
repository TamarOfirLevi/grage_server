using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageDAL;
using GarageModels;
using AutoMapper;
using AutoMapper.Configuration;
using Workers = GarageModels.Workers;

namespace GarageBL
{
    public class WorkerBl
    {

        public WorkerBl() {
        }
        public static void deleteWorker(string id)
        {
            WorkerDataBase.deleteWorkerByID(id);
        }
        public static Workers getWorkerByID(string id)
        {
            var worker = WorkerDataBase.getWorkerByID(id, "Employee_kind");

            GarageModels.Workers workersDTO = new GarageModels.Workers() {
                id_worker = worker.id_worker,
                first_name = worker.first_name,
                last_name = worker.last_name,
                tel_number = worker.tel_number,
                address = worker.address,
                num_of_credits = worker.num_of_credits??0,
                password = worker.password,
                employee_code  = new GarageModels.Employee_kind()
                {
                    description_of_the_kind = worker.Employee_kind.description_of_the_kind,
                    employee_kind_code = worker.Employee_kind.employee_kind_code
                }
            };

            return workersDTO;
        }

        public static Workers GetUser(string userID, string password)
        {
            var worker = WorkerDataBase.getUser(userID, password, "Employee_Status");

            GarageModels.Workers workersDTO = new GarageModels.Workers()
            {
                id_worker = worker.id_worker,
                first_name = worker.first_name,
                last_name = worker.last_name,
                tel_number = worker.tel_number,
                address = worker.address,
                num_of_credits = worker.num_of_credits??0,
                password = worker.password,

                employee_code = new GarageModels.Employee_kind()
                {
                    description_of_the_kind = worker.Employee_kind.description_of_the_kind,
                    employee_kind_code  = worker.Employee_kind.employee_kind_code
                }
            };

            return workersDTO;
        }
        public static List<GarageModels.Workers> getAllWorker()
        {
            List<GarageModels.Workers> workersDTO = new List<GarageModels.Workers>();

            //Mapper.Initialize(cfg => {
            //    cfg.CreateMap<Workers, Worker>();
            //    cfg.CreateMap<GarageDAL.Employee_Status, GarageModels.Employee_Status>();
            //});

            var workers = WorkerDataBase.getAllWorkers("Employee_Status");
            foreach (var worker in workers)
            {
                //workersDTO.Add(Mapper.Map<Worker>(worker));
                workersDTO.Add(new GarageModels.Workers() {
                    id_worker = worker.id_worker,
                    first_name = worker.first_name,
                    last_name= worker.last_name,
                    tel_number= worker.tel_number,
                    address= worker.address,
                    num_of_credits = worker.num_of_credits??0,
                    password= worker.password,
                    employee_code = new GarageModels.Employee_kind() {
                        description_of_the_kind = worker.Employee_kind.description_of_the_kind,
                        employee_kind_code = worker.Employee_kind.employee_kind_code
                    },
                   
                });
            }
            return workersDTO;
        } 
        //    public static List<Worker>getAllWorker()
        //    {
        //        List<Workers> DbWorkers = WorkerDataBase.getAllWorkers();
        //        List<Worker> Workers = new List<Worker>();
        //        foreach(var item in DbWorkers)
        //        {
        //            Worker w = new Worker()
        //            {
        //                 id_worker =item.id_worker,
        //    first_name=item.first_name, 
        //   last_name =item.last_name,
        //     tel_number=item.tel_number,
        //    adress=item.adress,
        //   num_of_credits =item.num_of_credits,
        //     password =item.password,
        //                employee_code= Employee_Status employee_code { get; set; }

        //};
        //            Workers.Add(w);
        //        }


        //    }
    }
}
