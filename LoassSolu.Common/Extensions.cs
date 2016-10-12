using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Reflection;
public static class Extensions
{
   
    public static Dictionary<string, object> EntityGetDic(this object obj)
    {
        PropertyInfo[] propertys = obj.GetType().GetProperties();
        Dictionary<string, object> dic = new Dictionary<string, object>();

        string a = "";
        foreach (PropertyInfo pi in propertys)
        {
            var t = obj.GetType();
            var property = t.GetProperty(pi.Name);
            if (property != null)
            {
                if (property.GetValue(obj, new object[] { }) != null&& property.GetValue(obj, new object[] { }).ToString() != "0001/1/1 0:00:00" && property.GetValue(obj, new object[] { }).ToString() !="" && property.GetValue(obj, new object[] { }).ToString() != "0") {
                    // a = .ToString();
                    dic.Add(property.Name, property.GetValue(obj, new object[] { }));
                }
            }
            else
            {
                a = obj.ToString();
            }

        }
     return   dic;
    }
}