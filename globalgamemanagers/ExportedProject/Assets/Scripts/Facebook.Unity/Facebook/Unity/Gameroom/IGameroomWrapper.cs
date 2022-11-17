using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity.Gameroom
{
	[Token(Token = "0x2000071")]
	internal interface IGameroomWrapper
	{
		[Token(Token = "0x17000081")]
		IDictionary<string, object> PipeResponse
		{
			[Token(Token = "0x6000226")]
			get;
			[Token(Token = "0x6000227")]
			set;
		}

		[Token(Token = "0x6000228")]
		void Init(GameroomFacebook.OnComplete completeDelegate);

		[Token(Token = "0x6000229")]
		void DoLoginRequest(string appID, string permissions, string callbackID, GameroomFacebook.OnComplete completeDelegate);

		[Token(Token = "0x600022A")]
		void DoFeedShareRequest(string appId, string toId, string link, string linkName, string linkCaption, string linkDescription, string pictureLink, string mediaSource, string callbackID, GameroomFacebook.OnComplete completeDelegate);

		[Token(Token = "0x600022B")]
		void DoAppRequestRequest(string appId, string message, string actionType, string objectId, string to, string filters, string excludeIDs, string maxRecipients, string data, string title, string callbackID, GameroomFacebook.OnComplete completeDelegate);
	}
}
