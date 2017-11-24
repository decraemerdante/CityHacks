using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitter.Models
{
    public class ListModelViews
    {
        public List<ModelViewSport> ModelSports;
        public ListModelViews()
        {
            ModelSports = new List<ModelViewSport>();
            ModelSports.Add(
                new ModelViewSport()
                {
                    src = "swimming.png",
                    SportId = 1,
                    Name = "Zwemmen",
                    Distance = 11,
                    Location = "S&R Olympia",
                    Description = "Deze les is bedoeld voor mensen die momenteel weldegelijk kunnen zwemmen maar de juiste techniek willen aanleren om door het water te glijden.Heb je interesse schrijf je dan nu in, je bent altijd welkom. ",
                    DeelNemers = new List<Person>()
                    {
                        new Person()
                        {
                            Name = "Jef Michiels",
                            Age = 21,
                        },
                         new Person()
                        {
                            Name = "Stella Artois",
                            Age = 31,
                        }

                    },
                    Teacher = new Person()
                    {
                        Name = "Motorola gsmmen",
                        Age = 25
                    }
                }
            );
            ModelSports.Add(
                new ModelViewSport()
                {
                    src = "lopen.png",
                    SportId = 2,
                    Name = "Lopen",
                    Location = "Minnewater Park",
                    Distance = 12,
                    Description = "Het is bewezen dat mensen die lopen onder begeleiding 2x langer doorgaan met lopen en zich na 10 workouts sportiever voelen dan mensen zonder begeleiding. Wil jij de juiste motivatie vinden om aan het lopen te gaan? Schrijf je dan nu in!",
                    DeelNemers = new List<Person>()
                    {
                        new Person()
                        {
                            Name = "Michke vonHaverbekke",
                            Age = 20,
                        },
                        new Person()
                        {
                            Name = "Dante Bardiau",
                            Age = 25,
                        },
                        new Person()
                        {
                            Name = "Jupiler Waterken",
                            Age = 23,
                        }
                    },
                    Teacher = new Person()
                    {
                        Name= "Asus Laptopussen",
                        Age = 25
                    }
                }
            );
           
            ModelSports.Add(
                new ModelViewSport()
                {
                    src = "fietsen.png",
                    SportId = 3,
                    Name = "Fietsen",
                    Location = "Brugse vaart",
                    Distance = 14,
                    Description = "Zin om samen te toeren door de Vlaamse Velden en ondertussen eventjes te schaven aan je techniek? Schrijf je dan nu in!",
                    DeelNemers = new List<Person>()
                    {
                        new Person()
                        {
                            Name = "Xander Maes",
                            Age = 20,
                        },
                        new Person()
                        {
                            Name = "Arno Sissau",
                            Age = 25,
                        },
                        new Person()
                        {
                            Name = "Tim Demeulder",
                            Age = 23,
                        }
                    },
                    Teacher = new Person()
                    {
                        Name = "Jolien Acer",
                        Age = 25
                    }
                }
            );
        }


       
    }

    /*
     * ZWEMMEN
Zin om samen te toeren door de Vlaamse Velden en ondertussen eventjes te schaven aan je techniek? Schrijf je dan nu in!     * */

}