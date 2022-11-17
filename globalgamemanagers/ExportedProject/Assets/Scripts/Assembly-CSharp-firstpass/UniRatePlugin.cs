using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000003")]
public class UniRatePlugin
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject _uniRateInterface;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x181CE68", Offset = "0x181CE68", VA = "0x181CE68")]
	public static void ShowPrompt(string title, string msg, string rateTitle, string canceltitle, string remindTitle)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x181D0B4", Offset = "0x181D0B4", VA = "0x181D0B4")]
	public static string GetAppStoreCountry()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x181D104", Offset = "0x181D104", VA = "0x181D104")]
	public static string GetApplicationName()
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x181D1B8", Offset = "0x181D1B8", VA = "0x181D1B8")]
	public static string GetApplicationVersion()
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x181D26C", Offset = "0x181D26C", VA = "0x181D26C")]
	public static string GetApplicationBundleID()
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x181D2B4", Offset = "0x181D2B4", VA = "0x181D2B4")]
	public static string GetPackageName()
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x181D368", Offset = "0x181D368", VA = "0x181D368")]
	public static void OpenAndroidRatePage(string rateURL)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x181D49C", Offset = "0x181D49C", VA = "0x181D49C")]
	public static void OpenWPMarket()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x181D4A0", Offset = "0x181D4A0", VA = "0x181D4A0")]
	public static void InitUniRateAndroid()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x181D55C", Offset = "0x181D55C", VA = "0x181D55C")]
	public UniRatePlugin()
	{
	}
}
