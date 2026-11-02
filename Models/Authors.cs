using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andrei_Man_Lab2.Models
{
    public class Authors
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Full Name")]
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public ICollection<Book>? Books { get; set; }
    }
}