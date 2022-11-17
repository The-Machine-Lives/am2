using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000535")]
	public class DynamicOfferSets : DepotController
	{
		[Token(Token = "0x40018A7")]
		[FieldOffset(Offset = "0x20")]
		private CasualGame m_game;

		[Token(Token = "0x40018A8")]
		[FieldOffset(Offset = "0x28")]
		private DynamicOffers m_offers;

		[Token(Token = "0x40018A9")]
		[FieldOffset(Offset = "0x30")]
		private UkenTimeController m_time;

		[Token(Token = "0x40018AA")]
		[FieldOffset(Offset = "0x38")]
		private SalesRecordController m_salesRecords;

		[Token(Token = "0x40018AB")]
		[FieldOffset(Offset = "0x40")]
		private InventoryController m_inventory;

		[Token(Token = "0x40018AC")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, DynamicOfferSet> m_cachedOfferSets;

		[Token(Token = "0x170006F3")]
		private DepotEntity<RDDynamicOfferSet> m_setData
		{
			[Token(Token = "0x60027F2")]
			[Address(RVA = "0xA5F25C", Offset = "0xA5F25C", VA = "0xA5F25C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027F3")]
		[Address(RVA = "0xA5F3C4", Offset = "0xA5F3C4", VA = "0xA5F3C4")]
		public DynamicOfferSets(CasualGame game, DataStoreController controller)
		{
		}

		[Token(Token = "0x60027F4")]
		[Address(RVA = "0xA5F450", Offset = "0xA5F450", VA = "0xA5F450", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60027F5")]
		[Address(RVA = "0xA5F4F4", Offset = "0xA5F4F4", VA = "0xA5F4F4", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x60027F6")]
		[Address(RVA = "0xA5F4FC", Offset = "0xA5F4FC", VA = "0xA5F4FC")]
		public DynamicOfferSet Get(string reference)
		{
			return null;
		}

		[Token(Token = "0x60027F7")]
		[Address(RVA = "0xA5F694", Offset = "0xA5F694", VA = "0xA5F694")]
		public List<DynamicOfferSet> GetActiveSetsBySource(string source)
		{
			return null;
		}

		[Token(Token = "0x60027F8")]
		[Address(RVA = "0xA5F84C", Offset = "0xA5F84C", VA = "0xA5F84C")]
		public void RefreshActiveHudSales()
		{
		}
	}
}
