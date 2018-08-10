using System.Collections.Generic;
using System.Linq;

namespace CSharpDemo
{
    public delegate int NumberOperator(int num, int num2); //This is a delegate, it defines a kind of function

    class Program
    {

        static void Main(string[] args)
        {
            NumberOperator numberOperator = Math.Add; // Delegates are containers for functions
            System.Console.WriteLine("Hello World!");
            var vehicles = new List<Vehicle>();
            var myVehicles = new MyList<Vehicle>();
        }
    }

    //Generics are a way for you to define classes that can be reused for different types, like in JS
    class MyList<T> {
        public T[] arr = new T[10];
    }

    // Classes 
    class Vehicle
    {
        int numOfWheels = 4;

        string SayHello(string name)
        {
            return "Hello " + name;
        }

        int NumMiles()
        {
            return Math.Add(1, 2);
        }
    }

    static class Math
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
