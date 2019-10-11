using System.Text.Json.Serialization;

namespace TrippinTool
{
    class AddressInfo
    {
        [JsonPropertyName("Address")]
        public string Address { get; }

        [JsonPropertyName("City")]
        public City City { get; }

        public AddressInfo(User user)
        {
            this.Address = user.Address;
            this.City = new City(user);
        }
    }
}
