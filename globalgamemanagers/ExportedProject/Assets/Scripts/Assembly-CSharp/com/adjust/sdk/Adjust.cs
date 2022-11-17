using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace com.adjust.sdk
{
	[Token(Token = "0x2000224")]
	public class Adjust : MonoBehaviour
	{
		[Token(Token = "0x4000C0C")]
		private const string errorMsgEditor = "Adjust: SDK can not be used in Editor.";

		[Token(Token = "0x4000C0D")]
		private const string errorMsgStart = "Adjust: SDK not started. Start it manually using the 'start' method.";

		[Token(Token = "0x4000C0E")]
		private const string errorMsgPlatform = "Adjust: SDK can only be used in Android, iOS, Windows Phone 8.1, Windows Store or Universal Windows apps.";

		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0x18")]
		public bool startManually;

		[Token(Token = "0x4000C10")]
		[FieldOffset(Offset = "0x19")]
		public bool eventBuffering;

		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0x1A")]
		public bool sendInBackground;

		[Token(Token = "0x4000C12")]
		[FieldOffset(Offset = "0x1B")]
		public bool launchDeferredDeeplink;

		[Token(Token = "0x4000C13")]
		[FieldOffset(Offset = "0x20")]
		public string appToken;

		[Token(Token = "0x4000C14")]
		[FieldOffset(Offset = "0x28")]
		public AdjustLogLevel logLevel;

		[Token(Token = "0x4000C15")]
		[FieldOffset(Offset = "0x2C")]
		public AdjustEnvironment environment;

		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0xABE298", Offset = "0xABE298", VA = "0xABE298", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0xABE4CC", Offset = "0xABE4CC", VA = "0xABE4CC")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0xABE428", Offset = "0xABE428", VA = "0xABE428")]
		public static void start(AdjustConfig adjustConfig)
		{
		}

		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0xABFAF0", Offset = "0xABFAF0", VA = "0xABFAF0")]
		public static void trackEvent(AdjustEvent adjustEvent)
		{
		}

		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0xAC0268", Offset = "0xAC0268", VA = "0xAC0268")]
		public static void setEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000EED")]
		[Address(RVA = "0xAC03F4", Offset = "0xAC03F4", VA = "0xAC03F4")]
		public static bool isEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0xAC04F8", Offset = "0xAC04F8", VA = "0xAC04F8")]
		public static void setOfflineMode(bool enabled)
		{
		}

		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0xAC0684", Offset = "0xAC0684", VA = "0xAC0684")]
		public static void setDeviceToken(string deviceToken)
		{
		}

		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0xAC0840", Offset = "0xAC0840", VA = "0xAC0840")]
		public static void gdprForgetMe()
		{
		}

		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0xAC09A8", Offset = "0xAC09A8", VA = "0xAC09A8")]
		public static void appWillOpenUrl(string url)
		{
		}

		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0xAC0C30", Offset = "0xAC0C30", VA = "0xAC0C30")]
		public static void sendFirstPackages()
		{
		}

		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0xAC0D2C", Offset = "0xAC0D2C", VA = "0xAC0D2C")]
		public static void addSessionPartnerParameter(string key, string value)
		{
		}

		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0xAC0F58", Offset = "0xAC0F58", VA = "0xAC0F58")]
		public static void addSessionCallbackParameter(string key, string value)
		{
		}

		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0xAC1184", Offset = "0xAC1184", VA = "0xAC1184")]
		public static void removeSessionPartnerParameter(string key)
		{
		}

		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0xAC1354", Offset = "0xAC1354", VA = "0xAC1354")]
		public static void removeSessionCallbackParameter(string key)
		{
		}

		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0xAC1524", Offset = "0xAC1524", VA = "0xAC1524")]
		public static void resetSessionPartnerParameters()
		{
		}

		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0xAC1690", Offset = "0xAC1690", VA = "0xAC1690")]
		public static void resetSessionCallbackParameters()
		{
		}

		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0xAC17FC", Offset = "0xAC17FC", VA = "0xAC17FC")]
		public static string getAdid()
		{
			return null;
		}

		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0xAC1900", Offset = "0xAC1900", VA = "0xAC1900")]
		public static AdjustAttribution getAttribution()
		{
			return null;
		}

		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0xAC205C", Offset = "0xAC205C", VA = "0xAC205C")]
		public static string getWinAdid()
		{
			return null;
		}

		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0xAC20E0", Offset = "0xAC20E0", VA = "0xAC20E0")]
		public static string getIdfa()
		{
			return null;
		}

		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0xAC2164", Offset = "0xAC2164", VA = "0xAC2164")]
		public static string getSdkVersion()
		{
			return null;
		}

		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0xAC2284", Offset = "0xAC2284", VA = "0xAC2284")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83555C", Offset = "0x83555C")]
		public static void setReferrer(string referrer)
		{
		}

		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0xAC2440", Offset = "0xAC2440", VA = "0xAC2440")]
		public static void getGoogleAdId(Action<string> onDeviceIdsRead)
		{
		}

		[Token(Token = "0x6000F00")]
		[Address(RVA = "0xAC261C", Offset = "0xAC261C", VA = "0xAC261C")]
		public static string getAmazonAdId()
		{
			return null;
		}

		[Token(Token = "0x6000F01")]
		[Address(RVA = "0xABE420", Offset = "0xABE420", VA = "0xABE420")]
		private static bool IsEditor()
		{
			return default(bool);
		}

		[Token(Token = "0x6000F02")]
		[Address(RVA = "0xAC278C", Offset = "0xAC278C", VA = "0xAC278C")]
		public static void SetTestOptions(Dictionary<string, string> testOptions)
		{
		}

		[Token(Token = "0x6000F03")]
		[Address(RVA = "0xAC293C", Offset = "0xAC293C", VA = "0xAC293C")]
		public Adjust()
		{
		}
	}
}
