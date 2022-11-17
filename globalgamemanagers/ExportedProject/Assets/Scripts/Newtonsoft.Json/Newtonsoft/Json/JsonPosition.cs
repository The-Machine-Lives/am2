using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000018")]
	[Preserve]
	internal struct JsonPosition
	{
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] SpecialCharacters;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x0")]
		internal JsonContainerType Type;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x4")]
		internal int Position;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x8")]
		internal string PropertyName;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x10")]
		internal bool HasIndex;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x8A1A64", Offset = "0x8A1A64", VA = "0x8A1A64")]
		public JsonPosition(JsonContainerType type)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x8A1A6C", Offset = "0x8A1A6C", VA = "0x8A1A6C")]
		internal int CalculateLength()
		{
			return default(int);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x8A1A74", Offset = "0x8A1A74", VA = "0x8A1A74")]
		internal void WriteTo(StringBuilder sb)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xD4D7C4", Offset = "0xD4D7C4", VA = "0xD4D7C4")]
		internal static bool TypeHasIndex(JsonContainerType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xD4DAA8", Offset = "0xD4DAA8", VA = "0xD4DAA8")]
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xD4DD48", Offset = "0xD4DD48", VA = "0xD4DD48")]
		internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message)
		{
			return null;
		}
	}
}
