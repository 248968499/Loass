﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using log4net;
using LoassSolu.Errors;
using LoassSolu.Services.Entities;

namespace LoassSolu.Services.DAOS
{
public class tb_AdDao : BaseDao
{
    private static readonly ILog log = LogManager.GetLogger(typeof(tb_AdDao));
    
    #region 代码系统生成
    //添加产品
     public int Inserttb_AdEntity(Dictionary<String,Object> param)
    {
        try
        {
           return int.Parse(Insert("tb_AdEntity.insert", param).ToString());
        }
        catch (Exception ex)
        {
            new LoassException("添加tb_AdEntity出错", log, ex);
            return -1;
        }
    }
    
    //更新产品
     public int Updatetb_AdEntity(Dictionary<String,Object> param)
    {
        try
        {
           
            return Update("tb_AdEntity.update", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("更新tb_AdEntity出错", log, ex);
            return -1;
        }
    }
    
    //删除产品
     public int Deletetb_AdEntity(String id)
    {
        try
        {
            return Delete("tb_AdEntity.delete", id);
        }
        catch (System.Exception ex)
        {
            new LoassException("删除tb_AdEntity出错", log, ex);
            return -1;
        }
    }
    //查找
    public tb_AdEntity Selecttb_AdEntity(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<tb_AdEntity>("tb_AdEntity.select", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取tb_AdEntity实体失败", log, ex);
            return null;
        }
    }
    
        /// <summary>
        /// 获取实体列表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IList Selecttb_AdEntityList(Dictionary<String,Object> param)
        {
            try
            {
                return SqlMapper.QueryForList("tb_AdEntity.select", param);
            }
            catch (System.Exception ex)
            {
                new LoassException("获取tb_AdEntity实体列表失败", log, ex);
                return null;
            }
        }
    
    
    //获取产品总数
    public int Gettb_AdEntityCount(Dictionary<String,Object> param)
    {
        try
        {
            return SqlMapper.QueryForObject<int>("tb_AdEntity.tb_ad_count", param);
        }
        catch (System.Exception ex)
        {
            new LoassException("获取产品tb_AdEntity总的条数失败", log, ex);
            return 0;
        }
    }
    
    //分页
    public IList Get_tb_AdEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        recordCount = -1;
        IList list = null;
        try
        {

            recordCount = SqlMapper.QueryForObject<int>("tb_AdEntity.tb_ad_count", param);
          
            int totalPage = recordCount / pageSize;
            if (recordCount % pageSize != 0)
                totalPage++;

            param.Add("startId", (currentPage - 1) * pageSize + 1);
            param.Add("endId", currentPage * pageSize);
            list = SqlMapper.QueryForList("tb_AdEntity.tb_ad_list", param);

            return list;
        }
        catch (System.Exception ex)
        {
            new LoassException("tb_AdEntity产品分页出错", log, ex);
            return null;
        }
    }
    #endregion
}
}
