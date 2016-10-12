using Loass.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loass.Framework.Data
{
    public class UnitOfWorkBase : IDisposable
    {
        private LoassContext context = new LoassContext();
        #region 用户表
        private RepositoryBase<UserEntity> userRepository;
        public RepositoryBase<UserEntity> UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new RepositoryBase<UserEntity>(context);
                }
                return userRepository;
            }
        }
        #endregion
        #region 文章
        private RepositoryBase<ArticleEntity> articleRepository;
        public RepositoryBase<ArticleEntity> ArticleRepository
        {
            get
            {
                if (this.articleRepository == null)
                {
                    this.articleRepository = new RepositoryBase<ArticleEntity>(context);
                }
                return articleRepository;
            }
        }
        #endregion
        #region
        public int Save()
        {
          return  context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
