using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000024")]
	public class ApplicationOpen : BaseEvent
	{
		[Token(Token = "0x4000082")]
		private const string TYPE = "application";

		[Token(Token = "0x4000083")]
		private const string NAME = "open";

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x70")]
		private ApplicationOpenEventData eventData;

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x16D4E6C", Offset = "0x16D4E6C", VA = "0x16D4E6C")]
		public ApplicationOpen()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x16D4F44", Offset = "0x16D4F44", VA = "0x16D4F44", Slot = "4")]
		public override void ApplyCustomData(RuntimeContext runtimeContext)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x16D4F8C", Offset = "0x16D4F8C", VA = "0x16D4F8C")]
		public ApplicationOpen SetFacebookId(string facebookId)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x16D4FD4", Offset = "0x16D4FD4", VA = "0x16D4FD4")]
		public ApplicationOpen SetGoogleplayservicesId(string googleplayservicesId)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x16D501C", Offset = "0x16D501C", VA = "0x16D501C")]
		public ApplicationOpen SetGamecenterId(string gamecenterId)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x16D5064", Offset = "0x16D5064", VA = "0x16D5064", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x16D5100", Offset = "0x16D5100", VA = "0x16D5100")]
		public string GetLanguage()
		{
			return null;
		}
	}
}
