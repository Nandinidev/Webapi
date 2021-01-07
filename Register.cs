using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OnlineExam.VClasses
{
    [DataContract]
    public class Register
    {
        
        public int User_id { get; set; }
        [Required]
        public string Full_Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Mobile_Number { get; set; }
        [Required]
        public Nullable<System.DateTime> Date_of_Birth { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Qualification { get; set; }
        [Required]
        public string Year_of_Completion { get; set; }
    }
}