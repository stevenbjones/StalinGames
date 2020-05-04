﻿using System.ComponentModel.DataAnnotations;

namespace StalinGames.DAL.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters.")] // to test put (12345678901234567890123456789012345678901234567890)
        public string Name { get; set; }

        [Required]
        //[RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")] // correct = a@a.a
        [EmailAddress]
        [Display(Name = "Office Email")]
        public string Email { get; set; }

        [Required]
        public Department? Department { get; set; }

        [Required]
   
        public string BankAccountNumber { get; set; }

        public string PhotoPath { get; set; }
    }
}
