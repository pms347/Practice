using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class WebAPIExample
    {
        public void Metho()
        {
            var client = new RestClient("https://jsonmock.hackerrank.com/api/countries?name=Afghanistan");
            //client.Timeout = -1;
            var request = new RestRequest(Method.Get.ToString());
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
