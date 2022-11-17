using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace com.adjust.sdk
{
	[Token(Token = "0x2000225")]
	public class AdjustAndroid
	{
		[Token(Token = "0x2000677")]
		private class AttributionChangeListener : AndroidJavaProxy
		{
			[Token(Token = "0x4001FD2")]
			[FieldOffset(Offset = "0x20")]
			private Action<AdjustAttribution> callback;

			[Token(Token = "0x6002E00")]
			[Address(RVA = "0x177685C", Offset = "0x177685C", VA = "0x177685C")]
			public AttributionChangeListener(Action<AdjustAttribution> pCallback)
			{
			}

			[Token(Token = "0x6002E01")]
			[Address(RVA = "0x17768E4", Offset = "0x17768E4", VA = "0x17768E4")]
			public void onAttributionChanged(AndroidJavaObject attribution)
			{
			}
		}

		[Token(Token = "0x2000678")]
		private class DeferredDeeplinkListener : AndroidJavaProxy
		{
			[Token(Token = "0x4001FD3")]
			[FieldOffset(Offset = "0x20")]
			private Action<string> callback;

			[Token(Token = "0x6002E02")]
			[Address(RVA = "0x1776EEC", Offset = "0x1776EEC", VA = "0x1776EEC")]
			public DeferredDeeplinkListener(Action<string> pCallback)
			{
			}

			[Token(Token = "0x6002E03")]
			[Address(RVA = "0x1776F74", Offset = "0x1776F74", VA = "0x1776F74")]
			public bool launchReceivedDeeplink(AndroidJavaObject deeplink)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000679")]
		private class EventTrackingSucceededListener : AndroidJavaProxy
		{
			[Token(Token = "0x4001FD4")]
			[FieldOffset(Offset = "0x20")]
			private Action<AdjustEventSuccess> callback;

			[Token(Token = "0x6002E04")]
			[Address(RVA = "0x1777838", Offset = "0x1777838", VA = "0x1777838")]
			public EventTrackingSucceededListener(Action<AdjustEventSuccess> pCallback)
			{
			}

			[Token(Token = "0x6002E05")]
			[Address(RVA = "0x17778C0", Offset = "0x17778C0", VA = "0x17778C0")]
			public void onFinishedEventTrackingSucceeded(AndroidJavaObject eventSuccessData)
			{
			}
		}

		[Token(Token = "0x200067A")]
		private class EventTrackingFailedListener : AndroidJavaProxy
		{
			[Token(Token = "0x4001FD5")]
			[FieldOffset(Offset = "0x20")]
			private Action<AdjustEventFailure> callback;

			[Token(Token = "0x6002E06")]
			[Address(RVA = "0x1777200", Offset = "0x1777200", VA = "0x1777200")]
			public EventTrackingFailedListener(Action<AdjustEventFailure> pCallback)
			{
			}

			[Token(Token = "0x6002E07")]
			[Address(RVA = "0x1777288", Offset = "0x1777288", VA = "0x1777288")]
			public void onFinishedEventTrackingFailed(AndroidJavaObject eventFailureData)
			{
			}
		}

		[Token(Token = "0x200067B")]
		private class SessionTrackingSucceededListener : AndroidJavaProxy
		{
			[Token(Token = "0x4001FD6")]
			[FieldOffset(Offset = "0x20")]
			private Action<AdjustSessionSuccess> callback;

			[Token(Token = "0x6002E08")]
			[Address(RVA = "0x177836C", Offset = "0x177836C", VA = "0x177836C")]
			public SessionTrackingSucceededListener(Action<AdjustSessionSuccess> pCallback)
			{
			}

			[Token(Token = "0x6002E09")]
			[Address(RVA = "0x17783F4", Offset = "0x17783F4", VA = "0x17783F4")]
			public void onFinishedSessionTrackingSucceeded(AndroidJavaObject sessionSuccessData)
			{
			}
		}

		[Token(Token = "0x200067C")]
		private class SessionTrackingFailedListener : AndroidJavaProxy
		{
			[Token(Token = "0x4001FD7")]
			[FieldOffset(Offset = "0x20")]
			private Action<AdjustSessionFailure> callback;

			[Token(Token = "0x6002E0A")]
			[Address(RVA = "0x1777E3C", Offset = "0x1777E3C", VA = "0x1777E3C")]
			public SessionTrackingFailedListener(Action<AdjustSessionFailure> pCallback)
			{
			}

			[Token(Token = "0x6002E0B")]
			[Address(RVA = "0x1777EC4", Offset = "0x1777EC4", VA = "0x1777EC4")]
			public void onFinishedSessionTrackingFailed(AndroidJavaObject sessionFailureData)
			{
			}
		}

		[Token(Token = "0x200067D")]
		private class DeviceIdsReadListener : AndroidJavaProxy
		{
			[Token(Token = "0x4001FD8")]
			[FieldOffset(Offset = "0x20")]
			private Action<string> onPlayAdIdReadCallback;

			[Token(Token = "0x6002E0C")]
			[Address(RVA = "0x177706C", Offset = "0x177706C", VA = "0x177706C")]
			public DeviceIdsReadListener(Action<string> pCallback)
			{
			}

			[Token(Token = "0x6002E0D")]
			[Address(RVA = "0x17770F4", Offset = "0x17770F4", VA = "0x17770F4")]
			public void onGoogleAdIdRead(string playAdId)
			{
			}

			[Token(Token = "0x6002E0E")]
			[Address(RVA = "0x1777168", Offset = "0x1777168", VA = "0x1777168")]
			public void onGoogleAdIdRead(AndroidJavaObject ajoAdId)
			{
			}
		}

		[Token(Token = "0x4000C16")]
		private const string sdkPrefix = "unity4.17.0";

		[Token(Token = "0x4000C17")]
		[FieldOffset(Offset = "0x0")]
		private static bool launchDeferredDeeplink;

		[Token(Token = "0x4000C18")]
		[FieldOffset(Offset = "0x8")]
		private static AndroidJavaClass ajcAdjust;

		[Token(Token = "0x4000C19")]
		[FieldOffset(Offset = "0x10")]
		private static AndroidJavaObject ajoCurrentActivity;

		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x18")]
		private static DeferredDeeplinkListener onDeferredDeeplinkListener;

		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x20")]
		private static AttributionChangeListener onAttributionChangedListener;

		[Token(Token = "0x4000C1C")]
		[FieldOffset(Offset = "0x28")]
		private static EventTrackingFailedListener onEventTrackingFailedListener;

		[Token(Token = "0x4000C1D")]
		[FieldOffset(Offset = "0x30")]
		private static EventTrackingSucceededListener onEventTrackingSucceededListener;

		[Token(Token = "0x4000C1E")]
		[FieldOffset(Offset = "0x38")]
		private static SessionTrackingFailedListener onSessionTrackingFailedListener;

		[Token(Token = "0x4000C1F")]
		[FieldOffset(Offset = "0x40")]
		private static SessionTrackingSucceededListener onSessionTrackingSucceededListener;

		[Token(Token = "0x6000F04")]
		[Address(RVA = "0xABE68C", Offset = "0xABE68C", VA = "0xABE68C")]
		public static void Start(AdjustConfig adjustConfig)
		{
		}

		[Token(Token = "0x6000F05")]
		[Address(RVA = "0xABFB94", Offset = "0xABFB94", VA = "0xABFB94")]
		public static void TrackEvent(AdjustEvent adjustEvent)
		{
		}

		[Token(Token = "0x6000F06")]
		[Address(RVA = "0xAC0450", Offset = "0xAC0450", VA = "0xAC0450")]
		public static bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000F07")]
		[Address(RVA = "0xAC02CC", Offset = "0xAC02CC", VA = "0xAC02CC")]
		public static void SetEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000F08")]
		[Address(RVA = "0xAC055C", Offset = "0xAC055C", VA = "0xAC055C")]
		public static void SetOfflineMode(bool enabled)
		{
		}

		[Token(Token = "0x6000F09")]
		[Address(RVA = "0xAC0C8C", Offset = "0xAC0C8C", VA = "0xAC0C8C")]
		public static void SendFirstPackages()
		{
		}

		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0xAC06E8", Offset = "0xAC06E8", VA = "0xAC06E8")]
		public static void SetDeviceToken(string deviceToken)
		{
		}

		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0xAC1858", Offset = "0xAC1858", VA = "0xAC1858")]
		public static string GetAdid()
		{
			return null;
		}

		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0xAC089C", Offset = "0xAC089C", VA = "0xAC089C")]
		public static void GdprForgetMe()
		{
		}

		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0xAC195C", Offset = "0xAC195C", VA = "0xAC195C")]
		public static AdjustAttribution GetAttribution()
		{
			return null;
		}

		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0xAC0DA0", Offset = "0xAC0DA0", VA = "0xAC0DA0")]
		public static void AddSessionPartnerParameter(string key, string value)
		{
		}

		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0xAC0FCC", Offset = "0xAC0FCC", VA = "0xAC0FCC")]
		public static void AddSessionCallbackParameter(string key, string value)
		{
		}

		[Token(Token = "0x6000F10")]
		[Address(RVA = "0xAC11E8", Offset = "0xAC11E8", VA = "0xAC11E8")]
		public static void RemoveSessionPartnerParameter(string key)
		{
		}

		[Token(Token = "0x6000F11")]
		[Address(RVA = "0xAC13B8", Offset = "0xAC13B8", VA = "0xAC13B8")]
		public static void RemoveSessionCallbackParameter(string key)
		{
		}

		[Token(Token = "0x6000F12")]
		[Address(RVA = "0xAC1580", Offset = "0xAC1580", VA = "0xAC1580")]
		public static void ResetSessionPartnerParameters()
		{
		}

		[Token(Token = "0x6000F13")]
		[Address(RVA = "0xAC16EC", Offset = "0xAC16EC", VA = "0xAC16EC")]
		public static void ResetSessionCallbackParameters()
		{
		}

		[Token(Token = "0x6000F14")]
		[Address(RVA = "0xAC0A0C", Offset = "0xAC0A0C", VA = "0xAC0A0C")]
		public static void AppWillOpenUrl(string url)
		{
		}

		[Token(Token = "0x6000F15")]
		[Address(RVA = "0xABE54C", Offset = "0xABE54C", VA = "0xABE54C")]
		public static void OnPause()
		{
		}

		[Token(Token = "0x6000F16")]
		[Address(RVA = "0xABE5EC", Offset = "0xABE5EC", VA = "0xABE5EC")]
		public static void OnResume()
		{
		}

		[Token(Token = "0x6000F17")]
		[Address(RVA = "0xAC22E8", Offset = "0xAC22E8", VA = "0xAC22E8")]
		public static void SetReferrer(string referrer)
		{
		}

		[Token(Token = "0x6000F18")]
		[Address(RVA = "0xAC24A4", Offset = "0xAC24A4", VA = "0xAC24A4")]
		public static void GetGoogleAdId(Action<string> onDeviceIdsRead)
		{
		}

		[Token(Token = "0x6000F19")]
		[Address(RVA = "0xAC2678", Offset = "0xAC2678", VA = "0xAC2678")]
		public static string GetAmazonAdId()
		{
			return null;
		}

		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0xAC21C0", Offset = "0xAC21C0", VA = "0xAC21C0")]
		public static string GetSdkVersion()
		{
			return null;
		}

		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0xAC27F0", Offset = "0xAC27F0", VA = "0xAC27F0")]
		public static void SetTestOptions(Dictionary<string, string> testOptions)
		{
		}

		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0xAC29A8", Offset = "0xAC29A8", VA = "0xAC29A8")]
		private static bool IsAppSecretSet(AdjustConfig adjustConfig)
		{
			return default(bool);
		}

		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0xAC2A84", Offset = "0xAC2A84", VA = "0xAC2A84")]
		public AdjustAndroid()
		{
		}
	}
}
