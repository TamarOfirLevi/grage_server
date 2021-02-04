using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageModels
{
   public class Mishaps
    {
        public int mishap_code { get; set; }
        public Cars car_number { get; set; }
        public string mishap_description { get; set; }
        public int num_of_credits { get; set; }
        public int mishap_urgency { get; set; }
        public Mishap_status Mishap_status { get; set; }
        //public      mishap_img :any;

        public float mishap_price { get; set; }
    }
}
