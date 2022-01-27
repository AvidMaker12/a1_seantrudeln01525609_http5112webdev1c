using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1_seantrudeln01525609_http5112webdev1c.Controllers
{
    public class ExampleController : ApiController
    {
        // Here we can define the requests and responses!
        /*
         * multi-line comment
         */

        // GET api/example is implying an HTTP request to the following address: localhost:xxxx/api/example
            // run api from "example" controller
            // under Solution Explorer/App_Start/WebApiConfig.cs it shows the HTTP request map
            // for now this lesson is to send server inputs and get server outputs. Later learn to get HTML webpage from server
        // we want to print the message of hello when a GET request is sent to our server
        
        public string Get()
        {

            return "Hello Class!";
        }

        // GET api/example/50 -> 200
        // GET api/example/100 -> 400
        public string Get(int id)   //add (int id) because can't have 2 of the same GET functions with the same name. (int id) adds unique ID to this GET. Refer to "C# Terminology" doc
        {
            string message = "Hello CLass!";    //just like JavaScript var message = "string"; except in C# var must be type specific so that code doesn't need to guess type
            return message;
        }

    }
}
