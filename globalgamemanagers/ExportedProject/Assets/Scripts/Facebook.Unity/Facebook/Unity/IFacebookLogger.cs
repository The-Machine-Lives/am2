using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000054")]
	internal interface IFacebookLogger
	{
		[Token(Token = "0x600018B")]
		void Log(string msg);

		[Token(Token = "0x600018C")]
		void Info(string msg);

		[Token(Token = "0x600018D")]
		void Warn(string msg);
	}
}
