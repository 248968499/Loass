
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_User_PowerAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_User_PowerEntity(Dictionary<String,Object> param)
    {
        tb_User_PowerDao tb_user_powerDao = new tb_User_PowerDao();
        return tb_user_powerDao.Inserttb_User_PowerEntity(param);
    }
    
    //更新产品
     public static int Updatetb_User_PowerEntity(Dictionary<String,Object> param)
    {
        tb_User_PowerDao tb_user_powerDao = new tb_User_PowerDao();
        return tb_user_powerDao.Updatetb_User_PowerEntity(param);
    }
    
    //删除产品
     public static int Deletetb_User_PowerEntity(String id)
    {
        tb_User_PowerDao tb_user_powerDao = new tb_User_PowerDao();
        return tb_user_powerDao.Deletetb_User_PowerEntity(id);
    }
    //查找
    public static tb_User_PowerEntity Selecttb_User_PowerEntity(Dictionary<String,Object> param)
    {
        tb_User_PowerDao tb_user_powerDao = new tb_User_PowerDao();
        return tb_user_powerDao.Selecttb_User_PowerEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_User_PowerEntityList(Dictionary<String,Object> param)
    {
        tb_User_PowerDao tb_user_powerDao = new tb_User_PowerDao();
        return tb_user_powerDao.Selecttb_User_PowerEntityList(param);
    }

    
    //分页
    public static IList Get_tb_User_PowerEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_User_PowerDao tb_user_powerDao = new tb_User_PowerDao();
        return tb_user_powerDao.Get_tb_User_PowerEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

