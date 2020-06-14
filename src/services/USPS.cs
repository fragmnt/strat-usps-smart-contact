using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace USPSClient {

    public class Package {
        public string TrackingNumber {get; set;}
        public string ActualDeliveryDate {get; set;}
        public string EstimatedDeliveryDate {get; set;}
    }

    public class Address {
        public string streetName {get; set;}
        public string stateName {get; set;}
    }
    class Api {

        static HttpClient client = HttpClient();
        private const string uspsBase = "https://secure.shippingapis.com";
        private const string mthv = "application/json";

        // endpoints
        
        private const string shippingApiEndpoint = "/shippingapi.dll?API=Verify&XML=";

        static async Task<Address> GetAnAddress(string path) {
            
        }

        static async Task Fetch(string[] baseUrl, string[] headerType) {

            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(headerType));

            try {

            } catch (Exception err) {
                Console.WriteLine(err.Message);
            }

            Console.ReadLine("/");
        }

        static void Main() {
            Fetch(uspsBase, mthv).GetAwaiter().GetResult();
        }
    }
}