using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x2000019")]
	internal interface IFacebook
	{
		[Token(Token = "0x1700002B")]
		bool LoggedIn
		{
			[Token(Token = "0x60000BF")]
			get;
		}

		[Token(Token = "0x1700002C")]
		bool LimitEventUsage
		{
			[Token(Token = "0x60000C0")]
			get;
			[Token(Token = "0x60000C1")]
			set;
		}

		[Token(Token = "0x1700002D")]
		string SDKUserAgent
		{
			[Token(Token = "0x60000C2")]
			get;
		}

		[Token(Token = "0x1700002E")]
		bool Initialized
		{
			[Token(Token = "0x60000C3")]
			get;
		}

		[Token(Token = "0x60000C4")]
		void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback);

		[Token(Token = "0x60000C5")]
		void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback);

		[Token(Token = "0x60000C6")]
		void LogOut();

		[Token(Token = "0x60000C7")]
		void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback);

		[Token(Token = "0x60000C8")]
		void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback);

		[Token(Token = "0x60000C9")]
		void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback);

		[Token(Token = "0x60000CA")]
		void API(string query, HttpMethod method, IDictionary<string, string> formData, FacebookDelegate<IGraphResult> callback);

		[Token(Token = "0x60000CB")]
		void API(string query, HttpMethod method, WWWForm formData, FacebookDelegate<IGraphResult> callback);

		[Token(Token = "0x60000CC")]
		void ActivateApp([Optional] string appId);

		[Token(Token = "0x60000CD")]
		void GetAppLink(FacebookDelegate<IAppLinkResult> callback);

		[Token(Token = "0x60000CE")]
		void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters);

		[Token(Token = "0x60000CF")]
		void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters);
	}
}
