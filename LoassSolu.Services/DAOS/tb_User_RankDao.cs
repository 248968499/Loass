using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Errors;
using log4net;
using LoassSolu.Services.Entities;

namespace LoassSolu.Services.DAOS
{
public class tb_User_RankDao : BaseDao
{
    private static readonly ILog log = LogManager.GetLogger(typeof(tb_User_RankDao));
    
    #region 代码系统生成
    //添加产品
     public int Inserttb_User_RankEntity(Dictionary<String,Object> param)
    {
        try
        {
           return int.Parse(Insert("tb_User_RankEntity.insert", param).ToString());
        }
        catch (Exception ex)
        {
            new LoassException("添加tb_User_RankEntity出错", log, ex);
            return -1;
        }
    }
    
    //更新产品
     public int Updatetb_User_RankEntity(Dictionary<String,Object> param)
    {
        try
        {
           
            return Update("tb_User_RankEntity.update", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("更新tb_User_RankEntity出错", log, ex);
            return -1;
        }
    }
    
    //删除产品
     public int Deletetb_User_RankEntity(String id)
    {
        try
        {
            return Delete("tb_User_RankEntity.delete", id);
        }
        catch (System.Exception ex)
        {
            new LoassException("删除tb_User_RankEntity出错", log, ex);
            return -1;
        }
    }
    //查找
    public tb_User_RankEntity Selecttb_User_RankEntity(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<tb_User_RankEntity>("tb_User_RankEntity.select", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取tb_User_RankEntity实体失败", log, ex);
            return null;
        }
    }
    
        /// <summary>
        /// 获取实体列表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IList Selecttb_User_RankEntityList(Dictionary<String,Object> param)
        {
            try
            {
                return SqlMapper.QueryForList("tb_User_RankEntity.select", param);
            }
            catch (System.Exception ex)
            {
                new LoassException("获取tb_User_RankEntity实体列表失败", log, ex);
                return null;
            }
        }
    
    
    //获取产品总数
    public int Gettb_User_RankEntityCount(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<int>("tb_User_RankEntity.tb_user_rank_count", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取产品tb_User_RankEntity总的条数失败", log, ex);
            return 0;
        }
    }
    
    //分页
    public IList Get_tb_User_RankEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        recordCount = -1;
        IList list = null;
        try
        {

            recordCount = SqlMapper.QueryForObject<int>("tb_User_RankEntity.tb_user_rank_count", param);
          
            int totalPage = recordCount / pageSize;
            if (recordCount % pageSize != 0)
                totalPage++;

            param.Add("startId", (currentPage - 1) * pageSize + 1);
            param.Add("endId", currentPage * pageSize);
            list = SqlMapper.QueryForList("tb_User_RankEntity.tb_user_rank_list", param);

            return list;
        }
        catch (System.Exception ex)
        {
            new LoassException("tb_User_RankEntity产品分页出错", log, ex);
            return null;
        }
    }
    #endregion
}
}
