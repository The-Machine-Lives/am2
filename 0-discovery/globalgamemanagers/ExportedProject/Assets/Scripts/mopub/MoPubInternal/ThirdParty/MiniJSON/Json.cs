using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace MoPubInternal.ThirdParty.MiniJSON
{
	[Token(Token = "0x2000039")]
	public static class Json
	{
		[Token(Token = "0x200003A")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x200003B")]
			private enum TOKEN
			{
				[Token(Token = "0x400009E")]
				NONE = 0,
				[Token(Token = "0x400009F")]
				CURLY_OPEN = 1,
				[Token(Token = "0x40000A0")]
				CURLY_CLOSE = 2,
				[Token(Token = "0x40000A1")]
				SQUARED_OPEN = 3,
				[Token(Token = "0x40000A2")]
				SQUARED_CLOSE = 4,
				[Token(Token = "0x40000A3")]
				COLON = 5,
				[Token(Token = "0x40000A4")]
				COMMA = 6,
				[Token(Token = "0x40000A5")]
				STRING = 7,
				[Token(Token = "0x40000A6")]
				NUMBER = 8,
				[Token(Token = "0x40000A7")]
				TRUE = 9,
				[Token(Token = "0x40000A8")]
				FALSE = 10,
				[Token(Token = "0x40000A9")]
				NULL = 11
			}

			[Token(Token = "0x400009C")]
			[FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x1700002B")]
			private char PeekChar
			{
				[Token(Token = "0x600012B")]
				[Address(RVA = "0x175D534", Offset = "0x175D534", VA = "0x175D534")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x1700002C")]
			private char NextChar
			{
				[Token(Token = "0x600012C")]
				[Address(RVA = "0x175D300", Offset = "0x175D300", VA = "0x175D300")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x1700002D")]
			private string NextWord
			{
				[Token(Token = "0x600012D")]
				[Address(RVA = "0x175D390", Offset = "0x175D390", VA = "0x175D390")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002E")]
			private TOKEN NextToken
			{
				[Token(Token = "0x600012E")]
				[Address(RVA = "0x175CB0C", Offset = "0x175CB0C", VA = "0x175CB0C")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x175C84C", Offset = "0x175C84C", VA = "0x175C84C")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x175C8F0", Offset = "0x175C8F0", VA = "0x175C8F0")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x175C664", Offset = "0x175C664", VA = "0x175C664")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000123")]
			[Address(RVA = "0x175C994", Offset = "0x175C994", VA = "0x175C994", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x175C9D0", Offset = "0x175C9D0", VA = "0x175C9D0")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x175CFEC", Offset = "0x175CFEC", VA = "0x175CFEC")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x175C96C", Offset = "0x175C96C", VA = "0x175C96C")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x175D0D8", Offset = "0x175D0D8", VA = "0x175D0D8")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x175CCE8", Offset = "0x175CCE8", VA = "0x175CCE8")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x175D1B4", Offset = "0x175D1B4", VA = "0x175D1B4")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x175D46C", Offset = "0x175D46C", VA = "0x175D46C")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x200003C")]
		private sealed class Serializer
		{
			[Token(Token = "0x40000AA")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x600012F")]
			[Address(RVA = "0x175D5C4", Offset = "0x175D5C4", VA = "0x175D5C4")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x175C7A8", Offset = "0x175C7A8", VA = "0x175C7A8")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000131")]
			[Address(RVA = "0x175D630", Offset = "0x175D630", VA = "0x175D630")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x175DDB8", Offset = "0x175DDB8", VA = "0x175DDB8")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x175DABC", Offset = "0x175DABC", VA = "0x175DABC")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x175D7EC", Offset = "0x175D7EC", VA = "0x175D7EC")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000135")]
			[Address(RVA = "0x175E1FC", Offset = "0x175E1FC", VA = "0x175E1FC")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1757CA4", Offset = "0x1757CA4", VA = "0x1757CA4")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1757F80", Offset = "0x1757F80", VA = "0x1757F80")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
