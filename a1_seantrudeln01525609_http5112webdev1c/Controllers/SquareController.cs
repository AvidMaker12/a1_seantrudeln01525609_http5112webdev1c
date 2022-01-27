using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1_seantrudeln01525609_http5112webdev1c.Controllers
{
    public class SquareController : ApiController
    {
        // <summary>
        // Returns the square of the integer input {id}
        // </summary>
        // Assignment1 Question 2   sean trudel
        // Example1: GET localhost/Square/2 should return 4
        // Example2: GET localhost/Square/-2 should return 4
        // Example3: GET localhost/Square/10 should return 100
        public int Get(int id)
        {
            return id * id;
        }
    }
}
