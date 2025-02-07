
namespace UmlToCsharp.Batiments;

public class Salle
{
    public string Numero { get; private set; }
    public List<Mur> Murs{ get; private set; }

    public Salle(string numero, List<Mur> murs)
    {
        Numero = numero;
        Murs = murs;
    }

    public override string ToString()
    {
        string s = Numero;
        s += " a pour murs : ";
        foreach (Mur mur in Murs)
        {
            s +=mur.ToString()+" - ";
        }
        return s;
    }
}