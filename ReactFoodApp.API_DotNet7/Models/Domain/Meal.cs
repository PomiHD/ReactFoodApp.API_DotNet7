namespace ReactFoodApp.API_DotNet7.Models.Domain
{
    public class Meal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
