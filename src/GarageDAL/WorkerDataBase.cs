
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageDAL
{
  public  class WorkerDataBase
    {
        public static void deleteWorkerByID(string id)
        {
            try
            {
                using (garage_of_carsEntities db = new garage_of_carsEntities())
                {
                    var worker = db.Workers.First(c => c.id_worker == id);
                    db.Workers.Remove(worker);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Worker getUser(string userName, string password, string include)
        {
            Worker w = new Worker();
            try
            {
                using (garage_of_carsEntities db = new garage_of_carsEntities())
                {
                    var worker = db.Workers.Include(include).First(c => c.id_worker == userName&&c.password==password);
                    w = worker;
               
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return w;
        }

        public static Worker getWorkerByID(string id, string include)
        {
            try
            {
                using (garage_of_carsEntities db = new garage_of_carsEntities())
                {
                    return db.Workers.Include(include).First(c => c.id_worker == id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Worker> getAllWorkers(string includes)
        {
            try
            {
                using (garage_of_carsEntities db = new garage_of_carsEntities())
                {
                    return db.Workers.Include(includes).ToList();
                }
            }
            catch (Exception ex )
            {
                throw ex;
            }
        }
    }
}
