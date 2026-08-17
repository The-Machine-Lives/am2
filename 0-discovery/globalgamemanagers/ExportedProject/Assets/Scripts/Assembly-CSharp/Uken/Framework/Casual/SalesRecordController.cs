using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000542")]
	public class SalesRecordController : UkenController
	{
		[Token(Token = "0x40018F7")]
		private const int MAX_ALLOWABLE_SALES_RECORDS = 30;

		[Token(Token = "0x40018F8")]
		private const string SALES_RECORDS_METADATA_ITEM_NAME = "sales_records_V2";

		[Token(Token = "0x40018F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CasualGame m_game;

		[Token(Token = "0x40018FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InventoryController m_inventory;

		[Token(Token = "0x40018FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UkenTimeController m_time;

		[Token(Token = "0x40018FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DynamicOfferSets m_offerSets;

		[Token(Token = "0x40018FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MetadataItem m_salesRecordsMetadataItem;

		[Token(Token = "0x40018FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SalesRecordV2[] m_salesRecords;

		[Token(Token = "0x6002826")]
		[Address(RVA = "0xA8F534", Offset = "0xA8F534", VA = "0xA8F534")]
		public SalesRecordController(CasualGame game)
		{
		}

		[Token(Token = "0x6002827")]
		[Address(RVA = "0xA8F560", Offset = "0xA8F560", VA = "0xA8F560", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6002828")]
		[Address(RVA = "0xA8F5E4", Offset = "0xA8F5E4", VA = "0xA8F5E4", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x6002829")]
		[Address(RVA = "0xA8F7E4", Offset = "0xA8F7E4", VA = "0xA8F7E4")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600282A")]
		[Address(RVA = "0xA8F828", Offset = "0xA8F828", VA = "0xA8F828")]
		public SalesRecordV2 GetExistingSalesRecord(DynamicOfferSet offerSet)
		{
			return null;
		}

		[Token(Token = "0x600282B")]
		[Address(RVA = "0xA8FAA0", Offset = "0xA8FAA0", VA = "0xA8FAA0")]
		public bool ReserveSalesRecord(DynamicOfferSet offerSet, int offerIndex, Sale sale, int viewEndTime, int recordExpiryTime, string source)
		{
			return default(bool);
		}

		[Token(Token = "0x600282C")]
		[Address(RVA = "0xA8FF64", Offset = "0xA8FF64", VA = "0xA8FF64")]
		public void UpdateSaleOnRecord(DynamicOfferSet offerSet, int offerIndex, Sale sale, int viewExpiry, bool resetViewData)
		{
		}

		[Token(Token = "0x600282D")]
		[Address(RVA = "0xA901EC", Offset = "0xA901EC", VA = "0xA901EC")]
		public void RecordSaleView(DynamicOfferSet offerSet)
		{
		}

		[Token(Token = "0x600282E")]
		[Address(RVA = "0xA90368", Offset = "0xA90368", VA = "0xA90368")]
		public void IncrementPurchaseCount(DynamicOfferSet offerSet)
		{
		}

		[Token(Token = "0x600282F")]
		[Address(RVA = "0xA90560", Offset = "0xA90560", VA = "0xA90560")]
		public void DecrementPurchaseCount(DynamicOfferSet offerSet)
		{
		}

		[Token(Token = "0x6002830")]
		[Address(RVA = "0xA8FE5C", Offset = "0xA8FE5C", VA = "0xA8FE5C")]
		private SalesRecordV2 GetEmptySalesRecord()
		{
			return null;
		}

		[Token(Token = "0x6002831")]
		[Address(RVA = "0xA906B8", Offset = "0xA906B8", VA = "0xA906B8")]
		public List<SalesRecordV2> GetActiveRecords([Optional] string source)
		{
			return null;
		}
	}
}
