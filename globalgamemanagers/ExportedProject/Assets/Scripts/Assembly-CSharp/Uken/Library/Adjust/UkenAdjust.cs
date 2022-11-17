using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using com.adjust.sdk;

namespace Uken.Library.Adjust
{
	[Token(Token = "0x200044F")]
	public class UkenAdjust : com.adjust.sdk.Adjust
	{
		[Token(Token = "0x2000802")]
		public delegate string GetUserIDFunc();

		[Token(Token = "0x40013FC")]
		public const string ADJUST_PAID_ATTRIBUTION_ITEM = "adjust_paid_attribution_item";

		[Token(Token = "0x40013FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<int, string> adjustEvents;

		[Token(Token = "0x40013FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GetUserIDFunc m_GetUserID;

		[Token(Token = "0x40013FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AdjustAttribution m_attribution;

		[Token(Token = "0x4001400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, string> m_attributionDictionary;

		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0xAECF2C", Offset = "0xAECF2C", VA = "0xAECF2C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6001FDA")]
		[Address(RVA = "0xAED000", Offset = "0xAED000", VA = "0xAED000", Slot = "5")]
		public virtual void Initialize(GetUserIDFunc getUserID)
		{
		}

		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0xAED270", Offset = "0xAED270", VA = "0xAED270")]
		public void ClearGpdrData()
		{
		}

		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0xAED354", Offset = "0xAED354", VA = "0xAED354")]
		public Dictionary<string, string> GetAttributionDictionary()
		{
			return null;
		}

		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0xAED3C4", Offset = "0xAED3C4", VA = "0xAED3C4")]
		public string GetAttributionString(string key)
		{
			return null;
		}

		[Token(Token = "0x6001FDE")]
		[Address(RVA = "0xAED46C", Offset = "0xAED46C", VA = "0xAED46C", Slot = "6")]
		protected virtual void OnAttributionChanged(AdjustAttribution attribution)
		{
		}

		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0xAED938", Offset = "0xAED938", VA = "0xAED938")]
		protected void RegisterEvent(int eventID, string adjustEventID)
		{
		}

		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0xAECFF4", Offset = "0xAECFF4", VA = "0xAECFF4")]
		private void DetermineEnvironment()
		{
		}

		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0xAEDBA8", Offset = "0xAEDBA8", VA = "0xAEDBA8", Slot = "7")]
		protected virtual string GetAppToken()
		{
			return null;
		}

		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0xAEDBF0", Offset = "0xAEDBF0", VA = "0xAEDBF0", Slot = "8")]
		protected virtual string GetRevenueEventString()
		{
			return null;
		}

		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0xAEDC40", Offset = "0xAEDC40", VA = "0xAEDC40")]
		public void SendAdjustRevenueEvent(string transactionId, double currencyAmount, string currencyCode)
		{
		}

		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0xAEE004", Offset = "0xAEE004", VA = "0xAEE004")]
		public void SendAdjustEvent(int ukenEventID, [Optional] Dictionary<string, string> callbackParameters)
		{
		}

		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0xAEDE9C", Offset = "0xAEDE9C", VA = "0xAEDE9C")]
		private void SendAdjustEvent(AdjustEvent adjustEvent)
		{
		}

		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0xAEE82C", Offset = "0xAEE82C", VA = "0xAEE82C")]
		public UkenAdjust()
		{
		}
	}
}
