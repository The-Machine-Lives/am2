using System;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.IAP;

[Token(Token = "0x200015D")]
public class BIPaymentValidator : UkenPaymentValidator
{
	[Token(Token = "0x2000644")]
	public class PaymenValidationRequest : WebRequest
	{
		[Token(Token = "0x4001F35")]
		[FieldOffset(Offset = "0x38")]
		private UkenPaymentProduct m_product;

		[Token(Token = "0x6002D49")]
		[Address(RVA = "0xA41388", Offset = "0xA41388", VA = "0xA41388")]
		public PaymenValidationRequest(string endpoint, Action<WebResponse, WebRequest> onComplete)
		{
		}

		[Token(Token = "0x6002D4A")]
		[Address(RVA = "0xA41390", Offset = "0xA41390", VA = "0xA41390")]
		public void SetParameters(UkenPaymentProduct product)
		{
		}
	}

	[Token(Token = "0x400087A")]
	[FieldOffset(Offset = "0x38")]
	private Action<WebRequest> m_webInterface;

	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x40")]
	private string m_paymentValidationURL;

	[Token(Token = "0x600098F")]
	[Address(RVA = "0xA411AC", Offset = "0xA411AC", VA = "0xA411AC")]
	public BIPaymentValidator(Action<WebRequest> webInterface)
	{
	}

	[Token(Token = "0x6000990")]
	[Address(RVA = "0xA41218", Offset = "0xA41218", VA = "0xA41218")]
	public void SetPaymentValidationURL(string url)
	{
	}

	[Token(Token = "0x6000991")]
	[Address(RVA = "0xA41220", Offset = "0xA41220", VA = "0xA41220", Slot = "7")]
	protected override void ValidateInternal(UkenPaymentProduct purchasedProduct)
	{
	}

	[Token(Token = "0x6000992")]
	[Address(RVA = "0xA41224", Offset = "0xA41224", VA = "0xA41224")]
	private void ValidateReceiptWithBackend(UkenPaymentProduct purchasedProduct)
	{
	}

	[Token(Token = "0x6000993")]
	[Address(RVA = "0xA41538", Offset = "0xA41538", VA = "0xA41538")]
	private void OnValidationRequestFinished(WebResponse response, WebRequest request)
	{
	}

	[Token(Token = "0x6000994")]
	[Address(RVA = "0xA4160C", Offset = "0xA4160C", VA = "0xA4160C")]
	private UkenPaymentValidationResult ValidateJSON(string jsonString)
	{
		return default(UkenPaymentValidationResult);
	}
}
