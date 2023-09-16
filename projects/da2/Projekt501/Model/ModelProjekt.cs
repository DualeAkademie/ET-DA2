using Newtonsoft.Json;
using Projekt501.Daten;
using System;
using System.IO;

namespace Projekt501.Model;

public class ModelProjekt
{
    public Plz? Plz { get; set; }

    public ModelProjekt(string? pfad)
    {

        try
        {
            Plz = JsonConvert.DeserializeObject<Plz>(File.ReadAllText(pfad!));
        }
        catch (Exception e)
        {
            Console.WriteLine("Postleitzahlen:" + e);
            throw;
        }
    }
}
