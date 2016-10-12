
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_FriendAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_FriendEntity(Dictionary<String,Object> param)
    {
        tb_FriendDao tb_friendDao = new tb_FriendDao();
        return tb_friendDao.Inserttb_FriendEntity(param);
    }
    
    //更新产品
     public static int Updatetb_FriendEntity(Dictionary<String,Object> param)
    {
        tb_FriendDao tb_friendDao = new tb_FriendDao();
        return tb_friendDao.Updatetb_FriendEntity(param);
    }
    
    //删除产品
     public static int Deletetb_FriendEntity(String id)
    {
        tb_FriendDao tb_friendDao = new tb_FriendDao();
        return tb_friendDao.Deletetb_FriendEntity(id);
    }
    //查找
    public static tb_FriendEntity Selecttb_FriendEntity(Dictionary<String,Object> param)
    {
        tb_FriendDao tb_friendDao = new tb_FriendDao();
        return tb_friendDao.Selecttb_FriendEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_FriendEntityList(Dictionary<String,Object> param)
    {
        tb_FriendDao tb_friendDao = new tb_FriendDao();
        return tb_friendDao.Selecttb_FriendEntityList(param);
    }

    
    //分页
    public static IList Get_tb_FriendEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_FriendDao tb_friendDao = new tb_FriendDao();
        return tb_friendDao.Get_tb_FriendEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

