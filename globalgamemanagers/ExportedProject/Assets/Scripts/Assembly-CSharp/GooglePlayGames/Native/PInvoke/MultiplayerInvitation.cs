using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200026F")]
	internal class MultiplayerInvitation : BaseReferenceHolder
	{
		[Token(Token = "0x6001265")]
		[Address(RVA = "0xC77BF0", Offset = "0xC77BF0", VA = "0xC77BF0")]
		internal MultiplayerInvitation(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001266")]
		[Address(RVA = "0xC77C64", Offset = "0xC77C64", VA = "0xC77C64")]
		internal MultiplayerParticipant Inviter()
		{
			return null;
		}

		[Token(Token = "0x6001267")]
		[Address(RVA = "0xC77DA0", Offset = "0xC77DA0", VA = "0xC77DA0")]
		internal uint Variant()
		{
			return default(uint);
		}

		[Token(Token = "0x6001268")]
		[Address(RVA = "0xC77DB8", Offset = "0xC77DB8", VA = "0xC77DB8")]
		internal ulong CreationTime()
		{
			return default(ulong);
		}

		[Token(Token = "0x6001269")]
		[Address(RVA = "0xC77DD0", Offset = "0xC77DD0", VA = "0xC77DD0")]
		internal Types.MultiplayerInvitationType Type()
		{
			return default(Types.MultiplayerInvitationType);
		}

		[Token(Token = "0x600126A")]
		[Address(RVA = "0xC6063C", Offset = "0xC6063C", VA = "0xC6063C")]
		internal string Id()
		{
			return null;
		}

		[Token(Token = "0x600126B")]
		[Address(RVA = "0xC77DE8", Offset = "0xC77DE8", VA = "0xC77DE8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600126C")]
		[Address(RVA = "0xC606D0", Offset = "0xC606D0", VA = "0xC606D0")]
		internal uint AutomatchingSlots()
		{
			return default(uint);
		}

		[Token(Token = "0x600126D")]
		[Address(RVA = "0xC606E8", Offset = "0xC606E8", VA = "0xC606E8")]
		internal uint ParticipantCount()
		{
			return default(uint);
		}

		[Token(Token = "0x600126E")]
		[Address(RVA = "0xC77DF8", Offset = "0xC77DF8", VA = "0xC77DF8")]
		private static Invitation.InvType ToInvType(Types.MultiplayerInvitationType invitationType)
		{
			return default(Invitation.InvType);
		}

		[Token(Token = "0x600126F")]
		[Address(RVA = "0xC5F8DC", Offset = "0xC5F8DC", VA = "0xC5F8DC")]
		internal Invitation AsInvitation()
		{
			return null;
		}

		[Token(Token = "0x6001270")]
		[Address(RVA = "0xC75A18", Offset = "0xC75A18", VA = "0xC75A18")]
		internal static MultiplayerInvitation FromPointer(IntPtr selfPointer)
		{
			return null;
		}

		[Token(Token = "0x6001271")]
		[Address(RVA = "0xC77ECC", Offset = "0xC77ECC", VA = "0xC77ECC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836214", Offset = "0x836214")]
		private UIntPtr _003CId_003Eb__5_0(byte[] out_string, UIntPtr size)
		{
			return default(UIntPtr);
		}
	}
}
