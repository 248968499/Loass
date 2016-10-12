using Loass.Framework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loass.Framework.Data
{
    public class LoassContext : DbContext
    {
        public LoassContext() : base("LoassContext") { }
        public DbSet<AboutBlogEntity> AboutBlogs { get; set; }
        public DbSet<AdEntity> Ads { get; set; }
        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<ArticleSortEntity> ArticleSorts { get; set; }
        public DbSet<FriendEntity> Friends { get; set; }
        public DbSet<FriendlyLinkEntity> FriendlyLinks { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        public DbSet<GroupPowerEntity> GroupPowers { get; set; }
        public DbSet<PhoneMessageEntity> PhoneMessages { get; set; }
        public DbSet<PhotosEntity> Photos { get; set; }
        public DbSet<PhotoSortEntity> PhotoSorts { get; set; }
        public DbSet<PowerListEntity> PowerLists { get; set; }
        public DbSet<SecretMessageEntity> SecretMessages { get; set; }
        public DbSet<ShuoshuoEntity> Shuoshuos { get; set; }
        public DbSet<SystemMessageEntity> SystemMessages { get; set; }
        public DbSet<UserAttentionEntity> UserAttentions { get; set; }
        public DbSet<UserCommentEntity> UserComments { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UserGroupEntity> UserGroups { get; set; }
        public DbSet<UserPowerEntity> UserPowers { get; set; }
        public DbSet<UserRankEntity> UserRanks { get; set; }
        public DbSet<VisitorEntity> Visitors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
