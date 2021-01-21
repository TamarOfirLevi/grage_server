using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http;
using System.Web.Routing;
using ClassLibrary1;
using APIProjectEX;
using APIProjectEX.Models;
using System.Web.Mvc;
using System.Web.Http.Cors;
using GarageModels;
using GarageBL;

namespace garageMyApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [System.Web.Http.RoutePrefix("mishaps")]
    public class MishapController : ApiController
    {
        //        //protected void Application_Start()
        //        //{
        //        //    GlobalConfiguration.Configure(WebApiConfig.Register);
        //        //}
        //        [HttpGet]
        //        public HttpResponseMessage GetAllMishaps()
        //        {
        //            return Request.CreateResponse(HttpStatusCode.OK, MishapDal.GatAllMishaps());
        ////            using (Garage_of_carsEntities db = new Garage_of_carsEntities())
        ////    {
        ////                Mishaps mishaps = new Mishaps()
        ////                {
        ////                     MishapsCode =HttpClient.Equals.m;
        //// public mishap_description : string;
        //// public num_of_credits :number;
        //// public mishap_urgency :number;
        //// public mishap_status_code :number;
        ////   mishap_img :any;
        //// public mishap_status :any;

        ////                }
        ////}
        //        }
        //זה היה טוב
        [System.Web.Http.HttpPost]
        public HttpResponseMessage InsertMishap(Mishaps mishaps)
        {
            MishapBL.InsertMishap(mishaps);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        //מחיקה 
        //[HttpGet]
        //public HttpResponseMessage InsertMishap(Mishaps mishaps)
        //{
        //    MishapDal.DeleteMishap(mishaps);
        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}
        //        //}
        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("{code:int}")]
        public void DeleteMishap(int code)
        {
            MishapBL.DeleteMishap(code);
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("all")]
        public List<Mishaps> GetAllMishap()
        {
            return MishapBL.GetAllMishap();
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("queue")]
        public List<Mishaps> GetAllMishapsFromQueue()
        {
            return MishapBL.GetAllMishapsFromQueue();
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("{code:int}")]
        public Mishaps GetMishap(int code)
        {
            return MishapBL.GetMishapByCode(code);
        }
    }
}


    

