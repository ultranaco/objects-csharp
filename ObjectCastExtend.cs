using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultranaco.Objects
{
  public static class ObjectCastExtend
  {
    public static byte[] GetBytes(this object obj)
    {
      var json = obj.SerializeJson();
      return Encoding.UTF8.GetBytes(json);
    }
    public static double GetDouble(this object obj, double defaultValue = 0)
    {
      return obj as double? != null ? (double)obj : defaultValue;
    }

    public static float GetFloat(this object obj, float defaultValue = 0)
    {
      return obj as float? != null ? (float)obj : defaultValue;
    }
    public static decimal GetDecimal(this object obj, decimal defaultValue = 0)
    {
      return obj as decimal? != null ? (decimal)obj : defaultValue;
    }

    public static int GetInt32(this object obj, int defaultValue = 0)
    {
      return obj as int? != null ? (int)obj : defaultValue;
    }

    public static long GetLong(this object obj, long defaultValue = 0)
    {
      return obj as long? != null ? (long)obj : defaultValue;
    }

    public static string GetString(this object obj, string defaultValue = null)
    {
      return obj as string != null ? (string)obj : defaultValue;
    }

    public static bool GetBoolean(this object obj, bool defaultValue = false)
    {
      return obj as bool? != null ? (bool)obj : defaultValue;
    }

    public static bool GetBoolean(this string obj)
    {
      bool result;
      bool.TryParse(obj, out result);
      return result;
    }

    public static DateTime GetDateTime(this object obj)
    {
      return obj.GetDateTime(DateTime.MinValue);
    }

    public static DateTime GetDateTime(this object obj, DateTime defaultValue)
    {
      return obj as DateTime? != null ? (DateTime)obj : defaultValue;
    }

    public static TEnum GetEnum<TEnum>(this object obj, TEnum defaultValue) where TEnum : struct, IConvertible, IComparable, IFormattable
    {
      if (obj as byte? == null)
        return defaultValue;

      var value = Convert.ToInt32((byte)obj);
      return (TEnum)(object)(value);
    }
  }
}
