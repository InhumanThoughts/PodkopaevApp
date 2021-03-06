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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.RecordLists = new HashSet<RecordList>();
        }
    
        public int Id { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public Nullable<System.DateTime> EmploymentDate { get; set; }
        public Nullable<int> CabinetNumber { get; set; }
        public Nullable<int> GenderId { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecordList> RecordLists { get; set; }
        public virtual Role Role { get; set; }
    }
}
