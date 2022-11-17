using System;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000530")]
	public class SalesRecord
	{
		[Token(Token = "0x400188A")]
		[FieldOffset(Offset = "0x10")]
		protected MetadataItem m_salesRecordsMetadataItem;

		[Token(Token = "0x400188B")]
		[FieldOffset(Offset = "0x18")]
		protected int m_index;

		[Token(Token = "0x400188C")]
		public const string RECORD_LIMIT_TRAIT_NAME = "sales_records_limit";

		[Token(Token = "0x400188D")]
		public const string DYNAMIC_SALE_ITEM_REFERENCE_TRAIT_SUFFIX = "_dynamic_sale_item_reference";

		[Token(Token = "0x400188E")]
		public const string SALE_ITEM_REFERENCE_TRAIT_SUFFIX = "_sale_item_reference";

		[Token(Token = "0x400188F")]
		public const string ITERATION_TRAIT_SUFFIX = "_iteration";

		[Token(Token = "0x4001890")]
		public const string PURCHASE_COUNT_TRAIT_SUFFIX = "_purchase_count";

		[Token(Token = "0x4001891")]
		public const string TIMER_END_TIME = "_timer_end_time";

		[Token(Token = "0x4001892")]
		public const string VIEW_COUNT_PLAYER_PREFS_SUFFIX = "_sale_view_count";

		[Token(Token = "0x4001893")]
		public const string LAST_VIEWED_TIME_PLAYER_PREFS_SUFFIX = "_sale_last_viewed_time";

		[Token(Token = "0x4001894")]
		public const string LTO_SET_REFERENCE_TRAIT_SUFFIX = "_lto_set_reference";

		[Token(Token = "0x170006DB")]
		public string DynamicSaleReference
		{
			[Token(Token = "0x60027B5")]
			[Address(RVA = "0xA8EEEC", Offset = "0xA8EEEC", VA = "0xA8EEEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DC")]
		public string SaleReference
		{
			[Token(Token = "0x60027B6")]
			[Address(RVA = "0xA8EF84", Offset = "0xA8EF84", VA = "0xA8EF84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DD")]
		public string LTOSetReference
		{
			[Token(Token = "0x60027B7")]
			[Address(RVA = "0xA8F008", Offset = "0xA8F008", VA = "0xA8F008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DE")]
		public int Iteration
		{
			[Token(Token = "0x60027B8")]
			[Address(RVA = "0xA8F08C", Offset = "0xA8F08C", VA = "0xA8F08C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006DF")]
		public int PurchaseCount
		{
			[Token(Token = "0x60027B9")]
			[Address(RVA = "0xA8F13C", Offset = "0xA8F13C", VA = "0xA8F13C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006E0")]
		public int ViewCount
		{
			[Token(Token = "0x60027BA")]
			[Address(RVA = "0xA8F1A4", Offset = "0xA8F1A4", VA = "0xA8F1A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006E1")]
		public DateTime LastViewedTime
		{
			[Token(Token = "0x60027BB")]
			[Address(RVA = "0xA8F20C", Offset = "0xA8F20C", VA = "0xA8F20C")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x170006E2")]
		public DateTime TimerEndTime
		{
			[Token(Token = "0x60027BC")]
			[Address(RVA = "0xA8F378", Offset = "0xA8F378", VA = "0xA8F378")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x60027BD")]
		[Address(RVA = "0xA8F4F0", Offset = "0xA8F4F0", VA = "0xA8F4F0")]
		public SalesRecord(int index, MetadataItem salesRecordsMetadataItem)
		{
		}

		[Token(Token = "0x60027BE")]
		[Address(RVA = "0xA8F52C", Offset = "0xA8F52C", VA = "0xA8F52C")]
		public int GetIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60027BF")]
		[Address(RVA = "0xA8F0F4", Offset = "0xA8F0F4", VA = "0xA8F0F4")]
		private int GetIntTrait(string traitName)
		{
			return default(int);
		}

		[Token(Token = "0x60027C0")]
		[Address(RVA = "0xA8EF70", Offset = "0xA8EF70", VA = "0xA8EF70")]
		private string GetStringTrait(string traitName)
		{
			return null;
		}
	}
}
