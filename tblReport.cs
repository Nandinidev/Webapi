//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineExam.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblReport
    {
        public int Test_id { get; set; }
        public Nullable<int> User_id { get; set; }
        public Nullable<int> Score { get; set; }
        public string ExamTopic { get; set; }
    
        public virtual tblUser tblUser { get; set; }
    }
}