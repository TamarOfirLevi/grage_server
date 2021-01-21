using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using ClassLibrary1;
using APIProjectEX;
using APIProjectEX.Models;
using System.Web.Mvc;
using System.Web.Http;
using GarageModels;
using GarageBL;
using System.Web.Http.Cors;


namespace APIProjectEX.Controllers
{

   
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [System.Web.Http.RoutePrefix("worker")]
    public class LoginController : ApiController
       
    {
 [System.Web.Http.HttpGet]
        //[System.Web.Http.Route("{id}"),("{password}")]
        //[EnableCors(origins: "http://localhost:4200/", headers: "*", methods: "*")]
        public HttpResponseMessage Login(string userID , string password)
        {

         var res=   WorkerBl.GetUser(userID, password);

            return Request.CreateResponse(HttpStatusCode.OK, res);

      }
    }
}
