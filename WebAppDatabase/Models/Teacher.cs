using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppDatabase.Models
{
    [Table("v_Teacher")]
    [PrimaryKey("PersonId","Year","Month")]
    
    public class Teacher
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Column("PersonId")]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PersonId { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public byte Year { get; set; }

        public byte Month { get; set; }

        public string Degree { get; set; }

    }

}
