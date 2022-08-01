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
        public List<int> Day1Food = new List<int>();
        public List<int> Day2Food = new List<int>();
        public List<int> Day3Food = new List<int>();
        public List<int> Day4Food = new List<int>();
        public List<int> Day5Food = new List<int>();
        public List<int> Day6Food = new List<int>();
        public List<int> Day7Food = new List<int>();

        public AnimalManager()
        {

        }
    
        public void addAnimal(NewAnimal a)
        {
            animals.Add(a);
        }

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

        public string FoodSummary(string option, string species, int age)
        {
            string selectedOption = $"No Values Inputed";

            foreach (NewAnimal animal in animals)
            {
                if (option.Equals("Species"))
                {
                    selectedOption = $"{species} Summary";

                    if (animal.GetSpecies().Equals(species))
                    {
                        Day1Food.Add(animal.GetDay1());
                        Day2Food.Add(animal.GetDay2());
                        Day3Food.Add(animal.GetDay3());
                        Day4Food.Add(animal.GetDay4());
                        Day5Food.Add(animal.GetDay5());
                        Day6Food.Add(animal.GetDay6());
                        Day7Food.Add(animal.GetDay7());

                    }
                }
                else if (option.Equals("Age"))
                {
                    selectedOption = $"{age}-year-old Summary";

                    if (animal.GetAge().Equals(age))
                    {
                        Day1Food.Add(animal.GetDay1());
                        Day2Food.Add(animal.GetDay2());
                        Day3Food.Add(animal.GetDay3());
                        Day4Food.Add(animal.GetDay4());
                        Day5Food.Add(animal.GetDay5());
                        Day6Food.Add(animal.GetDay6());
                        Day7Food.Add(animal.GetDay7());
                    }
                }
                else
                {
                    selectedOption = $"Summary of all Animals";

                    Day1Food.Add(animal.GetDay1());
                    Day2Food.Add(animal.GetDay2());
                    Day3Food.Add(animal.GetDay3());
                    Day4Food.Add(animal.GetDay4());
                    Day5Food.Add(animal.GetDay5());
                    Day6Food.Add(animal.GetDay6());
                    Day7Food.Add(animal.GetDay7());
                }
            }

            return $"{selectedOption} \n" + 
                $"{Day1Food.Sum()} g: Cost $ {Math.Round(Day1Food.Sum() * 1.00265 * 100) / 100} \n" +
                $"{Day2Food.Sum()} g: Cost $ {Math.Round(Day2Food.Sum() * 1.00265 * 100) / 100} \n" +
                $"{Day3Food.Sum()} g: Cost $ {Math.Round(Day3Food.Sum() * 1.00265 * 100) / 100} \n" +
                $"{Day4Food.Sum()} g: Cost $ {Math.Round(Day4Food.Sum() * 1.00265 * 100) / 100} \n" +
                $"{Day5Food.Sum()} g: Cost $ {Math.Round(Day5Food.Sum() * 1.00265 * 100) / 100} \n" +
                $"{Day6Food.Sum()} g: Cost $ {Math.Round(Day6Food.Sum() * 1.00265 * 100) / 100} \n" +
                $"{Day7Food.Sum()} g: Cost $ {Math.Round(Day7Food.Sum() * 1.00265 * 100) / 100} \n" +
                $"Total: {totalCalc(Day1Food.Sum(), Day2Food.Sum(), Day3Food.Sum(), Day4Food.Sum(), Day5Food.Sum(), Day6Food.Sum(), Day7Food.Sum())} g " +
                $"Total Cost: $ {Math.Round(totalCalc(Day1Food.Sum(), Day2Food.Sum(), Day3Food.Sum(), Day4Food.Sum(), Day5Food.Sum(), Day6Food.Sum(), Day7Food.Sum()) * 1.00265 * 100) / 100}";
                
        }
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
                            $"ID: {animal.GetID()}";
                }
            }
            return reciept;
        }
        private int totalCalc(int day1, int day2, int day3, int day4, int day5, int day6, int day7)
        {
            return day1 + day2 + day3 + day4 + day5 + day6 + day7;
        }
    
    }
}