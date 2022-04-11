using System;
using System.Collections.Generic;
using System.Text;
using DelegateHomework.Enums;
namespace DelegateHomework.Models
{
    public class Book
    {
        private static int _no;

        public Book()
        {
            _no++;
            No = _no;
        }

        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public TypeGenre Genre { get; set; }
        public double Price { get; set; }


    }
}
