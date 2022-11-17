using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace fastJSON
{
	[Token(Token = "0x2000004")]
	internal sealed class JsonParser
	{
		[Token(Token = "0x2000005")]
		private enum Token
		{
			[Token(Token = "0x4000010")]
			None = -1,
			[Token(Token = "0x4000011")]
			Curly_Open = 0,
			[Token(Token = "0x4000012")]
			Curly_Close = 1,
			[Token(Token = "0x4000013")]
			Squared_Open = 2,
			[Token(Token = "0x4000014")]
			Squared_Close = 3,
			[Token(Token = "0x4000015")]
			Colon = 4,
			[Token(Token = "0x4000016")]
			Comma = 5,
			[Token(Token = "0x4000017")]
			String = 6,
			[Token(Token = "0x4000018")]
			Number = 7,
			[Token(Token = "0x4000019")]
			True = 8,
			[Token(Token = "0x400001A")]
			False = 9,
			[Token(Token = "0x400001B")]
			Null = 10
		}

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		private readonly string json;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		private readonly StringBuilder s;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		private Token lookAheadToken;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x24")]
		private int index;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1813500", Offset = "0x1813500", VA = "0x1813500")]
		internal JsonParser(string json)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1813584", Offset = "0x1813584", VA = "0x1813584")]
		public object Decode()
		{
			return null;
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x18137D8", Offset = "0x18137D8", VA = "0x18137D8")]
		private Dictionary<string, object> ParseObject()
		{
			return null;
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1813EBC", Offset = "0x1813EBC", VA = "0x1813EBC")]
		private List<object> ParseArray()
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x181364C", Offset = "0x181364C", VA = "0x181364C")]
		private object ParseValue()
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x18139C4", Offset = "0x18139C4", VA = "0x18139C4")]
		private string ParseString()
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1814328", Offset = "0x1814328", VA = "0x1814328")]
		private uint ParseSingleChar(char c1, uint multipliyer)
		{
			return default(uint);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x18141BC", Offset = "0x18141BC", VA = "0x18141BC")]
		private uint ParseUnicode(char c1, char c2, char c3, char c4)
		{
			return default(uint);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1813FA4", Offset = "0x1813FA4", VA = "0x1813FA4")]
		private object ParseNumber()
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1813990", Offset = "0x1813990", VA = "0x1813990")]
		private Token LookAhead()
		{
			return default(Token);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1813984", Offset = "0x1813984", VA = "0x1813984")]
		private void ConsumeToken()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1813E84", Offset = "0x1813E84", VA = "0x1813E84")]
		private Token NextToken()
		{
			return default(Token);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1814380", Offset = "0x1814380", VA = "0x1814380")]
		private Token NextTokenCore()
		{
			return default(Token);
		}
	}
}
