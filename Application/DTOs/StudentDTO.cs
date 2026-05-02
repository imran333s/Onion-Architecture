using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.ValueObjects;
namespace Application.DTOs
{
    public class StudentDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }
}
