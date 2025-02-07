namespace UmlToCsharp.Batiments;

public class Mur
{
    public int Id { get; private set; }
    public Mur(int id)
    {
        Id=id;
    }

    public override string ToString()
    {
        return Id.ToString();
    }  
}