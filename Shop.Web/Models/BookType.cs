using System.Runtime.Serialization;

namespace Shop.Web.Models
{
    [DataContract]
    public class BookType
    {
        public int BookTypeId { get; set; }
        [DataMember]
        public int Value { get; set; }
    }
}