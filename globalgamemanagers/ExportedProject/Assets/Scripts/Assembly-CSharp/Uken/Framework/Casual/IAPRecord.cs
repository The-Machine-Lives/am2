using System;
using Il2CppDummyDll;
using Uken.Library.Inventory;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000523")]
	public class IAPRecord
	{
		[Token(Token = "0x4001817")]
		[FieldOffset(Offset = "0x10")]
		public Func<DateTime> m_currentTimeCallback;

		[Token(Token = "0x4001818")]
		public const string IAP_RECORD_ITEM_NAME = "iap_record";

		[Token(Token = "0x4001819")]
		public const string CURRENT_LOGIN_TIMESTAMP_TRAIT = "current_login_timestamp";

		[Token(Token = "0x400181A")]
		public const string LAST_LOGIN_TIMESTAMP_TRAIT = "last_login_timestamp";

		[Token(Token = "0x400181B")]
		public const string LAST_IAP_TIMESTAMP_TRAIT = "last_iap_timestamp";

		[Token(Token = "0x400181C")]
		public const string IAP_MAX_TRAIT = "iap_max";

		[Token(Token = "0x400181D")]
		public const string IAP_TOTAL_TRAIT = "iap_total";

		[Token(Token = "0x400181E")]
		public const string IAP_COUNT_TRAIT = "iap_count";

		[Token(Token = "0x400181F")]
		public const string LAST_IAP_VALUE_TRAIT = "last_iap_value";

		[Token(Token = "0x4001820")]
		public const string LAST_IAP_NAME_TRAIT = "last_iap_name";

		[Token(Token = "0x4001821")]
		public const string HARD_CURRENCY_IAP_MAX_TRAIT = "hard_currency_iap_max";

		[Token(Token = "0x4001822")]
		public const string HARD_CURRENCY_IAP_TOTAL_TRAIT = "hard_currency_iap_total";

		[Token(Token = "0x4001823")]
		public const string HARD_CURRENCY_IAP_COUNT_TRAIT = "hard_currency_iap_count";

		[Token(Token = "0x4001824")]
		public const string SOFT_CURRENCY_IAP_MAX_TRAIT = "soft_currency_iap_max";

		[Token(Token = "0x4001825")]
		public const string SOFT_CURRENCY_IAP_TOTAL_TRAIT = "soft_currency_iap_total";

		[Token(Token = "0x4001826")]
		public const string SOFT_CURRENCY_IAP_COUNT_TRAIT = "soft_currency_iap_count";

		[Token(Token = "0x4001827")]
		[FieldOffset(Offset = "0x18")]
		protected MetadataItem m_recordItem;

		[Token(Token = "0x4001828")]
		[FieldOffset(Offset = "0x20")]
		protected string m_softCurrencyName;

		[Token(Token = "0x4001829")]
		[FieldOffset(Offset = "0x28")]
		protected string m_hardCurrencyName;

		[Token(Token = "0x400182A")]
		[FieldOffset(Offset = "0x30")]
		protected InventoryController m_inventory;

		[Token(Token = "0x170006B9")]
		public DateTime CurrentLoginTimestamp
		{
			[Token(Token = "0x6002730")]
			[Address(RVA = "0xA691C0", Offset = "0xA691C0", VA = "0xA691C0")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002731")]
			[Address(RVA = "0xA69258", Offset = "0xA69258", VA = "0xA69258")]
			protected set
			{
			}
		}

		[Token(Token = "0x170006BA")]
		public DateTime LastLoginTimestamp
		{
			[Token(Token = "0x6002732")]
			[Address(RVA = "0xA692F8", Offset = "0xA692F8", VA = "0xA692F8")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002733")]
			[Address(RVA = "0xA69388", Offset = "0xA69388", VA = "0xA69388")]
			protected set
			{
			}
		}

		[Token(Token = "0x170006BB")]
		public DateTime LastIAPTimestamp
		{
			[Token(Token = "0x6002734")]
			[Address(RVA = "0xA69414", Offset = "0xA69414", VA = "0xA69414")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002735")]
			[Address(RVA = "0xA694A4", Offset = "0xA694A4", VA = "0xA694A4")]
			protected set
			{
			}
		}

		[Token(Token = "0x170006BC")]
		public double IAPMax
		{
			[Token(Token = "0x6002736")]
			[Address(RVA = "0xA69530", Offset = "0xA69530", VA = "0xA69530")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6002737")]
			[Address(RVA = "0xA69598", Offset = "0xA69598", VA = "0xA69598")]
			protected set
			{
			}
		}

		[Token(Token = "0x170006BD")]
		public double IAPTotal
		{
			[Token(Token = "0x6002738")]
			[Address(RVA = "0xA69614", Offset = "0xA69614", VA = "0xA69614")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6002739")]
			[Address(RVA = "0xA6967C", Offset = "0xA6967C", VA = "0xA6967C")]
			protected set
			{
			}
		}

		[Token(Token = "0x170006BE")]
		public int IAPCount
		{
			[Token(Token = "0x600273A")]
			[Address(RVA = "0xA696F8", Offset = "0xA696F8", VA = "0xA696F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600273B")]
			[Address(RVA = "0xA69754", Offset = "0xA69754", VA = "0xA69754")]
			protected set
			{
			}
		}

		[Token(Token = "0x170006BF")]
		public double LastIAPValue
		{
			[Token(Token = "0x600273C")]
			[Address(RVA = "0xA697D0", Offset = "0xA697D0", VA = "0xA697D0")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600273D")]
			[Address(RVA = "0xA69838", Offset = "0xA69838", VA = "0xA69838")]
			protected set
			{
			}
		}

		[Token(Token = "0x170006C0")]
		public string LastIAPName
		{
			[Token(Token = "0x600273E")]
			[Address(RVA = "0xA698B4", Offset = "0xA698B4", VA = "0xA698B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600273F")]
			[Address(RVA = "0xA69924", Offset = "0xA69924", VA = "0xA69924")]
			protected set
			{
			}
		}

		[Token(Token = "0x170006C1")]
		public double IAPAverage
		{
			[Token(Token = "0x6002740")]
			[Address(RVA = "0xA6999C", Offset = "0xA6999C", VA = "0xA6999C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170006C2")]
		public double HardCurrencyIAPMax
		{
			[Token(Token = "0x6002741")]
			[Address(RVA = "0xA699EC", Offset = "0xA699EC", VA = "0xA699EC")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6002742")]
			[Address(RVA = "0xA69A54", Offset = "0xA69A54", VA = "0xA69A54")]
			private set
			{
			}
		}

		[Token(Token = "0x170006C3")]
		public double HardCurrencyIAPTotal
		{
			[Token(Token = "0x6002743")]
			[Address(RVA = "0xA69AD0", Offset = "0xA69AD0", VA = "0xA69AD0")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6002744")]
			[Address(RVA = "0xA69B38", Offset = "0xA69B38", VA = "0xA69B38")]
			private set
			{
			}
		}

		[Token(Token = "0x170006C4")]
		public int HardCurrencyIAPCount
		{
			[Token(Token = "0x6002745")]
			[Address(RVA = "0xA69BB4", Offset = "0xA69BB4", VA = "0xA69BB4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002746")]
			[Address(RVA = "0xA69C10", Offset = "0xA69C10", VA = "0xA69C10")]
			private set
			{
			}
		}

		[Token(Token = "0x170006C5")]
		public double SoftCurrencyIAPMax
		{
			[Token(Token = "0x6002747")]
			[Address(RVA = "0xA69C8C", Offset = "0xA69C8C", VA = "0xA69C8C")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6002748")]
			[Address(RVA = "0xA69CF4", Offset = "0xA69CF4", VA = "0xA69CF4")]
			private set
			{
			}
		}

		[Token(Token = "0x170006C6")]
		public double SoftCurrencyIAPTotal
		{
			[Token(Token = "0x6002749")]
			[Address(RVA = "0xA69D70", Offset = "0xA69D70", VA = "0xA69D70")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600274A")]
			[Address(RVA = "0xA69DD8", Offset = "0xA69DD8", VA = "0xA69DD8")]
			private set
			{
			}
		}

		[Token(Token = "0x170006C7")]
		public int SoftCurrencyIAPCount
		{
			[Token(Token = "0x600274B")]
			[Address(RVA = "0xA69E54", Offset = "0xA69E54", VA = "0xA69E54")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600274C")]
			[Address(RVA = "0xA69EB0", Offset = "0xA69EB0", VA = "0xA69EB0")]
			private set
			{
			}
		}

		[Token(Token = "0x170006C8")]
		public double HardCurrencyIAPAverage
		{
			[Token(Token = "0x600274D")]
			[Address(RVA = "0xA69F2C", Offset = "0xA69F2C", VA = "0xA69F2C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170006C9")]
		public double SoftCurrencyIAPAverage
		{
			[Token(Token = "0x600274E")]
			[Address(RVA = "0xA69F7C", Offset = "0xA69F7C", VA = "0xA69F7C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x600274F")]
		[Address(RVA = "0xA69FCC", Offset = "0xA69FCC", VA = "0xA69FCC")]
		public IAPRecord(Func<DateTime> currentTimeCallback, InventoryController inventory)
		{
		}

		[Token(Token = "0x6002750")]
		[Address(RVA = "0xA6A050", Offset = "0xA6A050", VA = "0xA6A050")]
		public void OnDataUpdated()
		{
		}

		[Token(Token = "0x6002751")]
		[Address(RVA = "0xA69250", Offset = "0xA69250", VA = "0xA69250")]
		protected MetadataItem IAPRecordMetadataItem()
		{
			return null;
		}

		[Token(Token = "0x6002752")]
		[Address(RVA = "0xA6A16C", Offset = "0xA6A16C", VA = "0xA6A16C", Slot = "4")]
		public virtual void RecordIAP(string saleName, string itemName, double price)
		{
		}

		[Token(Token = "0x6002753")]
		[Address(RVA = "0xA6A37C", Offset = "0xA6A37C", VA = "0xA6A37C", Slot = "5")]
		public virtual void RecordLoginTimestamp()
		{
		}

		[Token(Token = "0x6002754")]
		[Address(RVA = "0xA692E4", Offset = "0xA692E4", VA = "0xA692E4")]
		protected void SetValue(string traitName, string value)
		{
		}
	}
}
