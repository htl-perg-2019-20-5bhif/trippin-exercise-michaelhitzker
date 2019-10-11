using System.Text.Json.Serialization;

namespace TrippinTool
{
    class TrippinUser
    {
        [JsonPropertyName("UserName")]
        public string Username { get; }

        [JsonPropertyName("FirstName")]
        public string Firstname { get; }

        [JsonPropertyName("LastName")]
        public string Lastname { get; }

        [JsonPropertyName("Emails")]
        public string[] Emails { get; }

        [JsonPropertyName("AddressInfo")]
        public AddressInfo[] AddressInfo { get; }


        public TrippinUser(User user)
        {
            this.Username = user.Username;
            this.Firstname = user.FirstName;
            this.Lastname = user.LastName;
            this.Emails = new string[] { user.Email };
            AddressInfo addressInfo = new AddressInfo(user);
            this.AddressInfo = new AddressInfo[] { addressInfo };
        }
    }
}
