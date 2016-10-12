
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_Friendly_LinkAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_Friendly_LinkEntity(Dictionary<String,Object> param)
    {
        tb_Friendly_LinkDao tb_friendly_linkDao = new tb_Friendly_LinkDao();
        return tb_friendly_linkDao.Inserttb_Friendly_LinkEntity(param);
    }
    
    //更新产品
     public static int Updatetb_Friendly_LinkEntity(Dictionary<String,Object> param)
    {
        tb_Friendly_LinkDao tb_friendly_linkDao = new tb_Friendly_LinkDao();
        return tb_friendly_linkDao.Updatetb_Friendly_LinkEntity(param);
    }
    
    //删除产品
     public static int Deletetb_Friendly_LinkEntity(String id)
    {
        tb_Friendly_LinkDao tb_friendly_linkDao = new tb_Friendly_LinkDao();
        return tb_friendly_linkDao.Deletetb_Friendly_LinkEntity(id);
    }
    //查找
    public static tb_Friendly_LinkEntity Selecttb_Friendly_LinkEntity(Dictionary<String,Object> param)
    {
        tb_Friendly_LinkDao tb_friendly_linkDao = new tb_Friendly_LinkDao();
        return tb_friendly_linkDao.Selecttb_Friendly_LinkEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_Friendly_LinkEntityList(Dictionary<String,Object> param)
    {
        tb_Friendly_LinkDao tb_friendly_linkDao = new tb_Friendly_LinkDao();
        return tb_friendly_linkDao.Selecttb_Friendly_LinkEntityList(param);
    }

    
    //分页
    public static IList Get_tb_Friendly_LinkEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_Friendly_LinkDao tb_friendly_linkDao = new tb_Friendly_LinkDao();
        return tb_friendly_linkDao.Get_tb_Friendly_LinkEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

