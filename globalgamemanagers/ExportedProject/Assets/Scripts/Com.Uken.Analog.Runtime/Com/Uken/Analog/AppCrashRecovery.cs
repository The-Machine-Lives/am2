using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200001D")]
	public class AppCrashRecovery : BaseEvent
	{
		[Token(Token = "0x4000072")]
		private const string TYPE = "app_crash";

		[Token(Token = "0x4000073")]
		private const string NAME = "recovery";

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x16D4810", Offset = "0x16D4810", VA = "0x16D4810")]
		public AppCrashRecovery(DateTime crashDateTime, string lastSceneView)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x16D4920", Offset = "0x16D4920", VA = "0x16D4920", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}
	}
}
