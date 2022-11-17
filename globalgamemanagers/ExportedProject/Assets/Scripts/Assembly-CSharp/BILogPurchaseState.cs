using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.IAP;

[Token(Token = "0x20000AD")]
public class BILogPurchaseState : CasualAnalogData
{
	[Token(Token = "0x600043E")]
	[Address(RVA = "0xA40DA8", Offset = "0xA40DA8", VA = "0xA40DA8")]
	public BILogPurchaseState(string sale_reference, float price, string custom_payload, UkenPurchaseResult purchase_result)
	{
	}
}
