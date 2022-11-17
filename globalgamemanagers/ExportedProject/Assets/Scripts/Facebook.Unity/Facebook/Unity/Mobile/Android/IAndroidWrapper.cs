using Il2CppDummyDll;

namespace Facebook.Unity.Mobile.Android
{
	[Token(Token = "0x200008C")]
	internal interface IAndroidWrapper
	{
		[Token(Token = "0x600035A")]
		T CallStatic<T>(string methodName);

		[Token(Token = "0x600035B")]
		void CallStatic(string methodName, params object[] args);
	}
}
