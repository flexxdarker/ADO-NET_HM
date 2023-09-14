using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM14._08._2023
{
    public class HM
    {
        LibraryDB library = new LibraryDB();

        public void firstTask(int pages)
        {
            var a = library.Books.Where(x => x.Pages > pages);
            foreach (var i in a) Console.WriteLine(i.Name);
        }

        public void secondTask(char a)
        {
            var b = library.Books.Where(x => x.Name.StartsWith(a.ToString().ToLower()) || x.Name.StartsWith(a.ToString().ToUpper()));
            foreach (var i in b) Console.WriteLine(i.Name);
        }

        public void thirdTask(string name, string surname)
        {
            var a = library.Books.Where(x => x.Author.Name == name && x.Author.Surname == surname);
            foreach (var i in a) Console.WriteLine(i.Name);
        }

        public void fourhTask(string country)
        {
            var a = library.Authors.Where(x => x.Country.Name == country);
            foreach (var i in a) Console.WriteLine(i.Name + " " + i.Surname);
        }

        public void fifthTask(int count)
        {
            var a = library.Books.Where(x => x.Name.Length < count);
            foreach (var i in a) Console.WriteLine(i.Name + " " + i.Name.Length);
        }

        public void sixthTask(string country)
        {
            var a = library.Books.Where(x => x.Author.Country.Name == country).OrderByDescending(x => x.Pages);
            foreach (var i in a) Console.WriteLine(i.Name + " " + i.Pages);
        }

        public void seventhTask(string country)
        {
            var a = library.Authors.Where(x => x.Country.Name == country).OrderByDescending(x => x.Books.Count);
            foreach (var i in a) Console.WriteLine(i.Name + " " + i.Books.Count);
        }

        public void eightTask()
        {
            var a = library.Countries.OrderByDescending(x => x.Authors.Count);
            foreach (var i in a) Console.WriteLine(i.Name + " " + i.Authors.Count);
        }
    }
}
