using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<int> Orders;
        /* another way of intializing without constructor */
        /* adding readonly makes it immutable and able to modify directly by using Customer.Orders.Add(...rest) */
        //public readonly List<int> Orders = new List<int>();

        // Constructor Overloading(using Multiple Constructors)
        /*  public Customer()
          {
              Orders = new List<int>();
          }

          public Customer(int Id)
          {
              this.Id = Id;
          }
          public Customer(string Name) : this(Id)
          {
              this.Name = Name;
          }
          // In the above constructors the Orders will be initialized first then Id, Then Customer, This is not reliable and causes confusion, So its avoided.
        */
        // Without Constructor Overloading
        public Customer(int Id, string Name, List<int> Orders)
        {
            this.Id = Id;
            this.Orders = Orders;
            this.Name = Name;
        }

        /* avoiding method overloading by using the param keyword, This allows the value to be consecutively without being passed as an array or list param,
          also avoids multiple methods to be declared */
        public static void AddSkills(params string[] skills)
        {
            foreach (var skill in skills)
                Console.WriteLine(skill);
            var CusSkill = skills;
            Console.WriteLine(CusSkill[0]);
        }

        public void AddSkillToUser()
        {
            //overloading is prevented now
            AddSkills("t", "t1", "t2");
            AddSkills(new string[] { "t3", "t4", "t5" });
        }
    }

}
