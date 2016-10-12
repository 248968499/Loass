
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_Phone_MessageAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_Phone_MessageEntity(Dictionary<String,Object> param)
    {
        tb_Phone_MessageDao tb_phone_messageDao = new tb_Phone_MessageDao();
        return tb_phone_messageDao.Inserttb_Phone_MessageEntity(param);
    }
    
    //更新产品
     public static int Updatetb_Phone_MessageEntity(Dictionary<String,Object> param)
    {
        tb_Phone_MessageDao tb_phone_messageDao = new tb_Phone_MessageDao();
        return tb_phone_messageDao.Updatetb_Phone_MessageEntity(param);
    }
    
    //删除产品
     public static int Deletetb_Phone_MessageEntity(String id)
    {
        tb_Phone_MessageDao tb_phone_messageDao = new tb_Phone_MessageDao();
        return tb_phone_messageDao.Deletetb_Phone_MessageEntity(id);
    }
    //查找
    public static tb_Phone_MessageEntity Selecttb_Phone_MessageEntity(Dictionary<String,Object> param)
    {
        tb_Phone_MessageDao tb_phone_messageDao = new tb_Phone_MessageDao();
        return tb_phone_messageDao.Selecttb_Phone_MessageEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_Phone_MessageEntityList(Dictionary<String,Object> param)
    {
        tb_Phone_MessageDao tb_phone_messageDao = new tb_Phone_MessageDao();
        return tb_phone_messageDao.Selecttb_Phone_MessageEntityList(param);
    }

    
    //分页
    public static IList Get_tb_Phone_MessageEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_Phone_MessageDao tb_phone_messageDao = new tb_Phone_MessageDao();
        return tb_phone_messageDao.Get_tb_Phone_MessageEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

