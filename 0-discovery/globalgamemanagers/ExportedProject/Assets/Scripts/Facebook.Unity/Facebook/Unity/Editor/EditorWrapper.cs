using Il2CppDummyDll;

namespace Facebook.Unity.Editor
{
	[Token(Token = "0x2000076")]
	internal class EditorWrapper : IEditorWrapper
	{
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x10")]
		private IFacebookCallbackHandler callbackHandler;

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xCD4888", Offset = "0xCD4888", VA = "0xCD4888")]
		public EditorWrapper(IFacebookCallbackHandler callbackHandler)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xCD7994", Offset = "0xCD7994", VA = "0xCD7994", Slot = "4")]
		public void Init()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xCD7A60", Offset = "0xCD7A60", VA = "0xCD7A60", Slot = "5")]
		public void ShowLoginMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId, string permsisions)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xCD7AE8", Offset = "0xCD7AE8", VA = "0xCD7AE8", Slot = "6")]
		public void ShowAppRequestMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xCD7BE4", Offset = "0xCD7BE4", VA = "0xCD7BE4", Slot = "7")]
		public void ShowMockShareDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xCD7C84", Offset = "0xCD7C84", VA = "0xCD7C84", Slot = "8")]
		public void ShowMockFriendFinderDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xCD7B48", Offset = "0xCD7B48", VA = "0xCD7B48")]
		private void ShowEmptyMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId, string title)
		{
		}
	}
}
