using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x200003A")]
	public interface ILoginResult : IResult
	{
		[Token(Token = "0x1700004D")]
		AccessToken AccessToken
		{
			[Token(Token = "0x6000130")]
			get;
		}
	}
}
