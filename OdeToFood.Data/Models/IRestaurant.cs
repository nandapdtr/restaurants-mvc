namespace OdeToFood.Data.Models
{
    public interface IRestaurant
    {
        int Id { get; }
        string Name { get; }
        CuisineType Cuisine { get; }

    }
}