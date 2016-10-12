using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Errors;
using log4net;

namespace LoassSolu.Services.DAOS
{
public class tb_About_BlogDao : BaseDao
{
    private static readonly ILog log = LogManager.GetLogger(typeof(tb_About_BlogDao));
    
    #region 代码系统生成
    //添加产品
     public int Inserttb_About_BlogEntity(Dictionary<String,Object> param)
    {
        try
        {
           return int.Parse(Insert("tb_About_BlogEntity.insert", param).ToString());
        }
        catch (Exception ex)
        {
            new LoassException("添加tb_About_BlogEntity出错", log, ex);
            return -1;
        }
    }
    
    //更新产品
     public int Updatetb_About_BlogEntity(Dictionary<String,Object> param)
    {
        try
        {
           
            return Update("tb_About_BlogEntity.update", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("更新tb_About_BlogEntity出错", log, ex);
            return -1;
        }
    }
    
    //删除产品
     public int Deletetb_About_BlogEntity(String id)
    {
        try
        {
            return Delete("tb_About_BlogEntity.delete", id);
        }
        catch (System.Exception ex)
        {
            new LoassException("删除tb_About_BlogEntity出错", log, ex);
            return -1;
        }
    }
    //查找
    public tb_About_BlogEntity Selecttb_About_BlogEntity(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<tb_About_BlogEntity>("tb_About_BlogEntity.select", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取tb_About_BlogEntity实体失败", log, ex);
            return null;
        }
    }
    
        /// <summary>
        /// 获取实体列表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IList Selecttb_About_BlogEntityList(Dictionary<String,Object> param)
        {
            try
            {
                return SqlMapper.QueryForList("tb_About_BlogEntity.select", param);
            }
            catch (System.Exception ex)
            {
                new LoassException("获取tb_About_BlogEntity实体列表失败", log, ex);
                return null;
            }
        }
    
    
    //获取产品总数
    public int Gettb_About_BlogEntityCount(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<int>("tb_About_BlogEntity.tb_about_blog_count", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取产品tb_About_BlogEntity总的条数失败", log, ex);
            return 0;
        }
    }
    
    //分页
    public IList Get_tb_About_BlogEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        recordCount = -1;
        IList list = null;
        try
        {

            recordCount = SqlMapper.QueryForObject<int>("tb_About_BlogEntity.tb_about_blog_count", param);
          
            int totalPage = recordCount / pageSize;
            if (recordCount % pageSize != 0)
                totalPage++;

            param.Add("startId", (currentPage - 1) * pageSize + 1);
            param.Add("endId", currentPage * pageSize);
            list = SqlMapper.QueryForList("tb_About_BlogEntity.tb_about_blog_list", param);

            return list;
        }
        catch (System.Exception ex)
        {
            new LoassException("tb_About_BlogEntity产品分页出错", log, ex);
            return null;
        }
    }
    #endregion
}
}
