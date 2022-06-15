using _4_Odev.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4_Odev.Entities
{
    [Table("MessageType", Schema="User")]
    public class MessageTypeEntity : IEntity
    {

        #region CTOR
        public MessageTypeEntity()
        {

        }

        #endregion

        #region PROPERTIES
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int MessageTypeId { get; set; }
        public string MessageTypeName { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        #endregion

 
    }
}
