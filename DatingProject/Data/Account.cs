using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace DatingProject.Data
{
    public class Account
    {
        [Key]
        public int AccountsId { get; set; }

        [Required(ErrorMessage = "First Name must be min. 2 characters and max. 50 characters...")]
        [MaxLength(50)]
        [MinLength(2)]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name must be min. 2 characters and max. 50 characters...")]
        [MaxLength(50)]
        [MinLength(2)]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email must be min. 2 characters and max. 50 characters...")]
        [MaxLength(50)]
        [MinLength(2)]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        [Required(ErrorMessage = "User Name must be min. 2 characters and max. 50 characters...")]
        [MaxLength(50)]
        [MinLength(2)]
        [Column("UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password must be min. 3 characters and max. 50 characters...")]
        [MaxLength(50)]
        [MinLength(3)]
        [Column("Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must specify a birth date...")]
        public DateTime CreatedDate { get; set; }

        //[ForeignKey("City")]
        ////public int ZipCode { get; set; }
        //public City City { get; set; }

        //public List<Like> SentLikes { get; set; } = new List<Like>();
    }
}
