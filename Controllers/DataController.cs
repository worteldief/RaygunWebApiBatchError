using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RaygunWebApiBatchError.Controllers
{
    public class DataController : ApiController
    {                
        public KeyValuePair<int, string> Get(int id)
        {            
            return new KeyValuePair<int, string>(id, "success");
        }
    }
}