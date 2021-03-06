using System.ComponentModel.DataAnnotations;

namespace simpleCRUD.ViewModel
{
    public class VmRegister
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
    }
}
