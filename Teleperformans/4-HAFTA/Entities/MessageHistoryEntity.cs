using _4_Odev.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4_Odev.Entities
{
    [Table("MessageHistory", Schema = "User")]
    public class MessageHistoryEntity : IEntity
    {
        #region CTOR

        public MessageHistoryEntity()
        {
            UpdatedDate = DateTime.Now;
        }

        #endregion

        #region PROPERTIES
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int MessageHistoryId { get; set; }
        [ForeignKey("MessageId")]
        public int MessageId { get; set; }
        [ForeignKey("MessageTypeId")]
        public int MessageTypeId { get; set; }
        public string MessageBody { get; set; }

        public DateTime UpdatedDate { get; set; }

        


        #endregion


        #region NAVIGATION PROPERTIES

        #endregion


    }
}
