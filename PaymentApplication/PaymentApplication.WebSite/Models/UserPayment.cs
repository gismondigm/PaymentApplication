using System.Text.Json;
using System.Text.Json.Serialization;

namespace PaymentApplication.WebSite.Models
{
    public class UserPayment
    {
        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public override string ToString() => JsonSerializer.Serialize<UserPayment>(this);


    }
}