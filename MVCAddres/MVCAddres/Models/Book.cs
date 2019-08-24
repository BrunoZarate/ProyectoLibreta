

namespace MVCAddres.Models

{
    using System.ComponentModel.DataAnnotations;

    public enum TypeContact
    {
        Telephone,
        Email,
        Facebook,
        Twitter,
        Instagram,
        Dblink,
    }
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeContact Type { get; set; }
        [Required]
        public string Contact { get; set; }
    }
}