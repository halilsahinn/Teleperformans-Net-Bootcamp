using _4_Odev.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _4_Odev.Contexts
{
    public class SocialMediaContext : IdentityDbContext<UserEntity>
    {
        #region CTOR
        public SocialMediaContext(DbContextOptions<SocialMediaContext> options) : base(options)
        {
        }
       

        #endregion

        #region DBSET

        public DbSet<CommentEntity> Comment { get; set; }
        public DbSet<FriendConfirmationEntity> FriendConfirmation { get; set; }
        public DbSet<FriendEntity> Friend { get; set; }
        public DbSet<GroupMessagesEntity> GroupMessages { get; set; }
        public DbSet<MessageHistoryEntity> MessageHistory { get; set; }
        public DbSet<MessagesEntity> Messages { get; set; }
        public DbSet<MessageTypeEntity> CommMessageType { get; set; }
        public DbSet<UserEntity> User { get; set; }


        #endregion
 
        #region METHODS
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        #endregion

    }
}
