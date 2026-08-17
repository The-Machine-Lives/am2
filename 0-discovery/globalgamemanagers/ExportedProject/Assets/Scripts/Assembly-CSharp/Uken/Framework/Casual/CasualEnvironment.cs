using Il2CppDummyDll;
using Uken.Core;
using UnityEngine;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004D0")]
	public class CasualEnvironment : UkenEnvironment
	{
		[Token(Token = "0x4001671")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x82EC3C", Offset = "0x82EC3C")]
		public string gameID;

		[Token(Token = "0x4001672")]
		[FieldOffset(Offset = "0x28")]
		public string inventoryServiceURL;

		[Token(Token = "0x4001673")]
		[FieldOffset(Offset = "0x30")]
		public string refDataServiceURL;

		[Token(Token = "0x4001674")]
		[FieldOffset(Offset = "0x38")]
		public string authServiceURL;

		[Token(Token = "0x4001675")]
		[FieldOffset(Offset = "0x40")]
		public string assetLocalPath;

		[Token(Token = "0x4001676")]
		[FieldOffset(Offset = "0x48")]
		public string assetRemoteURL;

		[Token(Token = "0x4001677")]
		[FieldOffset(Offset = "0x50")]
		public string assetBucketKey;

		[Token(Token = "0x4001678")]
		[FieldOffset(Offset = "0x58")]
		public string analogServiceUrl;

		[Token(Token = "0x4001679")]
		[FieldOffset(Offset = "0x60")]
		public string analogAPIKey;

		[Token(Token = "0x400167A")]
		[FieldOffset(Offset = "0x68")]
		public string clientMetricsServiceUrl;

		[Token(Token = "0x400167B")]
		[FieldOffset(Offset = "0x70")]
		public string clientMetricsAPIKey;

		[Token(Token = "0x400167C")]
		[FieldOffset(Offset = "0x78")]
		public string networkStatusURL;

		[Token(Token = "0x400167D")]
		[FieldOffset(Offset = "0x80")]
		public string jingotURL;

		[Token(Token = "0x400167E")]
		[FieldOffset(Offset = "0x88")]
		public string jingotRunningTestsURL;

		[Token(Token = "0x400167F")]
		[FieldOffset(Offset = "0x90")]
		public string scoreboardURL;

		[Token(Token = "0x4001680")]
		[FieldOffset(Offset = "0x98")]
		public string aidURL;

		[Token(Token = "0x4001681")]
		[FieldOffset(Offset = "0xA0")]
		public string clubsURL;

		[Token(Token = "0x4001682")]
		[FieldOffset(Offset = "0xA8")]
		public string teamsURL;

		[Token(Token = "0x4001683")]
		[FieldOffset(Offset = "0xB0")]
		public string userAnalyticsURL;

		[Token(Token = "0x4001684")]
		[FieldOffset(Offset = "0xB8")]
		public string leagueURL;

		[Token(Token = "0x4001685")]
		[FieldOffset(Offset = "0xC0")]
		public string scrubRequestURL;

		[Token(Token = "0x4001686")]
		[FieldOffset(Offset = "0xC8")]
		public string scrubAPIKey;

		[Token(Token = "0x4001687")]
		[FieldOffset(Offset = "0xD0")]
		public string inboxURL;

		[Token(Token = "0x4001688")]
		[FieldOffset(Offset = "0xD8")]
		public string platformInboxURL;

		[Token(Token = "0x4001689")]
		[FieldOffset(Offset = "0xE0")]
		public string androidAdUnitId;

		[Token(Token = "0x400168A")]
		[FieldOffset(Offset = "0xE8")]
		public string iosAdUnitId;

		[Token(Token = "0x400168B")]
		[FieldOffset(Offset = "0xF0")]
		public LogType logLevel;

		[Token(Token = "0x400168C")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x82EC74", Offset = "0x82EC74")]
		public string purchaseRegistrationURL;

		[Token(Token = "0x400168D")]
		[FieldOffset(Offset = "0x100")]
		public string purchaseCancellationURL;

		[Token(Token = "0x400168E")]
		[FieldOffset(Offset = "0x108")]
		public string receiptValidationURL;

		[Token(Token = "0x400168F")]
		[FieldOffset(Offset = "0x110")]
		public string finalizePurchaseURL;

		[Token(Token = "0x4001690")]
		[FieldOffset(Offset = "0x118")]
		public string unclaimedPurchaseURL;

		[Token(Token = "0x4001691")]
		[FieldOffset(Offset = "0x120")]
		public string iapDefinitionURL;

		[Token(Token = "0x4001692")]
		[FieldOffset(Offset = "0x128")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x82ECAC", Offset = "0x82ECAC")]
		public bool DebugLocalizationText;

		[Token(Token = "0x4001693")]
		[FieldOffset(Offset = "0x129")]
		public bool DebugSimulateiPhoneX;

		[Token(Token = "0x4001694")]
		[FieldOffset(Offset = "0x12A")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x82ECE4", Offset = "0x82ECE4")]
		public bool DebugUseLocalRefData;

		[Token(Token = "0x4001695")]
		[FieldOffset(Offset = "0x12B")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x82ED1C", Offset = "0x82ED1C")]
		public bool LoadBundlesLocally;

		[Token(Token = "0x4001696")]
		[FieldOffset(Offset = "0x12C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x82ED54", Offset = "0x82ED54")]
		public bool EnableLocalNotifications;

		[Token(Token = "0x600245D")]
		[Address(RVA = "0xA2BD08", Offset = "0xA2BD08", VA = "0xA2BD08")]
		public UkenLogger.LogLevel GetUkenLogType()
		{
			return default(UkenLogger.LogLevel);
		}

		[Token(Token = "0x600245E")]
		[Address(RVA = "0xA2BD2C", Offset = "0xA2BD2C", VA = "0xA2BD2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600245F")]
		[Address(RVA = "0xA2BDA0", Offset = "0xA2BDA0", VA = "0xA2BDA0")]
		public CasualEnvironment()
		{
		}
	}
}
