using Domain.Enums;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;

namespace Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }

}
