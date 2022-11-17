using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000538")]
	public class PurchaseItem
	{
		[Token(Token = "0x40018B8")]
		[FieldOffset(Offset = "0x10")]
		private RDPurchaseItem m_purchaseItemData;

		[Token(Token = "0x40018B9")]
		[FieldOffset(Offset = "0x18")]
		private CasualGame m_game;

		[Token(Token = "0x40018BA")]
		[FieldOffset(Offset = "0x20")]
		private ItemController m_items;

		[Token(Token = "0x170006F5")]
		public string ItemName
		{
			[Token(Token = "0x60027FD")]
			[Address(RVA = "0xA79688", Offset = "0xA79688", VA = "0xA79688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F6")]
		public string ImageURL
		{
			[Token(Token = "0x60027FE")]
			[Address(RVA = "0xA796B4", Offset = "0xA796B4", VA = "0xA796B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F7")]
		public string BadgeTextTop
		{
			[Token(Token = "0x60027FF")]
			[Address(RVA = "0xA796E0", Offset = "0xA796E0", VA = "0xA796E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F8")]
		public string BadgeTextBottom
		{
			[Token(Token = "0x6002800")]
			[Address(RVA = "0xA7970C", Offset = "0xA7970C", VA = "0xA7970C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002801")]
		[Address(RVA = "0xA79738", Offset = "0xA79738", VA = "0xA79738")]
		public PurchaseItem(RDPurchaseItem productData, CasualGame game, ItemController items)
		{
		}

		[Token(Token = "0x6002802")]
		[Address(RVA = "0xA79778", Offset = "0xA79778", VA = "0xA79778")]
		public string GetQuantityAdjustedDisplayName()
		{
			return null;
		}

		[Token(Token = "0x6002803")]
		[Address(RVA = "0xA797F8", Offset = "0xA797F8", VA = "0xA797F8")]
		public int GetPurchaseScaledQuantity()
		{
			return default(int);
		}

		[Token(Token = "0x6002804")]
		[Address(RVA = "0xA79904", Offset = "0xA79904", VA = "0xA79904")]
		public string GetItemSpritePath()
		{
			return null;
		}

		[Token(Token = "0x6002805")]
		[Address(RVA = "0xA79964", Offset = "0xA79964", VA = "0xA79964")]
		public bool ShowsBadge()
		{
			return default(bool);
		}
	}
}
