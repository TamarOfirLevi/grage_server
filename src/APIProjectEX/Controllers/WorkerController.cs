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
    [System.Web.Http.RoutePrefix("worker")]
    public class WorkerController : ApiController
    {
        ////protected void Application_Start()
        ////{
        ////    GlobalConfiguration.Configure(WebApiConfig.Register);
        ////}
        //[System.Web.Http.HttpGet]

        //public HttpResponseMessage GatAllWorker()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, WorkerDal.GatAllWorker());
        //    //return Request.CreateResponse(HttpStatusCode.Unauthorized);
        //}


        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("{id}")]
        public void  deleteWorker(string id)
        {
             WorkerBl.deleteWorker(id);
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("all")]
        public List<Workers> GatAllWorker()
        {
            return WorkerBl.getAllWorker();
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("{id}")]
        public Workers GetWorker(string id)
        {
            return WorkerBl.getWorkerByID(id);
        }
    }
}
