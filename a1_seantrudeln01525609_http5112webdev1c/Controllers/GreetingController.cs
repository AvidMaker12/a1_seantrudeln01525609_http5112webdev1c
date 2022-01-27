using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1_seantrudeln01525609_http5112webdev1c.Controllers
{
    public class GreetingController : ApiController
    {
        // <summary>
        // Returns the string "Hello World!"
        // </summary>
        // Assignment1 Questions 3   sean trudel
        // Example1: GET localhost/Greeting should return string "Hello World!"
        public string Get()
        {
            return "Hello World!";
        }

        // <summary>
        // Returns the string "Greetings to {id} people!" where id is an integer value.
        // </summary>
        // Assignment1 Question 4
        // Example1: GET localhost/Greeting/3 should return string "Greetings to 3 people!"
        // Example2: GET localhost/Greeting/6 should return string "Greetings to 6 people!"
        // Example3: GET localhost/Greeting/0 should return string "Greetings to 0 people!"
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
