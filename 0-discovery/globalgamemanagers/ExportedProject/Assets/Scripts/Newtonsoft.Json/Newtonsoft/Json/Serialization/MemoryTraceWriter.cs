using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200007D")]
	[Preserve]
	public class MemoryTraceWriter : ITraceWriter
	{
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x10")]
		private readonly Queue<string> _traceMessages;

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F7D8", Offset = "0x80F7D8")]
		private TraceLevel _003CLevelFilter_003Ek__BackingField;

		[Token(Token = "0x17000089")]
		public TraceLevel LevelFilter
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0xF05854", Offset = "0xF05854", VA = "0xF05854", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810538", Offset = "0x810538")]
			get
			{
				return default(TraceLevel);
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0xF0585C", Offset = "0xF0585C", VA = "0xF0585C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810548", Offset = "0x810548")]
			set
			{
			}
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xF05864", Offset = "0xF05864", VA = "0xF05864")]
		public MemoryTraceWriter()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xF058E0", Offset = "0xF058E0", VA = "0xF058E0", Slot = "5")]
		public void Trace(TraceLevel level, string message, Exception ex)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xF05B80", Offset = "0xF05B80", VA = "0xF05B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
