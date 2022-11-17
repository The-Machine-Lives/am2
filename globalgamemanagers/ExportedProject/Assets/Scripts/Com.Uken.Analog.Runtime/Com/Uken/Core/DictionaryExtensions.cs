using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.Core
{
	[Token(Token = "0x2000005")]
	public static class DictionaryExtensions
	{
		[Token(Token = "0x600000C")]
		public static string AsString<TValue>(this Dictionary<string, TValue> dict, string key, string fallback)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		public static bool AsBool<TValue>(this Dictionary<string, TValue> dict, string key, bool fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		public static int AsInt<TValue>(this Dictionary<string, TValue> dict, string key, int fallback)
		{
			return default(int);
		}

		[Token(Token = "0x600000F")]
		public static int? AsNullableInt<TValue>(this Dictionary<string, TValue> dict, string key, int? fallback)
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		public static float AsFloat<TValue>(this Dictionary<string, TValue> dict, string key, float fallback)
		{
			return default(float);
		}

		[Token(Token = "0x6000011")]
		public static List<object> AsList<TValue>(this Dictionary<string, TValue> dict, string key)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		public static Dictionary<string, object> AsDictionary<TValue>(this Dictionary<string, TValue> dict, string key)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		public static bool ContainsKeyAndValueNotNull<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		private static bool IsKeyValid<TValue>(this Dictionary<string, TValue> dict, string key)
		{
			return default(bool);
		}
	}
}
