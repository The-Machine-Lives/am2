using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;
using Uken.Library.UserAnalytics;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200056A")]
	public class UserProfiler : UkenController
	{
		[Token(Token = "0x2000856")]
		public delegate string GetAdjustAttribute(string key);

		[Token(Token = "0x40019A2")]
		[FieldOffset(Offset = "0x18")]
		protected CasualGame m_game;

		[Token(Token = "0x40019A3")]
		[FieldOffset(Offset = "0x20")]
		protected InventoryController m_inventory;

		[Token(Token = "0x40019A4")]
		[FieldOffset(Offset = "0x28")]
		protected Features m_features;

		[Token(Token = "0x40019A5")]
		[FieldOffset(Offset = "0x30")]
		protected UserAnalyticsController m_userAnalyticsController;

		[Token(Token = "0x40019A6")]
		public const string SESSION_START_HARD_CURRENCY_KEY = "SessionStartHardCurrency";

		[Token(Token = "0x40019A7")]
		public const string SESSION_START_SOFT_CURRENCY_KEY = "SessionStartSoftCurrency";

		[Token(Token = "0x40019A8")]
		[FieldOffset(Offset = "0x38")]
		protected IAPRecord m_iapRecord;

		[Token(Token = "0x40019A9")]
		[FieldOffset(Offset = "0x40")]
		protected Func<DateTime> m_currentTimeCallback;

		[Token(Token = "0x40019AA")]
		[FieldOffset(Offset = "0x48")]
		protected GetAdjustAttribute m_getAdjustAttribute;

		[Token(Token = "0x40019AB")]
		[FieldOffset(Offset = "0x50")]
		protected Stack<int> m_locationStack;

		[Token(Token = "0x600294C")]
		[Address(RVA = "0xA9CFEC", Offset = "0xA9CFEC", VA = "0xA9CFEC")]
		public UserProfiler(CasualGame game)
		{
		}

		[Token(Token = "0x600294D")]
		[Address(RVA = "0xA9D094", Offset = "0xA9D094", VA = "0xA9D094", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600294E")]
		[Address(RVA = "0xA9D25C", Offset = "0xA9D25C", VA = "0xA9D25C", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x600294F")]
		[Address(RVA = "0xA9D298", Offset = "0xA9D298", VA = "0xA9D298")]
		public void ResetUserLocationStack()
		{
		}

		[Token(Token = "0x6002950")]
		[Address(RVA = "0xA9D320", Offset = "0xA9D320", VA = "0xA9D320")]
		public string AdjustAttribute(string key)
		{
			return null;
		}

		[Token(Token = "0x6002951")]
		[Address(RVA = "0xA9DA80", Offset = "0xA9DA80", VA = "0xA9DA80")]
		public string GetUserRegion()
		{
			return null;
		}

		[Token(Token = "0x6002952")]
		[Address(RVA = "0xA9DAB4", Offset = "0xA9DAB4", VA = "0xA9DAB4")]
		public void UpdateUserLocation(int newState, bool replace = false, bool reset = false)
		{
		}

		[Token(Token = "0x6002953")]
		[Address(RVA = "0xA9DB90", Offset = "0xA9DB90", VA = "0xA9DB90")]
		public int GetUserLocation()
		{
			return default(int);
		}

		[Token(Token = "0x6002954")]
		[Address(RVA = "0xA9DC2C", Offset = "0xA9DC2C", VA = "0xA9DC2C")]
		public void RecordIAP(string saleName, string itemName, double price)
		{
		}

		[Token(Token = "0x6002955")]
		[Address(RVA = "0xA9DC88", Offset = "0xA9DC88", VA = "0xA9DC88")]
		public void RecordLoginTimestamp()
		{
		}

		[Token(Token = "0x6002956")]
		[Address(RVA = "0xA9DCBC", Offset = "0xA9DCBC", VA = "0xA9DCBC")]
		public int RFM()
		{
			return default(int);
		}

		[Token(Token = "0x6002957")]
		[Address(RVA = "0xA9DD0C", Offset = "0xA9DD0C", VA = "0xA9DD0C")]
		public int RFM_R()
		{
			return default(int);
		}

		[Token(Token = "0x6002958")]
		[Address(RVA = "0xA9DD5C", Offset = "0xA9DD5C", VA = "0xA9DD5C")]
		public int RFM_F()
		{
			return default(int);
		}

		[Token(Token = "0x6002959")]
		[Address(RVA = "0xA9DDAC", Offset = "0xA9DDAC", VA = "0xA9DDAC")]
		public int RFM_M()
		{
			return default(int);
		}

		[Token(Token = "0x600295A")]
		[Address(RVA = "0xA9DDFC", Offset = "0xA9DDFC", VA = "0xA9DDFC")]
		public int NumberOfDaysActive7Day()
		{
			return default(int);
		}

		[Token(Token = "0x600295B")]
		[Address(RVA = "0xA9DE4C", Offset = "0xA9DE4C", VA = "0xA9DE4C")]
		public int NumberOfDaysWithMatch()
		{
			return default(int);
		}

		[Token(Token = "0x600295C")]
		[Address(RVA = "0xA9DE9C", Offset = "0xA9DE9C", VA = "0xA9DE9C")]
		public int NumberOfPurchases()
		{
			return default(int);
		}

		[Token(Token = "0x600295D")]
		[Address(RVA = "0xA9DEEC", Offset = "0xA9DEEC", VA = "0xA9DEEC")]
		public float TotalSpend7Day()
		{
			return default(float);
		}

		[Token(Token = "0x600295E")]
		[Address(RVA = "0xA9DF40", Offset = "0xA9DF40", VA = "0xA9DF40")]
		public float TotalSpend30Day()
		{
			return default(float);
		}

		[Token(Token = "0x600295F")]
		[Address(RVA = "0xA9DF94", Offset = "0xA9DF94", VA = "0xA9DF94")]
		public long LastLogin()
		{
			return default(long);
		}

		[Token(Token = "0x6002960")]
		[Address(RVA = "0xA9DFE4", Offset = "0xA9DFE4", VA = "0xA9DFE4")]
		public float AverageSpend7Day()
		{
			return default(float);
		}

		[Token(Token = "0x6002961")]
		[Address(RVA = "0xA9E038", Offset = "0xA9E038", VA = "0xA9E038")]
		public float AverageSpend14Day()
		{
			return default(float);
		}

		[Token(Token = "0x6002962")]
		[Address(RVA = "0xA9E08C", Offset = "0xA9E08C", VA = "0xA9E08C")]
		public float AverageSpend30Day()
		{
			return default(float);
		}

		[Token(Token = "0x6002963")]
		[Address(RVA = "0xA9E0E0", Offset = "0xA9E0E0", VA = "0xA9E0E0")]
		public float AverageSpend60Day()
		{
			return default(float);
		}

		[Token(Token = "0x6002964")]
		[Address(RVA = "0xA9E134", Offset = "0xA9E134", VA = "0xA9E134")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83A564", Offset = "0x83A564")]
		public long InstallDateMillisecondsSinceEpoch()
		{
			return default(long);
		}

		[Token(Token = "0x6002965")]
		[Address(RVA = "0xA9E184", Offset = "0xA9E184", VA = "0xA9E184")]
		public float MinutesSinceInstall()
		{
			return default(float);
		}

		[Token(Token = "0x6002966")]
		[Address(RVA = "0xA9E2AC", Offset = "0xA9E2AC", VA = "0xA9E2AC")]
		public float BalanceScoreAdjustment()
		{
			return default(float);
		}

		[Token(Token = "0x6002967")]
		[Address(RVA = "0xA9E2FC", Offset = "0xA9E2FC", VA = "0xA9E2FC")]
		public string UserID()
		{
			return null;
		}

		[Token(Token = "0x6002968")]
		[Address(RVA = "0xA9E338", Offset = "0xA9E338", VA = "0xA9E338", Slot = "10")]
		public virtual Version BuildVersion()
		{
			return null;
		}

		[Token(Token = "0x6002969")]
		[Address(RVA = "0xA9E490", Offset = "0xA9E490", VA = "0xA9E490", Slot = "11")]
		public virtual string Platform()
		{
			return null;
		}

		[Token(Token = "0x600296A")]
		[Address(RVA = "0xA9E4F0", Offset = "0xA9E4F0", VA = "0xA9E4F0")]
		public bool IsFeatureEnabled(string feature)
		{
			return default(bool);
		}

		[Token(Token = "0x600296B")]
		[Address(RVA = "0xA9E52C", Offset = "0xA9E52C", VA = "0xA9E52C")]
		protected string HardCurrencyReference()
		{
			return null;
		}

		[Token(Token = "0x600296C")]
		[Address(RVA = "0xA9E55C", Offset = "0xA9E55C", VA = "0xA9E55C")]
		protected string SoftCurrencyReference()
		{
			return null;
		}

		[Token(Token = "0x600296D")]
		[Address(RVA = "0xA9E58C", Offset = "0xA9E58C", VA = "0xA9E58C")]
		public long Level()
		{
			return default(long);
		}

		[Token(Token = "0x600296E")]
		[Address(RVA = "0xA9E5C4", Offset = "0xA9E5C4", VA = "0xA9E5C4", Slot = "12")]
		public virtual long XP()
		{
			return default(long);
		}

		[Token(Token = "0x600296F")]
		[Address(RVA = "0xA9E638", Offset = "0xA9E638", VA = "0xA9E638", Slot = "13")]
		public virtual long HardCurrency()
		{
			return default(long);
		}

		[Token(Token = "0x6002970")]
		[Address(RVA = "0xA9E674", Offset = "0xA9E674", VA = "0xA9E674", Slot = "14")]
		public virtual long SoftCurrency()
		{
			return default(long);
		}

		[Token(Token = "0x6002971")]
		[Address(RVA = "0xA9E6B0", Offset = "0xA9E6B0", VA = "0xA9E6B0", Slot = "15")]
		public virtual bool HasItem(string itemName)
		{
			return default(bool);
		}

		[Token(Token = "0x6002972")]
		[Address(RVA = "0xA9E6F4", Offset = "0xA9E6F4", VA = "0xA9E6F4", Slot = "16")]
		public virtual long GetItemQuantity(string itemName)
		{
			return default(long);
		}

		[Token(Token = "0x6002973")]
		[Address(RVA = "0xA9E72C", Offset = "0xA9E72C", VA = "0xA9E72C", Slot = "17")]
		public virtual long SessionStartHardCurrency()
		{
			return default(long);
		}

		[Token(Token = "0x6002974")]
		[Address(RVA = "0xA9E7B8", Offset = "0xA9E7B8", VA = "0xA9E7B8", Slot = "18")]
		public virtual long SessionStartSoftCurrency()
		{
			return default(long);
		}

		[Token(Token = "0x6002975")]
		[Address(RVA = "0xA9E844", Offset = "0xA9E844", VA = "0xA9E844", Slot = "19")]
		public virtual double PercentOfSessionStartHardCurrency()
		{
			return default(double);
		}

		[Token(Token = "0x6002976")]
		[Address(RVA = "0xA9E954", Offset = "0xA9E954", VA = "0xA9E954", Slot = "20")]
		public virtual double PercentOfSessionStartSoftCurrency()
		{
			return default(double);
		}

		[Token(Token = "0x6002977")]
		[Address(RVA = "0xA9EA64", Offset = "0xA9EA64", VA = "0xA9EA64")]
		public float MinutesSinceLastPurchase()
		{
			return default(float);
		}

		[Token(Token = "0x6002978")]
		[Address(RVA = "0xA9EB40", Offset = "0xA9EB40", VA = "0xA9EB40")]
		public float MinutesSinceLastLogin()
		{
			return default(float);
		}

		[Token(Token = "0x6002979")]
		[Address(RVA = "0xA9EC88", Offset = "0xA9EC88", VA = "0xA9EC88", Slot = "21")]
		public virtual double IAPMaximum()
		{
			return default(double);
		}

		[Token(Token = "0x600297A")]
		[Address(RVA = "0xA9ED1C", Offset = "0xA9ED1C", VA = "0xA9ED1C", Slot = "22")]
		public virtual double IAPAverage()
		{
			return default(double);
		}

		[Token(Token = "0x600297B")]
		[Address(RVA = "0xA9EDB0", Offset = "0xA9EDB0", VA = "0xA9EDB0", Slot = "23")]
		public virtual double IAPTotal()
		{
			return default(double);
		}

		[Token(Token = "0x600297C")]
		[Address(RVA = "0xA9EE44", Offset = "0xA9EE44", VA = "0xA9EE44", Slot = "24")]
		public virtual double LastIAPValue()
		{
			return default(double);
		}

		[Token(Token = "0x600297D")]
		[Address(RVA = "0xA9EED8", Offset = "0xA9EED8", VA = "0xA9EED8", Slot = "25")]
		public virtual string LastIAPName()
		{
			return null;
		}

		[Token(Token = "0x600297E")]
		[Address(RVA = "0xA9EF08", Offset = "0xA9EF08", VA = "0xA9EF08", Slot = "26")]
		public virtual double HardCurrencyIAPMaximum()
		{
			return default(double);
		}

		[Token(Token = "0x600297F")]
		[Address(RVA = "0xA9EF20", Offset = "0xA9EF20", VA = "0xA9EF20", Slot = "27")]
		public virtual double HardCurrencyIAPAverage()
		{
			return default(double);
		}

		[Token(Token = "0x6002980")]
		[Address(RVA = "0xA9EF38", Offset = "0xA9EF38", VA = "0xA9EF38", Slot = "28")]
		public virtual double HardCurrencyIAPTotal()
		{
			return default(double);
		}

		[Token(Token = "0x6002981")]
		[Address(RVA = "0xA9EF50", Offset = "0xA9EF50", VA = "0xA9EF50", Slot = "29")]
		public virtual double SoftCurrencyIAPMaximum()
		{
			return default(double);
		}

		[Token(Token = "0x6002982")]
		[Address(RVA = "0xA9EF68", Offset = "0xA9EF68", VA = "0xA9EF68", Slot = "30")]
		public virtual double SoftCurrencyIAPAverage()
		{
			return default(double);
		}

		[Token(Token = "0x6002983")]
		[Address(RVA = "0xA9EF80", Offset = "0xA9EF80", VA = "0xA9EF80", Slot = "31")]
		public virtual double SoftCurrencyIAPTotal()
		{
			return default(double);
		}

		[Token(Token = "0x6002984")]
		[Address(RVA = "0xA9EF98", Offset = "0xA9EF98", VA = "0xA9EF98")]
		public DateTime LastLoginTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x6002985")]
		[Address(RVA = "0xA9F064", Offset = "0xA9F064", VA = "0xA9F064")]
		public bool IsNewUser()
		{
			return default(bool);
		}

		[Token(Token = "0x6002986")]
		[Address(RVA = "0xA9F0A0", Offset = "0xA9F0A0", VA = "0xA9F0A0", Slot = "32")]
		public virtual long BalanceScore()
		{
			return default(long);
		}

		[Token(Token = "0x6002987")]
		[Address(RVA = "0xA9F114", Offset = "0xA9F114", VA = "0xA9F114")]
		public int VIPTier()
		{
			return default(int);
		}

		[Token(Token = "0x6002988")]
		[Address(RVA = "0xA9F3EC", Offset = "0xA9F3EC", VA = "0xA9F3EC")]
		public bool HasAdjustPaidAttribution()
		{
			return default(bool);
		}
	}
}
