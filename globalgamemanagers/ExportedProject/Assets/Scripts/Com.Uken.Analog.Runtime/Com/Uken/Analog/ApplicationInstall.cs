using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000022")]
	public class ApplicationInstall : BaseEvent
	{
		[Token(Token = "0x400007E")]
		private const string TYPE = "application";

		[Token(Token = "0x400007F")]
		private const string NAME = "install";

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x70")]
		private ApplicationInstallEventData eventData;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x16D1580", Offset = "0x16D1580", VA = "0x16D1580")]
		public ApplicationInstall()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x16D4CA0", Offset = "0x16D4CA0", VA = "0x16D4CA0", Slot = "4")]
		public override void ApplyCustomData(RuntimeContext runtimeContext)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x16D4CF0", Offset = "0x16D4CF0", VA = "0x16D4CF0", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x16D4D8C", Offset = "0x16D4D8C", VA = "0x16D4D8C")]
		public string GetLanguage()
		{
			return null;
		}
	}
}
