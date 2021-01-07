using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OnlineExam.VClasses
{
    [DataContract]
    public class Login
    {
        [DataMember]
        [Required]
        public string Email { get; set; }

        [DataMember]
        [Required]

        public string Pwd { get; set; }
    }
}