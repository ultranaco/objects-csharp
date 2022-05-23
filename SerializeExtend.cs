using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ultranaco.Objects
{
   public enum CaseSensitive
   {
      None,
      UpperCamelCase,
      LowerCaemlCase,
      SnakeCase
   } // TODO: implement case flavor

   public static class SerializeExtend
   {
      public static string SerializeJson(this object obj)
      {
         return JsonSerializer.Serialize(obj);
      }

      public static T DeserializeJson<T>(this string obj)
      {
         return JsonSerializer.Deserialize<T>(obj);
      }
   }
}
