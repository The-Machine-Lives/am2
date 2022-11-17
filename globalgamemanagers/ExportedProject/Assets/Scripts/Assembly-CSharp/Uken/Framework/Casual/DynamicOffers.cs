using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000533")]
	public class DynamicOffers : DepotController
	{
		[Token(Token = "0x400189A")]
		[FieldOffset(Offset = "0x20")]
		private CasualGame m_game;

		[Token(Token = "0x400189B")]
		[FieldOffset(Offset = "0x28")]
		private UserSegments m_userSegments;

		[Token(Token = "0x400189C")]
		[FieldOffset(Offset = "0x30")]
		private Sales m_sales;

		[Token(Token = "0x400189D")]
		[FieldOffset(Offset = "0x38")]
		private UserProfiler m_userProfiler;

		[Token(Token = "0x400189E")]
		[FieldOffset(Offset = "0x40")]
		private PurchaseItems m_purchaseItems;

		[Token(Token = "0x400189F")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, DynamicOffer> m_cachedOffers;

		[Token(Token = "0x170006E5")]
		private DepotEntity<RDDynamicOffer> m_offers
		{
			[Token(Token = "0x60027C6")]
			[Address(RVA = "0xA5FA04", Offset = "0xA5FA04", VA = "0xA5FA04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027C7")]
		[Address(RVA = "0xA5FB6C", Offset = "0xA5FB6C", VA = "0xA5FB6C")]
		public DynamicOffers(CasualGame game, DataStoreController controller)
		{
		}

		[Token(Token = "0x60027C8")]
		[Address(RVA = "0xA5FBF8", Offset = "0xA5FBF8", VA = "0xA5FBF8", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60027C9")]
		[Address(RVA = "0xA5E0A8", Offset = "0xA5E0A8", VA = "0xA5E0A8")]
		public DynamicOffer Get(string reference)
		{
			return null;
		}
	}
}
