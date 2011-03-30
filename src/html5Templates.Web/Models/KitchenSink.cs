﻿using System;
using System.ComponentModel.DataAnnotations;

namespace html5Templates.Web.Models
{
    public class KitchenSink
    {
        public string RegularString { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        public string Url { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType("Search")]
        //[UIHint("Search")]  //UI hint and a custom datatype do the same thing
        public string Search { get; set; }

        //[DataType(DataType.DateTime)] //Redundant
        public DateTime DateTime { get; set; }
        
        [DataType("DateTime-Local")]
        public DateTime DateTimeLocal { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOnly { get; set; }

        [DataType(DataType.Time)]
        public string TimeOnly { get; set; }

        [DataType("Month")]
        public string Month { get; set; }
    }
}