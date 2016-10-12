
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_User_GroupAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_User_GroupEntity(Dictionary<String,Object> param)
    {
        tb_User_GroupDao tb_user_groupDao = new tb_User_GroupDao();
        return tb_user_groupDao.Inserttb_User_GroupEntity(param);
    }
    
    //更新产品
     public static int Updatetb_User_GroupEntity(Dictionary<String,Object> param)
    {
        tb_User_GroupDao tb_user_groupDao = new tb_User_GroupDao();
        return tb_user_groupDao.Updatetb_User_GroupEntity(param);
    }
    
    //删除产品
     public static int Deletetb_User_GroupEntity(String id)
    {
        tb_User_GroupDao tb_user_groupDao = new tb_User_GroupDao();
        return tb_user_groupDao.Deletetb_User_GroupEntity(id);
    }
    //查找
    public static tb_User_GroupEntity Selecttb_User_GroupEntity(Dictionary<String,Object> param)
    {
        tb_User_GroupDao tb_user_groupDao = new tb_User_GroupDao();
        return tb_user_groupDao.Selecttb_User_GroupEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_User_GroupEntityList(Dictionary<String,Object> param)
    {
        tb_User_GroupDao tb_user_groupDao = new tb_User_GroupDao();
        return tb_user_groupDao.Selecttb_User_GroupEntityList(param);
    }

    
    //分页
    public static IList Get_tb_User_GroupEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_User_GroupDao tb_user_groupDao = new tb_User_GroupDao();
        return tb_user_groupDao.Get_tb_User_GroupEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

