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
        public List<int> food = new List<int>();

        AnimalManager am = new AnimalManager();

        public NewAnimal() 
        { 
            
        }

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

        public void SetDetails(string name, int age, string species, string specNotes, int ID)
        {
            this.name = name;
            this.age = age;
            this.species = species;
            this.specNotes = specNotes;
            this.IDNumber = ID;
        }
        
        public void SetConsumption(int day1, int day2, int day3, int day4, int day5, int day6, int day7)
        {
            food.Add(day1);
            food.Add(day2);
            food.Add(day3);
            food.Add(day4);
            food.Add(day5);
            food.Add(day6);
            food.Add(day7);
        }

        public string reciept()
        {
            return $"Name: {name} \n" +
                $"Age: {age} \n" +
                $"Species: {species}\n" +
                $"ID: {IDNumber}";
        }
    

    }
}
