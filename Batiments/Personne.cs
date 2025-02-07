namespace UmlToCsharp.Batiments;

public class Personne
{
    public string Nom {  get; private set; }
    public Personne(string nom) { Nom = nom; }
    public override string ToString() { return Nom+"\n"; }
}