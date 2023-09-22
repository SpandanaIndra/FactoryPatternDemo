using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    /*  public abstract class Document
      {
          public abstract void CreatePages();
      }

      public class Resume : Document
      {
          public override void CreatePages()
          {
              Console.WriteLine("Creating resume pages...");
          }
      }
      public class Report : Document
      {
          public override void CreatePages()
          {
              Console.WriteLine("Creating report pages...");
          }
      }
      internal class Program
      {
          static void Main(string[] args)
          {
              DocumentCreator resumeCreator = new ResumeCreator();
              Document resume = resumeCreator.CreateDocument();
              resume.CreatePages();

              DocumentCreator reportCreator = new ReportCreator();
              Document report = reportCreator.CreateDocument();
              report.CreatePages();

              Console.Read();
          }
      }

      //Creating an abstract DocumentCreator class with a factory method:
      public abstract class DocumentCreator
      {
          public abstract Document CreateDocument();
      }
      public class ResumeCreator : DocumentCreator
      {
          public override Document CreateDocument()
          {
              return new Resume();
          }
      }
      public class ReportCreator : DocumentCreator
      {
          public override Document CreateDocument()
          {
              return new Report();
          }
      }
  */




    //Example 2

    // Step 1: Define the Product (interface)
    interface IProduct
    {
        void Operation();
    }

    // Step 2: Create Concrete Products
    class ConcreteProductA : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Concrete Product A");
        }
    }

    class ConcreteProductB : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Concrete Product B");
        }
    }
    class ConcreteProductC : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Concrete Product C");
        }
    }

    // Step 3: Define the Factory Interface
    interface IFactory
    {
        IProduct CreateProduct();
    }

    // Step 4: Create Concrete Factories
    class FactoryA : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }

    class FactoryB : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
    class Factoryc : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProductC();
        }
    }

    // Step 5: Client Code
    class Program
    {
        public static void Main(string[] args)
        {
            IFactory factory = new Factoryc(); // or FactoryB
            IProduct product = factory.CreateProduct();
            product.Operation(); // Output depends on the factory used

            Console.Read();
        }
    }






}
/*Finally, the client uses the product and asks it to perform its Operation.
 * Depending on the factory used, the product will either display "Concrete Product A" 
 * or "Concrete Product B."

In essence, this pattern allows us to create products (like cars or smartphones)
without worrying about how they are made, and we can switch between different factories
to get different products easily. It helps keep our code flexible and organized.*/