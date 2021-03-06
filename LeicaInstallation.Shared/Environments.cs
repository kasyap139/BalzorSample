﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LeicaInstallation.Shared
{
    public class Environments
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        //public string Email { get; set; }
        public string Street { get; set; }
        //public string Zip { get; set; }
        public string City { get; set; }
        //public int CountryId { get; set; }
        //public string PhoneNumber { get; set; }
        //public bool Smoker { get; set; }
        public string Comment { get; set; }
        //public DateTime? JoinedDate { get; set; }
        //public DateTime? ExitDate { get; set; }    
        //public int JobCategoryId { get; set; }
        //public double Latitude { get; set; }
        //public double Longitude { get; set; }
    }
}
