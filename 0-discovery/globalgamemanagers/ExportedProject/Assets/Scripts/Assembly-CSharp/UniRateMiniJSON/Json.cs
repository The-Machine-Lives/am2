using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace UniRateMiniJSON
{
	[Token(Token = "0x2000248")]
	public static class Json
	{
		[Token(Token = "0x200067F")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x2000888")]
			private enum TOKEN
			{
				[Token(Token = "0x400244D")]
				NONE = 0,
				[Token(Token = "0x400244E")]
				CURLY_OPEN = 1,
				[Token(Token = "0x400244F")]
				CURLY_CLOSE = 2,
				[Token(Token = "0x4002450")]
				SQUARED_OPEN = 3,
				[Token(Token = "0x4002451")]
				SQUARED_CLOSE = 4,
				[Token(Token = "0x4002452")]
				COLON = 5,
				[Token(Token = "0x4002453")]
				COMMA = 6,
				[Token(Token = "0x4002454")]
				STRING = 7,
				[Token(Token = "0x4002455")]
				NUMBER = 8,
				[Token(Token = "0x4002456")]
				TRUE = 9,
				[Token(Token = "0x4002457")]
				FALSE = 10,
				[Token(Token = "0x4002458")]
				NULL = 11
			}

			[Token(Token = "0x4001FDB")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x4001FDC")]
			[FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x170007FB")]
			private char PeekChar
			{
				[Token(Token = "0x6002E1C")]
				[Address(RVA = "0xAA7D9C", Offset = "0xAA7D9C", VA = "0xAA7D9C")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170007FC")]
			private char NextChar
			{
				[Token(Token = "0x6002E1D")]
				[Address(RVA = "0xAA7B68", Offset = "0xAA7B68", VA = "0xAA7B68")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170007FD")]
			private string NextWord
			{
				[Token(Token = "0x6002E1E")]
				[Address(RVA = "0xAA7BF8", Offset = "0xAA7BF8", VA = "0xAA7BF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170007FE")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6002E1F")]
				[Address(RVA = "0xAA73E0", Offset = "0xAA73E0", VA = "0xAA73E0")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6002E11")]
			[Address(RVA = "0xAA7120", Offset = "0xAA7120", VA = "0xAA7120")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x6002E12")]
			[Address(RVA = "0xAA71C4", Offset = "0xAA71C4", VA = "0xAA71C4")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6002E13")]
			[Address(RVA = "0xAA6F34", Offset = "0xAA6F34", VA = "0xAA6F34")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6002E14")]
			[Address(RVA = "0xAA7268", Offset = "0xAA7268", VA = "0xAA7268", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6002E15")]
			[Address(RVA = "0xAA72A4", Offset = "0xAA72A4", VA = "0xAA72A4")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6002E16")]
			[Address(RVA = "0xAA78C0", Offset = "0xAA78C0", VA = "0xAA78C0")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6002E17")]
			[Address(RVA = "0xAA7240", Offset = "0xAA7240", VA = "0xAA7240")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6002E18")]
			[Address(RVA = "0xAA79AC", Offset = "0xAA79AC", VA = "0xAA79AC")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6002E19")]
			[Address(RVA = "0xAA75BC", Offset = "0xAA75BC", VA = "0xAA75BC")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6002E1A")]
			[Address(RVA = "0xAA7A88", Offset = "0xAA7A88", VA = "0xAA7A88")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6002E1B")]
			[Address(RVA = "0xAA7CD4", Offset = "0xAA7CD4", VA = "0xAA7CD4")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x2000680")]
		private sealed class Serializer
		{
			[Token(Token = "0x4001FDD")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x6002E20")]
			[Address(RVA = "0xAA7E2C", Offset = "0xAA7E2C", VA = "0xAA7E2C")]
			private Serializer()
			{
			}

			[Token(Token = "0x6002E21")]
			[Address(RVA = "0xAA707C", Offset = "0xAA707C", VA = "0xAA707C")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6002E22")]
			[Address(RVA = "0xAA7E98", Offset = "0xAA7E98", VA = "0xAA7E98")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6002E23")]
			[Address(RVA = "0xAA8620", Offset = "0xAA8620", VA = "0xAA8620")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6002E24")]
			[Address(RVA = "0xAA8324", Offset = "0xAA8324", VA = "0xAA8324")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6002E25")]
			[Address(RVA = "0xAA8054", Offset = "0xAA8054", VA = "0xAA8054")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6002E26")]
			[Address(RVA = "0xAA8A64", Offset = "0xAA8A64", VA = "0xAA8A64")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x6001089")]
		[Address(RVA = "0xAA5C90", Offset = "0xAA5C90", VA = "0xAA5C90")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x600108A")]
		[Address(RVA = "0xAA7078", Offset = "0xAA7078", VA = "0xAA7078")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
