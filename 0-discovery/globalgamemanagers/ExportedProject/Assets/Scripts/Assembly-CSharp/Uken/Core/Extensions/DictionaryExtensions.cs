using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Core.Extensions
{
	[Token(Token = "0x20003D8")]
	public static class DictionaryExtensions
	{
		[Token(Token = "0x6001DAB")]
		private static bool IsKeyValid<TValue>(this Dictionary<string, TValue> dict, string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6001DAC")]
		public static string AsString<TValue>(this Dictionary<string, TValue> dict, string key, string fallback)
		{
			return null;
		}

		[Token(Token = "0x6001DAD")]
		public static bool AsBool<TValue>(this Dictionary<string, TValue> dict, string key, bool fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6001DAE")]
		public static int AsInt<TValue>(this Dictionary<string, TValue> dict, string key, int fallback)
		{
			return default(int);
		}

		[Token(Token = "0x6001DAF")]
		public static long AsLong<TValue>(this Dictionary<string, TValue> dict, string key, int fallback)
		{
			return default(long);
		}

		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0xA15E58", Offset = "0xA15E58", VA = "0xA15E58")]
		public static long AsLongEfficient(this Dictionary<string, object> dict, string key, int fallback)
		{
			return default(long);
		}

		[Token(Token = "0x6001DB1")]
		public static int? AsNullableInt<TValue>(this Dictionary<string, TValue> dict, string key, int? fallback)
		{
			return null;
		}

		[Token(Token = "0x6001DB2")]
		public static long? AsNullableLong<TValue>(this Dictionary<string, TValue> dict, string key, long? fallback)
		{
			return null;
		}

		[Token(Token = "0x6001DB3")]
		public static float AsFloat<TValue>(this Dictionary<string, TValue> dict, string key, float fallback)
		{
			return default(float);
		}

		[Token(Token = "0x6001DB4")]
		public static List<object> AsList<TValue>(this Dictionary<string, TValue> dict, string key)
		{
			return null;
		}

		[Token(Token = "0x6001DB5")]
		public static Dictionary<string, object> AsDictionary<TValue>(this Dictionary<string, TValue> dict, string key)
		{
			return null;
		}

		[Token(Token = "0x6001DB6")]
		public static bool ContainsKeyAndValueNotNull<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6001DB7")]
		public static void AddFrom<TKey, TValue>(this Dictionary<TKey, TValue> self, Dictionary<TKey, TValue> other)
		{
		}
	}
}
