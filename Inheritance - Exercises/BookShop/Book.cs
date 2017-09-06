using System;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get { return this.author; }
            protected set
            {
                string[] author = value.Split();
                if (author.Length == 2)
                {
                    string secondName = author[1];
                    for (int i = 0; i < secondName.Length; i++)
                    {
                        int output;
                        if (int.TryParse(secondName[0].ToString(), out output))
                        {
                            throw new ArgumentException("Author not valid!");
                        }
                    }
                }
                this.author = value;
            }
        }

        public string Title
        {
            get { return this.title; }
            protected set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }
    }
}

