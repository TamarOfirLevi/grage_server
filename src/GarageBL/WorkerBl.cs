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
        public static void deleteWorker(int id)
        {
            WorkerDataBase.deleteWorkerByID(id);
        }
        public static Workers getWorkerByID(int id)
        {
            var worker = WorkerDataBase.getWorkerByID(id, "Employee_Status");

            GarageModels.Workers workersDTO = new GarageModels.Workers() {
                User = new GarageModels.User()
                {
                    first_name = worker.User.first_name,
                    last_name = worker.User.last_name,
                    tel_number = worker.User.tel_number,
                    address = worker.User.address
                },
                id_worker = worker.id_worker,
                num_of_credits = worker.num_of_credits??0,
                password = worker.User.password,
                employee_code  = new GarageModels.Employee_kind()
                {
                    description_of_the_kind = worker.Employee_kind.description_of_the_kind,
                    employee_kind_code = worker.Employee_kind.employee_kind_code
                }
            };

            return workersDTO;
        }

        public static Workers GetUser(int userID, string password)
        {
            var worker = WorkerDataBase.getWorker(userID, password, "Employee_Status");

            GarageModels.Workers workersDTO = new GarageModels.Workers()
            {
                User = new GarageModels.User
                {
                    first_name = worker.User.first_name,
                    last_name = worker.User.last_name,
                    tel_number = worker.User.tel_number,
                    address = worker.User.address,
                    password = worker.User.password,
                    mail_address = worker.User.mail_address,
                    registertion_date = DateTime.Now
                },
                
                
                num_of_credits = worker.num_of_credits??0,

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
                    User = new GarageModels.User
                    {
                        first_name = worker.User.first_name,
                        last_name = worker.User.last_name,
                        tel_number = worker.User.tel_number,
                        address = worker.User.address,
                        password = worker.User.password,
                    },
                    id_worker = worker.id_worker,
                    
                    num_of_credits= worker.num_of_credits??0,
                    
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
