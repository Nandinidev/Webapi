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
    
    public partial class tblQuestionBank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblQuestionBank()
        {
            this.tblAnswers = new HashSet<tblAnswer>();
        }
    
        public int Q_id { get; set; }
        public Nullable<int> file_id { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CorrectOption { get; set; }
        public Nullable<int> QuestionMarks { get; set; }
        public Nullable<int> QuestionLevel { get; set; }
    
        public virtual tblFile tblFile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAnswer> tblAnswers { get; set; }
    }
}