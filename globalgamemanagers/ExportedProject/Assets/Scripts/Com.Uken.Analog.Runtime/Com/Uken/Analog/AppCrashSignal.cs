using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200001F")]
	public class AppCrashSignal : BaseEvent
	{
		[Token(Token = "0x4000076")]
		private const string TYPE = "app_crash";

		[Token(Token = "0x4000077")]
		private const string NAME = "signal";

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x16D4A54", Offset = "0x16D4A54", VA = "0x16D4A54")]
		public AppCrashSignal(DateTime crashDateTime, string stackTrace)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x16D4B64", Offset = "0x16D4B64", VA = "0x16D4B64", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}
	}
}
