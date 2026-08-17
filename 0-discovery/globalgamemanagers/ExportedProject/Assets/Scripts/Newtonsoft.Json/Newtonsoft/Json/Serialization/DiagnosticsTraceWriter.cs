using System;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000079")]
	[Preserve]
	public class DiagnosticsTraceWriter : ITraceWriter
	{
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F788", Offset = "0x80F788")]
		private TraceLevel _003CLevelFilter_003Ek__BackingField;

		[Token(Token = "0x17000081")]
		public TraceLevel LevelFilter
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0xD110AC", Offset = "0xD110AC", VA = "0xD110AC", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8104A8", Offset = "0x8104A8")]
			get
			{
				return default(TraceLevel);
			}
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xD110B4", Offset = "0xD110B4", VA = "0xD110B4")]
		private TraceEventType GetTraceEventType(TraceLevel level)
		{
			return default(TraceEventType);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xD11150", Offset = "0xD11150", VA = "0xD11150", Slot = "5")]
		public void Trace(TraceLevel level, string message, Exception ex)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xD11610", Offset = "0xD11610", VA = "0xD11610")]
		public DiagnosticsTraceWriter()
		{
		}
	}
}
