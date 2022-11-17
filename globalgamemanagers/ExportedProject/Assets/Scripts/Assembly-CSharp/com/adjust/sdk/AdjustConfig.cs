using System;
using Il2CppDummyDll;

namespace com.adjust.sdk
{
	[Token(Token = "0x2000227")]
	public class AdjustConfig
	{
		[Token(Token = "0x4000C28")]
		[FieldOffset(Offset = "0x10")]
		internal string appToken;

		[Token(Token = "0x4000C29")]
		[FieldOffset(Offset = "0x18")]
		internal string sceneName;

		[Token(Token = "0x4000C2A")]
		[FieldOffset(Offset = "0x20")]
		internal string userAgent;

		[Token(Token = "0x4000C2B")]
		[FieldOffset(Offset = "0x28")]
		internal string defaultTracker;

		[Token(Token = "0x4000C2C")]
		[FieldOffset(Offset = "0x30")]
		internal long? info1;

		[Token(Token = "0x4000C2D")]
		[FieldOffset(Offset = "0x40")]
		internal long? info2;

		[Token(Token = "0x4000C2E")]
		[FieldOffset(Offset = "0x50")]
		internal long? info3;

		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0x60")]
		internal long? info4;

		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0x70")]
		internal long? secretId;

		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0x80")]
		internal double? delayStart;

		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0x90")]
		internal bool? isDeviceKnown;

		[Token(Token = "0x4000C33")]
		[FieldOffset(Offset = "0x92")]
		internal bool? sendInBackground;

		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x94")]
		internal bool? eventBufferingEnabled;

		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0x96")]
		internal bool? allowSuppressLogLevel;

		[Token(Token = "0x4000C36")]
		[FieldOffset(Offset = "0x98")]
		internal bool launchDeferredDeeplink;

		[Token(Token = "0x4000C37")]
		[FieldOffset(Offset = "0x9C")]
		internal AdjustLogLevel? logLevel;

		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0xA4")]
		internal AdjustEnvironment environment;

		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0xA8")]
		internal Action<string> deferredDeeplinkDelegate;

		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0xB0")]
		internal Action<AdjustEventSuccess> eventSuccessDelegate;

		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0xB8")]
		internal Action<AdjustEventFailure> eventFailureDelegate;

		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0xC0")]
		internal Action<AdjustSessionSuccess> sessionSuccessDelegate;

		[Token(Token = "0x4000C3D")]
		[FieldOffset(Offset = "0xC8")]
		internal Action<AdjustSessionFailure> sessionFailureDelegate;

		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0xD0")]
		internal Action<AdjustAttribution> attributionChangedDelegate;

		[Token(Token = "0x4000C3F")]
		[FieldOffset(Offset = "0xD8")]
		internal bool? readImei;

		[Token(Token = "0x4000C40")]
		[FieldOffset(Offset = "0xE0")]
		internal string processName;

		[Token(Token = "0x4000C41")]
		[FieldOffset(Offset = "0xE8")]
		internal Action<string> logDelegate;

		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x1778D88", Offset = "0x1778D88", VA = "0x1778D88")]
		public AdjustConfig(string appToken, AdjustEnvironment environment)
		{
		}

		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x1778DFC", Offset = "0x1778DFC", VA = "0x1778DFC")]
		public AdjustConfig(string appToken, AdjustEnvironment environment, bool allowSuppressLogLevel)
		{
		}

		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x1778EA0", Offset = "0x1778EA0", VA = "0x1778EA0")]
		public void setLogLevel(AdjustLogLevel logLevel)
		{
		}

		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x1778F10", Offset = "0x1778F10", VA = "0x1778F10")]
		public void setDefaultTracker(string defaultTracker)
		{
		}

		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x1778F18", Offset = "0x1778F18", VA = "0x1778F18")]
		public void setLaunchDeferredDeeplink(bool launchDeferredDeeplink)
		{
		}

		[Token(Token = "0x6000F37")]
		[Address(RVA = "0x1778F24", Offset = "0x1778F24", VA = "0x1778F24")]
		public void setSendInBackground(bool sendInBackground)
		{
		}

		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x1778F94", Offset = "0x1778F94", VA = "0x1778F94")]
		public void setEventBufferingEnabled(bool eventBufferingEnabled)
		{
		}

		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x1779004", Offset = "0x1779004", VA = "0x1779004")]
		public void setDelayStart(double delayStart)
		{
		}

		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x177907C", Offset = "0x177907C", VA = "0x177907C")]
		public void setUserAgent(string userAgent)
		{
		}

		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x1779084", Offset = "0x1779084", VA = "0x1779084")]
		public void setIsDeviceKnown(bool isDeviceKnown)
		{
		}

		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x17790F4", Offset = "0x17790F4", VA = "0x17790F4")]
		public void setDeferredDeeplinkDelegate(Action<string> deferredDeeplinkDelegate, string sceneName = "Adjust")
		{
		}

		[Token(Token = "0x6000F3D")]
		[Address(RVA = "0x1779100", Offset = "0x1779100", VA = "0x1779100")]
		public Action<string> getDeferredDeeplinkDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0x1779108", Offset = "0x1779108", VA = "0x1779108")]
		public void setAttributionChangedDelegate(Action<AdjustAttribution> attributionChangedDelegate, string sceneName = "Adjust")
		{
		}

		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x1779114", Offset = "0x1779114", VA = "0x1779114")]
		public Action<AdjustAttribution> getAttributionChangedDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x177911C", Offset = "0x177911C", VA = "0x177911C")]
		public void setEventSuccessDelegate(Action<AdjustEventSuccess> eventSuccessDelegate, string sceneName = "Adjust")
		{
		}

		[Token(Token = "0x6000F41")]
		[Address(RVA = "0x1779128", Offset = "0x1779128", VA = "0x1779128")]
		public Action<AdjustEventSuccess> getEventSuccessDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x1779130", Offset = "0x1779130", VA = "0x1779130")]
		public void setEventFailureDelegate(Action<AdjustEventFailure> eventFailureDelegate, string sceneName = "Adjust")
		{
		}

		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x177913C", Offset = "0x177913C", VA = "0x177913C")]
		public Action<AdjustEventFailure> getEventFailureDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x1779144", Offset = "0x1779144", VA = "0x1779144")]
		public void setSessionSuccessDelegate(Action<AdjustSessionSuccess> sessionSuccessDelegate, string sceneName = "Adjust")
		{
		}

		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x1779150", Offset = "0x1779150", VA = "0x1779150")]
		public Action<AdjustSessionSuccess> getSessionSuccessDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x1779158", Offset = "0x1779158", VA = "0x1779158")]
		public void setSessionFailureDelegate(Action<AdjustSessionFailure> sessionFailureDelegate, string sceneName = "Adjust")
		{
		}

		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x1779164", Offset = "0x1779164", VA = "0x1779164")]
		public Action<AdjustSessionFailure> getSessionFailureDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x177916C", Offset = "0x177916C", VA = "0x177916C")]
		public void setAppSecret(long secretId, long info1, long info2, long info3, long info4)
		{
		}

		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x1779274", Offset = "0x1779274", VA = "0x1779274")]
		public void setProcessName(string processName)
		{
		}

		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x177927C", Offset = "0x177927C", VA = "0x177927C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x835694", Offset = "0x835694")]
		public void setReadMobileEquipmentIdentity(bool readMobileEquipmentIdentity)
		{
		}

		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x1779280", Offset = "0x1779280", VA = "0x1779280")]
		public void setLogDelegate(Action<string> logDelegate)
		{
		}
	}
}
