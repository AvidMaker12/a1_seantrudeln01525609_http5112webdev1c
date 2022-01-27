using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1_seantrudeln01525609_http5112webdev1c.Controllers
{
    public class NumberMachineController : ApiController
    {
        // <summary>
        // Create a method which has an input {id}, and applies four mathematical operations to it
        // </summary>
        // Assignment1 Questions 5   sean trudel
        // Example1: GET localhost/NumberMachine/10 should return the integer 34 (rounded from 34.5)
        // Example2: GET localhost/NumberMachine/-5 should return the integer 12
        // Example3: GET localhost/NumberMachine/30 should return the integer 64 (rounded from 64.5)
        public int Get(int id)
        {
            return ((id + 27) * 3 - 42) / 2;
        }
    }
}
