
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_Photo_SortAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_Photo_SortEntity(Dictionary<String,Object> param)
    {
        tb_Photo_SortDao tb_photo_sortDao = new tb_Photo_SortDao();
        return tb_photo_sortDao.Inserttb_Photo_SortEntity(param);
    }
    
    //更新产品
     public static int Updatetb_Photo_SortEntity(Dictionary<String,Object> param)
    {
        tb_Photo_SortDao tb_photo_sortDao = new tb_Photo_SortDao();
        return tb_photo_sortDao.Updatetb_Photo_SortEntity(param);
    }
    
    //删除产品
     public static int Deletetb_Photo_SortEntity(String id)
    {
        tb_Photo_SortDao tb_photo_sortDao = new tb_Photo_SortDao();
        return tb_photo_sortDao.Deletetb_Photo_SortEntity(id);
    }
    //查找
    public static tb_Photo_SortEntity Selecttb_Photo_SortEntity(Dictionary<String,Object> param)
    {
        tb_Photo_SortDao tb_photo_sortDao = new tb_Photo_SortDao();
        return tb_photo_sortDao.Selecttb_Photo_SortEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_Photo_SortEntityList(Dictionary<String,Object> param)
    {
        tb_Photo_SortDao tb_photo_sortDao = new tb_Photo_SortDao();
        return tb_photo_sortDao.Selecttb_Photo_SortEntityList(param);
    }

    
    //分页
    public static IList Get_tb_Photo_SortEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_Photo_SortDao tb_photo_sortDao = new tb_Photo_SortDao();
        return tb_photo_sortDao.Get_tb_Photo_SortEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

