using Il2CppDummyDll;

namespace Facebook.Unity.Gameroom
{
	[Token(Token = "0x200006F")]
	internal interface IGameroomFacebookImplementation : IGameroomFacebook, IPayFacebook, IFacebook, IGameroomFacebookResultHandler, IFacebookResultHandler
	{
		[Token(Token = "0x6000224")]
		bool HaveReceivedPipeResponse();

		[Token(Token = "0x6000225")]
		string GetPipeResponse(string callbackId);
	}
}
