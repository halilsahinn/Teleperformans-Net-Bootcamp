using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4_Odev.Entities
{
    [Table("Friends", Schema = "User")]
    public class FriendEntity
    { 
        /// <summary>
      /// Bu tabloda arkadaşlık kaydı tutulur.s
      /// </summary>
   
        #region CTOR
        public FriendEntity()
        {
            CreatedDate=DateTime.Now;
        }
        #endregion
         
        #region PROPERTIES
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int UserFriendId { get; set; }

        [ForeignKey("SourceId")]
        public int SourceId { get; set; }

        [ForeignKey("TargetId")]
        public int TargetId { get; set; }

        public DateTime CreatedDate { get; set; }
        

        #endregion

        #region NAVIGATION PROPERTIES

        #endregion
    }
}
