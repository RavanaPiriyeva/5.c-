using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    internal class Library
    {


        public Book[] Books;

        int j = 0;
        public void AddBook(Book book)
        {
            Books[j++] = book;
        }
        public Book[] GetFilteredBooksGenre(string genre)
        {
            int count = 0;
            foreach (var item in Books)
            {
                if (item.genre == genre)
                {
                    count++;
                }
            }
            Book[] newbooks = new Book[count];
            int x = 0;
            foreach (var item in Books)
            {
                if (item.genre == genre)
                {
                    newbooks[x++] = item;
                }
            }
            return newbooks;
        }
        public Book[] GelFilteredBooksPrice(double minprice, double maxprice)
        {
            int count = 0;
            foreach (var item in Books)
            {
                if (item.price > minprice && item.price < maxprice)
                {
                    count++;
                }
            }
            Book[] newbooks = new Book[count];
            int x = 0;
            foreach (var item in Books)
            {
                if (item.price > minprice && item.price < maxprice)
                {
                    newbooks[x++] = item;
                }
            }
            return newbooks;
        }
        public void getInfo(Book[] Books)
        {
            foreach (var item in Books)
            {
                Console.WriteLine($"AD: {item.name}   QIYMET: {item.price}    JANR: {item.genre}    No: {item.no}    SAY: {item.count} ");
            }
        }

    }
}

