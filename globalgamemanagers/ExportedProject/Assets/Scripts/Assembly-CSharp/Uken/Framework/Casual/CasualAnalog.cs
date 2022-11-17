using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Com.Uken.Analog;
using Com.Uken.Core;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Advertising;
using Uken.Library.IAP;
using Uken.Library.Jingot;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004CA")]
	public class CasualAnalog : UkenController
	{
		[Token(Token = "0x400165B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool fireBaseInitialized;

		[Token(Token = "0x400165C")]
		public const int c_maxTimeScaleBeforeDisablingSend = 3;

		[Token(Token = "0x400165D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Analog m_analog;

		[Token(Token = "0x400165E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnalogController m_analogController;

		[Token(Token = "0x400165F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CasualGame m_game;

		[Token(Token = "0x4001660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ThirdParty m_thirdParty;

		[Token(Token = "0x4001661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_softCurrencyName;

		[Token(Token = "0x4001662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string m_hardCurrencyName;

		[Token(Token = "0x4001663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string m_matchID;

		[Token(Token = "0x4001664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Com.Uken.Core.Device m_device;

		[Token(Token = "0x6002413")]
		[Address(RVA = "0xA26858", Offset = "0xA26858", VA = "0xA26858")]
		public CasualAnalog(CasualGame game, RuntimeContext analogContext, string softCurrencyName, string hardCurrencyName)
		{
		}

		[Token(Token = "0x6002414")]
		[Address(RVA = "0xA26A60", Offset = "0xA26A60", VA = "0xA26A60", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6002415")]
		[Address(RVA = "0xA26AAC", Offset = "0xA26AAC", VA = "0xA26AAC")]
		public void SetNewMatchID()
		{
		}

		[Token(Token = "0x6002416")]
		[Address(RVA = "0xA26B34", Offset = "0xA26B34", VA = "0xA26B34")]
		public void ClearMatchID()
		{
		}

		[Token(Token = "0x6002417")]
		[Address(RVA = "0xA26A6C", Offset = "0xA26A6C", VA = "0xA26A6C")]
		public void FetchAsyncIdentifiersIfNecessary()
		{
		}

		[Token(Token = "0x6002418")]
		[Address(RVA = "0xA26B3C", Offset = "0xA26B3C", VA = "0xA26B3C")]
		private Action<Dictionary<string, object>> OnIdentifiersFetched()
		{
			return null;
		}

		[Token(Token = "0x6002419")]
		[Address(RVA = "0xA26BB4", Offset = "0xA26BB4", VA = "0xA26BB4")]
		public void UpdateEventContext(Dictionary<string, object> contextData)
		{
		}

		[Token(Token = "0x600241A")]
		[Address(RVA = "0xA27440", Offset = "0xA27440", VA = "0xA27440")]
		private bool TimeScaleIsNormalSpeed()
		{
			return default(bool);
		}

		[Token(Token = "0x600241B")]
		[Address(RVA = "0xA27464", Offset = "0xA27464", VA = "0xA27464", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x600241C")]
		[Address(RVA = "0xA2747C", Offset = "0xA2747C", VA = "0xA2747C")]
		public void LogGenericEvent(string type, string name, [Optional] CasualAnalogData extraData)
		{
		}

		[Token(Token = "0x600241D")]
		[Address(RVA = "0xA27EB8", Offset = "0xA27EB8", VA = "0xA27EB8")]
		public void TEMP_LOG_USER_CLEARED_DATA()
		{
		}

		[Token(Token = "0x600241E")]
		[Address(RVA = "0xA27F50", Offset = "0xA27F50", VA = "0xA27F50")]
		public void LogGlobalSpeedBoostAdRewarded(string adConfigRef, double durationInSeconds, double boostPercent, string eventName)
		{
		}

		[Token(Token = "0x600241F")]
		[Address(RVA = "0xA2816C", Offset = "0xA2816C", VA = "0xA2816C")]
		public void LogMiniEventTransaction(bool isActivation, string miniEventRef, long amountBeforeEvent, string source)
		{
		}

		[Token(Token = "0x6002420")]
		[Address(RVA = "0xA2838C", Offset = "0xA2838C", VA = "0xA2838C")]
		public void LogUIEvent(string eventName)
		{
		}

		[Token(Token = "0x6002421")]
		[Address(RVA = "0xA2840C", Offset = "0xA2840C", VA = "0xA2840C")]
		public void LogPlayerPrestige(long numberOfPrestigeTokensToBeAwarded, long currentPowerSpeedResearchLevel, long currentPowerSustainLevel, long newPrestigeLevel)
		{
		}

		[Token(Token = "0x6002422")]
		[Address(RVA = "0xA28564", Offset = "0xA28564", VA = "0xA28564")]
		public void LogTabNavigation(string m_tabPressEventName)
		{
		}

		[Token(Token = "0x6002423")]
		[Address(RVA = "0xA285E4", Offset = "0xA285E4", VA = "0xA285E4")]
		public void LogLTOServedToUser(string ltoReferenceName, string productName)
		{
		}

		[Token(Token = "0x6002424")]
		[Address(RVA = "0xA286DC", Offset = "0xA286DC", VA = "0xA286DC")]
		public void LogLeaderboardPlacement(string source, int rank, string userName, long score)
		{
		}

		[Token(Token = "0x6002425")]
		[Address(RVA = "0xA28878", Offset = "0xA28878", VA = "0xA28878")]
		public void LogUserIDChange(string originalUserID)
		{
		}

		[Token(Token = "0x6002426")]
		[Address(RVA = "0xA2891C", Offset = "0xA2891C", VA = "0xA2891C")]
		public void LogAppInstall()
		{
		}

		[Token(Token = "0x6002427")]
		[Address(RVA = "0xA28980", Offset = "0xA28980", VA = "0xA28980")]
		private void LogCurrencyTransaction(Currency currencyType, long delta, string event_name, string source_sink)
		{
		}

		[Token(Token = "0x6002428")]
		[Address(RVA = "0xA28A20", Offset = "0xA28A20", VA = "0xA28A20")]
		public void LogItemTransaction(string event_name, string item_name, long delta, long previousAmount, string source_sink)
		{
		}

		[Token(Token = "0x6002429")]
		[Address(RVA = "0xA277B4", Offset = "0xA277B4", VA = "0xA277B4")]
		private void AddMatchIDToLogEvent(BaseEvent logEvent)
		{
		}

		[Token(Token = "0x600242A")]
		[Address(RVA = "0xA23180", Offset = "0xA23180", VA = "0xA23180")]
		public void LogAdStart(string ukenAdID, string provider, AdType watchType, AdController.AdStockState placementState, string actionName, bool isDynamic)
		{
		}

		[Token(Token = "0x600242B")]
		[Address(RVA = "0xA234D4", Offset = "0xA234D4", VA = "0xA234D4")]
		public void LogAdComplete(string ukenAdID, string provider, AdType watchType, AdController.AdStockState placementState, string actionName, string currency, long quantity, bool isDynamic)
		{
		}

		[Token(Token = "0x600242C")]
		[Address(RVA = "0xA28B34", Offset = "0xA28B34", VA = "0xA28B34")]
		public void LogABAssignments(List<ABTestGroup> testData)
		{
		}

		[Token(Token = "0x600242D")]
		[Address(RVA = "0xA28D28", Offset = "0xA28D28", VA = "0xA28D28")]
		public void LogABJoin(string experimentName, string experimentGroup)
		{
		}

		[Token(Token = "0x600242E")]
		[Address(RVA = "0xA28DA4", Offset = "0xA28DA4", VA = "0xA28DA4")]
		public void LogMatchStart(Guid matchID, CasualAnalogData matchData)
		{
		}

		[Token(Token = "0x600242F")]
		[Address(RVA = "0xA28F50", Offset = "0xA28F50", VA = "0xA28F50")]
		public void LogMatchEnd(Guid matchID, CasualAnalogData matchData)
		{
		}

		[Token(Token = "0x6002430")]
		[Address(RVA = "0xA290FC", Offset = "0xA290FC", VA = "0xA290FC")]
		public void LogAppCrashRecovery(DateTime crashDateTime, string lastSceneView)
		{
		}

		[Token(Token = "0x6002431")]
		[Address(RVA = "0xA29178", Offset = "0xA29178", VA = "0xA29178")]
		public void LogPaymentValidationStart(string vendor_id, UkenPurchasePayload custom_payload, string transaction_id, string receipt, bool isRetry)
		{
		}

		[Token(Token = "0x6002432")]
		[Address(RVA = "0xA2927C", Offset = "0xA2927C", VA = "0xA2927C")]
		public void LogPaymentValidationCompleted(UkenPaymentValidationResult validationResult, string vendor_id, UkenPurchasePayload custom_payload, string transaction_id, string receipt, bool isRetry)
		{
		}

		[Token(Token = "0x6002433")]
		[Address(RVA = "0xA293AC", Offset = "0xA293AC", VA = "0xA293AC")]
		public void LogIAPProviderPurchaseRequest(UkenPaymentProduct product)
		{
		}

		[Token(Token = "0x6002434")]
		[Address(RVA = "0xA294BC", Offset = "0xA294BC", VA = "0xA294BC")]
		public void LogIAPProviderPurchaseComplete(UkenPaymentValidationResult validationResult, UkenPaymentProduct product)
		{
		}

		[Token(Token = "0x6002435")]
		[Address(RVA = "0xA2965C", Offset = "0xA2965C", VA = "0xA2965C")]
		public void LogIAPOrphanedProduct(string provider_transaction_id, string receipt, string vendor_id)
		{
		}

		[Token(Token = "0x6002436")]
		[Address(RVA = "0xA296E8", Offset = "0xA296E8", VA = "0xA296E8")]
		public void LogPurchaseRequest(string ukenTransactionID, string vendor_id, UkenPurchasePayload custom_payload, double USDPrice)
		{
		}

		[Token(Token = "0x6002437")]
		[Address(RVA = "0xA2979C", Offset = "0xA2979C", VA = "0xA2979C")]
		public void LogPurchaseComplete(UkenPurchaseResult result, UkenPaymentProduct product, Dictionary<string, object> extraData)
		{
		}

		[Token(Token = "0x6002438")]
		[Address(RVA = "0xA29A5C", Offset = "0xA29A5C", VA = "0xA29A5C")]
		public void LogPurchaseFailure(string reason, string provider_transaction_id, UkenPaymentProduct product)
		{
		}

		[Token(Token = "0x6002439")]
		[Address(RVA = "0xA29B8C", Offset = "0xA29B8C", VA = "0xA29B8C")]
		public void LogAppCrashSignal(DateTime crashDateTime, string stackTrace)
		{
		}

		[Token(Token = "0x600243A")]
		[Address(RVA = "0xA29C24", Offset = "0xA29C24", VA = "0xA29C24")]
		public void LogApplicationInstall()
		{
		}

		[Token(Token = "0x600243B")]
		[Address(RVA = "0xA29C88", Offset = "0xA29C88", VA = "0xA29C88")]
		public void LogApplicationOpen()
		{
		}

		[Token(Token = "0x600243C")]
		[Address(RVA = "0xA29CEC", Offset = "0xA29CEC", VA = "0xA29CEC")]
		public void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600243D")]
		[Address(RVA = "0xA29D68", Offset = "0xA29D68", VA = "0xA29D68")]
		public void OnApplicationFocus(bool focus)
		{
		}

		[Token(Token = "0x600243E")]
		[Address(RVA = "0xA29E04", Offset = "0xA29E04", VA = "0xA29E04")]
		public void LogApplicationTagInstallSource(string source_type, string trackerName, string network, string campaign, string adgroup, string creative, string clickLabel)
		{
		}

		[Token(Token = "0x600243F")]
		[Address(RVA = "0xA29EC8", Offset = "0xA29EC8", VA = "0xA29EC8")]
		public void LogApplicationUpdateUserId()
		{
		}

		[Token(Token = "0x6002440")]
		[Address(RVA = "0xA29F30", Offset = "0xA29F30", VA = "0xA29F30")]
		public void LogEventLoadStart(string name)
		{
		}

		[Token(Token = "0x6002441")]
		[Address(RVA = "0xA29FA4", Offset = "0xA29FA4", VA = "0xA29FA4")]
		public void LogEventLoadEnd(string name)
		{
		}

		[Token(Token = "0x6002442")]
		[Address(RVA = "0xA2A018", Offset = "0xA2A018", VA = "0xA2A018")]
		public void LogFacebookConnect(string FBFirstName, string FBLastName, string FBName, string FBGender, string FBId, string FBLocale, string FBAgeRangeMin, string FBEmail, string FBTimezone)
		{
		}

		[Token(Token = "0x6002443")]
		[Address(RVA = "0xA2A0E4", Offset = "0xA2A0E4", VA = "0xA2A0E4")]
		public void LogItemTransaction(string eventName, string item, TransactionType itemTransactionType, long quantity, long amountBeforeEvent, string source_sink)
		{
		}

		[Token(Token = "0x6002444")]
		[Address(RVA = "0xA2A190", Offset = "0xA2A190", VA = "0xA2A190")]
		public void LogGameStart(Guid matchId, CasualAnalogData contextData)
		{
		}

		[Token(Token = "0x6002445")]
		[Address(RVA = "0xA2A33C", Offset = "0xA2A33C", VA = "0xA2A33C")]
		public void LogGameEnd(Guid matchId, CasualAnalogData contextData)
		{
		}

		[Token(Token = "0x6002446")]
		[Address(RVA = "0xA2A4E8", Offset = "0xA2A4E8", VA = "0xA2A4E8")]
		public void ForceDispatch()
		{
		}

		[Token(Token = "0x6002447")]
		[Address(RVA = "0xA2783C", Offset = "0xA2783C", VA = "0xA2783C")]
		private void Send(BaseEvent eventLog)
		{
		}

		[Token(Token = "0x6002449")]
		[Address(RVA = "0xA2A51C", Offset = "0xA2A51C", VA = "0xA2A51C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8396FC", Offset = "0x8396FC")]
		private void _003COnIdentifiersFetched_003Eb__15_0(Dictionary<string, object> dict)
		{
		}

		[Token(Token = "0x600244A")]
		[Address(RVA = "0xA2A5DC", Offset = "0xA2A5DC", VA = "0xA2A5DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83970C", Offset = "0x83970C")]
		private void _003COnIdentifiersFetched_003Eb__15_1(string adjustData)
		{
		}
	}
}
