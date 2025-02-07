namespace UmlToCsharp.Batiments;

public class Batiment
{
    public string Nom {  get; set; }
    public List<Mur> Murs { get; private set; } = [];
    public List<Salle> Salles { get; private set; } = [];
    public Personne Gardien { get; set; }

    public Batiment(string nom) { this.Nom = nom; }
    
    public Mur AddMur(int id)
    {
        Mur m = new Mur(id);
        Murs.Add(m);
        return m;
    }

    public Mur? FindMur(int id)
    {
        return Murs.FirstOrDefault(x => x.Id == id);
    }
   
    public Salle AddSalle(string nomSalle, int [] murs)
    {
        List<Mur> m = [];
        foreach (int idMur in murs)
        {
            m.Add(FindMur(idMur));
        }
        Salle s = new Salle(nomSalle, m);
        Salles.Add(s);
        return s;
    }
    
    public override string ToString()
    {
        string s="********** Bâtiment "+Nom+"********\n";
        s += "Les salles \n";
        foreach (Salle p in Salles)
        {
            s+=$"{p}\n";
        }
        s += "Le gardien est : " + Gardien.ToString();
        return s;
    }
}