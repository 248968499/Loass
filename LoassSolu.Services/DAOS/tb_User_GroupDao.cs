using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Errors;
using log4net;
using LoassSolu.Services.Entities;

namespace LoassSolu.Services.DAOS
{
public class tb_User_GroupDao : BaseDao
{
    private static readonly ILog log = LogManager.GetLogger(typeof(tb_User_GroupDao));
    
    #region 代码系统生成
    //添加产品
     public int Inserttb_User_GroupEntity(Dictionary<String,Object> param)
    {
        try
        {
           return int.Parse(Insert("tb_User_GroupEntity.insert", param).ToString());
        }
        catch (Exception ex)
        {
            new LoassException("添加tb_User_GroupEntity出错", log, ex);
            return -1;
        }
    }
    
    //更新产品
     public int Updatetb_User_GroupEntity(Dictionary<String,Object> param)
    {
        try
        {
           
            return Update("tb_User_GroupEntity.update", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("更新tb_User_GroupEntity出错", log, ex);
            return -1;
        }
    }
    
    //删除产品
     public int Deletetb_User_GroupEntity(String id)
    {
        try
        {
            return Delete("tb_User_GroupEntity.delete", id);
        }
        catch (System.Exception ex)
        {
            new LoassException("删除tb_User_GroupEntity出错", log, ex);
            return -1;
        }
    }
    //查找
    public tb_User_GroupEntity Selecttb_User_GroupEntity(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<tb_User_GroupEntity>("tb_User_GroupEntity.select", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取tb_User_GroupEntity实体失败", log, ex);
            return null;
        }
    }
    
        /// <summary>
        /// 获取实体列表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IList Selecttb_User_GroupEntityList(Dictionary<String,Object> param)
        {
            try
            {
                return SqlMapper.QueryForList("tb_User_GroupEntity.select", param);
            }
            catch (System.Exception ex)
            {
                new LoassException("获取tb_User_GroupEntity实体列表失败", log, ex);
                return null;
            }
        }
    
    
    //获取产品总数
    public int Gettb_User_GroupEntityCount(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<int>("tb_User_GroupEntity.tb_user_group_count", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取产品tb_User_GroupEntity总的条数失败", log, ex);
            return 0;
        }
    }
    
    //分页
    public IList Get_tb_User_GroupEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        recordCount = -1;
        IList list = null;
        try
        {

            recordCount = SqlMapper.QueryForObject<int>("tb_User_GroupEntity.tb_user_group_count", param);
          
            int totalPage = recordCount / pageSize;
            if (recordCount % pageSize != 0)
                totalPage++;

            param.Add("startId", (currentPage - 1) * pageSize + 1);
            param.Add("endId", currentPage * pageSize);
            list = SqlMapper.QueryForList("tb_User_GroupEntity.tb_user_group_list", param);

            return list;
        }
        catch (System.Exception ex)
        {
            new LoassException("tb_User_GroupEntity产品分页出错", log, ex);
            return null;
        }
    }
    #endregion
}
}
