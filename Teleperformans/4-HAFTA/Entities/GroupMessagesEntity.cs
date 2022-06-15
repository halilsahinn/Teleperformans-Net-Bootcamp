using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4_Odev.Entities
{
    [Table("GroupMessages", Schema = "User")]
    public class GroupMessagesEntity
    {
        #region CTOR
        public GroupMessagesEntity()
        {
            SentDate = DateTime.Now;
        }

        #endregion

        #region PROPERTIES
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int GroupMessagesId { get; set; }
      
        public int MessageTypeId { get; set; }
        public string MessageBody { get; set; }
        public DateTime SentDate { get; set; }
        [ForeignKey("SenderId")]
        public int SenderId { get; set; }
        [ForeignKey("RecieverId")]
        public int RecieverId { get; set; }
        

        #endregion

        #region NAVIGATION PROPERTIES

        #endregion
    }
}
