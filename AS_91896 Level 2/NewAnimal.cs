using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_91896_Level_2
{
    


    class NewAnimal
    {
        public int day1Food;
        public int day2Food;
        public int day3Food;
        public int day4Food;
        public int day5Food;
        public int day6Food;
        public int day7Food;
        public string name;
        public string species;


        public NewAnimal()
        {
        
        }

        public int test = 9;

        


        public void Day1(int day1Food)
        {
                this.day1Food = day1Food;
        }
        
        public void Day2(int day2Food)
        {
            this.day2Food = day2Food;
        }
        
        public void Day3(int day3Food)
        {
            this.day3Food = day3Food;
        }
        
        public void Day4(int day4Food)
        {
            this.day4Food = day4Food;
        }
        
        public void Day5(int day5Food)
        {
            this.day5Food = day5Food;
        }
        
        public void Day6(int day6Food)
        {
            this.day6Food = day6Food;
        }
        
        public void Day7(int day7Food)
        {
            this.day7Food = day7Food;
        }
    
        public void getName(string name)
        {
            this.name = name;
        }

        public void getSpecies(string species)
        {
            this.species = species;
        }

        public string recieptGen()
        {
            return $"Name: {name} \n" +
                $"Species: {species} \n" +
                $"----Food Consumption---- \n" +
                $"Day 1: {day1Food}kg \n" +
                $"Day 2: {day2Food}kg \n" +
                $"Day 3: {day3Food}kg \n" +
                $"Day 4: {day4Food}kg \n" +
                $"Day 5: {day5Food}kg \n" +
                $"Day 6: {day6Food}kg \n" +
                $"Day 7: {day7Food}kg \n" +
                $"Weekly Cost of Food: $ {foodCost()}";

            
        }
    
        public float foodCost()
        {
            return (((day1Food + day2Food + day3Food + day4Food + day5Food + day6Food + day7Food) / 1000) * 2);
        }
    
    }
}
