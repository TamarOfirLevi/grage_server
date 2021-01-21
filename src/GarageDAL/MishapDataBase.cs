using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GarageDAL
{
    public class MishapDataBase
    {
        //public static List<Mishaps>
        public static class MishapDal
        {
            public static Mishap InsertMishap(Mishap mishap)
            {
                try
                {
                    using (var context = new garage_of_carsEntities())
                    {
                        context.Mishaps.Add(mishap);
                        context.SaveChanges();
                        return mishap;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            //public static string DeleteMishap(int mishapId)
            //{
            //    try
            //    {
            //        using (var contex = new Garage_of_carsEntities())
            //        {
            //            contex.Mishaps.Remove(contex.Mishaps.Find(mishapId));
            //            contex.SaveChanges();
            //        }
            //        return ("ok");
            //    }
            //    catch (Exception ex)
            //    {

            //        throw ex;
            //    }
            //}
            public static void DeleteMishapByCode(int code)
            {
                try
                {
                    using (garage_of_carsEntities db = new garage_of_carsEntities())
                    {
                        var mishap = db.Mishaps.First(c => c.mishap_code == code);
                        db.Mishaps.Remove(mishap);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }



            public static Mishap GetMishapByCode(int code, string include)
            {
                try
                {
                    using (garage_of_carsEntities db = new garage_of_carsEntities())
                    {
                        return db.Mishaps.Include(include).First(c => c.mishap_code == code);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public static List<Mishap> GetAllMishap<TKey>(string includes, Expression<Func<Mishap, TKey>> order)
            {
                try
                {
                    using (garage_of_carsEntities db = new garage_of_carsEntities())
                    {
                        return db.Mishaps.Include(includes).OrderByDescending(order).ToList();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
