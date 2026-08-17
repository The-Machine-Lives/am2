using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000539")]
	public class PurchaseItems : DepotController
	{
		[Token(Token = "0x40018BB")]
		[FieldOffset(Offset = "0x20")]
		protected CasualGame m_game;

		[Token(Token = "0x40018BC")]
		[FieldOffset(Offset = "0x28")]
		protected ItemController m_items;

		[Token(Token = "0x40018BD")]
		[FieldOffset(Offset = "0x30")]
		protected Dictionary<string, PurchaseItem> m_cachedPurchaseItems;

		[Token(Token = "0x170006F9")]
		protected DepotEntity<RDPurchaseItem> m_purchaseItems
		{
			[Token(Token = "0x6002806")]
			[Address(RVA = "0xA799CC", Offset = "0xA799CC", VA = "0xA799CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002807")]
		[Address(RVA = "0xA79B34", Offset = "0xA79B34", VA = "0xA79B34")]
		public PurchaseItems(CasualGame game, DataStoreController controller)
		{
		}

		[Token(Token = "0x6002808")]
		[Address(RVA = "0xA79BC0", Offset = "0xA79BC0", VA = "0xA79BC0", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6002809")]
		[Address(RVA = "0xA79C04", Offset = "0xA79C04", VA = "0xA79C04")]
		public PurchaseItem Get(string reference)
		{
			return null;
		}
	}
}
