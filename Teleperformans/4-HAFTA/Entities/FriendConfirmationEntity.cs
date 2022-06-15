using _4_Odev.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4_Odev.Entities
{
    [Table("FriendConfirmation", Schema = "User")]
    
    public class FriendConfirmationEntity:IEntity
    {
        /// <summary>
        /// Bu tabloda arkadaşlık istiklerinin kaydı tutulur.s
        /// </summary>
       

        #region CTOR

        public FriendConfirmationEntity()
        {
            SentDate=DateTime.Now;
        }
        #endregion

        #region PROPERTIES
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int FriendConfirmationId { get; set; }
        
        [ForeignKey("SourceId")]
        public int SourceId { get; set; }

        [ForeignKey("TargetId")]
        public int TargetId { get; set; }
        public bool IsAccepted { get; set; }

        public DateTime SentDate { get; set; }
        #endregion

        #region NAVIGATION PROPERTIES

        #endregion



    }
}
