using Loass.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoassSolu.Ass.Controllers
{
    public class EditBolgController : BaseController
    {
        // GET: EditBolg
        public ActionResult Bolg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Bolg(FormCollection fc)
            {
            string article_name = fc["article_name"];
            string article_content = fc["article_content"];
            ArticleEntity article = new ArticleEntity();
            article.article_name = article_name;
            article.article_content = article_content;
            unitOfWork.ArticleRepository.Insert(article);
            // int a= unitOfWork.Save();
            if (unitOfWork.Save() <= 0)
            {
                ViewBag.LoginState = "失败";
            }
            else
            {
                return Redirect("/Account/Login");
            }
            return View();
        }
        //上传文件
        public ActionResult ProcessRequest()
        {
            Response.ContentType = "text/plain";
            Response.Charset = "utf-8";

            var files = Request.Files;
            if (files.Count <= 0)
            {
                return Content("");
            }

            HttpPostedFileBase file = files[0];

            if (file == null)
            {

                return Content("error|file is null");
            }
            else
            {
                string path = Server.MapPath("~/upload/");  //存储图片的文件夹
                string originalFileName = file.FileName;
                string fileExtension = originalFileName.Substring(originalFileName.LastIndexOf('.'), originalFileName.Length - originalFileName.LastIndexOf('.'));
                string currentFileName = (new Random()).Next() + fileExtension;  //文件名中不要带中文，否则会出错
                //生成文件路径
                string imagePath = path + currentFileName;
                //保存文件
                file.SaveAs(imagePath);

                //获取图片url地址
                string imgUrl = "http://localhost:51016/upload/" + currentFileName;

                //返回图片url地址

                return Content(imgUrl);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

    }
}