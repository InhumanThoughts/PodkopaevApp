//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PodkopaevApp.Helper
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientView
    {
        public int Id { get; set; }
        public Nullable<int> MedicalCardId { get; set; }
        public Nullable<int> PolisId { get; set; }
        public Nullable<int> GenderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronimic { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Gender { get; set; }
    }
}
