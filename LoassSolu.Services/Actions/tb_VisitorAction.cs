
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_VisitorAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_VisitorEntity(Dictionary<String,Object> param)
    {
        tb_VisitorDao tb_visitorDao = new tb_VisitorDao();
        return tb_visitorDao.Inserttb_VisitorEntity(param);
    }
    
    //更新产品
     public static int Updatetb_VisitorEntity(Dictionary<String,Object> param)
    {
        tb_VisitorDao tb_visitorDao = new tb_VisitorDao();
        return tb_visitorDao.Updatetb_VisitorEntity(param);
    }
    
    //删除产品
     public static int Deletetb_VisitorEntity(String id)
    {
        tb_VisitorDao tb_visitorDao = new tb_VisitorDao();
        return tb_visitorDao.Deletetb_VisitorEntity(id);
    }
    //查找
    public static tb_VisitorEntity Selecttb_VisitorEntity(Dictionary<String,Object> param)
    {
        tb_VisitorDao tb_visitorDao = new tb_VisitorDao();
        return tb_visitorDao.Selecttb_VisitorEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_VisitorEntityList(Dictionary<String,Object> param)
    {
        tb_VisitorDao tb_visitorDao = new tb_VisitorDao();
        return tb_visitorDao.Selecttb_VisitorEntityList(param);
    }

    
    //分页
    public static IList Get_tb_VisitorEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_VisitorDao tb_visitorDao = new tb_VisitorDao();
        return tb_visitorDao.Get_tb_VisitorEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

