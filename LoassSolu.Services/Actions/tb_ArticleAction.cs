
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_ArticleAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_ArticleEntity(Dictionary<String,Object> param)
    {
        tb_ArticleDao tb_articleDao = new tb_ArticleDao();
        return tb_articleDao.Inserttb_ArticleEntity(param);
    }
    
    //更新产品
     public static int Updatetb_ArticleEntity(Dictionary<String,Object> param)
    {
        tb_ArticleDao tb_articleDao = new tb_ArticleDao();
        return tb_articleDao.Updatetb_ArticleEntity(param);
    }
    
    //删除产品
     public static int Deletetb_ArticleEntity(String id)
    {
        tb_ArticleDao tb_articleDao = new tb_ArticleDao();
        return tb_articleDao.Deletetb_ArticleEntity(id);
    }
    //查找
    public static tb_ArticleEntity Selecttb_ArticleEntity(Dictionary<String,Object> param)
    {
        tb_ArticleDao tb_articleDao = new tb_ArticleDao();
        return tb_articleDao.Selecttb_ArticleEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_ArticleEntityList(Dictionary<String,Object> param)
    {
        tb_ArticleDao tb_articleDao = new tb_ArticleDao();
        return tb_articleDao.Selecttb_ArticleEntityList(param);
    }

    
    //分页
    public static IList Get_tb_ArticleEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_ArticleDao tb_articleDao = new tb_ArticleDao();
        return tb_articleDao.Get_tb_ArticleEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

