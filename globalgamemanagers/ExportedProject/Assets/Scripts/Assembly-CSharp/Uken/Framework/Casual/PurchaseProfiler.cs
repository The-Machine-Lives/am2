using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000528")]
	public class PurchaseProfiler : UkenController
	{
		[Token(Token = "0x400183D")]
		public const string SALES_RECORDS_METADATA_ITEM_NAME = "sales_records";

		[Token(Token = "0x400183E")]
		[FieldOffset(Offset = "0x18")]
		protected InventoryController m_inventory;

		[Token(Token = "0x400183F")]
		[FieldOffset(Offset = "0x20")]
		protected MetadataItem m_salesRecordsMetadataItem;

		[Token(Token = "0x4001840")]
		[FieldOffset(Offset = "0x28")]
		protected SalesRecord[] m_salesRecords;

		[Token(Token = "0x4001841")]
		[FieldOffset(Offset = "0x30")]
		protected Func<DateTime> m_currentTimeCallback;

		[Token(Token = "0x4001842")]
		[FieldOffset(Offset = "0x38")]
		protected int m_maxAllowableSalesRecords;

		[Token(Token = "0x600277E")]
		[Address(RVA = "0xA79D80", Offset = "0xA79D80", VA = "0xA79D80")]
		public PurchaseProfiler(Func<DateTime> currentTimeCallback, InventoryController inventory)
		{
		}

		[Token(Token = "0x600277F")]
		[Address(RVA = "0xA79DC4", Offset = "0xA79DC4", VA = "0xA79DC4", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x6002780")]
		[Address(RVA = "0xA79FF0", Offset = "0xA79FF0", VA = "0xA79FF0", Slot = "10")]
		public virtual bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6002781")]
		[Address(RVA = "0xA7A018", Offset = "0xA7A018", VA = "0xA7A018")]
		protected void ClearSalesRecord(int index)
		{
		}

		[Token(Token = "0x6002782")]
		[Address(RVA = "0xA7A228", Offset = "0xA7A228", VA = "0xA7A228")]
		public List<SalesRecord> GetActiveSalesRecords()
		{
			return null;
		}

		[Token(Token = "0x6002783")]
		[Address(RVA = "0xA7A39C", Offset = "0xA7A39C", VA = "0xA7A39C")]
		protected SalesRecord GetEmptySalesRecord()
		{
			return null;
		}

		[Token(Token = "0x6002784")]
		[Address(RVA = "0xA7A3BC", Offset = "0xA7A3BC", VA = "0xA7A3BC")]
		public SalesRecord GetSalesRecord(DynamicSaleItem dynamicSaleItem)
		{
			return null;
		}

		[Token(Token = "0x6002785")]
		[Address(RVA = "0xA79F94", Offset = "0xA79F94", VA = "0xA79F94")]
		public void CleanUpExcessSalesRecords(int maxAllowableRecords)
		{
		}

		[Token(Token = "0x6002786")]
		[Address(RVA = "0xA7A534", Offset = "0xA7A534", VA = "0xA7A534")]
		private int GetRecordLimit()
		{
			return default(int);
		}

		[Token(Token = "0x6002787")]
		[Address(RVA = "0xA7A5BC", Offset = "0xA7A5BC", VA = "0xA7A5BC")]
		private void SetRecordLimit(int limit)
		{
		}

		[Token(Token = "0x6002788")]
		[Address(RVA = "0xA7A644", Offset = "0xA7A644", VA = "0xA7A644")]
		public void LTOSetRecordClear(SalesRecord salesRecord)
		{
		}

		[Token(Token = "0x6002789")]
		[Address(RVA = "0xA7A648", Offset = "0xA7A648", VA = "0xA7A648")]
		protected void ClearSalesRecord(SalesRecord salesRecord)
		{
		}

		[Token(Token = "0x600278A")]
		[Address(RVA = "0xA7A688", Offset = "0xA7A688", VA = "0xA7A688")]
		public void ClearExpiredUnlimitedSalesRecords()
		{
		}

		[Token(Token = "0x600278B")]
		[Address(RVA = "0xA7A68C", Offset = "0xA7A68C", VA = "0xA7A68C")]
		public bool ReserveSalesRecord(DynamicSaleItem dynamicSaleItem, SaleItem saleItem)
		{
			return default(bool);
		}

		[Token(Token = "0x600278C")]
		[Address(RVA = "0xA7A6F8", Offset = "0xA7A6F8", VA = "0xA7A6F8")]
		public bool UpdateSaleItemOnRecord(DynamicSaleItem dynamicSaleItem, SaleItem saleItem)
		{
			return default(bool);
		}

		[Token(Token = "0x600278D")]
		[Address(RVA = "0xA7A7DC", Offset = "0xA7A7DC", VA = "0xA7A7DC")]
		public void RecordSaleView(DynamicSaleItem viewedSale)
		{
		}

		[Token(Token = "0x600278E")]
		[Address(RVA = "0xA7A924", Offset = "0xA7A924", VA = "0xA7A924")]
		public void OnSalePurchased(DynamicSaleItem purchasedItem)
		{
		}

		[Token(Token = "0x600278F")]
		[Address(RVA = "0xA7AAD4", Offset = "0xA7AAD4", VA = "0xA7AAD4")]
		public void OnSaleSucceeded(DynamicSaleItem purchasedItem)
		{
		}

		[Token(Token = "0x6002790")]
		[Address(RVA = "0xA7AB74", Offset = "0xA7AB74", VA = "0xA7AB74")]
		public void OnSaleFailed(DynamicSaleItem purchasedItem)
		{
		}

		[Token(Token = "0x6002791")]
		[Address(RVA = "0xA7A9B4", Offset = "0xA7A9B4", VA = "0xA7A9B4")]
		protected void IncrementSalesRecordPurchaseCount(SalesRecord salesRecord)
		{
		}

		[Token(Token = "0x6002792")]
		[Address(RVA = "0xA7AC04", Offset = "0xA7AC04", VA = "0xA7AC04")]
		protected void DecrementSalesRecordPurchaseCount(SalesRecord salesRecord)
		{
		}

		[Token(Token = "0x6002793")]
		[Address(RVA = "0xA7AD24", Offset = "0xA7AD24", VA = "0xA7AD24", Slot = "11")]
		protected virtual void ForceSaveInventoryData()
		{
		}
	}
}
