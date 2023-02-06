using System;

namespace myProject
{
    class Fitness
    {
        private string name;
        private int age;
        private double weight;

        public Fitness()
        {
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            string ageInput = Console.ReadLine();
            while (!Int32.TryParse(ageInput, out age))
            {
                Console.WriteLine("Invalid input. Enter Age: ");
                ageInput = Console.ReadLine();
            }

            Console.WriteLine("Enter Weight: ");
            string weightInput = Console.ReadLine();
            while (!Double.TryParse(weightInput, out weight))
            {
                Console.WriteLine("Invalid input. Enter Weight: ");
                weightInput = Console.ReadLine();
            }
        }

        public Fitness(string name, int age, double weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fitness user1 = new Fitness();
            Fitness user2 = new Fitness();

            Fitness user3 = new Fitness("Tom", 25, 150.0);
            Fitness user4 = new Fitness("Jane", 30, 140.0);

            Console.WriteLine("User 1 Info: Name = {0}, Age = {1}, Weight = {2}", user1.GetName(), user1.GetAge(), user1.GetWeight());
            Console.WriteLine("User 2 Info: Name = {0}, Age = {1}, Weight = {2}", user2.GetName(), user2.GetAge(), user2.GetWeight());
            Console.WriteLine("User 3 Info: Name = {0}, Age = {1}, Weight = {2}", user3.GetName(), user3.GetAge(), user3.GetWeight());
            Console.WriteLine("User 4 Info: Name = {0}, Age = {1}, Weight = {2}", user4.GetName(), user4.GetAge(), user4.GetWeight());

            Console.ReadLine();
        }
    }
}
