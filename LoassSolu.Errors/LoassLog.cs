using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoassSolu.Errors
{
    public class LoassLog
    {


        /// <summary>
        /// 写错误
        /// </summary>
        /// <param name="message"></param>
        /// <param name="log"></param>
        /// <param name="innerException"></param>
        public static void Error(String message, ILog log, System.Exception innerException)
        {
            log.Error(message, innerException);
        }
        /// <summary>
        ///  写错误
        /// </summary>
        /// <param name="message"></param>
        /// <param name="log"></param>
        public static void Error(String message, ILog log)
        {
            log.Error(message);

        }

        /// <summary>
        /// 写信息
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="log"></param>
        public static void Info(String msg, ILog log)
        {
            log.Info(msg);
        }
    }
}


