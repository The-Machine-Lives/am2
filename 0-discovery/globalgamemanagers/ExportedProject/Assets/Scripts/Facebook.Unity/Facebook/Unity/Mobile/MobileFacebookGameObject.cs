using Il2CppDummyDll;

namespace Facebook.Unity.Mobile
{
	[Token(Token = "0x2000082")]
	internal abstract class MobileFacebookGameObject : FacebookGameObject, IMobileFacebookCallbackHandler, IFacebookCallbackHandler
	{
		[Token(Token = "0x1700008F")]
		private IMobileFacebookImplementation MobileFacebook
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x17BE884", Offset = "0x17BE884", VA = "0x17BE884")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x17BE94C", Offset = "0x17BE94C", VA = "0x17BE94C", Slot = "11")]
		public void OnFetchDeferredAppLinkComplete(string message)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x17BEB5C", Offset = "0x17BEB5C", VA = "0x17BEB5C", Slot = "12")]
		public void OnRefreshCurrentAccessTokenComplete(string message)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x17BEC4C", Offset = "0x17BEC4C", VA = "0x17BEC4C", Slot = "13")]
		public void OnFriendFinderComplete(string message)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x17BED3C", Offset = "0x17BED3C", VA = "0x17BED3C", Slot = "14")]
		public void OnUploadImageToMediaLibraryComplete(string message)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x17BEE2C", Offset = "0x17BEE2C", VA = "0x17BEE2C", Slot = "15")]
		public void OnUploadVideoToMediaLibraryComplete(string message)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x17BEF1C", Offset = "0x17BEF1C", VA = "0x17BEF1C", Slot = "16")]
		public void OnOnIAPReadyComplete(string message)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x17BF00C", Offset = "0x17BF00C", VA = "0x17BF00C", Slot = "17")]
		public void OnGetCatalogComplete(string message)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x17BF0FC", Offset = "0x17BF0FC", VA = "0x17BF0FC", Slot = "18")]
		public void OnGetPurchasesComplete(string message)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x17BF1EC", Offset = "0x17BF1EC", VA = "0x17BF1EC", Slot = "19")]
		public void OnPurchaseComplete(string message)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x17BF2DC", Offset = "0x17BF2DC", VA = "0x17BF2DC", Slot = "20")]
		public void OnConsumePurchaseComplete(string message)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x17BF3CC", Offset = "0x17BF3CC", VA = "0x17BF3CC", Slot = "21")]
		public void OnInitCloudGameComplete(string message)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x17BF4BC", Offset = "0x17BF4BC", VA = "0x17BF4BC", Slot = "22")]
		public void OnScheduleAppToUserNotificationComplete(string message)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x17BF5AC", Offset = "0x17BF5AC", VA = "0x17BF5AC", Slot = "23")]
		public void OnLoadInterstitialAdComplete(string message)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x17BF69C", Offset = "0x17BF69C", VA = "0x17BF69C", Slot = "24")]
		public void OnShowInterstitialAdComplete(string message)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x17BF78C", Offset = "0x17BF78C", VA = "0x17BF78C", Slot = "25")]
		public void OnLoadRewardedVideoComplete(string message)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x17BF87C", Offset = "0x17BF87C", VA = "0x17BF87C", Slot = "26")]
		public void OnShowRewardedVideoComplete(string message)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x17BF96C", Offset = "0x17BF96C", VA = "0x17BF96C", Slot = "27")]
		public void OnGetPayloadComplete(string message)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x17BD188", Offset = "0x17BD188", VA = "0x17BD188")]
		protected MobileFacebookGameObject()
		{
		}
	}
}
