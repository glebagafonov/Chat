using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Chat.Web.Models;

namespace Chat.Web.Controllers
{
    public class ShowController : ApiController
    {
        private IDetail idetail = null;
        public ShowController(IDetail Idetail)

        {

            idetail = Idetail;

        }
        // GET
        [HttpGet]
        public string GetValue()
        {

            return idetail.FullName;
        }

    }
}