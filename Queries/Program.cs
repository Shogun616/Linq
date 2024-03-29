﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movies>
            {
                new Movies {Title = "The Dark Knight", Rating = 8.9f, Year = 2008},
                new Movies {Title = "The King´s Speech", Rating = 8.0f, Year = 2010},
                new Movies {Title = "Casablanca", Rating = 8.5f, Year = 1942},
                new Movies {Title = "Star Wars Episode V: Empire Strikes Back", Rating = 8.7f, Year = 1980}
            };

            var query = from movie in movies
                        where movie.Year > 2000
                        orderby movie.Rating descending
                        select movie;

            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Title);
            }
        }
    }
}
