using System;
using System.Collections.Generic;
using System.Text;

namespace Ultranaco.Objects
{
  public static class StringExtend
  {
    public static string FisrtUpper(this string chararray)
    {
      return char.ToUpper(chararray[0]) + chararray.Substring(1);
    }
  }
}
