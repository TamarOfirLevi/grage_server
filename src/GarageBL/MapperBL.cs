using AutoMapper;
using GarageDAL;
using GarageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers = GarageModels.Workers;

namespace GarageBL
{
    public class MapperBL
    {


       public static MapperConfiguration GetConfig()
        {
            return new MapperConfiguration(cfg => {
                cfg.CreateMap<Workers, Workers>();
                cfg.CreateMap<GarageDAL.Employee_kind, GarageModels.Employee_kind>();
            });
        }

        public static MapperConfiguration GetConfigMishap()
        {
            return new MapperConfiguration(cfgm =>
            {
                cfgm.CreateMap<GarageDAL.Mishap, GarageModels.Mishaps>();
                cfgm.CreateMap<GarageDAL.Mishap_status, GarageModels.Mishap_status>();
            });
        }
    }
}
