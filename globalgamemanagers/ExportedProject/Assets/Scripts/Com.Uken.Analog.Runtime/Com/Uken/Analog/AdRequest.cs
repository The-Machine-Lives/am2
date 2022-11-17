using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000019")]
	public class AdRequest : BaseEvent
	{
		[Token(Token = "0x400005B")]
		private const string TYPE = "ad";

		[Token(Token = "0x400005C")]
		private const string NAME = "request";

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x70")]
		private AdRequestEventData eventData;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x16CE24C", Offset = "0x16CE24C", VA = "0x16CE24C")]
		public AdRequest(AdType type, string provider, string adId)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x16CE38C", Offset = "0x16CE38C", VA = "0x16CE38C")]
		public AdRequest SetRewardType(string rewardType)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x16CE3D4", Offset = "0x16CE3D4", VA = "0x16CE3D4")]
		public AdRequest SetRewardQuantity(int rewardQuantity)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x16CE460", Offset = "0x16CE460", VA = "0x16CE460")]
		public AdRequest SetPlacement(string placement)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x16CE4A8", Offset = "0x16CE4A8", VA = "0x16CE4A8")]
		public AdRequest SetProviderPlacementId(string providerPlacementId)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x16CE4F0", Offset = "0x16CE4F0", VA = "0x16CE4F0", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x16CE5E4", Offset = "0x16CE5E4", VA = "0x16CE5E4")]
		public string GetProvider()
		{
			return null;
		}
	}
}
