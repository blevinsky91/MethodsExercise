﻿namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
         
            Console.WriteLine("What is your favorite color?");

            string color = Console.ReadLine();
            
            Console.WriteLine("What is your favorite Animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Hello, my name is {name} and the coolest color is {color}. A {animal} is my favorite animal, and {band} makes the best music on the planet!");
        }
        
    }
}

