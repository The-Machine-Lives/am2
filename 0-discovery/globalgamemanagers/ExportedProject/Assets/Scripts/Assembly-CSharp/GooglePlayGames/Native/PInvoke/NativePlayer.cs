using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Multiplayer;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200027A")]
	internal class NativePlayer : BaseReferenceHolder
	{
		[Token(Token = "0x60012D4")]
		[Address(RVA = "0xE5AE48", Offset = "0xE5AE48", VA = "0xE5AE48")]
		internal NativePlayer(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x60012D5")]
		[Address(RVA = "0xE5AEC0", Offset = "0xE5AEC0", VA = "0xE5AEC0")]
		internal string Id()
		{
			return null;
		}

		[Token(Token = "0x60012D6")]
		[Address(RVA = "0xE5AF50", Offset = "0xE5AF50", VA = "0xE5AF50")]
		internal string Name()
		{
			return null;
		}

		[Token(Token = "0x60012D7")]
		[Address(RVA = "0xE5AFE0", Offset = "0xE5AFE0", VA = "0xE5AFE0")]
		internal string AvatarURL()
		{
			return null;
		}

		[Token(Token = "0x60012D8")]
		[Address(RVA = "0xE5B070", Offset = "0xE5B070", VA = "0xE5B070", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60012D9")]
		[Address(RVA = "0xE5B080", Offset = "0xE5B080", VA = "0xE5B080")]
		internal Player AsPlayer()
		{
			return null;
		}

		[Token(Token = "0x60012DA")]
		[Address(RVA = "0xE5B11C", Offset = "0xE5B11C", VA = "0xE5B11C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836504", Offset = "0x836504")]
		private UIntPtr _003CId_003Eb__1_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x60012DB")]
		[Address(RVA = "0xE5B150", Offset = "0xE5B150", VA = "0xE5B150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836514", Offset = "0x836514")]
		private UIntPtr _003CName_003Eb__2_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x60012DC")]
		[Address(RVA = "0xE5B184", Offset = "0xE5B184", VA = "0xE5B184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836524", Offset = "0x836524")]
		private UIntPtr _003CAvatarURL_003Eb__3_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
