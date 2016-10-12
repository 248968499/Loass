using Loass.Framework.Data;
using Loass.Framework.Models;
using LoassSolu.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LoassSolu.Ass.Controllers
{
    public class AccountController : BaseController
    {
        // GET: Account
        public ActionResult Login()
        {
            FormsAuthentication.SignOut();
            TempData["ReturnUrl"] = Convert.ToString(Request["ReturnUrl"]);
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            //1.获取表单数据
            string userName = fc["inputUserName"];
            string password = DESEncrypt.Encrypt(fc["inputUserPwd"]);
            bool rememberMe = fc["state"] == null ? false : true;
            string returnUrl = Convert.ToString(TempData["ReturnUrl"]); 
            //2.验证用户
            UserEntity user = unitOfWork.UserRepository.Get(filter: u => u.user_name == userName &&
                (u.user_pwd == password)).FirstOrDefault();
            unitOfWork.Dispose();

            //3.保存票据
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/Home/Articles");
                }
            }
            else
            {
                ViewBag.LoginState = "用户名或密码错误，请重试";
            }
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(FormCollection fc)
        {
            string userName = fc["inputUserName"];
            string password = fc["inputUserPwd1"];
            UserEntity u = new UserEntity();
            u.user_name = userName;
            u.user_pwd = DESEncrypt.Encrypt(password);
            unitOfWork.UserRepository.Insert(u);
            // int a= unitOfWork.Save();
            if (unitOfWork.Save() <= 0)
            {
                ViewBag.LoginState = "注册失败";
            }
            else {
                return Redirect("/Account/Login");
            }
            return View();
        }
    }
}