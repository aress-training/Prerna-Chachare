//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment.Models
{
    using MVCDemo.Common;
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RemoteClientServer("IsEmailAvailable", "Assignment11", ErrorMessage = "Email already in use.")]
        public string Email { get; set; }
    }
}
