using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000543")]
	public class SalesRecordV2
	{
		[Token(Token = "0x40018FF")]
		[FieldOffset(Offset = "0x10")]
		protected MetadataItem m_salesRecord;

		[Token(Token = "0x4001900")]
		[FieldOffset(Offset = "0x18")]
		protected int m_index;

		[Token(Token = "0x4001901")]
		public const string RECORD_LIMIT_TRAIT_NAME = "sales_records_limit";

		[Token(Token = "0x4001902")]
		public const string OFFER_SET_REFERENCE_TRAIT_SUFFIX = "_offer_set_reference";

		[Token(Token = "0x4001903")]
		public const string OFFER_INDEX_TRAIT_SUFFIX = "_offer_index";

		[Token(Token = "0x4001904")]
		public const string SALE_REFERENCE_TRAIT_SUFFIX = "_sale_reference";

		[Token(Token = "0x4001905")]
		public const string RECORD_EXPIRY_TRAIT_SUFFIX = "_record_expiry";

		[Token(Token = "0x4001906")]
		public const string VIEW_EXPIRY_TRAIT_SUFFIX = "_view_expiry";

		[Token(Token = "0x4001907")]
		public const string PURCHASE_COUNT_TRAIT_SUFFIX = "_purchase_count";

		[Token(Token = "0x4001908")]
		public const string TRIGGER_SOURCE_TRAIT_SUFFIX = "_trigger_source";

		[Token(Token = "0x4001909")]
		public const string VIEW_COUNT_PLAYER_PREFS_SUFFIX = "_sale_view_count_v2";

		[Token(Token = "0x400190A")]
		public const string LAST_VIEWED_TIME_PLAYER_PREFS_SUFFIX = "_sale_last_viewed_time_v2";

		[Token(Token = "0x17000701")]
		public string OfferSetReference
		{
			[Token(Token = "0x6002833")]
			[Address(RVA = "0xA8F958", Offset = "0xA8F958", VA = "0xA8F958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000702")]
		public int OfferIndex
		{
			[Token(Token = "0x6002834")]
			[Address(RVA = "0xA908D8", Offset = "0xA908D8", VA = "0xA908D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000703")]
		public string SaleReference
		{
			[Token(Token = "0x6002835")]
			[Address(RVA = "0xA90978", Offset = "0xA90978", VA = "0xA90978")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000704")]
		public int PurchaseCount
		{
			[Token(Token = "0x6002836")]
			[Address(RVA = "0xA904C0", Offset = "0xA904C0", VA = "0xA904C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000705")]
		public int ViewCount
		{
			[Token(Token = "0x6002837")]
			[Address(RVA = "0xA902E4", Offset = "0xA902E4", VA = "0xA902E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000706")]
		public int LastViewedTime
		{
			[Token(Token = "0x6002838")]
			[Address(RVA = "0xA90A20", Offset = "0xA90A20", VA = "0xA90A20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000707")]
		public int ViewExpiry
		{
			[Token(Token = "0x6002839")]
			[Address(RVA = "0xA90AA4", Offset = "0xA90AA4", VA = "0xA90AA4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000708")]
		public int RecordExpiry
		{
			[Token(Token = "0x600283A")]
			[Address(RVA = "0xA8FA00", Offset = "0xA8FA00", VA = "0xA8FA00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000709")]
		public string TriggerSource
		{
			[Token(Token = "0x600283B")]
			[Address(RVA = "0xA90830", Offset = "0xA90830", VA = "0xA90830")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002832")]
		[Address(RVA = "0xA8F7A8", Offset = "0xA8F7A8", VA = "0xA8F7A8")]
		public SalesRecordV2(int index, MetadataItem salesRecord)
		{
		}

		[Token(Token = "0x600283C")]
		[Address(RVA = "0xA8FF5C", Offset = "0xA8FF5C", VA = "0xA8FF5C")]
		public int GetIndex()
		{
			return default(int);
		}
	}
}
