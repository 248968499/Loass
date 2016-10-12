
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_Secret_MessageAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_Secret_MessageEntity(Dictionary<String,Object> param)
    {
        tb_Secret_MessageDao tb_secret_messageDao = new tb_Secret_MessageDao();
        return tb_secret_messageDao.Inserttb_Secret_MessageEntity(param);
    }
    
    //更新产品
     public static int Updatetb_Secret_MessageEntity(Dictionary<String,Object> param)
    {
        tb_Secret_MessageDao tb_secret_messageDao = new tb_Secret_MessageDao();
        return tb_secret_messageDao.Updatetb_Secret_MessageEntity(param);
    }
    
    //删除产品
     public static int Deletetb_Secret_MessageEntity(String id)
    {
        tb_Secret_MessageDao tb_secret_messageDao = new tb_Secret_MessageDao();
        return tb_secret_messageDao.Deletetb_Secret_MessageEntity(id);
    }
    //查找
    public static tb_Secret_MessageEntity Selecttb_Secret_MessageEntity(Dictionary<String,Object> param)
    {
        tb_Secret_MessageDao tb_secret_messageDao = new tb_Secret_MessageDao();
        return tb_secret_messageDao.Selecttb_Secret_MessageEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_Secret_MessageEntityList(Dictionary<String,Object> param)
    {
        tb_Secret_MessageDao tb_secret_messageDao = new tb_Secret_MessageDao();
        return tb_secret_messageDao.Selecttb_Secret_MessageEntityList(param);
    }

    
    //分页
    public static IList Get_tb_Secret_MessageEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_Secret_MessageDao tb_secret_messageDao = new tb_Secret_MessageDao();
        return tb_secret_messageDao.Get_tb_Secret_MessageEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

