using System.Collections;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace Uken.Library.Parsers
{
	[Token(Token = "0x2000407")]
	public class MiniJSON
	{
		[Token(Token = "0x40012CD")]
		private const int TOKEN_NONE = 0;

		[Token(Token = "0x40012CE")]
		private const int TOKEN_CURLY_OPEN = 1;

		[Token(Token = "0x40012CF")]
		private const int TOKEN_CURLY_CLOSE = 2;

		[Token(Token = "0x40012D0")]
		private const int TOKEN_SQUARED_OPEN = 3;

		[Token(Token = "0x40012D1")]
		private const int TOKEN_SQUARED_CLOSE = 4;

		[Token(Token = "0x40012D2")]
		private const int TOKEN_COLON = 5;

		[Token(Token = "0x40012D3")]
		private const int TOKEN_COMMA = 6;

		[Token(Token = "0x40012D4")]
		private const int TOKEN_STRING = 7;

		[Token(Token = "0x40012D5")]
		private const int TOKEN_NUMBER = 8;

		[Token(Token = "0x40012D6")]
		private const int TOKEN_TRUE = 9;

		[Token(Token = "0x40012D7")]
		private const int TOKEN_FALSE = 10;

		[Token(Token = "0x40012D8")]
		private const int TOKEN_NULL = 11;

		[Token(Token = "0x40012D9")]
		private const int BUILDER_CAPACITY = 2000;

		[Token(Token = "0x40012DA")]
		[FieldOffset(Offset = "0x0")]
		protected static int lastErrorIndex;

		[Token(Token = "0x40012DB")]
		[FieldOffset(Offset = "0x8")]
		protected static string lastDecode;

		[Token(Token = "0x40012DC")]
		[FieldOffset(Offset = "0x10")]
		private static StringBuilder stringBuilder;

		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0xBAD7E4", Offset = "0xBAD7E4", VA = "0xBAD7E4")]
		public static object jsonDecode(string json)
		{
			return null;
		}

		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0xBADBD8", Offset = "0xBADBD8", VA = "0xBADBD8")]
		public static string jsonEncode(object json)
		{
			return null;
		}

		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0xBAE2B0", Offset = "0xBAE2B0", VA = "0xBAE2B0")]
		public static bool lastDecodeSuccessful()
		{
			return default(bool);
		}

		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0xBAE320", Offset = "0xBAE320", VA = "0xBAE320")]
		public static int getLastErrorIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6001EA0")]
		[Address(RVA = "0xBAE388", Offset = "0xBAE388", VA = "0xBAE388")]
		public static string getLastErrorSnippet()
		{
			return null;
		}

		[Token(Token = "0x6001EA1")]
		[Address(RVA = "0xBAE518", Offset = "0xBAE518", VA = "0xBAE518")]
		protected static Hashtable parseObject(char[] json, ref int index)
		{
			return null;
		}

		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0xBAF0FC", Offset = "0xBAF0FC", VA = "0xBAF0FC")]
		protected static ArrayList parseArray(char[] json, ref int index)
		{
			return null;
		}

		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0xBAD95C", Offset = "0xBAD95C", VA = "0xBAD95C")]
		protected static object parseValue(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0xBAEBF0", Offset = "0xBAEBF0", VA = "0xBAEBF0")]
		protected static string parseString(char[] json, ref int index)
		{
			return null;
		}

		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0xBAF29C", Offset = "0xBAF29C", VA = "0xBAF29C")]
		protected static double parseNumber(char[] json, ref int index)
		{
			return default(double);
		}

		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0xBAF438", Offset = "0xBAF438", VA = "0xBAF438")]
		protected static int getLastIndexOfNumber(char[] json, int index)
		{
			return default(int);
		}

		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0xBAF370", Offset = "0xBAF370", VA = "0xBAF370")]
		protected static void eatWhitespace(char[] json, ref int index)
		{
		}

		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0xBAEB74", Offset = "0xBAEB74", VA = "0xBAEB74")]
		protected static int lookAhead(char[] json, int index)
		{
			return default(int);
		}

		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0xBAE714", Offset = "0xBAE714", VA = "0xBAE714")]
		protected static int nextToken(char[] json, ref int index)
		{
			return default(int);
		}

		[Token(Token = "0x6001EAA")]
		[Address(RVA = "0xBAF4F8", Offset = "0xBAF4F8", VA = "0xBAF4F8")]
		protected static bool serializeObject(Hashtable anObject, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EAB")]
		[Address(RVA = "0xBAFAC4", Offset = "0xBAFAC4", VA = "0xBAFAC4")]
		protected static bool serializeDictionary(Dictionary<string, object> dict, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EAC")]
		[Address(RVA = "0xBAFDE8", Offset = "0xBAFDE8", VA = "0xBAFDE8")]
		protected static bool serializeArray(ArrayList anArray, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EAD")]
		[Address(RVA = "0xBADC90", Offset = "0xBADC90", VA = "0xBADC90")]
		protected static bool serializeValue(object value, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EAE")]
		[Address(RVA = "0xBAF7E8", Offset = "0xBAF7E8", VA = "0xBAF7E8")]
		protected static void serializeString(string aString, StringBuilder builder)
		{
		}

		[Token(Token = "0x6001EAF")]
		[Address(RVA = "0xBAFF48", Offset = "0xBAFF48", VA = "0xBAFF48")]
		protected static void serializeNumber(double number, StringBuilder builder)
		{
		}

		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0xBAFFDC", Offset = "0xBAFFDC", VA = "0xBAFFDC")]
		public MiniJSON()
		{
		}
	}
}
