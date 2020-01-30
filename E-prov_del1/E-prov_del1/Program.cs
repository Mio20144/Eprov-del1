using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov_del1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool success = false;
            string answerString;
            Superhero s1 = new Superhero();
            Console.WriteLine("Welcome to Hero Academy");
            while (success == false)
            {
                Console.WriteLine("Please choose which kind of hero you want to be");

                Console.WriteLine("1. Superstrong");
                Console.WriteLine("2. Superninja");
                Console.WriteLine("3. Supersmart");
                Console.WriteLine("Enter the number of the hero you wish to be");
                answerString = Console.ReadLine();
                if (answerString == "1")
                {
                    Console.WriteLine("You have chosen SuperStrong");
                    
                    s1 = new SuperStrong();
                    
                    Console.ReadLine();
                    success = true;
                }
                else if (answerString == "2")
                {
                    Console.WriteLine("You have chosen SuperNinja");
                    s1 = new SuperNinja();
                    Console.ReadLine();
                    success = true;
           
                }
                else if (answerString == "3")
                {
                    Console.WriteLine("you have chosen SuperSmart");
                    s1 = new SuperSmart();
                    Console.ReadLine();
                    success = true;
                }
                else
                {
                    Console.WriteLine("Try again");
                    
                }
            }
            Console.Clear();
            bool success2 = false;
            while (success2 == false)
            {
                Console.WriteLine("Please choose a name for you hero. 1 to 10 letters");
                s1.name = Console.ReadLine();
                if (s1.name.Length > 0 && s1.name.Length < 11)
                {
                    Console.WriteLine("Your name is now " + s1.name);
                    success2 = true;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
            Console.Clear();
            bool success3 = false;
            while (success3 == false)
            {
                Console.WriteLine("These are your stats");
                Console.WriteLine("Strength:" + s1.strenght);
                Console.WriteLine("Agility" + s1.agility);
                Console.WriteLine("Intelligence" + s1.intelligence);
                Console.WriteLine("Please write the name of the stat you wish to boost");
                string boost = Console.ReadLine();
                s1.statBoost = boost.ToLower();
                if (s1.statBoost == "strenght" || s1.statBoost == "agility" || s1.statBoost == "intelligence")
                {
                    success3 = true;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                
            }
            

            Console.ReadLine();


            

        }
        
        public void RaiseStats(string statBoost, int strenght, int agility, int intelligence)
        {
            
            
            if (statBoost == "strenght")
            {
                strenght += 10;
            }
            else if (statBoost == "agility")
            {
                agility += 10;

            }
            else if (statBoost == "intelligence")
            {
                intelligence += 10;
            }
        }

    }
}
