using DatingAppLibrary.Models.DataModels;
using DatingAppLibrary.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace DatingAppServer.DBConnection
{
    public class DBDataContext : DbContext
    {
        public DBDataContext(DbContextOptions<DBDataContext> options) : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<Preference> Preferences { get; set; }
        public virtual DbSet<SexualPreference> SexualPreferences { get; set; }
        public virtual DbSet<ChatMap> ChatMaps { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("tblUsers");
            modelBuilder.Entity<User>(entity =>
            {
                //User Class from top down constraints.
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Email).IsRequired();
                entity.HasIndex(e => e.Username).IsUnique();
                entity.Property(e => e.Username).IsRequired();
                entity.Property(e => e.Password).IsRequired().UseCollation("SQL_Latin1_General_CP1_CS_AS");
                entity.HasOne(e => e.UserProfile).WithOne(e => e.User).HasForeignKey<Profile>(e => e.UserRefID);
                entity.Property(e => e.Active).HasDefaultValue(true).IsRequired();
                entity.Property(e => e.CreationDate).HasDefaultValueSql("GetDate()");
                entity.HasMany(e => e.Chats).WithMany(e => e.Participants)
                .UsingEntity<ChatMap>
                (
                    x => x.HasOne(xs => xs.Chat).WithMany(),
                    x => x.HasOne(xs => xs.User).WithMany()
                    ).HasKey(x => new { x.ChatRefID, x.UserRefID });
                entity.HasMany(e => e.PeopleWhoILike).WithOne(e => e.Liker).HasForeignKey(e => e.LikerRefID);
                entity.HasMany(e => e.PeopleWhoLikesMe).WithOne(e => e.Likee).HasForeignKey(e => e.LikeeRefID);
            });
            modelBuilder.Entity<Like>().ToTable("tblLikes");
            modelBuilder.Entity<Like>(entity =>
            {
                //Like Class from top down constraints.
                entity.HasKey(e => e.ID);
                entity.Property(e => e.LikerRefID).IsRequired();
                entity.Property(e => e.LikeeRefID).IsRequired();
                entity.Property(e => e.LikeType).HasConversion(x => (int)x, x => (LikeType)x);
                entity.Property(e => e.DateOfLike).HasDefaultValueSql("GetDate()");
                entity.HasOne(e => e.Liker).WithMany(e => e.PeopleWhoILike).HasForeignKey(e => e.LikerRefID);
                entity.HasOne(e => e.Likee).WithMany(e => e.PeopleWhoLikesMe).HasForeignKey(e => e.LikeeRefID).OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Profile>().ToTable("tblProfiles");
            modelBuilder.Entity<Profile>(entity =>
            {
                //Profile Class from top down constraints.
                entity.HasKey(e => e.ID);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.Age).IsRequired();
                entity.Property(e => e.Gender).HasConversion(x => (int)x, x => (Gender)x);
                entity.HasOne(e => e.Preferences).WithOne(e => e.Profile).HasForeignKey<Preference>(e => e.ProfileRefID);
            });
            modelBuilder.Entity<SexualPreference>().ToTable("tblSexualPreferences");
            modelBuilder.Entity<SexualPreference>(entity =>
            {
                //SexualPreference Class from top down constraints.
                entity.HasKey(e => e.ID);
                entity.Property(e => e.PreferenceRefID).IsRequired();
                entity.HasOne(e => e.Preferences).WithMany(e => e.SexPrefs).HasForeignKey(e => e.PreferenceRefID);
                entity.Property(e => e.PreferencedGender).HasConversion(x => (int)x, x => (Gender)x);
            });
            modelBuilder.Entity<Preference>().ToTable("tblPreferences");
            modelBuilder.Entity<Preference>(entity =>
            {
                //Preference Class from top down constraints.
                entity.HasKey(e => e.ID);
                //entity.HasOne(e => e.Profile).WithOne(e => e.Preferences).HasForeignKey<Profile>(e => e.);
                entity.HasMany(e => e.SexPrefs).WithOne(e => e.Preferences).HasForeignKey(e => e.PreferenceRefID);
                entity.Property(e => e.MinAge).IsRequired();
                entity.Property(e => e.MaxAge).IsRequired();
            });
            //modelBuilder.Entity<ChatMap>().ToTable("tblChatSessions");
            //modelBuilder.Entity<ChatMap>(entity =>
            //{
            //    //ChatSession Class from top down constraints.
            //    entity.HasKey(e => e.ID);
            //    entity.HasOne(e => e.Chat).WithOne(e => e.Map).HasForeignKey<ChatMap>(e => e.ChatRefID);
            //});
            modelBuilder.Entity<Chat>().ToTable("tblChats");
            modelBuilder.Entity<Chat>(entity =>
            {
                //Chat Class from top down constraints.
                entity.HasKey(e => e.ID);
                //entity.HasOne(e => e.chat).WithOne(e => e.Preferences).HasForeignKey<Profile>(e => e.);
                entity.HasMany(e => e.Messages).WithOne(e => e.Chat).HasForeignKey(e => e.ChatRefID);
                // entity.HasMany(e => e.Participants).WithOne().HasForeignKey<User>(e=>e.)
            });
            modelBuilder.Entity<Message>().ToTable("tblMessages");
            modelBuilder.Entity<Message>(entity =>
            {
                //Message Class from top down constraints.
                entity.HasKey(e => e.ID);
                entity.Property(e=>e.TimeSent).HasDefaultValueSql("GetDate()");
                entity.Property(e => e.Content).IsRequired();
                //maybe need map idk lets just cross fingers.
                entity.HasOne(e => e.Sender).WithMany();
            });
        }
    }
}
