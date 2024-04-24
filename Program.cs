using System;

namespace BiologicalModel
{
   public abstract class Animal
   {
      protected string _name;
      protected int _legsCount;

      protected Animal(string name, int legsCount)
      {
         _name = name;
         _legsCount = legsCount;
      }

      public abstract void Move();

      public void Eat()
      {
         Console.WriteLine($"{_name} eats with its mouth.");
      }
   }

   public class Human : Animal
   {
      public Human(string name) : base(name, 2) { }

      public override void Move()
      {
         Console.WriteLine($"{_name} walks on two legs.");
      }
   }

   public class Monkey : Animal
   {
      public Monkey(string name) : base(name, 2) { }

      public override void Move()
      {
         Console.WriteLine($"{_name} climbs and walks on two legs.");
      }
   }

   public class Elephant : Animal
   {
      public Elephant(string name) : base(name, 4) { }

      public override void Move()
      {
         Console.WriteLine($"{_name} walks on four legs.");
      }
   }

   public class Tortoise : Animal
   {
      public Tortoise(string name) : base(name, 4) { }

      public override void Move()
      {
         Console.WriteLine($"{_name} moves slowly on four legs.");
      }
   }

   public class Lizard : Animal
   {
      public Lizard(string name) : base(name, 4) { }

      public override void Move()
      {
         Console.WriteLine($"{_name} scurries on four legs.");
      }
   }

   class Program
   {
      static void Main(string[] args)
      {
         Animal[] animals = new Animal[]
         {
                new Human("Alice"),
                new Monkey("George"),
                new Elephant("Dumbo"),
                new Tortoise("Torty"),
                new Lizard("Lizzy")
         };

         foreach (Animal animal in animals)
         {
            animal.Move();
            animal.Eat();
         }
      }
   }
}
