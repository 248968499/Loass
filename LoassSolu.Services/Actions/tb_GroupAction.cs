
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_GroupAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_GroupEntity(Dictionary<String,Object> param)
    {
        tb_GroupDao tb_groupDao = new tb_GroupDao();
        return tb_groupDao.Inserttb_GroupEntity(param);
    }
    
    //更新产品
     public static int Updatetb_GroupEntity(Dictionary<String,Object> param)
    {
        tb_GroupDao tb_groupDao = new tb_GroupDao();
        return tb_groupDao.Updatetb_GroupEntity(param);
    }
    
    //删除产品
     public static int Deletetb_GroupEntity(String id)
    {
        tb_GroupDao tb_groupDao = new tb_GroupDao();
        return tb_groupDao.Deletetb_GroupEntity(id);
    }
    //查找
    public static tb_GroupEntity Selecttb_GroupEntity(Dictionary<String,Object> param)
    {
        tb_GroupDao tb_groupDao = new tb_GroupDao();
        return tb_groupDao.Selecttb_GroupEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_GroupEntityList(Dictionary<String,Object> param)
    {
        tb_GroupDao tb_groupDao = new tb_GroupDao();
        return tb_groupDao.Selecttb_GroupEntityList(param);
    }

    
    //分页
    public static IList Get_tb_GroupEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_GroupDao tb_groupDao = new tb_GroupDao();
        return tb_groupDao.Get_tb_GroupEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

