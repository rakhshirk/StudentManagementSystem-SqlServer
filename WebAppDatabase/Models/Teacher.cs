using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAppDatabase.Data;

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

        public string Name { get; set; } = "null";

        public string FatherName { get; set; } = "null";

        public string Address { get; set; } = "null";

        public string City { get; set; } = "null";

        public string Phone { get; set; } = "null";

        public string Email { get; set; } = "null";

        public byte Year { get; set; } = 0;

        public byte Month { get; set; } = 0;

        public string Degree { get; set; } = "null";

    }

}
