
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_ShuoshuoAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_ShuoshuoEntity(Dictionary<String,Object> param)
    {
        tb_ShuoshuoDao tb_shuoshuoDao = new tb_ShuoshuoDao();
        return tb_shuoshuoDao.Inserttb_ShuoshuoEntity(param);
    }
    
    //更新产品
     public static int Updatetb_ShuoshuoEntity(Dictionary<String,Object> param)
    {
        tb_ShuoshuoDao tb_shuoshuoDao = new tb_ShuoshuoDao();
        return tb_shuoshuoDao.Updatetb_ShuoshuoEntity(param);
    }
    
    //删除产品
     public static int Deletetb_ShuoshuoEntity(String id)
    {
        tb_ShuoshuoDao tb_shuoshuoDao = new tb_ShuoshuoDao();
        return tb_shuoshuoDao.Deletetb_ShuoshuoEntity(id);
    }
    //查找
    public static tb_ShuoshuoEntity Selecttb_ShuoshuoEntity(Dictionary<String,Object> param)
    {
        tb_ShuoshuoDao tb_shuoshuoDao = new tb_ShuoshuoDao();
        return tb_shuoshuoDao.Selecttb_ShuoshuoEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_ShuoshuoEntityList(Dictionary<String,Object> param)
    {
        tb_ShuoshuoDao tb_shuoshuoDao = new tb_ShuoshuoDao();
        return tb_shuoshuoDao.Selecttb_ShuoshuoEntityList(param);
    }

    
    //分页
    public static IList Get_tb_ShuoshuoEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_ShuoshuoDao tb_shuoshuoDao = new tb_ShuoshuoDao();
        return tb_shuoshuoDao.Get_tb_ShuoshuoEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

