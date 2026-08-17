using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000281")]
	internal class NativeScoreSummary : BaseReferenceHolder
	{
		[Token(Token = "0x600131B")]
		[Address(RVA = "0xE5C74C", Offset = "0xE5C74C", VA = "0xE5C74C")]
		internal NativeScoreSummary(IntPtr selfPtr)
		{
		}

		[Token(Token = "0x600131C")]
		[Address(RVA = "0xE5C7C4", Offset = "0xE5C7C4", VA = "0xE5C7C4", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600131D")]
		[Address(RVA = "0xE5C7D4", Offset = "0xE5C7D4", VA = "0xE5C7D4")]
		internal ulong ApproximateResults()
		{
			return default(ulong);
		}

		[Token(Token = "0x600131E")]
		[Address(RVA = "0xE5C7F0", Offset = "0xE5C7F0", VA = "0xE5C7F0")]
		internal NativeScore LocalUserScore()
		{
			return null;
		}

		[Token(Token = "0x600131F")]
		[Address(RVA = "0xE5C810", Offset = "0xE5C810", VA = "0xE5C810")]
		internal static NativeScoreSummary FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
