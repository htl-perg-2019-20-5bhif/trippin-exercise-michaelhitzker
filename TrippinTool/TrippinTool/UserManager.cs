using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace TrippinTool
{
    class UserManager
    {
        private static HttpClient HttpClient
           = new HttpClient() { BaseAddress = new Uri("https://services.odata.org/TripPinRESTierService/(S(c1zfiq4epxxussyc4gvfjobo))/") };

        public async void GoThroughUsers(User[] users)
        {
            foreach (var user in users)
            {
                var result = await HttpClient.GetAsync("People('" + user.Username + "')");
                try
                {

                    result.EnsureSuccessStatusCode();
                    Console.WriteLine("User '" + user.Username + "' already exists");
                }
                catch (Exception ex)
                {
                    AddUser(user);
                }
            }
            Console.WriteLine("\nFinished");
        }

        private async void AddUser(User user)
        {
            TrippinUser trippinUser = new TrippinUser(user);
            var content = new StringContent(JsonSerializer.Serialize(trippinUser), Encoding.UTF8, "application/json");
            var result = await HttpClient.PostAsync("People", content);
            result.EnsureSuccessStatusCode();
            Console.WriteLine("Added user " + user.Username);

        }
    }
}
