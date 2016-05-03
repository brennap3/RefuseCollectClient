using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using RefuseCollect;





namespace RefuseCollectClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:45055/";
            String guid = Guid.NewGuid().ToString();
            Console.WriteLine("This RowKey code is: "+guid);
            try
            {
                HttpClient client6 = new HttpClient();
                //http://localhost:45055/swagger
                var response2x = client6.GetAsync(baseAddress + "api/values/D8/1qw11123234529064ef").Result;

                Console.WriteLine(response2x);

                Console.WriteLine(response2x.Content.ReadAsStringAsync().Result);

                client6.Dispose();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                HttpClient client7 = new HttpClient();
                //     if (Aggtype == "Agg" && Aggquery == "CountById")
                // public int Get(String id, String Aggtype, String Aggquery)
                var response2x = client7.GetAsync(baseAddress + "api/values/D8/Agg/CountById").Result;

                Console.WriteLine(response2x);

                Console.WriteLine("The count of records in D8 is: " + response2x.Content.ReadAsStringAsync().Result);

                client7.Dispose();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                HttpClient client2 = new HttpClient();
                //string id, string pareaid, string platitude, string plongitude

                //api / values
                
                var postrefuse = new RefuseCollect.Controllers.PostRefuse() { id = "D8", pareaid = guid, platitude = "6", plongitude = "56" };
                Console.WriteLine(postrefuse.id);


                //string baseAddress2 = "http://localhost:45055/api/values/";
                
                var response2 = client2.PostAsJsonAsync("http://localhost:45055/api/values/", postrefuse).Result;
                client2.Dispose();
                Console.WriteLine(response2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                var putrefuse = new RefuseCollect.Controllers.PutRefuse() { id = "D8", pareaid = guid };
                Console.WriteLine(putrefuse.id);
                Console.WriteLine(putrefuse.pareaid);

                HttpClient client3 = new HttpClient();

                var response3 = client3.PutAsJsonAsync("http://localhost:45055/api/values", putrefuse).Result;
                client3.Dispose();
                Console.WriteLine(response3);
                client3.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                HttpClient client4 = new HttpClient();
                var response4 = client4.DeleteAsync("http://localhost:45055/api/values/"+guid).Result;
                client4.Dispose();
                Console.WriteLine(response4);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


        }
    }
}
