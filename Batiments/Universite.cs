using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlToCsharp.Batiments;

public class Universite
{
    public List<Batiment> Batiments { get; private set; } = [];
    public List<Personne> Employes { get; private set; } = [];

    public Personne AddEmploye(string nom)
    {
        Personne personne = new Personne(nom);
        Employes.Add(personne);
        return personne;
    }

    public void Gardienner(string nomBatiment, string nomPersonne)
    {
        Batiment b= Batiments.FirstOrDefault(b=>b.Nom.Equals(nomBatiment));
        Personne p=Employes.FirstOrDefault(e=>e.Nom.Equals(nomPersonne));
        b.Gardien = p;
    }

    public Batiment AddBatiment(string nomBatiment, int[] idMurs) 
    {
        Batiment batiment = new Batiment(nomBatiment);
        Batiments.Add(batiment);
        foreach (int id in idMurs)
        {
            batiment.AddMur(id);
        }
        return batiment;
    }
    public Batiment? AddSalle(string nomBatiment, string numero, int[] idMurs)
    {
        Batiment b = Batiments.FirstOrDefault(b=> b.Nom == nomBatiment);
        if (b == null) return null;
        b.AddSalle(numero, idMurs);
        return b;
    }

    public override string ToString()
    {
        string s = "";
        s += "**** Liste des bâtiments ****\n";
        foreach (Batiment b in Batiments) s += b.ToString();
        s += "**** Liste des employés ****\n";
        foreach (Personne personne in Employes) s += personne.ToString();
        return s;
    }
}
