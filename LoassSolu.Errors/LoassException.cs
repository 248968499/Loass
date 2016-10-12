using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace LoassSolu.Errors
{
  public   class LoassException
    {
        public LoassException(String Msg, ILog log, System.Exception innerException)
        {
            log.Debug(Msg, innerException);
        }
        public LoassException(String Msg, ILog log)
        {
            log.Debug(Msg);
        }
    }
}
