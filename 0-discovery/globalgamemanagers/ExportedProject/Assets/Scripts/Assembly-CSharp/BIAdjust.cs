using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Library.Adjust;

[Token(Token = "0x2000095")]
public class BIAdjust : UkenAdjust
{
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xA3BAD4", Offset = "0xA3BAD4", VA = "0xA3BAD4")]
	public static BIAdjust Get()
	{
		return null;
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xA3BBAC", Offset = "0xA3BBAC", VA = "0xA3BBAC", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0xA3BD5C", Offset = "0xA3BD5C", VA = "0xA3BD5C", Slot = "8")]
	protected override string GetRevenueEventString()
	{
		return null;
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xA3BDA4", Offset = "0xA3BDA4", VA = "0xA3BDA4")]
	public static void LogUnlockTab(string tabKey)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0xA3BEF8", Offset = "0xA3BEF8", VA = "0xA3BEF8")]
	public static void LogZoneStart(string zoneKey)
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xA3BF94", Offset = "0xA3BF94", VA = "0xA3BF94")]
	public static void LogZoneEnd(string zoneKey)
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xA3C030", Offset = "0xA3C030", VA = "0xA3C030")]
	public static void LogPurchase(double localizedPrice, string currencyCode, string transactionID)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xA3C0FC", Offset = "0xA3C0FC", VA = "0xA3C0FC")]
	public static void LogQuestComplete(string questRef)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xA3C198", Offset = "0xA3C198", VA = "0xA3C198")]
	public static void LogAdView(string adConfigRef)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xA3C290", Offset = "0xA3C290", VA = "0xA3C290")]
	public static void LogMaxCapUpgrade(long lvl)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xA3C348", Offset = "0xA3C348", VA = "0xA3C348")]
	public static void LogRecipeUnlocked(string recipeRef)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xA3C3E4", Offset = "0xA3C3E4", VA = "0xA3C3E4")]
	public static void LogSpeedBoosterCreated(string boosterRef)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xA3C480", Offset = "0xA3C480", VA = "0xA3C480")]
	public static void LogFirstPowerSustain()
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xA3BE40", Offset = "0xA3BE40", VA = "0xA3BE40")]
	public static void LogAdjustEvent(AM2AdjustEvent adjustEvent, [Optional] Dictionary<string, string> callbackParameters)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0xA3C48C", Offset = "0xA3C48C", VA = "0xA3C48C")]
	public BIAdjust()
	{
	}
}
