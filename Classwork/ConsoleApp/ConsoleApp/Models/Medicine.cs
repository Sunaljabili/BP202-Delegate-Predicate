using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.mODELS
{
    public class Medicine
    {
        private static int _id;
        public int Id { get; }
        public Medicine()
        {
            _id++;
            Id = _id;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; } = false;

        public void Sell()
        {
            if (Count>0)
            {
                Count--;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id-si {Id} , Name - {Name} , Price - {Price} , Count - {Count},");
        }

    }
}
