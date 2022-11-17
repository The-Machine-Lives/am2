using System.Runtime.InteropServices;
using Com.Uken.NativeHelpers;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x2000007")]
	public class Analog
	{
		[Token(Token = "0x400000D")]
		public const string PREFS_PREFIX = "com_uken_analog";

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RuntimeContext eventContext;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool logValidationError;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnalogTime analogTime;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AnalogController analogController;

		[Token(Token = "0x17000005")]
		public RuntimeContext EventContext
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x16CFA70", Offset = "0x16CFA70", VA = "0x16CFA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x16CFA78", Offset = "0x16CFA78", VA = "0x16CFA78")]
			set
			{
			}
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x16CF830", Offset = "0x16CF830", VA = "0x16CF830")]
		public Analog(RuntimeContext eventContext, bool logValidationError, AnalogController analogController, string serverEndpoint, string apiKey, int maxEventQueueSize = 1000, [Optional] AnalogTime analogTime)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x16CFA80", Offset = "0x16CFA80", VA = "0x16CFA80")]
		public void Send(BaseEvent eventLog)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x16D00D8", Offset = "0x16D00D8", VA = "0x16D00D8")]
		public void SetLogLevel(UkenLogger.LogLevel logLevel)
		{
		}
	}
}
