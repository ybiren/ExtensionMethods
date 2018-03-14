using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
	public static class Class1
	{
		public static DateTime Add2Month(this DateTime dt)
		{
			return dt.AddMonths(2);
		}

		public static string ToString1(this IEnumerable<int>  l)
		{
			string k = "";
			
			foreach (var i in l)
			{
				k += i.ToString() + ",";
			}
			return k;
		}

		public static IEnumerator<T> Where2<T>(this IEnumerable<T> l)
		{
			  for(var i=0 ;i <l.Count(); i++)
			  {
				   yield return l.ElementAt(i);
			  }
		}


	}
}