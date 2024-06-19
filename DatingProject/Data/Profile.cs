using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingProject.Data
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
    }
}
