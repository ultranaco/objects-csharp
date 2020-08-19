using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ultranaco.Objects
{
  public class StringComparerExtend : StringComparer
  {
    public static IEqualityComparer<string> WithoutDiactritics = new CompareWithoutDiacritics();
    public override int Compare(string x, string y)
    {
      throw new NotImplementedException();
    }

    public override bool Equals(string x, string y)
    {
      throw new NotImplementedException();
    }

    public override int GetHashCode(string obj)
    {
      throw new NotImplementedException();
    }
  }

  internal class CompareWithoutDiacritics : IEqualityComparer<string>
  {
    public bool Equals([AllowNull] string x, [AllowNull] string y)
    {
      var x1 = x.ToLower().RemoveDiacritics();
      var x2 = y.ToLower().RemoveDiacritics();
      return x1 == x2;
    }

    public int GetHashCode([DisallowNull] string obj)
    {
      return obj.ToLower().RemoveDiacritics().GetHashCode();
    }
  }
}