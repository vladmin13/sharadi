using Newtonsoft.Json;

namespace Sharadi.Model
{
    public class Category
    {
        [JsonIgnore]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Background { get; set; }

        public string Description { get; set; }

        public bool IsVisible { get; set; }

        public string Level { get; set; }

        public string Title { get; set; }
    }
}