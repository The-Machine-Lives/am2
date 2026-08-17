using Il2CppDummyDll;

namespace Facebook.Unity.Canvas
{
	[Token(Token = "0x2000096")]
	internal interface ICanvasFacebookResultHandler : IFacebookResultHandler
	{
		[Token(Token = "0x600038E")]
		void OnPayComplete(ResultContainer resultContainer);

		[Token(Token = "0x600038F")]
		void OnFacebookAuthResponseChange(ResultContainer resultContainer);

		[Token(Token = "0x6000390")]
		void OnUrlResponse(string message);

		[Token(Token = "0x6000391")]
		void OnHideUnity(bool hide);
	}
}
