using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;





namespace RefuseCollectClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:45055/";
            string guid = Guid.NewGuid().ToString();
            string guid2 = Guid.NewGuid().ToString();
            string guid3 = Guid.NewGuid().ToString();
            string baseAddress2 = "http://pbrefusecollect.azurewebsites.net/";
            string baseAddress3 = "http://pbrefusecollect.azurewebsites.net/api/values/";
            Console.WriteLine("This RowKey code is: " + guid);
            Console.WriteLine("This RowKey code is: " + guid2);

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
                HttpClient client7 = new HttpClient();
                //     if (Aggtype == "Agg" && Aggquery == "CountById")
                // public int Get(String id, String Aggtype, String Aggquery)
                var response2x = client7.GetAsync(baseAddress + "api/values/D8/Agg/CountByIdCollect").Result;

                Console.WriteLine(response2x);

                Console.WriteLine("The count of refuse collected in D8 is: " + response2x.Content.ReadAsStringAsync().Result);

                client7.Dispose();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                HttpClient client7 = new HttpClient();
                //     if (Aggtype == "Agg" && Aggquery == "CountById")
                //     public int Get(String id, String Aggtype, String Aggquery)
                var response2x = client7.GetAsync(baseAddress + "api/values/D8/Agg/CountByIdNotCollect").Result;

                Console.WriteLine(response2x);

                Console.WriteLine("The count of refuse not collected in D8 is: " + response2x.Content.ReadAsStringAsync().Result);

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
                HttpClient client2 = new HttpClient();
                //string id, string pareaid, string platitude, string plongitude

                //api / values

                var postrefuse = new PostRefuse() { id = "D8", pareaid = guid2, platitude = "6", plongitude = "56" };

                string postBody = JsonConvert.SerializeObject(postrefuse);
                Console.WriteLine(postBody);

                var cli = new WebClient();
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";
                var response = cli.UploadString("http://localhost:45055/api/values/", postBody);


                //string baseAddress2 = "http://localhost:45055/api/values/";

                //var response2 = client2.PostAsJsonAsync("http://localhost:45055/api/values/", postrefuse).Result;
                client2.Dispose();
                Console.WriteLine(response);
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

                var response3 = client3.PutAsJsonAsync("http://localhost:45055/api/values", putrefuse).Result; // see https://social.msdn.microsoft.com/Forums/vstudio/en-US/42de08af-9563-4ad3-ad51-e909994c78f9/webclient-put-to-webapi-method?forum=csharpgeneral
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
                var putrefuse = new PutRefuse() { id = "D8", pareaid = guid2 };
                Console.WriteLine(putrefuse.id);
                Console.WriteLine(putrefuse.pareaid);



                string putBody = JsonConvert.SerializeObject(putrefuse);
                Console.WriteLine(putBody);

                var cli = new WebClient();
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";
                var response = cli.UploadString("http://localhost:45055/api/values/", "PUT", putBody);
                Console.WriteLine(response);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                HttpClient client4 = new HttpClient();
                var response4 = client4.DeleteAsync("http://localhost:45055/api/values/" + guid).Result;
                client4.Dispose();
                Console.WriteLine(response4);

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
                // test calling the Azure website
                var response2x = client7.GetAsync(baseAddress2 + "api/values/D8/Agg/CountById").Result;

                Console.WriteLine(response2x);

                Console.WriteLine("The count of records in D8 (calling from Azure) is: " + response2x.Content.ReadAsStringAsync().Result);

                client7.Dispose();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                HttpClient client6 = new HttpClient();
                //http://localhost:45055/swagger
                var response2x = client6.GetAsync(baseAddress2 + "api/values/D8/1qw11123234529064ef").Result;

                Console.WriteLine(response2x);

                Console.WriteLine("Calling the " + response2x.Content.ReadAsStringAsync().Result);

                client6.Dispose();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                HttpClient client2 = new HttpClient();
                //
                var postrefuse = new PostRefuse() { id = "D9", pareaid = guid3, platitude = "6", plongitude = "56" };

                string postBody = JsonConvert.SerializeObject(postrefuse);
                Console.WriteLine(postBody);

                var cli = new WebClient();
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";
                var response = cli.UploadString(baseAddress3, postBody);

                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                var putrefuse = new PutRefuse() { id = "D9", pareaid = guid3 };
                Console.WriteLine(putrefuse.id);
                Console.WriteLine(putrefuse.pareaid);

                string putBody = JsonConvert.SerializeObject(putrefuse);
                Console.WriteLine(putBody);

                var cli = new WebClient();
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";
                var response = cli.UploadString(baseAddress3, "PUT", putBody); // see https://social.msdn.microsoft.com/Forums/vstudio/en-US/42de08af-9563-4ad3-ad51-e909994c78f9/webclient-put-to-webapi-method?forum=csharpgeneral
                Console.WriteLine("put request to azure webservice: " + response);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }




    internal class PutRefuse
    {
        public PutRefuse()
        {
        }

        public string id { get; set; }
        public string pareaid { get; set; }
    }

    internal class PostRefuse
    {
        public string id { get; set; }
        public string pareaid { get; set; }

        public string platitude { get; set; }

        public string plongitude { get; set; }
    }
}