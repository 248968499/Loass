using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.SessionStore; 
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.SqlMapper
{
    public class SqlMapperManager
    {
        public static ISqlMapper _SqlMapper = null;
        private static readonly ILog log = LogManager.GetLogger(typeof(BaseDao));

        protected static void Configure(object obj)
        {
            _SqlMapper = null;
        }

        protected static void InitMapper()
        {
            IBatisNet.Common.Utilities.ConfigureHandler handler = new IBatisNet.Common.Utilities.ConfigureHandler(Configure);
            IBatisNet.DataMapper.Configuration.DomSqlMapBuilder builder = new IBatisNet.DataMapper.Configuration.DomSqlMapBuilder();
            _SqlMapper = builder.ConfigureAndWatch("bin/config/SqlMap.config", handler);
            _SqlMapper.SessionStore = new HybridWebThreadSessionStore(_SqlMapper.Id);

        }

        protected static ISqlMapper Instance()
        {
            if (_SqlMapper == null)
            {
                lock (typeof(SqlMapperManager))
                {
                    if (_SqlMapper == null) // double-check
                        InitMapper();
                }
            }
            return _SqlMapper;
        }


        public static ISqlMapper SqlMapper
        {
            get
            {
                return Instance();
            }
        }
    }
}
