using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity.Canvas
{
	[Token(Token = "0x2000097")]
	internal interface ICanvasJSWrapper
	{
		[Token(Token = "0x6000392")]
		string GetSDKVersion();

		[Token(Token = "0x6000393")]
		void DisableFullScreen();

		[Token(Token = "0x6000394")]
		void Init(string connectFacebookUrl, string locale, int debug, string initParams, int status);

		[Token(Token = "0x6000395")]
		void Login(IEnumerable<string> scope, string callback_id);

		[Token(Token = "0x6000396")]
		void Logout();

		[Token(Token = "0x6000397")]
		void ActivateApp();

		[Token(Token = "0x6000398")]
		void LogAppEvent(string eventName, float? valueToSum, string parameters);

		[Token(Token = "0x6000399")]
		void LogPurchase(float purchaseAmount, string currency, string parameters);

		[Token(Token = "0x600039A")]
		void Ui(string x, string uid, string callbackMethodName);

		[Token(Token = "0x600039B")]
		void InitScreenPosition();
	}
}
