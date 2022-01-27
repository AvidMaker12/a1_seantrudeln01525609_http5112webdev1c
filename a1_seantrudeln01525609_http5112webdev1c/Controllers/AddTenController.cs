using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1_seantrudeln01525609_http5112webdev1c.Controllers
{
    public class AddTenController : ApiController
    {
        // <summary>
        // Returns 10 more than the integer input {id}
        // </summary>
        // Assignment1 Question 1   sean trudel
        // Example1: GET localhost/AddTen/21 should return 31
        // Example2: GET localhost/AddTen/0 should return 10
        // Example3: GET localhost/AddTen/-9 should return 1
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
