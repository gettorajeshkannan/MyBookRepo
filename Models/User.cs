// Create a new class user with the following members/
// ID (int) - A unique identifier for the user
// Username (String) - The users username
// Password (String) - The users Password
// Email (String) - The users Email
// Firstname (String) - The users Firstname
// Lastname (String) - The users Lastname
// Add data annotation validation to the class members


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
    }
