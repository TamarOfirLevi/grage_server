﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageModels
{
    public class User
    {

        public string id_user { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string tel_number { get; set; }
        public string address { get; set; }
        public System.DateTime registertion_date { get; set; }
        public string mail_address { get; set; }
        public string password { get; set; }
    }
}