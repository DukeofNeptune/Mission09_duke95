﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission09_duke95.Models;

namespace Mission09_duke95.Models
{
    public class Basket
    {
        //Add basket and Calculate total function
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();
        public void AddItem(Book book, int qty)
        {
            BasketLineItem line = Items
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = book,
                    Quantity = qty
                    
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }



    public class BasketLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
