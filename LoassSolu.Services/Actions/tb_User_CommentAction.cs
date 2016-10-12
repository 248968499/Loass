
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.DAOS;
using LoassSolu.Services.Entities;

namespace LoassSolu.Services.Actions
{
public class tb_User_CommentAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_User_CommentEntity(Dictionary<String,Object> param)
    {
        tb_User_CommentDao tb_user_commentDao = new tb_User_CommentDao();
        return tb_user_commentDao.Inserttb_User_CommentEntity(param);
    }
    
    //更新产品
     public static int Updatetb_User_CommentEntity(Dictionary<String,Object> param)
    {
        tb_User_CommentDao tb_user_commentDao = new tb_User_CommentDao();
        return tb_user_commentDao.Updatetb_User_CommentEntity(param);
    }
    
    //删除产品
     public static int Deletetb_User_CommentEntity(String id)
    {
        tb_User_CommentDao tb_user_commentDao = new tb_User_CommentDao();
        return tb_user_commentDao.Deletetb_User_CommentEntity(id);
    }
    //查找
    public static tb_User_CommentEntity Selecttb_User_CommentEntity(Dictionary<String,Object> param)
    {
        tb_User_CommentDao tb_user_commentDao = new tb_User_CommentDao();
        return tb_user_commentDao.Selecttb_User_CommentEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_User_CommentEntityList(Dictionary<String,Object> param)
    {
        tb_User_CommentDao tb_user_commentDao = new tb_User_CommentDao();
        return tb_user_commentDao.Selecttb_User_CommentEntityList(param);
    }

    
    //分页
    public static IList Get_tb_User_CommentEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_User_CommentDao tb_user_commentDao = new tb_User_CommentDao();
        return tb_user_commentDao.Get_tb_User_CommentEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

