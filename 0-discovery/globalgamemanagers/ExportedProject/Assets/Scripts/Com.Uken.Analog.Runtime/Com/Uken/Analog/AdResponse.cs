using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200001B")]
	public class AdResponse : BaseEvent
	{
		[Token(Token = "0x4000065")]
		private const string TYPE = "ad";

		[Token(Token = "0x4000066")]
		private const string NAME = "response";

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x70")]
		private AdResponseEventData eventData;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x16CE898", Offset = "0x16CE898", VA = "0x16CE898")]
		public AdResponse(AdType type, string provider, AdStatus status, string adId)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x16CE9F8", Offset = "0x16CE9F8", VA = "0x16CE9F8")]
		public AdResponse SetMessage(string message)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x16CEA40", Offset = "0x16CEA40", VA = "0x16CEA40")]
		public AdResponse SetRewardType(string rewardType)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x16CEA88", Offset = "0x16CEA88", VA = "0x16CEA88")]
		public AdResponse SetRewardQuantity(int rewardQuantity)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x16CEAD0", Offset = "0x16CEAD0", VA = "0x16CEAD0")]
		public AdResponse SetProviderPlacementId(string providerPlacementId)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x16CEB18", Offset = "0x16CEB18", VA = "0x16CEB18")]
		public AdResponse SetPlacement(string placement)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x16CEB60", Offset = "0x16CEB60", VA = "0x16CEB60")]
		public AdResponse SetEstUsdRevenue(int estUsdRevenue)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x16CEBEC", Offset = "0x16CEBEC", VA = "0x16CEBEC", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x16CECE0", Offset = "0x16CECE0", VA = "0x16CECE0")]
		public string GetProvider()
		{
			return null;
		}
	}
}
