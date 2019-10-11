using System.Text.Json;
using System.Threading.Tasks;

namespace TrippinTool
{
    class UserFileReader
    {
        async public Task<User[]> ReadFileAsync(string filename)
        {
            var content = await System.IO.File.ReadAllTextAsync(filename);
            var users = JsonSerializer.Deserialize<User[]>(content);
            return users;
        }
    }
}
