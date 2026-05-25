namespace Starbucks.Domain;

public class Coffee : BaseEntity
{
    public required string Name { get; set; }

    public string? Description { get; set;}

    public decimal Price { get; set;}

    public int CategoryId { get; set; }

    public string? Image { get; set; }
}
