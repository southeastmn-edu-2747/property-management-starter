namespace PropertyManagement.Core.Models;

public class Unit
{
    public int Id { get; set; }
    public int PropertyId { get; set; }
    public string UnitNumber { get; set; } = string.Empty;
    public int Bedrooms { get; set; }
    public decimal Bathrooms { get; set; }
    public decimal MonthlyRent { get; set; }
    public bool IsAvailable { get; set; }
}
