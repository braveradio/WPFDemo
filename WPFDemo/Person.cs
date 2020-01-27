﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public override string ToString()
        //{
        //    return FirstName;
        //}

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
