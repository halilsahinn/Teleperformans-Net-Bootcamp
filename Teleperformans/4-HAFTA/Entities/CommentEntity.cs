using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4_Odev.Entities
{
    [Table("Comments",Schema="User")]
    public class CommentEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
    
        public string CommentBody { get; set; }
        public string CommentCaption { get; set; }

        public DateTime CreatedDate { get; set; }


        
            
            
    }
}
