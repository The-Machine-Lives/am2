using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Com.Uken.ApiClient
{
	[Token(Token = "0x200000C")]
	public class RetrySettings
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815EA0", Offset = "0x815EA0")]
		private int _003CMaxRetries_003Ek__BackingField;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815EB0", Offset = "0x815EB0")]
		private int _003CInitialBackoffMilliseconds_003Ek__BackingField;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815EC0", Offset = "0x815EC0")]
		private int _003CMaxBackoffMilliseconds_003Ek__BackingField;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815ED0", Offset = "0x815ED0")]
		private HashSet<int> _003CNoRetryErrorCodes_003Ek__BackingField;

		[Token(Token = "0x17000005")]
		public int MaxRetries
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x17FB914", Offset = "0x17FB914", VA = "0x17FB914")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815FCC", Offset = "0x815FCC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x17FC38C", Offset = "0x17FC38C", VA = "0x17FC38C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815FDC", Offset = "0x815FDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public int InitialBackoffMilliseconds
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x17FB90C", Offset = "0x17FB90C", VA = "0x17FB90C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815FEC", Offset = "0x815FEC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x17FC394", Offset = "0x17FC394", VA = "0x17FC394")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815FFC", Offset = "0x815FFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public int MaxBackoffMilliseconds
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x17FB91C", Offset = "0x17FB91C", VA = "0x17FB91C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81600C", Offset = "0x81600C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x17FC39C", Offset = "0x17FC39C", VA = "0x17FC39C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81601C", Offset = "0x81601C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public HashSet<int> NoRetryErrorCodes
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x17FB904", Offset = "0x17FB904", VA = "0x17FB904")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81602C", Offset = "0x81602C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x17FC3A4", Offset = "0x17FC3A4", VA = "0x17FC3A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81603C", Offset = "0x81603C")]
			set
			{
			}
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x17FB8B4", Offset = "0x17FB8B4", VA = "0x17FB8B4")]
		public RetrySettings(int maxRetries = 0, int initialBackoffMilliseconds = 0, int maxBackoffMilliseconds = int.MaxValue, [Optional] HashSet<int> noRetryErrorCodes)
		{
		}
	}
}
