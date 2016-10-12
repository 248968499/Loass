using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Errors;
using log4net;
using LoassSolu.Services.Entities;

namespace LoassSolu.Services.DAOS
{
public class tb_Article_SortDao : BaseDao
{
    private static readonly ILog log = LogManager.GetLogger(typeof(tb_Article_SortDao));
    
    #region 代码系统生成
    //添加产品
     public int Inserttb_Article_SortEntity(Dictionary<String,Object> param)
    {
        try
        {
           return int.Parse(Insert("tb_Article_SortEntity.insert", param).ToString());
        }
        catch (Exception ex)
        {
            new LoassException("添加tb_Article_SortEntity出错", log, ex);
            return -1;
        }
    }
    
    //更新产品
     public int Updatetb_Article_SortEntity(Dictionary<String,Object> param)
    {
        try
        {
           
            return Update("tb_Article_SortEntity.update", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("更新tb_Article_SortEntity出错", log, ex);
            return -1;
        }
    }
    
    //删除产品
     public int Deletetb_Article_SortEntity(String id)
    {
        try
        {
            return Delete("tb_Article_SortEntity.delete", id);
        }
        catch (System.Exception ex)
        {
            new LoassException("删除tb_Article_SortEntity出错", log, ex);
            return -1;
        }
    }
    //查找
    public tb_Article_SortEntity Selecttb_Article_SortEntity(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<tb_Article_SortEntity>("tb_Article_SortEntity.select", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取tb_Article_SortEntity实体失败", log, ex);
            return null;
        }
    }
    
        /// <summary>
        /// 获取实体列表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IList Selecttb_Article_SortEntityList(Dictionary<String,Object> param)
        {
            try
            {
                return SqlMapper.QueryForList("tb_Article_SortEntity.select", param);
            }
            catch (System.Exception ex)
            {
                new LoassException("获取tb_Article_SortEntity实体列表失败", log, ex);
                return null;
            }
        }
    
    
    //获取产品总数
    public int Gettb_Article_SortEntityCount(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<int>("tb_Article_SortEntity.tb_article_sort_count", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取产品tb_Article_SortEntity总的条数失败", log, ex);
            return 0;
        }
    }
    
    //分页
    public IList Get_tb_Article_SortEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        recordCount = -1;
        IList list = null;
        try
        {

            recordCount = SqlMapper.QueryForObject<int>("tb_Article_SortEntity.tb_article_sort_count", param);
          
            int totalPage = recordCount / pageSize;
            if (recordCount % pageSize != 0)
                totalPage++;

            param.Add("startId", (currentPage - 1) * pageSize + 1);
            param.Add("endId", currentPage * pageSize);
            list = SqlMapper.QueryForList("tb_Article_SortEntity.tb_article_sort_list", param);

            return list;
        }
        catch (System.Exception ex)
        {
            new LoassException("tb_Article_SortEntity产品分页出错", log, ex);
            return null;
        }
    }
    #endregion
}
}
