using System;
using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesForm.Models
{
    public class Patient
    {
        
        [Display(Name = "First Name"), Required, StringLength(60, MinimumLength = 3), RegularExpression(@"^[a-zA-Z]+$")]
        public string FirstName { get; set; }
        

        [Display(Name = "Last Name"), Required, StringLength(60, MinimumLength = 3), RegularExpression(@"^[a-zA-Z]+$")]
        public string LastName { get; set; }
        
        [Display(Name = "Birth Date"), DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Gender { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Display(Name = "Phone Number"), DataType(DataType.PhoneNumber), RegularExpression(@"^[\d]{9}$"), MaxLength(9)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Is the patient ID checked?")]
        public bool PatientIdentification { get; set; }
        
        public int ID { get; set; }

    }
}
