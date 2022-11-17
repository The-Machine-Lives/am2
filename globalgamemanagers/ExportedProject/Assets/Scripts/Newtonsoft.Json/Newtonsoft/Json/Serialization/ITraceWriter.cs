using System;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200007B")]
	[Preserve]
	public interface ITraceWriter
	{
		[Token(Token = "0x17000082")]
		TraceLevel LevelFilter
		{
			[Token(Token = "0x6000352")]
			get;
		}

		[Token(Token = "0x6000353")]
		void Trace(TraceLevel level, string message, Exception ex);
	}
}
