
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LoassSolu.Services.DAOS;
using LoassSolu.Services.Entities;

namespace LoassSolu.Services.Actions
{
public class tb_Group_PowerAction
{
    #region 代码系统生成
    //添加产品
     public static int Inserttb_Group_PowerEntity(Dictionary<String,Object> param)
    {
        tb_Group_PowerDao tb_group_powerDao = new tb_Group_PowerDao();
        return tb_group_powerDao.Inserttb_Group_PowerEntity(param);
    }
    
    //更新产品
     public static int Updatetb_Group_PowerEntity(Dictionary<String,Object> param)
    {
        tb_Group_PowerDao tb_group_powerDao = new tb_Group_PowerDao();
        return tb_group_powerDao.Updatetb_Group_PowerEntity(param);
    }
    
    //删除产品
     public static int Deletetb_Group_PowerEntity(String id)
    {
        tb_Group_PowerDao tb_group_powerDao = new tb_Group_PowerDao();
        return tb_group_powerDao.Deletetb_Group_PowerEntity(id);
    }
    //查找
    public static tb_Group_PowerEntity Selecttb_Group_PowerEntity(Dictionary<String,Object> param)
    {
        tb_Group_PowerDao tb_group_powerDao = new tb_Group_PowerDao();
        return tb_group_powerDao.Selecttb_Group_PowerEntity(param);
    }
    
    /// <summary>
    /// 获取实体列表
    /// </summary>
    /// <param name="ht"></param>
    /// <returns></returns>
    public static IList Selecttb_Group_PowerEntityList(Dictionary<String,Object> param)
    {
        tb_Group_PowerDao tb_group_powerDao = new tb_Group_PowerDao();
        return tb_group_powerDao.Selecttb_Group_PowerEntityList(param);
    }

    
    //分页
    public static IList Get_tb_Group_PowerEntity_List(Dictionary<String,Object> param,int pageSize, int currentPage, out int recordCount)
    {
        tb_Group_PowerDao tb_group_powerDao = new tb_Group_PowerDao();
        return tb_group_powerDao.Get_tb_Group_PowerEntity_List(param,pageSize,currentPage,out recordCount);
    }   
  #endregion
}
}

