using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x200001E")]
	internal class MethodArguments
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<string, object> arguments;

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xCCABD8", Offset = "0xCCABD8", VA = "0xCCABD8")]
		public MethodArguments()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xCE10C4", Offset = "0xCE10C4", VA = "0xCE10C4")]
		public MethodArguments(MethodArguments methodArgs)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xCE1040", Offset = "0xCE1040", VA = "0xCE1040")]
		private MethodArguments(IDictionary<string, object> arguments)
		{
		}

		[Token(Token = "0x60000DD")]
		public void AddPrimative<T>(string argumentName, T value) where T : struct
		{
		}

		[Token(Token = "0x60000DE")]
		public void AddNullablePrimitive<T>(string argumentName, T? nullable) where T : struct
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xCCAC44", Offset = "0xCCAC44", VA = "0xCCAC44")]
		public void AddString(string argumentName, string value)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xCCB86C", Offset = "0xCCB86C", VA = "0xCCB86C")]
		public void AddCommaSeparatedList(string argumentName, IEnumerable<string> value)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xCE10F8", Offset = "0xCE10F8", VA = "0xCE10F8")]
		public void AddDictionary(string argumentName, IDictionary<string, object> dict)
		{
		}

		[Token(Token = "0x60000E2")]
		public void AddList<T>(string argumentName, IEnumerable<T> list)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xCCBC04", Offset = "0xCCBC04", VA = "0xCCBC04")]
		public void AddUri(string argumentName, Uri uri)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xCCAD9C", Offset = "0xCCAD9C", VA = "0xCCAD9C")]
		public string ToJsonString()
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xCE11E8", Offset = "0xCE11E8", VA = "0xCE11E8")]
		private static Dictionary<string, string> ToStringDict(IDictionary<string, object> dict)
		{
			return null;
		}
	}
}
