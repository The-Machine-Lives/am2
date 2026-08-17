using System;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Common.Api
{
	[Token(Token = "0x2000241")]
	public class PendingResult<R> : JavaObjWrapper where R : Result
	{
		[Token(Token = "0x4000CA8")]
		private const string CLASS_NAME = "com/google/android/gms/common/api/PendingResult";

		[Token(Token = "0x6001053")]
		public PendingResult(IntPtr ptr)
		{
		}

		[Token(Token = "0x6001054")]
		public PendingResult()
		{
		}

		[Token(Token = "0x6001055")]
		public R await(long arg_long_1, object arg_object_2)
		{
			return (R)null;
		}

		[Token(Token = "0x6001056")]
		public R await()
		{
			return (R)null;
		}

		[Token(Token = "0x6001057")]
		public bool isCanceled()
		{
			return default(bool);
		}

		[Token(Token = "0x6001058")]
		public void cancel()
		{
		}

		[Token(Token = "0x6001059")]
		public void setResultCallback(ResultCallback<R> arg_ResultCallback_1)
		{
		}

		[Token(Token = "0x600105A")]
		public void setResultCallback(ResultCallback<R> arg_ResultCallback_1, long arg_long_2, object arg_object_3)
		{
		}
	}
}
