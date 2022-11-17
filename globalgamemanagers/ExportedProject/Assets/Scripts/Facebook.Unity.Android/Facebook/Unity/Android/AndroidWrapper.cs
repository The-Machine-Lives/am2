using Facebook.Unity.Mobile.Android;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity.Android
{
	[Token(Token = "0x2000002")]
	internal class AndroidWrapper : Facebook.Unity.Mobile.Android.IAndroidWrapper
	{
		[Token(Token = "0x4000001")]
		private const string FacebookJavaClassName = "com.facebook.unity.FB";

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaClass facebookJavaClass;

		[Token(Token = "0x6000001")]
		public T CallStatic<T>(string methodName)
		{
			return (T)null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x181D8E4", Offset = "0x181D8E4", VA = "0x181D8E4", Slot = "5")]
		public void CallStatic(string methodName, params object[] args)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x181D92C", Offset = "0x181D92C", VA = "0x181D92C")]
		public AndroidWrapper()
		{
		}
	}
}
