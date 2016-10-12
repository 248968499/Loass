
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_About_BlogAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_About_BlogEntity(Dictionary<String,Object> param)
    {
        tb_About_BlogDao tb_about_blogDao = new tb_About_BlogDao();
        return tb_about_blogDao.Inserttb_About_BlogEntity(param);
    }
    
    //更新产品
     public static int Updatetb_About_BlogEntity(Dictionary<String,Object> param)
    {
        tb_About_BlogDao tb_about_blogDao = new tb_About_BlogDao();
        return tb_about_blogDao.Updatetb_About_BlogEntity(param);
    }
    
    //删除产品
     public static int Deletetb_About_BlogEntity(String id)
    {
        tb_About_BlogDao tb_about_blogDao = new tb_About_BlogDao();
        return tb_about_blogDao.Deletetb_About_BlogEntity(id);
    }
    //查找
    public static tb_About_BlogEntity Selecttb_About_BlogEntity(Dictionary<String,Object> param)
    {
        tb_About_BlogDao tb_about_blogDao = new tb_About_BlogDao();
        return tb_about_blogDao.Selecttb_About_BlogEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_About_BlogEntityList(Dictionary<String,Object> param)
    {
        tb_About_BlogDao tb_about_blogDao = new tb_About_BlogDao();
        return tb_about_blogDao.Selecttb_About_BlogEntityList(param);
    }

    
    //分页
    public static IList Get_tb_About_BlogEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_About_BlogDao tb_about_blogDao = new tb_About_BlogDao();
        return tb_about_blogDao.Get_tb_About_BlogEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

