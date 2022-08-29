using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_91896_Level_2
{
    public class AnimalManager
    {
        public List<string> names = new List<string>();
        public List<NewAnimal> animals = new List<NewAnimal>();
        public List<int> consumption = new List<int>();
        private readonly float costMultiplier = (float)0.0033;

        public AnimalManager()
        {

        }
    
        //Adds an Animals details 
        public void addAnimal(NewAnimal a)
        {
            animals.Add(a);
        }

        //Allows for the correct animal to be presented when searched for 
        public List<string> SearchAnimal(string name, int age, string species, int ID, string option)
        {

            foreach (NewAnimal animal in animals)
            {
                if (option.Equals("Species"))
                {
                    if (animal.GetSpecies().Equals(species))
                    {
                        names.Add(animal.GetName());
                    }
                }
                else if (option.Equals("Age"))
                {
                    if (animal.GetAge().Equals(age))
                    {
                        names.Add(animal.GetName());
                    }
                }
                
                else if (option.Equals("ID Number"))
                {
                    if (animal.GetID().Equals(ID))
                    {
                        names.Add(animal.GetName());
                    }
                }
                else if (option.Equals("Name"))
                {
                    if (animal.GetName().Equals(name))
                    {
                        names.Add(animal.GetName());
                    }
                }   
            }
            return names;
        }

        //A complete summary of every/select animals food cunsumption on a day to day basis
        public string FoodSummary(string option, string species, int age)
        {
            string selectedOption = $"No Values Inputed";
            int sumConsumption = 0;
            List<int> dayConsumption = new List<int>() {0, 0, 0, 0, 0, 0, 0};

            foreach (NewAnimal animal in animals)
            {
                if (option.Equals("Species"))
                {
                    selectedOption = $"{species} Summary";

                    if (animal.GetSpecies().Equals(species))
                    {
                        int dayIndex = 0;
                        foreach(int day in animal.GetConsumption())
                        {
                            sumConsumption += day;
                            dayConsumption[dayIndex] += day;
                            dayIndex++;

                        }
                    }
                }
                else if (option.Equals("Age"))
                {
                    selectedOption = $"{age}-year-old Summary";

                    if (animal.GetAge().Equals(age))
                    {
                        int dayIndex = 0;
                        foreach (int day in animal.GetConsumption())
                        {
                            sumConsumption += day;
                            dayConsumption[dayIndex] += day;
                            dayIndex++;

                        }
                    }
                }
                else
                {
                    selectedOption = $"Summary of all Animals";

                    int dayIndex = 0;
                    foreach (int day in animal.GetConsumption())
                    {
                        sumConsumption += day;
                        dayConsumption[dayIndex] += day;
                        dayIndex++;

                    }
                }
            }

            return $"{selectedOption} \n" + 
                $"{dayConsumption[0]} g: Cost $ {Math.Round(dayConsumption[0] * costMultiplier * 100) / 100} \n" +
                $"{dayConsumption[1]} g: Cost $ {Math.Round(dayConsumption[1] * costMultiplier * 100) / 100} \n" +
                $"{dayConsumption[2]} g: Cost $ {Math.Round(dayConsumption[2] * costMultiplier * 100) / 100} \n" +
                $"{dayConsumption[3]} g: Cost $ {Math.Round(dayConsumption[3] * costMultiplier * 100) / 100} \n" +
                $"{dayConsumption[4]} g: Cost $ {Math.Round(dayConsumption[4] * costMultiplier * 100) / 100} \n" +
                $"{dayConsumption[5]} g: Cost $ {Math.Round(dayConsumption[5] * costMultiplier * 100) / 100} \n" +
                $"{dayConsumption[6]} g: Cost $ {Math.Round(dayConsumption[6] * costMultiplier * 100) / 100} \n" +
                $"Total: {sumConsumption} g " +
                $"Total Cost: $ {Math.Round((sumConsumption * costMultiplier * 100) / 100)}";
        }
        
        //Returns a reciept of an animals information
        public string SearchReciept(string name)
        {
            string reciept = "";
            
            foreach (NewAnimal animal in animals)
            {
                if (animal.GetName().Equals(name))
                {
                    reciept = $"Name: {animal.GetName()} \n" +
                            $"Age: {animal.GetAge()} \n" +
                            $"Species: {animal.GetSpecies()} \n" +
                            $"ID: {animal.GetID()} \n" +
                            $"Consumptions \n" +
                            $"Day 1: {animal.consumption[0]}g \n" +
                            $"Day 2: {animal.consumption[1]}g \n" +
                            $"Day 3: {animal.consumption[2]}g \n" +
                            $"Day 4: {animal.consumption[3]}g \n" +
                            $"Day 5: {animal.consumption[4]}g \n" +
                            $"Day 6: {animal.consumption[5]}g \n" +
                            $"Day 7: {animal.consumption[6]}g \n" +
                            $"Total: {animal.consumption.Sum()}g \n" +      
                            $"Special Notes: {animal.GetSpecNotes()}";
                }
            }
            return reciept;
        }

    
    }
}