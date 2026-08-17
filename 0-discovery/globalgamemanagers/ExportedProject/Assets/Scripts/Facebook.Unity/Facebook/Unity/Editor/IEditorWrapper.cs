using Il2CppDummyDll;

namespace Facebook.Unity.Editor
{
	[Token(Token = "0x2000077")]
	internal interface IEditorWrapper
	{
		[Token(Token = "0x6000282")]
		void Init();

		[Token(Token = "0x6000283")]
		void ShowLoginMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId, string permissions);

		[Token(Token = "0x6000284")]
		void ShowAppRequestMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId);

		[Token(Token = "0x6000285")]
		void ShowMockShareDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId);

		[Token(Token = "0x6000286")]
		void ShowMockFriendFinderDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId);
	}
}
