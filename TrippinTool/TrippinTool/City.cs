using System.Text.Json.Serialization;

namespace TrippinTool
{
    class City
    {
        [JsonPropertyName("Name")]
        public string Name { get; }

        [JsonPropertyName("CountryRegion")]
        public string CountryRegion { get; }

        [JsonPropertyName("Region")]
        public string Region { get; }

        public City(User user)
        {
            this.Name = user.CityName;
            this.CountryRegion = user.Country;
            this.Region = "ID";
        }
    }
}
