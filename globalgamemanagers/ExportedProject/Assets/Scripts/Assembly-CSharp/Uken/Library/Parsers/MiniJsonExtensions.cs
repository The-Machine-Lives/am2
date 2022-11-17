using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Parsers
{
	[Token(Token = "0x2000408")]
	public static class MiniJsonExtensions
	{
		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0xB2FAE0", Offset = "0xB2FAE0", VA = "0xB2FAE0")]
		public static string toJson(this Hashtable obj)
		{
			return null;
		}

		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0xB2FB48", Offset = "0xB2FB48", VA = "0xB2FB48")]
		public static string toJson(this ArrayList obj)
		{
			return null;
		}

		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0xB2FBB0", Offset = "0xB2FBB0", VA = "0xB2FBB0")]
		public static string toJson(this Dictionary<string, object> obj)
		{
			return null;
		}

		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0xB2FC18", Offset = "0xB2FC18", VA = "0xB2FC18")]
		public static ArrayList arrayListFromJson(this string json)
		{
			return null;
		}

		[Token(Token = "0x6001EB6")]
		[Address(RVA = "0xB2FCC4", Offset = "0xB2FCC4", VA = "0xB2FCC4")]
		public static Hashtable hashtableFromJson(this string json)
		{
			return null;
		}
	}
}
