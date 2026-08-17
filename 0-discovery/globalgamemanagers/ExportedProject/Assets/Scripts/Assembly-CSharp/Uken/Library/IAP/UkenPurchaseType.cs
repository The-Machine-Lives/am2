using Il2CppDummyDll;

namespace Uken.Library.IAP
{
	[Token(Token = "0x2000433")]
	public enum UkenPurchaseType
	{
		[Token(Token = "0x400136B")]
		Consumable = 0,
		[Token(Token = "0x400136C")]
		NonConsumable = 1,
		[Token(Token = "0x400136D")]
		Subscription = 2
	}
}
