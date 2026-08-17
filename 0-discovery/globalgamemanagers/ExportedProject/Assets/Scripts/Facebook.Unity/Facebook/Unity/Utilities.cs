using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000055")]
	internal static class Utilities
	{
		[Token(Token = "0x2000056")]
		public delegate void Callback<T>(T obj);

		[Serializable]
		[Token(Token = "0x2000057")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8160F0", Offset = "0x8160F0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000081")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000082")]
			[FieldOffset(Offset = "0x8")]
			public static Func<object, string> _003C_003E9__18_0;

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x17C455C", Offset = "0x17C455C", VA = "0x17C455C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x17C4564", Offset = "0x17C4564", VA = "0x17C4564")]
			internal string _003CParsePermissionFromResult_003Eb__18_0(object permission)
			{
				return null;
			}
		}

		[Token(Token = "0x600018E")]
		public static bool TryGetValue<T>(this IDictionary<string, object> dictionary, string key, out T value)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x17C1200", Offset = "0x17C1200", VA = "0x17C1200")]
		public static long TotalSeconds(this DateTime dateTime)
		{
			return default(long);
		}

		[Token(Token = "0x6000190")]
		public static T GetValueOrDefault<T>(this IDictionary<string, object> dictionary, string key, bool logWarning = true)
		{
			return (T)null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x17C31E4", Offset = "0x17C31E4", VA = "0x17C31E4")]
		public static string ToCommaSeparateList(this IEnumerable<string> list)
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x17C3274", Offset = "0x17C3274", VA = "0x17C3274")]
		public static string AbsoluteUrlOrEmptyString(this Uri uri)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x17C331C", Offset = "0x17C331C", VA = "0x17C331C")]
		public static string GetUserAgent(string productName, string productVersion)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x17C2E80", Offset = "0x17C2E80", VA = "0x17C2E80")]
		public static string ToJson(this IDictionary<string, object> dictionary)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x17C3464", Offset = "0x17C3464", VA = "0x17C3464")]
		public static AccessToken ParseAccessTokenFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x17C0C5C", Offset = "0x17C0C5C", VA = "0x17C0C5C")]
		public static string ToStringNullOk(this object obj)
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x17BFEF4", Offset = "0x17BFEF4", VA = "0x17BFEF4")]
		public static string FormatToString(string baseString, string className, IDictionary<string, string> propertiesAndValues)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x17C35B8", Offset = "0x17C35B8", VA = "0x17C35B8")]
		private static DateTime ParseExpirationDateFromResult(IDictionary<string, object> resultDictionary)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x17C3A50", Offset = "0x17C3A50", VA = "0x17C3A50")]
		private static DateTime? ParseLastRefreshFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x17C3774", Offset = "0x17C3774", VA = "0x17C3774")]
		private static ICollection<string> ParsePermissionFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x17C3B0C", Offset = "0x17C3B0C", VA = "0x17C3B0C")]
		public static IList<Product> ParseCatalogFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x17C1A30", Offset = "0x17C1A30", VA = "0x17C1A30")]
		public static IList<Purchase> ParsePurchasesFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x17C12B8", Offset = "0x17C12B8", VA = "0x17C12B8")]
		public static Purchase ParsePurchaseFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x17C029C", Offset = "0x17C029C", VA = "0x17C029C")]
		public static IDictionary<string, string> ParsePayloadFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x17C0F10", Offset = "0x17C0F10", VA = "0x17C0F10")]
		public static DateTime FromTimestamp(int timestamp)
		{
			return default(DateTime);
		}
	}
}
