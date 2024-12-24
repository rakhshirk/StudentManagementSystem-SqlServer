using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using WebAppDatabase.Data;

namespace WebAppDatabase.Models
{
    [Table("Person")]
    [PrimaryKey("PersonId")]
    public class Person
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Column("PersonId")]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }


        [Column("Name")]
        public string Name { get; set; } = "null";

        [Column("FatherName")]
        public string FatherName { get; set; } = "null";

        [Column("Address")]
        public string Address { get; set; } = "null";

        [Column("City")]
        public string City { get; set; } = "null";

        [Column("Phone")]
        public string Phone { get; set; } = "null";

        [Column("Email")]
        public string Email { get; set; } = "null";

    }
}