using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.CommandHandlerSystem
{
	[Token(Token = "0x200000A")]
	public class Utils
	{
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x0")]
		private static string[] _colorNames;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x17E2778", Offset = "0x17E2778", VA = "0x17E2778")]
		public static object GetArgumentValueFromString(string argument, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x17E57CC", Offset = "0x17E57CC", VA = "0x17E57CC")]
		private static Color GetColorFromArgument(string argument)
		{
			return default(Color);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x17E4CB0", Offset = "0x17E4CB0", VA = "0x17E4CB0")]
		public static IEnumerable<string> GetDefaultParameterPossibleOptions(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x17E32E4", Offset = "0x17E32E4", VA = "0x17E32E4")]
		public static string GetFriendlyTypeName(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x17E5E18", Offset = "0x17E5E18", VA = "0x17E5E18")]
		public static string WrapInQuotesIfNecessary(string s)
		{
			return null;
		}
	}
}
