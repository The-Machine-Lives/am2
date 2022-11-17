using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000272")]
	internal class NativeAppIdentifier : BaseReferenceHolder
	{
		[PreserveSig]
		[Token(Token = "0x6001293")]
		[Address(RVA = "0xC78A9C", Offset = "0xC78A9C", VA = "0xC78A9C")]
		internal static extern IntPtr NearbyUtils_ConstructAppIdentifier(string appId);

		[Token(Token = "0x6001294")]
		[Address(RVA = "0xC78B50", Offset = "0xC78B50", VA = "0xC78B50")]
		internal NativeAppIdentifier(IntPtr pointer)
		{
		}

		[Token(Token = "0x6001295")]
		[Address(RVA = "0xC78BC4", Offset = "0xC78BC4", VA = "0xC78BC4")]
		internal string Id()
		{
			return null;
		}

		[Token(Token = "0x6001296")]
		[Address(RVA = "0xC78C58", Offset = "0xC78C58", VA = "0xC78C58", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001297")]
		[Address(RVA = "0xC78C68", Offset = "0xC78C68", VA = "0xC78C68")]
		internal static NativeAppIdentifier FromString(string appId)
		{
			return null;
		}

		[Token(Token = "0x6001298")]
		[Address(RVA = "0xC78CD8", Offset = "0xC78CD8", VA = "0xC78CD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836294", Offset = "0x836294")]
		private UIntPtr _003CId_003Eb__2_0(byte[] out_arg, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
