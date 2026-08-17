using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Facebook.Unity.Mobile.IOS
{
	[Token(Token = "0x2000083")]
	internal interface IIOSWrapper
	{
		[Token(Token = "0x60002F7")]
		void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix);

		[Token(Token = "0x60002F8")]
		void LogInWithReadPermissions(int requestId, string scope);

		[Token(Token = "0x60002F9")]
		void LogInWithPublishPermissions(int requestId, string scope);

		[Token(Token = "0x60002FA")]
		void LogOut();

		[Token(Token = "0x60002FB")]
		void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL);

		[Token(Token = "0x60002FC")]
		void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource);

		[Token(Token = "0x60002FD")]
		void AppRequest(int requestId, string message, string actionType, string objectId, [Optional] string[] to, int toLength = 0, string filters = "", [Optional] string[] excludeIds, int excludeIdsLength = 0, bool hasMaxRecipients = false, int maxRecipients = 0, string data = "", string title = "");

		[Token(Token = "0x60002FE")]
		void FBAppEventsActivateApp();

		[Token(Token = "0x60002FF")]
		void LogAppEvent(string logEvent, double valueToSum, int numParams, string[] paramKeys, string[] paramVals);

		[Token(Token = "0x6000300")]
		void LogPurchaseAppEvent(double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals);

		[Token(Token = "0x6000301")]
		void FBAppEventsSetLimitEventUsage(bool limitEventUsage);

		[Token(Token = "0x6000302")]
		void GetAppLink(int requestId);

		[Token(Token = "0x6000303")]
		string FBSdkVersion();

		[Token(Token = "0x6000304")]
		string FBGetUserID();

		[Token(Token = "0x6000305")]
		void OpenFriendFinderDialog(int requestId);

		[Token(Token = "0x6000306")]
		void UploadImageToMediaLibrary(int requestId, string caption, string mediaUri, bool shouldLaunchMediaDialog);

		[Token(Token = "0x6000307")]
		void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri);
	}
}
