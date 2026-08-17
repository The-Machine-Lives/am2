using System;
using Facebook.Unity.Mobile;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x2000010")]
	public sealed class FBGamingServices : ScriptableObject
	{
		[Token(Token = "0x17000021")]
		private static IMobileFacebook MobileFacebookImpl
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xCDADC0", Offset = "0xCDADC0", VA = "0xCDADC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xCDAD04", Offset = "0xCDAD04", VA = "0xCDAD04")]
		public static void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xCDAE78", Offset = "0xCDAE78", VA = "0xCDAE78")]
		public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xCDAF5C", Offset = "0xCDAF5C", VA = "0xCDAF5C")]
		public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xCDB030", Offset = "0xCDB030", VA = "0xCDB030")]
		public static void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xCDB0EC", Offset = "0xCDB0EC", VA = "0xCDB0EC")]
		public static void GetCatalog(FacebookDelegate<ICatalogResult> callback)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xCDB1A8", Offset = "0xCDB1A8", VA = "0xCDB1A8")]
		public static void GetPurchases(FacebookDelegate<IPurchasesResult> callback)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xCDB264", Offset = "0xCDB264", VA = "0xCDB264")]
		public static void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "")
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xCDB338", Offset = "0xCDB338", VA = "0xCDB338")]
		public static void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xCDB404", Offset = "0xCDB404", VA = "0xCDB404")]
		public static void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xCDB4C0", Offset = "0xCDB4C0", VA = "0xCDB4C0")]
		public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xCDB5BC", Offset = "0xCDB5BC", VA = "0xCDB5BC")]
		public static void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xCDB688", Offset = "0xCDB688", VA = "0xCDB688")]
		public static void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xCDB754", Offset = "0xCDB754", VA = "0xCDB754")]
		public static void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xCDB820", Offset = "0xCDB820", VA = "0xCDB820")]
		public static void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xCDB8EC", Offset = "0xCDB8EC", VA = "0xCDB8EC")]
		public static void GetPayload(FacebookDelegate<IPayloadResult> callback)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xCDB9A8", Offset = "0xCDB9A8", VA = "0xCDB9A8")]
		public FBGamingServices()
		{
		}
	}
}
