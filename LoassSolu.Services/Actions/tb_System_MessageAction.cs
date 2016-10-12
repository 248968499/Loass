
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_System_MessageAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_System_MessageEntity(Dictionary<String,Object> param)
    {
        tb_System_MessageDao tb_system_messageDao = new tb_System_MessageDao();
        return tb_system_messageDao.Inserttb_System_MessageEntity(param);
    }
    
    //更新产品
     public static int Updatetb_System_MessageEntity(Dictionary<String,Object> param)
    {
        tb_System_MessageDao tb_system_messageDao = new tb_System_MessageDao();
        return tb_system_messageDao.Updatetb_System_MessageEntity(param);
    }
    
    //删除产品
     public static int Deletetb_System_MessageEntity(String id)
    {
        tb_System_MessageDao tb_system_messageDao = new tb_System_MessageDao();
        return tb_system_messageDao.Deletetb_System_MessageEntity(id);
    }
    //查找
    public static tb_System_MessageEntity Selecttb_System_MessageEntity(Dictionary<String,Object> param)
    {
        tb_System_MessageDao tb_system_messageDao = new tb_System_MessageDao();
        return tb_system_messageDao.Selecttb_System_MessageEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_System_MessageEntityList(Dictionary<String,Object> param)
    {
        tb_System_MessageDao tb_system_messageDao = new tb_System_MessageDao();
        return tb_system_messageDao.Selecttb_System_MessageEntityList(param);
    }

    
    //分页
    public static IList Get_tb_System_MessageEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_System_MessageDao tb_system_messageDao = new tb_System_MessageDao();
        return tb_system_messageDao.Get_tb_System_MessageEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

