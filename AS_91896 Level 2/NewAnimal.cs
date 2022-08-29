using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_91896_Level_2
{
    public class NewAnimal
    {

        //Global Variables
        public string name;
        public int age;
        public string species;
        public string specNotes;
        public int IDNumber;
        public List<int> consumption = new List<int>();

        AnimalManager am = new AnimalManager();

        public NewAnimal() 
        { 
            
        }

        //All of the Getter methods that allow information to be called from within a list
        public string GetName()
        {
            return name;
        }
        public string GetSpecies()
        {
            return species;
        }
        public int GetAge()
        {
            return age;
        }
        public int GetID()
        {                                                                 
            return IDNumber;
        }
        public string GetSpecNotes()
        {
            return specNotes;
        }
        public List<int> GetConsumption()
        {
            return consumption;
        }

        //Method that sets the correct details for corresponding animal
        public void SetDetails(string name, int age, string species, string specNotes, int ID)
        {
            this.name = name;
            this.age = age;
            this.species = species;
            this.specNotes = specNotes;
            this.IDNumber = ID;
        }
        
        //Method that sets the correct consumptions for corresponding animal
        public void SetConsumption(List<int> consumption)
        {
            this.consumption = consumption;
        }

        //Method that creates a receipt for the animal
        public string receipt()
        {
            return $"Name: {name} \n" +
                $"Age: {age} \n" +
                $"Species: {species}\n" +
                $"ID: {IDNumber}";
        }
    

    }
}
