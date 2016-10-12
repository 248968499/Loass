using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Errors;
using log4net;
using LoassSolu.Services.Entities;

namespace LoassSolu.Services.DAOS
{
public class tb_Group_PowerDao : BaseDao
{
    private static readonly ILog log = LogManager.GetLogger(typeof(tb_Group_PowerDao));
    
    #region 代码系统生成
    //添加产品
     public int Inserttb_Group_PowerEntity(Dictionary<String,Object> param)
    {
        try
        {
           return int.Parse(Insert("tb_Group_PowerEntity.insert", param).ToString());
        }
        catch (Exception ex)
        {
            new LoassException("添加tb_Group_PowerEntity出错", log, ex);
            return -1;
        }
    }
    
    //更新产品
     public int Updatetb_Group_PowerEntity(Dictionary<String,Object> param)
    {
        try
        {
           
            return Update("tb_Group_PowerEntity.update", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("更新tb_Group_PowerEntity出错", log, ex);
            return -1;
        }
    }
    
    //删除产品
     public int Deletetb_Group_PowerEntity(String id)
    {
        try
        {
            return Delete("tb_Group_PowerEntity.delete", id);
        }
        catch (System.Exception ex)
        {
            new LoassException("删除tb_Group_PowerEntity出错", log, ex);
            return -1;
        }
    }
    //查找
    public tb_Group_PowerEntity Selecttb_Group_PowerEntity(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<tb_Group_PowerEntity>("tb_Group_PowerEntity.select", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取tb_Group_PowerEntity实体失败", log, ex);
            return null;
        }
    }
    
        /// <summary>
        /// 获取实体列表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IList Selecttb_Group_PowerEntityList(Dictionary<String,Object> param)
        {
            try
            {
                return SqlMapper.QueryForList("tb_Group_PowerEntity.select", param);
            }
            catch (System.Exception ex)
            {
                new LoassException("获取tb_Group_PowerEntity实体列表失败", log, ex);
                return null;
            }
        }
    
    
    //获取产品总数
    public int Gettb_Group_PowerEntityCount(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<int>("tb_Group_PowerEntity.tb_group_power_count", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取产品tb_Group_PowerEntity总的条数失败", log, ex);
            return 0;
        }
    }
    
    //分页
    public IList Get_tb_Group_PowerEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        recordCount = -1;
        IList list = null;
        try
        {

            recordCount = SqlMapper.QueryForObject<int>("tb_Group_PowerEntity.tb_group_power_count", param);
          
            int totalPage = recordCount / pageSize;
            if (recordCount % pageSize != 0)
                totalPage++;

            param.Add("startId", (currentPage - 1) * pageSize + 1);
            param.Add("endId", currentPage * pageSize);
            list = SqlMapper.QueryForList("tb_Group_PowerEntity.tb_group_power_list", param);

            return list;
        }
        catch (System.Exception ex)
        {
            new LoassException("tb_Group_PowerEntity产品分页出错", log, ex);
            return null;
        }
    }
    #endregion
}
}
