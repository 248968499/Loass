
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.DAOS;
using LoassSolu.Services.Entities;

namespace LoassSolu.Services.Actions
{
public class tb_User_RankAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_User_RankEntity(Dictionary<String,Object> param)
    {
        tb_User_RankDao tb_user_rankDao = new tb_User_RankDao();
        return tb_user_rankDao.Inserttb_User_RankEntity(param);
    }
    
    //更新产品
     public static int Updatetb_User_RankEntity(Dictionary<String,Object> param)
    {
        tb_User_RankDao tb_user_rankDao = new tb_User_RankDao();
        return tb_user_rankDao.Updatetb_User_RankEntity(param);
    }
    
    //删除产品
     public static int Deletetb_User_RankEntity(String id)
    {
        tb_User_RankDao tb_user_rankDao = new tb_User_RankDao();
        return tb_user_rankDao.Deletetb_User_RankEntity(id);
    }
    //查找
    public static tb_User_RankEntity Selecttb_User_RankEntity(Dictionary<String,Object> param)
    {
        tb_User_RankDao tb_user_rankDao = new tb_User_RankDao();
        return tb_user_rankDao.Selecttb_User_RankEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_User_RankEntityList(Dictionary<String,Object> param)
    {
        tb_User_RankDao tb_user_rankDao = new tb_User_RankDao();
        return tb_user_rankDao.Selecttb_User_RankEntityList(param);
    }

    
    //分页
    public static IList Get_tb_User_RankEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_User_RankDao tb_user_rankDao = new tb_User_RankDao();
        return tb_user_rankDao.Get_tb_User_RankEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

