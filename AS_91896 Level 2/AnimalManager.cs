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

        public AnimalManager()
        {

        }
    
        public void addAnimal(NewAnimal a)
        {
            animals.Add(a);
        }

        public List<string> SearchAnimal(string name, int age, string species, int ID)
        {

            foreach (NewAnimal animal in animals)
            {

                if (animal.GetSpecies().Equals(species))
                {
                    names.Add(animal.GetName());
                }
                else if (animal.GetAge().Equals(age))
                {
                    names.Add(animal.GetName());
                }
                else if (animal.GetID().Equals(ID))
                {
                    names.Add(animal.GetName());
                }
                else if (animal.GetName().Equals(name))
                {
                    names.Add(animal.GetName());
                }     
            }
            return names;
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
    }
}