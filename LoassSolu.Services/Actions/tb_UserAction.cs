
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_UserAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_UserEntity(Dictionary<String,Object> param)
    {
        tb_UserDao tb_userDao = new tb_UserDao();
        return tb_userDao.Inserttb_UserEntity(param);
    }
    
    //更新产品
     public static int Updatetb_UserEntity(Dictionary<String,Object> param)
    {
        tb_UserDao tb_userDao = new tb_UserDao();
        return tb_userDao.Updatetb_UserEntity(param);
    }
    
    //删除产品
     public static int Deletetb_UserEntity(String id)
    {
        tb_UserDao tb_userDao = new tb_UserDao();
        return tb_userDao.Deletetb_UserEntity(id);
    }
    //查找
    public static tb_UserEntity Selecttb_UserEntity(Dictionary<String,Object> param)
    {
        tb_UserDao tb_userDao = new tb_UserDao();
        return tb_userDao.Selecttb_UserEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_UserEntityList(Dictionary<String,Object> param)
    {
        tb_UserDao tb_userDao = new tb_UserDao();
        return tb_userDao.Selecttb_UserEntityList(param);
    }

    
    //分页
    public static IList Get_tb_UserEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_UserDao tb_userDao = new tb_UserDao();
        return tb_userDao.Get_tb_UserEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

