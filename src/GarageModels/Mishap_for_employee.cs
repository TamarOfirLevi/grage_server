using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageModels
{
    public class Mishap_for_employee
    {
        public int code { get; set; }
        public Mishaps MishapsCode { get; set; }
        public Workers worker_id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }    

    }
}
