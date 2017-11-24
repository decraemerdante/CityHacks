using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitter.Models
{
    public class ModelViewSport
    {
        public int SportId;
        public string Description;
        public string Name;
        public string Location;
        public int Distance;
        public List<Person> DeelNemers;
        public Person Teacher;
    }
}