using System.Runtime.Serialization;

namespace Shop.Web.Models
{
    [DataContract]
    public class Author
    {
        public int AuthorId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}