using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200027C")]
	internal class NativeRealTimeRoom : BaseReferenceHolder
	{
		[Token(Token = "0x60012EF")]
		[Address(RVA = "0xE5B63C", Offset = "0xE5B63C", VA = "0xE5B63C")]
		internal NativeRealTimeRoom(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x60012F0")]
		[Address(RVA = "0xE5B6B4", Offset = "0xE5B6B4", VA = "0xE5B6B4")]
		internal string Id()
		{
			return null;
		}

		[Token(Token = "0x60012F1")]
		[Address(RVA = "0xE5B744", Offset = "0xE5B744", VA = "0xE5B744")]
		internal IEnumerable<MultiplayerParticipant> Participants()
		{
			return null;
		}

		[Token(Token = "0x60012F2")]
		[Address(RVA = "0xE5B810", Offset = "0xE5B810", VA = "0xE5B810")]
		internal uint ParticipantCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60012F3")]
		[Address(RVA = "0xE5B848", Offset = "0xE5B848", VA = "0xE5B848")]
		internal Types.RealTimeRoomStatus Status()
		{
			return default(Types.RealTimeRoomStatus);
		}

		[Token(Token = "0x60012F4")]
		[Address(RVA = "0xE5B864", Offset = "0xE5B864", VA = "0xE5B864", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60012F5")]
		[Address(RVA = "0xE5B874", Offset = "0xE5B874", VA = "0xE5B874")]
		internal static NativeRealTimeRoom FromPointer(IntPtr selfPointer)
		{
			return null;
		}

		[Token(Token = "0x60012F6")]
		[Address(RVA = "0xE5B910", Offset = "0xE5B910", VA = "0xE5B910")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836534", Offset = "0x836534")]
		private UIntPtr _003CId_003Eb__1_0(byte[] out_string, UIntPtr size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x60012F7")]
		[Address(RVA = "0xE5B944", Offset = "0xE5B944", VA = "0xE5B944")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836544", Offset = "0x836544")]
		private MultiplayerParticipant _003CParticipants_003Eb__2_0(UIntPtr index)
		{
			return null;
		}
	}
}
