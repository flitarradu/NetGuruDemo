using System;
using Newtonsoft.Json.Linq;
using NUnit;
using NUnit.Framework;
using RestSharp;

namespace APITestingProj
{
    [TestFixture]
    public class MyFirstTest
    {
        [Test]
        public void ValidateGetBookingRequest()
        {
            var zaBookingId = "10";
            // create Client Connection
            RestClient restClient = new RestClient($"https://restful-booker.herokuapp.com/booking/{zaBookingId}");

            // Create request get data
            RestRequest restRequest = new RestRequest(Method.GET);
            restRequest = restRequest.AddHeader("Accept", "application/json") as RestRequest;

            // Execute request to server
            IRestResponse response = restClient.Execute(restRequest);

            // Extract data from response
            var responsData = response.Content;

            // Assert
            Assert.IsTrue(responsData.Contains("Sally"));


        }

        [Test]
        public void ValidatePostRequest()
        {
            // create Client Connection
            RestClient restClient = new RestClient($"https://restful-booker.herokuapp.com/auth");

            JObject objectBody = new JObject();
            objectBody.Add("username", "admin");
            objectBody.Add("password", "password123");

            var restRequest = new RestRequest(Method.POST);
            restRequest.AddParameter("application/json", objectBody, ParameterType.RequestBody);

            var response = restClient.Execute(restRequest);

            Assert.IsTrue(response.Content.Contains("token"));
            Assert.IsTrue(response.StatusCode.ToString().Contains("OK"));

        }
    }
}
