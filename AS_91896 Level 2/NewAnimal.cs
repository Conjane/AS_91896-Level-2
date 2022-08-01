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
        public int day1;
        public int day2;
        public int day3;
        public int day4;
        public int day5;
        public int day6;
        public int day7;

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
        
        public int GetDay1()
        {
            return day1;
        }
        public int GetDay2()
        {
            return day2;
        }
        public int GetDay3()
        {
            return day3;
        }
        public int GetDay4()
        {
            return day4;
        }
        public int GetDay5()
        {
            return day5;
        }
        public int GetDay6()
        {
            return day6;
        }
        public int GetDay7()
        {
            return day7;
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
            this.day1 = day1;
            this.day2 = day2;
            this.day3 = day3;
            this.day4 = day4;
            this.day5 = day5;
            this.day6 = day6;
            this.day7 = day7;
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
