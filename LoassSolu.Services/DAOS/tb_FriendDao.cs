using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Errors;
using LoassSolu.Services.Entities;
using log4net;

namespace LoassSolu.Services.DAOS
{
public class tb_FriendDao : BaseDao
{
    private static readonly ILog log = LogManager.GetLogger(typeof(tb_FriendDao));
    
    #region 代码系统生成
    //添加产品
     public int Inserttb_FriendEntity(Dictionary<String,Object> param)
    {
        try
        {
           return int.Parse(Insert("tb_FriendEntity.insert", param).ToString());
        }
        catch (Exception ex)
        {
            new LoassException("添加tb_FriendEntity出错", log, ex);
            return -1;
        }
    }
    
    //更新产品
     public int Updatetb_FriendEntity(Dictionary<String,Object> param)
    {
        try
        {
           
            return Update("tb_FriendEntity.update", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("更新tb_FriendEntity出错", log, ex);
            return -1;
        }
    }
    
    //删除产品
     public int Deletetb_FriendEntity(String id)
    {
        try
        {
            return Delete("tb_FriendEntity.delete", id);
        }
        catch (System.Exception ex)
        {
            new LoassException("删除tb_FriendEntity出错", log, ex);
            return -1;
        }
    }
    //查找
    public tb_FriendEntity Selecttb_FriendEntity(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<tb_FriendEntity>("tb_FriendEntity.select", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取tb_FriendEntity实体失败", log, ex);
            return null;
        }
    }
    
        /// <summary>
        /// 获取实体列表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IList Selecttb_FriendEntityList(Dictionary<String,Object> param)
        {
            try
            {
                return SqlMapper.QueryForList("tb_FriendEntity.select", param);
            }
            catch (System.Exception ex)
            {
                new LoassException("获取tb_FriendEntity实体列表失败", log, ex);
                return null;
            }
        }
    
    
    //获取产品总数
    public int Gettb_FriendEntityCount(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<int>("tb_FriendEntity.tb_friend_count", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取产品tb_FriendEntity总的条数失败", log, ex);
            return 0;
        }
    }
    
    //分页
    public IList Get_tb_FriendEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        recordCount = -1;
        IList list = null;
        try
        {

            recordCount = SqlMapper.QueryForObject<int>("tb_FriendEntity.tb_friend_count", param);
          
            int totalPage = recordCount / pageSize;
            if (recordCount % pageSize != 0)
                totalPage++;

            param.Add("startId", (currentPage - 1) * pageSize + 1);
            param.Add("endId", currentPage * pageSize);
            list = SqlMapper.QueryForList("tb_FriendEntity.tb_friend_list", param);

            return list;
        }
        catch (System.Exception ex)
        {
            new LoassException("tb_FriendEntity产品分页出错", log, ex);
            return null;
        }
    }
    #endregion
}
}
