
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_Article_SortAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_Article_SortEntity(Dictionary<String,Object> param)
    {
        tb_Article_SortDao tb_article_sortDao = new tb_Article_SortDao();
        return tb_article_sortDao.Inserttb_Article_SortEntity(param);
    }
    
    //更新产品
     public static int Updatetb_Article_SortEntity(Dictionary<String,Object> param)
    {
        tb_Article_SortDao tb_article_sortDao = new tb_Article_SortDao();
        return tb_article_sortDao.Updatetb_Article_SortEntity(param);
    }
    
    //删除产品
     public static int Deletetb_Article_SortEntity(String id)
    {
        tb_Article_SortDao tb_article_sortDao = new tb_Article_SortDao();
        return tb_article_sortDao.Deletetb_Article_SortEntity(id);
    }
    //查找
    public static tb_Article_SortEntity Selecttb_Article_SortEntity(Dictionary<String,Object> param)
    {
        tb_Article_SortDao tb_article_sortDao = new tb_Article_SortDao();
        return tb_article_sortDao.Selecttb_Article_SortEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_Article_SortEntityList(Dictionary<String,Object> param)
    {
        tb_Article_SortDao tb_article_sortDao = new tb_Article_SortDao();
        return tb_article_sortDao.Selecttb_Article_SortEntityList(param);
    }

    
    //分页
    public static IList Get_tb_Article_SortEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_Article_SortDao tb_article_sortDao = new tb_Article_SortDao();
        return tb_article_sortDao.Get_tb_Article_SortEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

