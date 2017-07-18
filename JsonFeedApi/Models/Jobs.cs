using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonFeedApi.Models
{
    public class Jobs
    {
        public int Sort { get; set; }
        public string Company { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Responsibility { get; set; }
        public double Salary { get; set; }
        public string Phone { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Image { get; set; }







    }
}