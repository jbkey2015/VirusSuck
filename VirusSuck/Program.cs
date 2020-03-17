using System;
using System.Collections.Generic;

namespace VirusSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("SARS");
            names.Add("Rabies");
            names.Add("Stupidity");
            names.Insert(0, "Shebola");

            names.Remove("Stupidity");
            names.RemoveAt(3);

            var people = new List<string> { "Nathan", "Marting", "Randy's Kid"};
            names.AddRange(people);

            names.RemoveRange(names.Count - 3, 3);

            foreach (var name in names)
            {
                Console.WriteLine($"current name is {name}");
            }

            //----------------------------------------------------------------------------
            //Dictoniaries
            //----------------------------------------------------------------------------

            var symptoms = new Dictionary<string,string>();

            symptoms.Add("COVID-19", "Dry cough, fever, respiratory problems");
            symptoms.Add("Ebola", "Fever, headache, muscle pain, and chills");
            symptoms.Add("Spanish Flu", " fever, a dry cough, fatigue and difficulty breathing");
            symptoms.Add("SARS", "Fever, dry cough, headache, muscle aches, and difficulty breathing");
            symptoms.Add("Rabies", "Symptoms include fever, headache, excess salivation, muscle spasms, paralysis, and mental confusion.");

            var covidSymptoms = symptoms["COVID-19"];

            symptoms.Remove("Ebola");

            var otherDictionary = new Dictionary<string, int> { { "nathan", 33 }, { "martin", 36 } };

            foreach (var (virus, symptom) in symptoms)
            {
                Console.WriteLine($"The {virus} virus has the following symptoms: {symptom}");
            }

            foreach (var name in names)
            {
                if (symptoms.ContainsKey(name))
                {
                    Console.WriteLine($"The {name} virus has the following symptoms: {symptoms[name]}");
                }
                else
                {
                    Console.WriteLine($"The {name} virus is unknown...");
                }
            }

            //--------------------------------------------------------------------------------------------------------------------
            // Queues
            //--------------------------------------------------------------------------------------------------------------------

            var diseasesToCure = new Queue<string>();

            diseasesToCure.Enqueue("SARS");
            diseasesToCure.Enqueue("COVID-19");

            var thingToCure = diseasesToCure.Dequeue();
            var nextThingToCure = diseasesToCure.Dequeue();

            //--------------------------------------------------------------------------------------------------------------------
            // Hashset
            //--------------------------------------------------------------------------------------------------------------------

            var vectors = new HashSet<string>();

            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Droplet");
            vectors.Add("Droplet");
            vectors.Add("Droplet");
            vectors.Add("Droplet");
            vectors.Add("Bloodborne");
            vectors.Add("Bloodborne");
            vectors.Add("Bloodborne");
            vectors.Add("Bloodborne");
            vectors.Add("Bloodborne");

            var covid19 = new Virus("COVID-19", 15);
            covid19.Symptoms.Add("Fever");
            covid19.Symptoms.Add("Dry Cough");
            covid19.Symptoms.Add("Cancels everything except work");
            covid19.NumberOfDeathsWorldWide = 7158;

            var spanishFlu = new Virus("Spanish Flu", 11);
            spanishFlu.Symptoms.Add("Fever");
            spanishFlu.Symptoms.Add("Dry Cough");
            spanishFlu.NumberOfDeathsWorldWide = 50000000;

            var rabies = new Virus("Rabies", 11);
            rabies.Symptoms.Add("Fever");
            rabies.Symptoms.Add("Excess Salivation");
            rabies.NumberOfDeathsWorldWide = 200000;

            var viruses = new List<Virus> { covid19, spanishFlu, rabies };

            foreach (var virus in viruses)
            {
                Console.WriteLine($"The {virus.Name} has an incubation period of {virus.IncubationDays} and has killed {virus.NumberOfDeathsWorldWide} wombats.");
                Console.WriteLine($"It has the following symptoms: {string.Join(", ", virus.Symptoms)}");
            }

        }
    }
}
