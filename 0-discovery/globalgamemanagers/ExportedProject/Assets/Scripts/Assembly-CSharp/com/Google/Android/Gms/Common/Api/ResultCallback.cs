using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Common.Api
{
	[Token(Token = "0x2000243")]
	public interface ResultCallback<R> where R : Result
	{
		[Token(Token = "0x600105C")]
		void onResult(R arg_Result_1);
	}
}
