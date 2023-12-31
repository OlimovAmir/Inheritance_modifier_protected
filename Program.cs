using Inheritance_modifier_protected;
using System;
using System.Collections.Generic;



class Program
{
    class A
    {
        public int publicFiled;
        private int privateFiled;
        protected int protectedFiled;


        public A()
        {
            Console.WriteLine(privateFiled);
            Console.WriteLine(publicFiled);
            Console.WriteLine(protectedFiled);
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine(protectedFiled = 12);
        }
    }

    

    static void Main(string[] args)
    {

        A a = new A();
        B b = new B();
        
        string filePath = "file.txt";

       
    }




    public void WriteToFile(List<Person> people ,string filePath)
    {
        try
        {
            using(StreamWriter sw = new StreamWriter(filePath))
            {
                foreach(Person person in people)
                {
                    sw.WriteLine($"{person.Id} {person.Name} {person.LastName} {person.Birthday.ToShortDateString()}");
                }
                Console.WriteLine($" {filePath}");
            }
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}