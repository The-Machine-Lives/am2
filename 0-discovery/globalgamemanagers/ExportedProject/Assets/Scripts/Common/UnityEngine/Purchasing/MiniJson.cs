using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000002")]
	internal class MiniJson
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		protected static int s_LastErrorIndex;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		protected static string s_LastDecode;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x180BC90", Offset = "0x180BC90", VA = "0x180BC90")]
		public static object JsonDecode(string json)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x180C02C", Offset = "0x180C02C", VA = "0x180C02C")]
		public static string JsonEncode(object json)
		{
			return null;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x180C77C", Offset = "0x180C77C", VA = "0x180C77C")]
		protected static Dictionary<string, object> ParseObject(char[] json, ref int index)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x180D194", Offset = "0x180D194", VA = "0x180D194")]
		protected static List<object> ParseArray(char[] json, ref int index)
		{
			return null;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x180BDB0", Offset = "0x180BDB0", VA = "0x180BDB0")]
		protected static object ParseValue(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x180CE6C", Offset = "0x180CE6C", VA = "0x180CE6C")]
		protected static string ParseString(char[] json, ref int index)
		{
			return null;
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x180D33C", Offset = "0x180D33C", VA = "0x180D33C")]
		protected static double ParseNumber(char[] json, ref int index)
		{
			return default(double);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x180D554", Offset = "0x180D554", VA = "0x180D554")]
		protected static int GetLastIndexOfNumber(char[] json, int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x180D48C", Offset = "0x180D48C", VA = "0x180D48C")]
		protected static void EatWhitespace(char[] json, ref int index)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x180CDF0", Offset = "0x180CDF0", VA = "0x180CDF0")]
		protected static int LookAhead(char[] json, int index)
		{
			return default(int);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x180C988", Offset = "0x180C988", VA = "0x180C988")]
		protected static int NextToken(char[] json, ref int index)
		{
			return default(int);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x180D614", Offset = "0x180D614", VA = "0x180D614")]
		protected static bool SerializeObject(Dictionary<string, object> anObject, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x180DC14", Offset = "0x180DC14", VA = "0x180DC14")]
		protected static bool SerializeDictionary(Dictionary<string, string> dict, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x180DE58", Offset = "0x180DE58", VA = "0x180DE58")]
		protected static bool SerializeArray(List<object> anArray, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x180C0E4", Offset = "0x180C0E4", VA = "0x180C0E4")]
		protected static bool SerializeValue(object value, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x180D938", Offset = "0x180D938", VA = "0x180D938")]
		protected static void SerializeString(string aString, StringBuilder builder)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x180DFCC", Offset = "0x180DFCC", VA = "0x180DFCC")]
		protected static void SerializeNumber(double number, StringBuilder builder)
		{
		}
	}
}
