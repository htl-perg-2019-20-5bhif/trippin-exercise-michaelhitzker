using System;

namespace TrippinTool
{
    class TrippinTool
    {
        static void Main(string[] args)
        {
            UserFileReader reader = new UserFileReader();
            UserManager manager = new UserManager();

            var users = reader.ReadFileAsync("users.json").GetAwaiter().GetResult();
            manager.GoThroughUsers(users);
            Console.ReadLine();
        }
    }
}
