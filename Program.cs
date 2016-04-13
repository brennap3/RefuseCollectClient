using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;



namespace RefuseCollectClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:45055/";
            try
            {
                HttpClient client6 = new HttpClient();

                var response2x = client6.GetAsync(baseAddress + "api/values/D8/1qw11123234529064ef").Result;

                Console.WriteLine(response2x);

                Console.WriteLine(response2x.Content.ReadAsStringAsync().Result);

                client6.Dispose();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }



        }
            }
}
