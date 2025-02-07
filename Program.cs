// See https://aka.ms/new-console-template for more information


using UmlToCsharp.Batiments;

Universite upjv=new Universite();
upjv.AddBatiment("F", [1,2,3,4,5,6,7]);

upjv.AddSalle("F","F102",[1,2,3,4]);
upjv.AddSalle("F", "F103", [1, 5, 6, 7]);

upjv.AddEmploye("Kevin Marchand");
upjv.Gardienner("F", "Kevin Marchand");

Console.WriteLine(upjv.ToString());


