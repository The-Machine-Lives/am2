using Il2CppDummyDll;

namespace Facebook.Unity.Canvas
{
	[Token(Token = "0x2000094")]
	internal interface ICanvasFacebookCallbackHandler : IFacebookCallbackHandler
	{
		[Token(Token = "0x600038A")]
		void OnPayComplete(string message);

		[Token(Token = "0x600038B")]
		void OnFacebookAuthResponseChange(string message);

		[Token(Token = "0x600038C")]
		void OnUrlResponse(string message);

		[Token(Token = "0x600038D")]
		void OnHideUnity(bool hide);
	}
}
