

namespace appAddress.Models
{


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
        public int BookID { get; set; }
        public string Name { get; set; }
        public TypeContact Type { get; set; }
        public string Contact { get; set; }
    }
}