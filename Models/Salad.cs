namespace ContosoSalad.Models;

public class Salad
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
    public string? Dressing { get; set; }
}