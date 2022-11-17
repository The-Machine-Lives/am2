using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;
using UnityEngine.Purchasing;

namespace Uken.Library.IAP
{
	[Token(Token = "0x200043F")]
	public class UnityIAP_PaymentProvider : UkenPaymentProvider, IStoreListener
	{
		[Token(Token = "0x20007F7")]
		public class UnityIAP_Product
		{
			[Token(Token = "0x40022FF")]
			[FieldOffset(Offset = "0x10")]
			public string vendor_id;

			[Token(Token = "0x4002300")]
			[FieldOffset(Offset = "0x18")]
			public ProductType productType;

			[Token(Token = "0x4002301")]
			[FieldOffset(Offset = "0x20")]
			public string customPayload;

			[Token(Token = "0x6003299")]
			[Address(RVA = "0xB96898", Offset = "0xB96898", VA = "0xB96898")]
			public UnityIAP_Product(UkenPaymentProduct ukenProduct)
			{
			}
		}

		[Token(Token = "0x40013AB")]
		[FieldOffset(Offset = "0xD0")]
		private IStoreController m_StoreController;

		[Token(Token = "0x40013AC")]
		[FieldOffset(Offset = "0xD8")]
		private IExtensionProvider m_StoreExtensionProvider;

		[Token(Token = "0x40013AD")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<string, object> m_unityPurchaseLogData;

		[Token(Token = "0x40013AE")]
		[FieldOffset(Offset = "0xE8")]
		private List<UnityIAP_Product> unityProducts;

		[Token(Token = "0x40013AF")]
		[FieldOffset(Offset = "0xF0")]
		private Dictionary<string, Product> m_unityPurchasedProducts;

		[Token(Token = "0x40013B0")]
		[FieldOffset(Offset = "0xF8")]
		private Action<bool> m_onUnclaimedPurchaseComplete;

		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0xB9658C", Offset = "0xB9658C", VA = "0xB9658C")]
		public UnityIAP_PaymentProvider(IAPGrantPurchase grantRewardsCB, Action<WebRequest> webInterface, LogPurchaseRequest logRequest, LogPurchaseFailure logFailure, LogPurchaseComplete logComplete, LogIAPProviderPurchaseRequest logIAPProviderPurchaseRequest, LogIAPProviderPurchaseComplete logIAPProviderPurchaseComplete, LogIAPOrphanedProduct logOrphanedProduct, IsGameReadyCallback isGameReadyCallback, bool bSkipIAPDefinitionQuery)
		{
		}

		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0xB966D8", Offset = "0xB966D8", VA = "0xB966D8", Slot = "10")]
		protected override void InitializeIAPs(List<UkenPaymentProduct> products)
		{
		}

		[Token(Token = "0x6001F90")]
		[Address(RVA = "0xB96C54", Offset = "0xB96C54", VA = "0xB96C54", Slot = "11")]
		public override string GetFormattedPrice(string vendorID)
		{
			return null;
		}

		[Token(Token = "0x6001F91")]
		[Address(RVA = "0xB96EAC", Offset = "0xB96EAC", VA = "0xB96EAC", Slot = "22")]
		protected override bool PurchaseInternal(UkenPaymentProduct product)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F92")]
		[Address(RVA = "0xB97450", Offset = "0xB97450", VA = "0xB97450", Slot = "19")]
		public override bool RestorePurchases(Action<bool> onRestoreFinished)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F93")]
		[Address(RVA = "0xB969AC", Offset = "0xB969AC", VA = "0xB969AC")]
		public void InitializePurchasing(List<UnityIAP_Product> products)
		{
		}

		[Token(Token = "0x6001F94")]
		[Address(RVA = "0xB9758C", Offset = "0xB9758C", VA = "0xB9758C", Slot = "20")]
		public override bool IsIAPInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6001F95")]
		[Address(RVA = "0xB96F24", Offset = "0xB96F24", VA = "0xB96F24")]
		private bool StartPurchase(UnityIAP_Product iapProduct)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F96")]
		[Address(RVA = "0xB97484", Offset = "0xB97484", VA = "0xB97484")]
		protected bool RestorePurchases_UnityIAP(Action<bool> onRestoreFinished)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F97")]
		[Address(RVA = "0xB9762C", Offset = "0xB9762C", VA = "0xB9762C", Slot = "33")]
		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		[Token(Token = "0x6001F98")]
		[Address(RVA = "0xB9783C", Offset = "0xB9783C", VA = "0xB9783C", Slot = "30")]
		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		[Token(Token = "0x6001F99")]
		[Address(RVA = "0xB97934", Offset = "0xB97934", VA = "0xB97934")]
		private void LogProductData(Product product, bool isRetry)
		{
		}

		[Token(Token = "0x6001F9A")]
		[Address(RVA = "0xB97D6C", Offset = "0xB97D6C", VA = "0xB97D6C", Slot = "23")]
		public override Dictionary<string, object> GetLogData()
		{
			return null;
		}

		[Token(Token = "0x6001F9B")]
		[Address(RVA = "0xB97F4C", Offset = "0xB97F4C", VA = "0xB97F4C", Slot = "31")]
		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
		{
			return default(PurchaseProcessingResult);
		}

		[Token(Token = "0x6001F9C")]
		[Address(RVA = "0xB982C0", Offset = "0xB982C0", VA = "0xB982C0", Slot = "32")]
		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
		}

		[Token(Token = "0x6001F9D")]
		[Address(RVA = "0xB985AC", Offset = "0xB985AC", VA = "0xB985AC", Slot = "27")]
		protected override void OnPurchaseValidated(UkenPaymentValidationResult result, UkenPaymentProduct purchasedProduct, string source_sink)
		{
		}

		[Token(Token = "0x6001F9E")]
		[Address(RVA = "0xB987B8", Offset = "0xB987B8", VA = "0xB987B8", Slot = "12")]
		protected override bool OnUnclaimedPurchaseQueryComplete(WebResponse response, Action<bool> onQueryComplete)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F9F")]
		[Address(RVA = "0xB98858", Offset = "0xB98858", VA = "0xB98858", Slot = "14")]
		protected override Queue<UkenPaymentProduct> GetUnvalidatedPurchases(List<Dictionary<string, object>> unprocessedPurchaseData)
		{
			return null;
		}

		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0xB990D0", Offset = "0xB990D0", VA = "0xB990D0")]
		private void StartValidationForUnvalidatedPurchases(bool success)
		{
		}

		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0xB99154", Offset = "0xB99154", VA = "0xB99154")]
		private void ValidateUnvalidatedPurchases()
		{
		}

		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0xB99288", Offset = "0xB99288", VA = "0xB99288")]
		private void AddUnclaimedPurchase(UkenPaymentValidationResult result, UkenPaymentProduct purchasedProduct, string sourceSink)
		{
		}

		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0xB98608", Offset = "0xB98608", VA = "0xB98608")]
		private void ConfirmPurchaseWithProvider(UkenPaymentValidationResult result, UkenPaymentProduct purchasedProduct)
		{
		}
	}
}
