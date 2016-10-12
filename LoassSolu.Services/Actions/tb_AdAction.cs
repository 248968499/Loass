
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_AdAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_AdEntity(Dictionary<String,Object> param)
    {
        tb_AdDao tb_adDao = new tb_AdDao();
        return tb_adDao.Inserttb_AdEntity(param);
    }
    
    //更新产品
     public static int Updatetb_AdEntity(Dictionary<String,Object> param)
    {
        tb_AdDao tb_adDao = new tb_AdDao();
        return tb_adDao.Updatetb_AdEntity(param);
    }
    
    //删除产品
     public static int Deletetb_AdEntity(String id)
    {
        tb_AdDao tb_adDao = new tb_AdDao();
        return tb_adDao.Deletetb_AdEntity(id);
    }
    //查找
    public static tb_AdEntity Selecttb_AdEntity(Dictionary<String,Object> param)
    {
        tb_AdDao tb_adDao = new tb_AdDao();
        return tb_adDao.Selecttb_AdEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_AdEntityList(Dictionary<String,Object> param)
    {
        tb_AdDao tb_adDao = new tb_AdDao();
        return tb_adDao.Selecttb_AdEntityList(param);
    }

    
    //分页
    public static IList Get_tb_AdEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_AdDao tb_adDao = new tb_AdDao();
        return tb_adDao.Get_tb_AdEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

