using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000270")]
	internal class MultiplayerParticipant : BaseReferenceHolder
	{
		[Token(Token = "0x4000D1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Types.ParticipantStatus, Participant.ParticipantStatus> StatusConversion;

		[Token(Token = "0x6001272")]
		[Address(RVA = "0xC77D14", Offset = "0xC77D14", VA = "0xC77D14")]
		internal MultiplayerParticipant(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001273")]
		[Address(RVA = "0xC63C4C", Offset = "0xC63C4C", VA = "0xC63C4C")]
		internal Types.ParticipantStatus Status()
		{
			return default(Types.ParticipantStatus);
		}

		[Token(Token = "0x6001274")]
		[Address(RVA = "0xC626E8", Offset = "0xC626E8", VA = "0xC626E8")]
		internal bool IsConnectedToRoom()
		{
			return default(bool);
		}

		[Token(Token = "0x6001275")]
		[Address(RVA = "0xC77EFC", Offset = "0xC77EFC", VA = "0xC77EFC")]
		internal string DisplayName()
		{
			return null;
		}

		[Token(Token = "0x6001276")]
		[Address(RVA = "0xC77F90", Offset = "0xC77F90", VA = "0xC77F90")]
		internal NativePlayer Player()
		{
			return null;
		}

		[Token(Token = "0x6001277")]
		[Address(RVA = "0xC62B8C", Offset = "0xC62B8C", VA = "0xC62B8C")]
		internal string Id()
		{
			return null;
		}

		[Token(Token = "0x6001278")]
		[Address(RVA = "0xC77D88", Offset = "0xC77D88", VA = "0xC77D88")]
		internal bool Valid()
		{
			return default(bool);
		}

		[Token(Token = "0x6001279")]
		[Address(RVA = "0xC78024", Offset = "0xC78024", VA = "0xC78024", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600127A")]
		[Address(RVA = "0xC62C4C", Offset = "0xC62C4C", VA = "0xC62C4C")]
		internal Participant AsParticipant()
		{
			return null;
		}

		[Token(Token = "0x600127B")]
		[Address(RVA = "0xC78034", Offset = "0xC78034", VA = "0xC78034")]
		internal static MultiplayerParticipant FromPointer(IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x600127C")]
		[Address(RVA = "0xC6DD4C", Offset = "0xC6DD4C", VA = "0xC6DD4C")]
		internal static MultiplayerParticipant AutomatchingSentinel()
		{
			return null;
		}

		[Token(Token = "0x600127E")]
		[Address(RVA = "0xC78298", Offset = "0xC78298", VA = "0xC78298")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836224", Offset = "0x836224")]
		private UIntPtr _003CDisplayName_003Eb__4_0(byte[] out_string, UIntPtr size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x600127F")]
		[Address(RVA = "0xC782C8", Offset = "0xC782C8", VA = "0xC782C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836234", Offset = "0x836234")]
		private UIntPtr _003CId_003Eb__6_0(byte[] out_string, UIntPtr size)
		{
			return default(UIntPtr);
		}
	}
}
