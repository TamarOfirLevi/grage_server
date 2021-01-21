using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageModels;

namespace GarageDAL
{
    public class ConvertDataBase
    {
        public static Dictionary<string, Dictionary<int, ConvertDB>> allConvertDataBase { get; set; }
        public static void convertsDB()
        {
            allConvertDataBase = new Dictionary<string, Dictionary<int, ConvertDB>>();
            ConEmployeeStatus();
        }
        public static void clearConvert()
        {
            allConvertDataBase.Clear();
            convertsDB();
        }
        private static void ConEmployeeStatus()
        {
            try
            {
                using (garage_of_carsEntities db = new garage_of_carsEntities())
                {
                    Dictionary<int, ConvertDB> employee_status = new Dictionary<int, ConvertDB>();
                    foreach(var item in db.Employee_kind)
                    {
                        employee_status.Add(item.employee_kind_code, new ConvertDB()
                        {
                            ConvertCode = item.employee_kind_code,
                            ConvertDescription = item.description_of_the_kind
                        });
                    }
                    allConvertDataBase.Add(Consts.employeeStatus, employee_status);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
       }     
    }
}
