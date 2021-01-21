using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageDAL;
using GarageModels;
using AutoMapper;
using AutoMapper.Configuration;

namespace GarageBL
{
    public class MishapBL
    {
        public MishapBL()
        {
        }
        public static bool InsertMishap(Mishaps mishaps)
        {
            var mishapsDAL = new GarageDAL.Mishap()
            {
                car_number = mishaps.car_number,
                mishap_description = mishaps.mishap_description,
                num_of_credits = mishaps.num_of_credits,
                mishap_urgency = mishaps.mishap_urgency,
                mishap_status_code = mishaps.Mishap_status.mishap_status_code,
                mishap_price= mishaps.mishap_price
            };

            //Mapper.Initialize(cfg => {
            //    cfg.CreateMap<Workers, Worker>();
            //    cfg.CreateMap<GarageDAL.Employee_Status, GarageModels.Employee_Status>();
            //});


            var mishap = MishapDataBase.MishapDal.InsertMishap(mishapsDAL);

            return true;
        }
        public static void DeleteMishap(int code)
        {
            MishapDataBase.MishapDal.DeleteMishapByCode(code);
        }
        public static Mishaps GetMishapByCode(int code)
        {
            var mishap = MishapDataBase.MishapDal.GetMishapByCode(code, "Mishap_status");

            Mishaps mishapsesDto = new Mishaps()
            {
                mishap_code = mishap.mishap_code,
                mishap_description = mishap.mishap_description,
                num_of_credits = mishap.num_of_credits,
                mishap_urgency = mishap.mishap_urgency,
                Mishap_status = new GarageModels.Mishap_status
                {
                    description_of_the_status = mishap.Mishap_status.description_of_the_status,
                    mishap_status_code = mishap.Mishap_status.mishap_status_code
                }
            };

            return mishapsesDto;
        }

        public static List<Mishaps> GetAllMishapsFromQueue() {
            List<Mishaps> mishapsDTO = new List<Mishaps>();

            var mishapsUrgency = MishapQueue.QueueUrgency;
            var mishapsPrice = MishapQueue.QueuePrice;

            var finalList = new List<QueueItem>();
            foreach (var mishap in mishapsUrgency)
            {
                var priceItem = mishapsPrice.First(c => c.mishap.mishap_code == mishap.mishap.mishap_code);
                finalList.Add(new QueueItem() {
                    mishap = mishap.mishap,
                    priority = mishap.priority + priceItem.priority
                });
            }

            var orderedList = new List<Mishap>();
            orderedList.AddRange(finalList.OrderByDescending(c => c.priority).Select(d => d.mishap).ToList());

            foreach (var mishap in orderedList)
            {
                //workersDTO.Add(Mapper.Map<Worker>(worker));
                mishapsDTO.Add(new Mishaps()
                {
                    mishap_code = mishap.mishap_code,
                    mishap_description = mishap.mishap_description,
                    num_of_credits = mishap.num_of_credits,
                    mishap_urgency = mishap.mishap_urgency,
                    Mishap_status = new GarageModels.Mishap_status()
                    {
                        description_of_the_status = mishap.Mishap_status.description_of_the_status,
                        mishap_status_code = mishap.Mishap_status.mishap_status_code
                    },

                });
            }
            return mishapsDTO;
        }
        public static List<Mishaps> GetAllMishap()
        {
            List<Mishaps> mishapsDTO = new List<Mishaps>();

            //Mapper.Initialize(cfg => {
            //    cfg.CreateMap<Workers, Worker>();
            //    cfg.CreateMap<GarageDAL.Employee_Status, GarageModels.Employee_Status>();
            //});

            var mishaps = MishapDataBase.MishapDal.GetAllMishap("Mishap_Status", c => c.mishap_urgency);
            foreach (var mishap in mishaps)
            {
                //workersDTO.Add(Mapper.Map<Worker>(worker));
                mishapsDTO.Add(new Mishaps()
                {
                    mishap_code = mishap.mishap_code,
                    mishap_description = mishap.mishap_description,
                    num_of_credits = mishap.num_of_credits,
                    mishap_urgency = mishap.mishap_urgency,
                    Mishap_status = new GarageModels.Mishap_status()
                    {
                        description_of_the_status = mishap.Mishap_status.description_of_the_status,
                        mishap_status_code = mishap.Mishap_status.mishap_status_code
                    },

                });
            }
            return mishapsDTO;
        }


    }

}
//public static List<Mishaps> InsertMishap()
//{
//    List<Mishaps> mishapsesDto = new List<Mishaps>();

//    //Mapper.Initialize(cfg => {
//    //    cfg.CreateMap<Workers, Worker>();
//    //    cfg.CreateMap<GarageDAL.Employee_Status, GarageModels.Employee_Status>();
//    //});

//    var mishaps = MishapDataBase.MishapDal.InsertMishap("Mishap_Status");
//    foreach (var mishaps in mishaps)
//    {
//        //workersDTO.Add(Mapper.Map<Worker>(worker));
//        mishapsesDto.Insert(new Mishaps()
//        {
//            MishapsCode = mishaps.
//            id_worker = worker.id_worker,
//            Mishap_Status = new GarageModels.Mishap_Status()
//            {
//                description_of_the_status = mishaps.Mishap_Status.,
//                employee_status_code = worker.Employee_Status.employee_status_code
//            },
//            first_name = worker.first_name
//        });
//    }
//    return mishapsesDto;
//}





