using System;
using Il2CppDummyDll;

namespace Uken.Library.IAP
{
	[Token(Token = "0x200043D")]
	public abstract class UkenPaymentValidator
	{
		[Token(Token = "0x20007F5")]
		public delegate void LogPaymentValidationStart(string vendor_id, UkenPurchasePayload custom_payload, string transation_id, string receipt, bool isRetry);

		[Token(Token = "0x20007F6")]
		public delegate void LogPaymentValidationCompleted(UkenPaymentValidationResult validationResult, string vendor_id, UkenPurchasePayload custom_payload, string transaction_id, string receipt, bool isRetry);

		[Token(Token = "0x40013A3")]
		[FieldOffset(Offset = "0x10")]
		private bool m_bInitialized;

		[Token(Token = "0x40013A4")]
		[FieldOffset(Offset = "0x18")]
		protected UkenPaymentProduct m_pendingValidationProduct;

		[Token(Token = "0x40013A5")]
		[FieldOffset(Offset = "0x20")]
		private Action<UkenPaymentValidationResult, UkenPaymentProduct, string> m_onValidationComplete;

		[Token(Token = "0x40013A6")]
		[FieldOffset(Offset = "0x28")]
		protected LogPaymentValidationStart m_logValidationStart;

		[Token(Token = "0x40013A7")]
		[FieldOffset(Offset = "0x30")]
		protected LogPaymentValidationCompleted m_logValidationComplete;

		[Token(Token = "0x6001F83")]
		[Address(RVA = "0xB95048", Offset = "0xB95048", VA = "0xB95048", Slot = "4")]
		public virtual void Initialize(LogPaymentValidationStart logValidationStart, LogPaymentValidationCompleted logValidationComplete)
		{
		}

		[Token(Token = "0x6001F84")]
		[Address(RVA = "0xB95058", Offset = "0xB95058", VA = "0xB95058", Slot = "5")]
		public virtual bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6001F85")]
		[Address(RVA = "0xB95060", Offset = "0xB95060", VA = "0xB95060", Slot = "6")]
		public virtual bool IsValidationInProgress()
		{
			return default(bool);
		}

		[Token(Token = "0x6001F86")]
		[Address(RVA = "0xB95070", Offset = "0xB95070", VA = "0xB95070")]
		public void ResetSystem()
		{
		}

		[Token(Token = "0x6001F87")]
		[Address(RVA = "0xB95078", Offset = "0xB95078", VA = "0xB95078")]
		public void ValidatePurchase(UkenPaymentProduct purchasedProduct, Action<UkenPaymentValidationResult, UkenPaymentProduct, string> onValidationComplete)
		{
		}

		[Token(Token = "0x6001F88")]
		protected abstract void ValidateInternal(UkenPaymentProduct purchasedProduct);

		[Token(Token = "0x6001F89")]
		[Address(RVA = "0xB95A44", Offset = "0xB95A44", VA = "0xB95A44", Slot = "8")]
		protected virtual void OnValidationComplete(UkenPaymentValidationResult result)
		{
		}

		[Token(Token = "0x6001F8A")]
		[Address(RVA = "0xB96240", Offset = "0xB96240", VA = "0xB96240")]
		protected UkenPaymentValidator()
		{
		}
	}
}
