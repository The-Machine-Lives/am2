using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000065")]
	[Preserve]
	internal static class EnumUtils
	{
		[Serializable]
		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E83C", Offset = "0x80E83C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x8")]
			public static Func<EnumMemberAttribute, string> _003C_003E9__1_0;

			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x10")]
			public static Func<FieldInfo, bool> _003C_003E9__5_0;

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x176AB64", Offset = "0x176AB64", VA = "0x176AB64")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x176AB6C", Offset = "0x176AB6C", VA = "0x176AB6C")]
			internal string _003CInitializeEnumType_003Eb__1_0(EnumMemberAttribute a)
			{
				return null;
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x176AB9C", Offset = "0x176AB9C", VA = "0x176AB9C")]
			internal bool _003CGetValues_003Eb__5_0(FieldInfo f)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E84C", Offset = "0x80E84C")]
		private sealed class _003C_003Ec__2<T> where T : struct
		{
			[Token(Token = "0x40001D8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__2<T> _003C_003E9;

			[Token(Token = "0x60002C6")]
			public _003C_003Ec__2()
			{
			}
		}

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType;

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x17698F4", Offset = "0x17698F4", VA = "0x17698F4")]
		private static BidirectionalDictionary<string, string> InitializeEnumType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1769DCC", Offset = "0x1769DCC", VA = "0x1769DCC")]
		public static IList<object> GetValues(Type enumType)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x176A264", Offset = "0x176A264", VA = "0x176A264")]
		public static object ParseEnumName(string enumText, bool isNullable, Type t)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x176A5B0", Offset = "0x176A5B0", VA = "0x176A5B0")]
		public static string ToEnumName(Type enumType, string enumText, bool camelCaseText)
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x176A52C", Offset = "0x176A52C", VA = "0x176A52C")]
		private static string ResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText)
		{
			return null;
		}
	}
}
