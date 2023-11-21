using System.Runtime.Serialization;

namespace ArttSabor.Domain.Entities
{
    [DataContract]

    public class BaseEntity
    {
        public int Id { get; set; }
    }
}
