using Il2CppDummyDll;
using Uniject;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000021")]
	internal interface IRawStoreProvider
	{
		[Token(Token = "0x6000048")]
		INativeStore GetAndroidStore(IUnityCallback callback, AndroidStore store, IPurchasingBinder binder, IUtil util);

		[Token(Token = "0x6000049")]
		INativeAppleStore GetStorekit(IUnityCallback callback);
	}
}
