using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000280")]
	internal class NativeScorePageToken : BaseReferenceHolder
	{
		[Token(Token = "0x6001319")]
		[Address(RVA = "0xE5C490", Offset = "0xE5C490", VA = "0xE5C490")]
		internal NativeScorePageToken(IntPtr selfPtr)
		{
		}

		[Token(Token = "0x600131A")]
		[Address(RVA = "0xE5C73C", Offset = "0xE5C73C", VA = "0xE5C73C", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}
	}
}
