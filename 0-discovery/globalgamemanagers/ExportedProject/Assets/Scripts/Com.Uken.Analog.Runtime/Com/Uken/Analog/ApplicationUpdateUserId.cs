using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000027")]
	public class ApplicationUpdateUserId : BaseEvent
	{
		[Token(Token = "0x400008F")]
		private const string TYPE = "application";

		[Token(Token = "0x4000090")]
		private const string NAME = "update_user_id";

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x70")]
		private ApplicationUpdateUserIdEventData eventData;

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x16D5A94", Offset = "0x16D5A94", VA = "0x16D5A94")]
		public ApplicationUpdateUserId(bool newUser)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x16D5BA0", Offset = "0x16D5BA0", VA = "0x16D5BA0", Slot = "4")]
		public override void ApplyCustomData(RuntimeContext runtimeContext)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x16D5BE8", Offset = "0x16D5BE8", VA = "0x16D5BE8")]
		public ApplicationUpdateUserId SetOldUserId(string oldUserId)
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x16D5C30", Offset = "0x16D5C30", VA = "0x16D5C30", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x16D5CCC", Offset = "0x16D5CCC", VA = "0x16D5CCC")]
		public string GetLanguage()
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x16D5D00", Offset = "0x16D5D00", VA = "0x16D5D00")]
		public bool GetNewUser()
		{
			return default(bool);
		}
	}
}
