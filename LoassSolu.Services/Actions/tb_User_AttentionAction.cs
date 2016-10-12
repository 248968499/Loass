
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_User_AttentionAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_User_AttentionEntity(Dictionary<String,Object> param)
    {
        tb_User_AttentionDao tb_user_attentionDao = new tb_User_AttentionDao();
        return tb_user_attentionDao.Inserttb_User_AttentionEntity(param);
    }
    
    //更新产品
     public static int Updatetb_User_AttentionEntity(Dictionary<String,Object> param)
    {
        tb_User_AttentionDao tb_user_attentionDao = new tb_User_AttentionDao();
        return tb_user_attentionDao.Updatetb_User_AttentionEntity(param);
    }
    
    //删除产品
     public static int Deletetb_User_AttentionEntity(String id)
    {
        tb_User_AttentionDao tb_user_attentionDao = new tb_User_AttentionDao();
        return tb_user_attentionDao.Deletetb_User_AttentionEntity(id);
    }
    //查找
    public static tb_User_AttentionEntity Selecttb_User_AttentionEntity(Dictionary<String,Object> param)
    {
        tb_User_AttentionDao tb_user_attentionDao = new tb_User_AttentionDao();
        return tb_user_attentionDao.Selecttb_User_AttentionEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_User_AttentionEntityList(Dictionary<String,Object> param)
    {
        tb_User_AttentionDao tb_user_attentionDao = new tb_User_AttentionDao();
        return tb_user_attentionDao.Selecttb_User_AttentionEntityList(param);
    }

    
    //分页
    public static IList Get_tb_User_AttentionEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_User_AttentionDao tb_user_attentionDao = new tb_User_AttentionDao();
        return tb_user_attentionDao.Get_tb_User_AttentionEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

