using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000007")]
	internal class CallbackManager
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<string, object> facebookDelegates;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x18")]
		private int nextAsyncId;

		[Token(Token = "0x600002A")]
		public string AddFacebookDelegate<T>(FacebookDelegate<T> callback) where T : IResult
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xCC998C", Offset = "0xCC998C", VA = "0xCC998C")]
		public void OnFacebookResponse(IInternalResult result)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xCC9C30", Offset = "0xCC9C30", VA = "0xCC9C30")]
		private static void CallCallback(object callback, IResult result)
		{
		}

		[Token(Token = "0x600002D")]
		private static bool TryCallCallback<T>(object callback, IResult result) where T : IResult
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xCC9F84", Offset = "0xCC9F84", VA = "0xCC9F84")]
		public CallbackManager()
		{
		}
	}
}
