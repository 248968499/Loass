using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using IBatisNet.DataMapper.Scope;
using IBatisNet.DataMapper.MappedStatements;
using IBatisNet.DataMapper.Exceptions;
using System.Transactions;
using LoassSolu.Services.SqlMapper;

namespace LoassSolu.Services.DAOS
{

    public class BaseDao : SqlMapperManager
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BaseDao));
        public IList<T> QueryForList<T>(string statementName, object parameterObject)
        {
            try
            {
                return SqlMapper.QueryForList<T>(statementName, parameterObject);
            }
            catch (Exception e)
            {
                log.Debug("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
                throw new DataMapperException("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
            }
        }
        public IList<T> QueryForList<T>(string statementName, object parameterObject, int skipResults, int maxResults)
        {
            try
            {
                return SqlMapper.QueryForList<T>(statementName, parameterObject, skipResults, maxResults);
            }
            catch (Exception e)
            {
                log.Debug("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
                throw new DataMapperException("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
            }
        }
        public T QueryForObject<T>(string statementName, object parameterObject)
        {
            try
            {
                return SqlMapper.QueryForObject<T>(statementName, parameterObject);
            }
            catch (Exception e)
            {
                log.Debug("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
                throw new DataMapperException("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
            }
        }
        public IDictionary<K, V> QueryForDictionary<K, V>(string statementName, object parameterObject, string keyProperty)
        {
            try
            {
                return SqlMapper.QueryForDictionary<K, V>(statementName, parameterObject, keyProperty);
            }
            catch (Exception e)
            {
                log.Debug("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
                throw new DataMapperException("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
            }
        }
        public IDictionary<K, V> QueryForDictionary<K, V>(string statementName, object parameterObject, string keyProperty, string valueProperty)
        {
            try
            {
                return SqlMapper.QueryForDictionary<K, V>(statementName, parameterObject, keyProperty, valueProperty);
            }
            catch (Exception e)
            {
                log.Debug("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
                throw new DataMapperException("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
            }
        }
        public object Insert(string statementName, object parameterObject)
        {
            try
            {
                object a = SqlMapper.Insert(statementName, parameterObject);
                if (a == null)
                {
                    return 1;
                }
                else
                {
                    return a;
                }
            }
            catch (Exception e)
            {
                log.Debug("Error executing query '" + statementName + "' for Insert.  Cause: " + e.Message, e);
                throw new DataMapperException("Error executing query '" + statementName + "' for Insert.  Cause: " + e.Message, e);
            }
        }
        public int Delete(string statementName, object parameterObject)
        {
            try
            {
                return SqlMapper.Delete(statementName, parameterObject);
            }
            catch (Exception e)
            {
                log.Debug("Error executing query '" + statementName + "' for delete.  Cause: " + e.Message, e);
                throw new DataMapperException("Error executing query '" + statementName + "' for delete.  Cause: " + e.Message, e);
            }
        }
        public int Update(string statementName, object parameterObject)
        {
            try
            {
                return SqlMapper.Update(statementName, parameterObject);
            }
            catch (Exception e)
            {
                log.Debug("Error executing query '" + statementName + "' for update.  Cause: " + e.Message, e);
                throw new DataMapperException("Error executing query '" + statementName + "' for update.  Cause: " + e.Message, e);
            }
        }
        public DataSet QueryForDataSet(string statementName, object paramObject, out Hashtable outputTable)
        {
            try
            {
                DataSet ds = new DataSet();
                IMappedStatement statement = SqlMapper.GetMappedStatement(statementName);
                if (!SqlMapper.IsSessionStarted)
                {
                    SqlMapper.OpenConnection();
                }
                RequestScope scope = statement.Statement.Sql.GetRequestScope(statement, paramObject, SqlMapper.LocalSession);
                statement.PreparedCommand.Create(scope, SqlMapper.LocalSession, statement.Statement, paramObject);

                //mapper.LocalSession.CreateDataAdapter((scope.IDbCommand).Fill(ds));
                IDbCommand dc = SqlMapper.LocalSession.CreateCommand(scope.IDbCommand.CommandType);
                dc.CommandText = scope.IDbCommand.CommandText;


                foreach (IDbDataParameter para in scope.IDbCommand.Parameters)
                {
                    System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter();
                    myParameter.ParameterName = para.ParameterName;

                    myParameter.Value = para.Value;
                    myParameter.Direction = para.Direction;

                    dc.Parameters.Add(myParameter);
                    //  dc.Parameters.Add(para);
                }
                //dc.Parameters = scope.IDbCommand.Parameters;
                IDbDataAdapter dda = SqlMapper.LocalSession.CreateDataAdapter(dc);
                dda.Fill(ds);

                SqlParameterCollection spc = (SqlParameterCollection)dc.Parameters;
                outputTable = new Hashtable();

                foreach (SqlParameter s in spc)
                {
                    outputTable.Add(s.ParameterName, s.Value);
                }

                return ds;
            }
            catch (Exception e)
            {
                log.Debug("Error executing query '" + statementName + "' for dataset.  Cause: " + e.Message, e);
                throw new DataMapperException("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
            }
        }

        /// <summary>
        /// 执行批量插入命令
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="dt">组装好的要批量导入的datatable</param>
        /// <returns></returns>
        protected bool ExecuteBatchInsert(string tableName, DataTable dt)
        {
            bool flag = false; 
            try
            {
                using ( TransactionScope scope = new TransactionScope())
                {

                    using (SqlConnection conn = new SqlConnection(SqlMapper.DataSource.ConnectionString))
                    {
                        conn.Open();
                        using (SqlBulkCopy sbc = new SqlBulkCopy(conn))
                        {
                            //服务器上目标表的名称
                            sbc.DestinationTableName = tableName;
                            sbc.BatchSize = 50000;
                            sbc.BulkCopyTimeout = 180;
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                //列映射定义数据源中的列和目标表中的列之间的关系
                                sbc.ColumnMappings.Add(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName);
                            }
                            sbc.WriteToServer(dt);
                            flag = true;
                            scope.Complete();//有效的事务
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                flag = false;
                string errMsg = ex.Message;
                log.Debug("Error executing batchinsert .  Cause: " + ex.Message, ex);
            }
            return flag;
        }


        #region 判断返回的数据集是否为空
        /// <summary>
        /// 判断返回的数据集是否为空,false为空,true不为空
        /// </summary>
        /// <param name="ds"></param>
        /// <returns>false 为空</returns>
        protected static bool DataSetIsNull(DataSet ds)
        {
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0] == null || ds.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }
        #endregion
    }
}


