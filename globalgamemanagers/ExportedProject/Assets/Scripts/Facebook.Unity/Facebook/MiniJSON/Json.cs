using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace Facebook.MiniJSON
{
	[Token(Token = "0x2000002")]
	public static class Json
	{
		[Token(Token = "0x2000003")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x2000004")]
			private enum TOKEN
			{
				[Token(Token = "0x4000004")]
				NONE = 0,
				[Token(Token = "0x4000005")]
				CURLY_OPEN = 1,
				[Token(Token = "0x4000006")]
				CURLY_CLOSE = 2,
				[Token(Token = "0x4000007")]
				SQUARED_OPEN = 3,
				[Token(Token = "0x4000008")]
				SQUARED_CLOSE = 4,
				[Token(Token = "0x4000009")]
				COLON = 5,
				[Token(Token = "0x400000A")]
				COMMA = 6,
				[Token(Token = "0x400000B")]
				STRING = 7,
				[Token(Token = "0x400000C")]
				NUMBER = 8,
				[Token(Token = "0x400000D")]
				TRUE = 9,
				[Token(Token = "0x400000E")]
				FALSE = 10,
				[Token(Token = "0x400000F")]
				NULL = 11
			}

			[Token(Token = "0x4000002")]
			[FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x17000001")]
			private char PeekChar
			{
				[Token(Token = "0x6000005")]
				[Address(RVA = "0xCC5CA8", Offset = "0xCC5CA8", VA = "0xCC5CA8")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000002")]
			private char NextChar
			{
				[Token(Token = "0x6000006")]
				[Address(RVA = "0xCC5D38", Offset = "0xCC5D38", VA = "0xCC5D38")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000003")]
			private string NextWord
			{
				[Token(Token = "0x6000007")]
				[Address(RVA = "0xCC5DC8", Offset = "0xCC5DC8", VA = "0xCC5DC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6000008")]
				[Address(RVA = "0xCC5ED4", Offset = "0xCC5ED4", VA = "0xCC5ED4")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6000004")]
			[Address(RVA = "0xCC5C2C", Offset = "0xCC5C2C", VA = "0xCC5C2C")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6000009")]
			[Address(RVA = "0xCC59A8", Offset = "0xCC59A8", VA = "0xCC59A8")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x600000A")]
			[Address(RVA = "0xCC61AC", Offset = "0xCC61AC", VA = "0xCC61AC", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600000B")]
			[Address(RVA = "0xCC61E8", Offset = "0xCC61E8", VA = "0xCC61E8")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x600000C")]
			[Address(RVA = "0xCC65FC", Offset = "0xCC65FC", VA = "0xCC65FC")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x600000D")]
			[Address(RVA = "0xCC6184", Offset = "0xCC6184", VA = "0xCC6184")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x600000E")]
			[Address(RVA = "0xCC66E8", Offset = "0xCC66E8", VA = "0xCC66E8")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x600000F")]
			[Address(RVA = "0xCC6324", Offset = "0xCC6324", VA = "0xCC6324")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6000010")]
			[Address(RVA = "0xCC67C4", Offset = "0xCC67C4", VA = "0xCC67C4")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0xCC60B4", Offset = "0xCC60B4", VA = "0xCC60B4")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x2000005")]
		private sealed class Serializer
		{
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x6000012")]
			[Address(RVA = "0xCC68F0", Offset = "0xCC68F0", VA = "0xCC68F0")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000013")]
			[Address(RVA = "0xCC5AF0", Offset = "0xCC5AF0", VA = "0xCC5AF0")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000014")]
			[Address(RVA = "0xCC695C", Offset = "0xCC695C", VA = "0xCC695C")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6000015")]
			[Address(RVA = "0xCC70F4", Offset = "0xCC70F4", VA = "0xCC70F4")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000016")]
			[Address(RVA = "0xCC6DF8", Offset = "0xCC6DF8", VA = "0xCC6DF8")]
			private void SerializeArray(IList array)
			{
			}

			[Token(Token = "0x6000017")]
			[Address(RVA = "0xCC6B08", Offset = "0xCC6B08", VA = "0xCC6B08")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000018")]
			[Address(RVA = "0xCC7538", Offset = "0xCC7538", VA = "0xCC7538")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static NumberFormatInfo numberFormat;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xCC599C", Offset = "0xCC599C", VA = "0xCC599C")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xCC5AEC", Offset = "0xCC5AEC", VA = "0xCC5AEC")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
