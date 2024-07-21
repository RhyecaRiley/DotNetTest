using ContosoSalad.Models;

namespace ContosoSalad.Services;

public static class SaladService
{
    static List<Salad> Salads { get; }
    static int nextId = 3;
    static SaladService()
    {
        Salads = new List<Salad>
        {
            new Salad { Id = 1, Name = "Classic Italian", Dressing = "Italian", IsGlutenFree = true },
            new Salad { Id = 2, Name = "Cobb", Dressing = "Ranch", IsGlutenFree = true },
            new Salad { Id = 3, Name = "Ham and Cheese", Dressing = "Thousand Island", IsGlutenFree = true },
            new Salad { Id = 4, Name = "Turkey and Cheese", Dressing = "Balsamic vinaigrette", IsGlutenFree = true },
        };
    }

    public static List<Salad> GetAll() => Salads;

    public static Salad? Get(int id) => Salads.FirstOrDefault(p => p.Id == id);

    public static void Add(Salad salad)
    {
        salad.Id = nextId++;
        Salads.Add(salad);
    }

    public static void Delete(int id)
    {
        var salad = Get(id);
        if(salad is null)
            return;

        Salads.Remove(salad);
    }

    public static void Update(Salad salad)
    {
        var index = Salads.FindIndex(p => p.Id == salad.Id);
        if(index == -1)
            return;

        Salads[index] = salad;
    }
}