using System;
using System.Text.RegularExpressions;

namespace Ultranaco.Objects
{
  public static class UriExtend
  {
    public static string ToFriendlyPath(this string path)
    {
      var uriPattern = new Regex(@"[^A-Za-z0-9_\.~áéíóúÁÉÍÓÚÀÈÌÒÙàèìòù]+");
      var pathResult = uriPattern.Replace(path.RemoveDiacritics(), "-").ToLower();
      return pathResult;
    }
  }
}