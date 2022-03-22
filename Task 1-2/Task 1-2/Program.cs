using System;

namespace Task_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Netobook notebook1 = new Netobook();
            notebook1.Name = "Asus";
            notebook1.Brandname = "Zenbook";
            notebook1.Price = 2000;

            Netobook notebook2 = new Netobook();
            notebook2.Name = "Hp";
            notebook2.Brandname = " Gaming";
            notebook2.Price = 1500;

            Netobook notebook3 = new Netobook();
            notebook1.Name = "Samsung";
            notebook1.Brandname = "Tab";
            notebook1.Price = 2500;

            Netobook [] notebook = { notebook1, notebook2 , notebook3 };
            Netobook[] findNotebook = FindNotebook(notebook);
            foreach (var item in findNotebook)
            {
                Console.WriteLine($"Ad: {item.Name}       Model: {item.Brandname}           Qiymet: {item.Price} ");
            }
          

        }
        static Netobook[] FindNotebook(Netobook [] arr)
        {
           int  count = 0;
            double minprice = 1000;
            double maxprice = 2000;
            for (int i = 0; i < arr.Length; i++)
            {
               if(arr[i].Price < maxprice && arr[i].Price > minprice)
                {
                    count++;
                }
            }
            Netobook [] newNotebook = new Netobook[count];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Price < maxprice && arr[i].Price > minprice)
                {
                    newNotebook[j] = arr[i];
                }
            }
           
            return newNotebook;   
          

        }
    }
}
