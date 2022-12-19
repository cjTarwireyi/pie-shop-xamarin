

using System.Text.Json.Serialization;

namespace PieShopMobile.API.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        [JsonIgnore]
        public List<Pie> Pies { get; set; }
    }
}
