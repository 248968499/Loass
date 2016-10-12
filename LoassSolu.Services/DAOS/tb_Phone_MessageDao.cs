using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Errors;
using log4net;
using LoassSolu.Services.Entities;

namespace LoassSolu.Services.DAOS
{
public class tb_Phone_MessageDao : BaseDao
{
    private static readonly ILog log = LogManager.GetLogger(typeof(tb_Phone_MessageDao));
    
    #region 代码系统生成
    //添加产品
     public int Inserttb_Phone_MessageEntity(Dictionary<String,Object> param)
    {
        try
        {
           return int.Parse(Insert("tb_Phone_MessageEntity.insert", param).ToString());
        }
        catch (Exception ex)
        {
            new LoassException("添加tb_Phone_MessageEntity出错", log, ex);
            return -1;
        }
    }
    
    //更新产品
     public int Updatetb_Phone_MessageEntity(Dictionary<String,Object> param)
    {
        try
        {
           
            return Update("tb_Phone_MessageEntity.update", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("更新tb_Phone_MessageEntity出错", log, ex);
            return -1;
        }
    }
    
    //删除产品
     public int Deletetb_Phone_MessageEntity(String id)
    {
        try
        {
            return Delete("tb_Phone_MessageEntity.delete", id);
        }
        catch (System.Exception ex)
        {
            new LoassException("删除tb_Phone_MessageEntity出错", log, ex);
            return -1;
        }
    }
    //查找
    public tb_Phone_MessageEntity Selecttb_Phone_MessageEntity(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<tb_Phone_MessageEntity>("tb_Phone_MessageEntity.select", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取tb_Phone_MessageEntity实体失败", log, ex);
            return null;
        }
    }
    
        /// <summary>
        /// 获取实体列表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IList Selecttb_Phone_MessageEntityList(Dictionary<String,Object> param)
        {
            try
            {
                return SqlMapper.QueryForList("tb_Phone_MessageEntity.select", param);
            }
            catch (System.Exception ex)
            {
                new LoassException("获取tb_Phone_MessageEntity实体列表失败", log, ex);
                return null;
            }
        }
    
    
    //获取产品总数
    public int Gettb_Phone_MessageEntityCount(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<int>("tb_Phone_MessageEntity.tb_phone_message_count", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取产品tb_Phone_MessageEntity总的条数失败", log, ex);
            return 0;
        }
    }
    
    //分页
    public IList Get_tb_Phone_MessageEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        recordCount = -1;
        IList list = null;
        try
        {

            recordCount = SqlMapper.QueryForObject<int>("tb_Phone_MessageEntity.tb_phone_message_count", param);
          
            int totalPage = recordCount / pageSize;
            if (recordCount % pageSize != 0)
                totalPage++;

            param.Add("startId", (currentPage - 1) * pageSize + 1);
            param.Add("endId", currentPage * pageSize);
            list = SqlMapper.QueryForList("tb_Phone_MessageEntity.tb_phone_message_list", param);

            return list;
        }
        catch (System.Exception ex)
        {
            new LoassException("tb_Phone_MessageEntity产品分页出错", log, ex);
            return null;
        }
    }
    #endregion
}
}
