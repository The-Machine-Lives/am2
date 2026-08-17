using Google.Developers;
using Il2CppDummyDll;
using UnityEngine;

namespace Com.Google.Android.Gms.Common.Api
{
	[Token(Token = "0x2000244")]
	public abstract class ResultCallbackProxy<R> : JavaInterfaceProxy, ResultCallback<R> where R : Result
	{
		[Token(Token = "0x4000CA9")]
		private const string CLASS_NAME = "com/google/android/gms/common/api/ResultCallback";

		[Token(Token = "0x600105D")]
		public ResultCallbackProxy()
		{
		}

		[Token(Token = "0x600105E")]
		public abstract void OnResult(R arg_Result_1);

		[Token(Token = "0x600105F")]
		public void onResult(R arg_Result_1)
		{
		}

		[Token(Token = "0x6001060")]
		public void onResult(AndroidJavaObject arg_Result_1)
		{
		}
	}
}
