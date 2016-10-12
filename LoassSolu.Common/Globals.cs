using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Web;

namespace LoassSolu.Common
{
    public class Globals
    {
        #region 获取页面参数
        /// <summary>
        /// 获取页面参数
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <returns></returns>
        public static String GetParamter(String paramName)
        {
            String str = HttpContext.Current.Request[paramName];
            if (str == null)
                return "";
            return str;
        }



        /// <summary>
        /// 获取页面整型参数
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <returns></returns>
        public static int GetIntParamter(String paramName)
        {
            String str = HttpContext.Current.Request[paramName];
            if (str == null || str.Length == 0)
                return 0;
            try
            {
                return int.Parse(str);
            }
            catch { }
            return 0;
        }
        #endregion

        #region 获取传送过来的参数
        /// <summary>
        /// 获取传送过来的参数
        /// </summary>
        /// <returns></returns>
        public static SortedList GetParameters()
        {
            SortedList paras = new SortedList();

            HttpRequest request = HttpContext.Current.Request;
            for (int i = 0; i < request.Form.Count; i++)
            {
                string[] value = request.Form.GetValues(i);
                paras.Add(request.Form.GetKey(i) == null ? "null" : request.Form.GetKey(i), value[0]);
            }

            for (int i = 0; i < request.QueryString.Count; i++)
            {
                string[] value = request.QueryString.GetValues(i);
                paras.Add(request.QueryString.GetKey(i) == null ? "null" : request.QueryString.GetKey(i), value[0]);
            }

            return paras;
        }
        public static SortedList GetQueryStringParameters()
        {
            SortedList paras = new SortedList();

            HttpRequest request = HttpContext.Current.Request;

            for (int i = 0; i < request.QueryString.Count; i++)
            {
                string[] value = request.QueryString.GetValues(i);
                paras.Add(request.QueryString.GetKey(i) == null ? "null" : request.QueryString.GetKey(i), value[0]);
            }

            return paras;
        }
        #endregion

        #region 字符串操作
        /// <summary>
        /// 删除不可见字符
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns></returns>
        public static string DeleteUnVisibleChar(string strSource)
        {
            System.Text.StringBuilder sBuilder = new System.Text.StringBuilder(131);
            for (int i = 0; i < strSource.Length; i++)
            {
                int Unicode = strSource[i];
                if (Unicode >= 16)
                {
                    sBuilder.Append(strSource[i].ToString());
                }
            }
            return sBuilder.ToString();
        }

        /// <summary>
        /// 编码(输入到数据库中)
        /// </summary>
        /// <param name="strSource">源字符串</param>
        /// <returns>返回值</returns>
        public static string Encode(string strSource)
        {
            string strReturn;
            strReturn = strSource;
            if (strReturn != null && strReturn.Length > 0)
            {
                strReturn = strReturn.Replace("'", "''");
                strReturn = strReturn.Replace(" ", "&nbsp;");
                strReturn = strReturn.Replace("<", "&lt;");
                strReturn = strReturn.Replace(">", "&gt;");
                strReturn = strReturn.Replace("\"", "&quot;");
                strReturn = strReturn.Replace("<br/>", "\r\n");
                strReturn = strReturn.Replace("<br />", "\r\n");
                strReturn.Replace(" select ", " sel&#101;ct ").Replace(" insert ", " ins&#101;rt ").Replace(" create ", " cr&#101;ate ").Replace(" drop ", " dro&#112 ").
                Replace(" alter ", " alt&#101;r ").Replace(" delete ", " del&#101;te ").Replace(" update ", " up&#100;ate ").Replace(" or ", " o&#114; ").Replace("&", "&amp");

            }
            return strReturn;
        }

        /// <summary>
        /// 解码(返回到TextBox中)
        /// </summary>
        /// <param name="strSource">源字符串</param>
        /// <returns>返回值</returns>
        public static string Decode(string strSource)
        {
            string strReturn;
            strReturn = strSource;
            if (strReturn != null && strReturn.Length > 0)
            {
                strReturn = strReturn.Replace("''", "'");
                strReturn = strReturn.Replace("&nbsp;", " ");
                strReturn = strReturn.Replace("&lt;", "<");
                strReturn = strReturn.Replace("&gt;", ">");
                strReturn = strReturn.Replace("&quot;", "\"");
                strReturn = strReturn.Replace("\r\n", "<br/>");
                strReturn.Replace(" sel&#101;ct ", " select ").Replace(" ins&#101;rt ", " insert ").Replace(" cr&#101;ate ", " create ").Replace(" dro&#112 ", " drop ").
                Replace(" alt&#101;r ", " alter ").Replace(" del&#101;te ", " delete ").Replace(" up&#100;ate ", " update ").Replace(" o&#114; ", " or ").Replace("&amp;", "&");



            }
            return strReturn;
        }
        #endregion

        /// <summary>
        /// 截取字符串,从指定的标记位置开始到字符串结束(不包括指定标记)
        /// </summary>
        /// <param name="str"></param>
        /// <param name="mark"></param>
        /// <returns></returns>
        public static String SubStrFromMark(String str, String mark)
        {
            if (str == null || str.Length == 0)
                return "";
            int index = str.IndexOf(mark);
            if (str.IndexOf(mark) == -1)
                return "";
            return str.Substring(index + 1);
        }

        public static String SubStrEndMark(String str, String mark)
        {
            if (str == null || str.Length == 0)
                return "";
            int index = str.LastIndexOf(mark);
            if (str.LastIndexOf(mark) == -1)
                return "";
            return str.Substring(index + 1);
        }


        #region 截取字符串
        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="mark"></param>
        /// <returns></returns>
        public static String SubStr(String str, String mark)
        {
            if (str == null || str.Length == 0)
                return "";
            int index = str.IndexOf(mark);
            if (str.IndexOf(mark) == -1)
                return "";
            return str.Substring(0, index);
        }
        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String SubStr(String str)
        {
            return SubStr(str, "@");
        }

        /// <summary>
        ///截取字符串的长度
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="len">长度</param>
        /// <param name="suffix">后缀</param>
        /// <returns></returns>
        public static String SubStr(String str, int len, String suffix)
        {
            int lenTemp = 0;
            ASCIIEncoding asc = new ASCIIEncoding();
            byte[] bytes = asc.GetBytes(str);
            int count = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] == 63)
                {
                    count++;
                }
                count++;
                if (count > len)
                    break;
                lenTemp++;
            }
            if (str.Length <= lenTemp)
                return str;
            return str.Substring(0, lenTemp) + suffix;
        }

        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="len">长度</param>
        /// <returns></returns>
        public static String SubStr(String str, int len)
        {
            return SubStr(str, len, "...");
        }
        #endregion


        /// <summary>
        /// 对图片名称进行处理，有可能是多张出图片
        /// </summary>
        /// <param name="imgName"></param>
        /// <returns></returns>
        public static String ImgNameOperate(object imgName)
        {
            if (imgName == null || imgName.ToString().Length == 0)
                return "";
            String[] imgs = imgName.ToString().Split(',');
            return imgs[0].Substring(0, 8) + "/" + imgs[0];

        }


        public static int chkStrAscii(String code)
        {
            int flag = 0;//
            for (int i = 0; i < code.Length; i++)
            {
                if ((int)code[i] > 127)
                {
                    flag = 1;//汉字
                    break;
                }
                else
                {
                    flag = 2;//不是汉字
                    break;
                }

            }
            return flag;
        }



        /// <summary>
        /// datetime转换成unixtime
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int GetTimestamp(DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return Convert.ToInt32((time - startTime).TotalSeconds);
        }

        /// <summary>
        /// 生成16位的随机数
        /// </summary>
        /// <returns></returns>
        public static String NonceStr()
        {
            int length = 16;
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string str = "";
            Random rad = new Random();
            for (int i = 0; i < length; i++)
                str += chars.Substring(rad.Next(0, chars.Length - 1), 1);
            return str;

        }


        /// <summary>
        /// 生成8位的随机数
        /// </summary>
        /// <returns></returns>
        public static String RandomNum()
        {
            //int length = 8;
            //string chars = "0123456789";
            //string str = "";
            //Random rad = new Random();

            //for (int i = 0; i < length; i++)
            //    str += chars.Substring(rad.Next(0, chars.Length - 1), 1);
            //return str;
            return DateTime.Now.ToString("mmfffffff");
        }/// <summary>
        /// 生成6位的随机数
        /// </summary>
        /// <returns></returns>
        public static int RandomNum6()
        {
            Random r = new Random(System.Environment.TickCount);
            int i = r.Next(100000, 999999);
            return i;
        }
    }
}
