using Loass.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoassSolu.Ass.Controllers
{
    /// <summary>
    /// 基本控制器，需要验证登录的页面继承此页面
    /// </summary>
    public class BaseController : Controller
    {

        public UnitOfWorkBase unitOfWork = new UnitOfWorkBase();
        //  public UserCookie userCookie = null;
        //重写，判断是否登录 
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            //String url = Request.Url.PathAndQuery;
            //if (!(url == "/" || url == "/home/home") && url != "/share/share" && url != "/home/location_redirect" && !url.Contains("xfx_page"))
            //{
            //    //userCookie = new UserCookie("");
            //    //if (userCookie.Uid == null || userCookie.Uid.Length == 0)
            //    filterContext.Result = new RedirectResult("/Login/Login?redirecturl=" + url);
            //}
            //实例化一个数据上下文对象  
            ////创建数据库如果不存在的话  
            //if (unitOfWork..Database.CreateIfNotExists())
            //{
            //    Console.WriteLine("数据库已创建成功！");
            //    Console.Read();
            //}
            //else
            //{
            //    Console.WriteLine("数据库已经存在，无需创建！");
            //}
        }
    }
}