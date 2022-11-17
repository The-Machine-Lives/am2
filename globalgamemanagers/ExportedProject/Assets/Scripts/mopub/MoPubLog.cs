using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200000A")]
public static class MoPubLog
{
	[Serializable]
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x812B10", Offset = "0x812B10")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<object, string> _003C_003E9__4_0;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x175E908", Offset = "0x175E908", VA = "0x175E908")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x175E910", Offset = "0x175E910", VA = "0x175E910")]
		internal string _003CLog_003Eb__4_0(object a)
		{
			return null;
		}
	}

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, MoPub.LogLevel> logLevelMap;

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x17552D4", Offset = "0x17552D4", VA = "0x17552D4")]
	public static void Log(string callerMethod, string message, params object[] args)
	{
	}
}
