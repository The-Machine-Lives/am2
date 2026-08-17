using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Firebase.Crashlytics
{
	[Token(Token = "0x200000F")]
	internal class LoggedException : Exception
	{
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817B84", Offset = "0x817B84")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x817B84", Offset = "0x817B84")]
		private string _003CName_003Ek__BackingField;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817BC0", Offset = "0x817BC0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x817BC0", Offset = "0x817BC0")]
		private string _003CCustomStackTrace_003Ek__BackingField;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817BFC", Offset = "0x817BFC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x817BFC", Offset = "0x817BFC")]
		private Dictionary<string, string>[] _003CParsedStackTrace_003Ek__BackingField;

		[Token(Token = "0x1700000F")]
		public string Name
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x17A27F0", Offset = "0x17A27F0", VA = "0x17A27F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818214", Offset = "0x818214")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x17A9260", Offset = "0x17A9260", VA = "0x17A9260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818224", Offset = "0x818224")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public string CustomStackTrace
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x17A9270", Offset = "0x17A9270", VA = "0x17A9270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818234", Offset = "0x818234")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x17A9268", Offset = "0x17A9268", VA = "0x17A9268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818244", Offset = "0x818244")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Dictionary<string, string>[] ParsedStackTrace
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x17A1E50", Offset = "0x17A1E50", VA = "0x17A1E50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818254", Offset = "0x818254")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x17A9534", Offset = "0x17A9534", VA = "0x17A9534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818264", Offset = "0x818264")]
			private set
			{
			}
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x17A80B4", Offset = "0x17A80B4", VA = "0x17A80B4")]
		public LoggedException(string name, string message, string stackTrace)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x17A1C5C", Offset = "0x17A1C5C", VA = "0x17A1C5C")]
		public static LoggedException FromException(Exception exception)
		{
			return null;
		}
	}
}
