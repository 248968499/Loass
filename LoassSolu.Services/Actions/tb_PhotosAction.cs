
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.Entities;
using LoassSolu.Services.DAOS;

namespace LoassSolu.Services.Actions
{
public class tb_PhotosAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_PhotosEntity(Dictionary<String,Object> param)
    {
        tb_PhotosDao tb_photosDao = new tb_PhotosDao();
        return tb_photosDao.Inserttb_PhotosEntity(param);
    }
    
    //更新产品
     public static int Updatetb_PhotosEntity(Dictionary<String,Object> param)
    {
        tb_PhotosDao tb_photosDao = new tb_PhotosDao();
        return tb_photosDao.Updatetb_PhotosEntity(param);
    }
    
    //删除产品
     public static int Deletetb_PhotosEntity(String id)
    {
        tb_PhotosDao tb_photosDao = new tb_PhotosDao();
        return tb_photosDao.Deletetb_PhotosEntity(id);
    }
    //查找
    public static tb_PhotosEntity Selecttb_PhotosEntity(Dictionary<String,Object> param)
    {
        tb_PhotosDao tb_photosDao = new tb_PhotosDao();
        return tb_photosDao.Selecttb_PhotosEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_PhotosEntityList(Dictionary<String,Object> param)
    {
        tb_PhotosDao tb_photosDao = new tb_PhotosDao();
        return tb_photosDao.Selecttb_PhotosEntityList(param);
    }

    
    //分页
    public static IList Get_tb_PhotosEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_PhotosDao tb_photosDao = new tb_PhotosDao();
        return tb_photosDao.Get_tb_PhotosEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

