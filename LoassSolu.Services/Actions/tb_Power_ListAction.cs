
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_Power_ListAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_Power_ListEntity(Dictionary<String,Object> param)
    {
        tb_Power_ListDao tb_power_listDao = new tb_Power_ListDao();
        return tb_power_listDao.Inserttb_Power_ListEntity(param);
    }
    
    //更新产品
     public static int Updatetb_Power_ListEntity(Dictionary<String,Object> param)
    {
        tb_Power_ListDao tb_power_listDao = new tb_Power_ListDao();
        return tb_power_listDao.Updatetb_Power_ListEntity(param);
    }
    
    //删除产品
     public static int Deletetb_Power_ListEntity(String id)
    {
        tb_Power_ListDao tb_power_listDao = new tb_Power_ListDao();
        return tb_power_listDao.Deletetb_Power_ListEntity(id);
    }
    //查找
    public static tb_Power_ListEntity Selecttb_Power_ListEntity(Dictionary<String,Object> param)
    {
        tb_Power_ListDao tb_power_listDao = new tb_Power_ListDao();
        return tb_power_listDao.Selecttb_Power_ListEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_Power_ListEntityList(Dictionary<String,Object> param)
    {
        tb_Power_ListDao tb_power_listDao = new tb_Power_ListDao();
        return tb_power_listDao.Selecttb_Power_ListEntityList(param);
    }

    
    //分页
    public static IList Get_tb_Power_ListEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_Power_ListDao tb_power_listDao = new tb_Power_ListDao();
        return tb_power_listDao.Get_tb_Power_ListEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

