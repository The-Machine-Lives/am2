using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200055D")]
	public class ListHelper
	{
		[Token(Token = "0x6002904")]
		public static void Shuffle<T>(IList<T> list)
		{
		}

		[Token(Token = "0x6002905")]
		public static bool TrySelectRandomWeighted<T>(IList<T> list, Func<T, float> getWeight, out T result)
		{
			return default(bool);
		}

		[Token(Token = "0x6002906")]
		public static bool TrySelectRandom<T>(IList<T> list, out T result)
		{
			return default(bool);
		}

		[Token(Token = "0x6002907")]
		public static T SelectRandom<T>(IList<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x6002908")]
		[Address(RVA = "0xA7158C", Offset = "0xA7158C", VA = "0xA7158C")]
		public static List<int> Range(int start, int end)
		{
			return null;
		}

		[Token(Token = "0x6002909")]
		[Address(RVA = "0xA71638", Offset = "0xA71638", VA = "0xA71638")]
		public static List<int> RandomRange(int start, int end)
		{
			return null;
		}

		[Token(Token = "0x600290A")]
		[Address(RVA = "0xA716A8", Offset = "0xA716A8", VA = "0xA716A8")]
		public ListHelper()
		{
		}
	}
}
