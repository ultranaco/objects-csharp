using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultranaco.Objects
{
   public enum CaseSensitive
   {
      None,
      CamelLowerCase
   }

   public static class SerializeExtend
   {
      public static string SerializeJson(this object obj)
      {
         return obj.SerializeJson(Formatting.None, CaseSensitive.CamelLowerCase);
      }

      public static string SerializeJson(this object obj, Formatting formating)
      {
         return obj.SerializeJson(formating, CaseSensitive.None);
      }

      public static string SerializeJson(this object obj, CaseSensitive caseSensitive)
      {
         return obj.SerializeJson(Formatting.None, caseSensitive);
      }

      public static string SerializeJson(this object obj, Formatting formating, CaseSensitive caseSensitive)
      {
         if (caseSensitive == CaseSensitive.None)
            return JsonConvert.SerializeObject(obj);
         var jsonSerializerSettings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
         return JsonConvert.SerializeObject(obj, formating, jsonSerializerSettings);

      }

      public static T DeserializeJson<T>(this string obj)
      {
         return JsonConvert.DeserializeObject<T>(obj);
      }
   }
}
