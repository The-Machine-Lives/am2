using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000285")]
	internal class NativeTurnBasedMatch : BaseReferenceHolder
	{
		[Token(Token = "0x6001336")]
		[Address(RVA = "0xE5D840", Offset = "0xE5D840", VA = "0xE5D840")]
		internal NativeTurnBasedMatch(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001337")]
		[Address(RVA = "0xE5D8B8", Offset = "0xE5D8B8", VA = "0xE5D8B8")]
		internal uint AvailableAutomatchSlots()
		{
			return default(uint);
		}

		[Token(Token = "0x6001338")]
		[Address(RVA = "0xE5D8D4", Offset = "0xE5D8D4", VA = "0xE5D8D4")]
		internal ulong CreationTime()
		{
			return default(ulong);
		}

		[Token(Token = "0x6001339")]
		[Address(RVA = "0xE5D8F0", Offset = "0xE5D8F0", VA = "0xE5D8F0")]
		internal ulong LastUpdateTime()
		{
			return default(ulong);
		}

		[Token(Token = "0x600133A")]
		[Address(RVA = "0xE5D90C", Offset = "0xE5D90C", VA = "0xE5D90C")]
		internal IEnumerable<MultiplayerParticipant> Participants()
		{
			return null;
		}

		[Token(Token = "0x600133B")]
		[Address(RVA = "0xE5D9D8", Offset = "0xE5D9D8", VA = "0xE5D9D8")]
		internal uint Version()
		{
			return default(uint);
		}

		[Token(Token = "0x600133C")]
		[Address(RVA = "0xE5D9F4", Offset = "0xE5D9F4", VA = "0xE5D9F4")]
		internal uint Variant()
		{
			return default(uint);
		}

		[Token(Token = "0x600133D")]
		[Address(RVA = "0xE5DA10", Offset = "0xE5DA10", VA = "0xE5DA10")]
		internal ParticipantResults Results()
		{
			return null;
		}

		[Token(Token = "0x600133E")]
		[Address(RVA = "0xE5DB04", Offset = "0xE5DB04", VA = "0xE5DB04")]
		internal MultiplayerParticipant ParticipantWithId(string participantId)
		{
			return null;
		}

		[Token(Token = "0x600133F")]
		[Address(RVA = "0xE5DE48", Offset = "0xE5DE48", VA = "0xE5DE48")]
		internal MultiplayerParticipant PendingParticipant()
		{
			return null;
		}

		[Token(Token = "0x6001340")]
		[Address(RVA = "0xE5DF00", Offset = "0xE5DF00", VA = "0xE5DF00")]
		internal Types.MatchStatus MatchStatus()
		{
			return default(Types.MatchStatus);
		}

		[Token(Token = "0x6001341")]
		[Address(RVA = "0xE5DF1C", Offset = "0xE5DF1C", VA = "0xE5DF1C")]
		internal string Description()
		{
			return null;
		}

		[Token(Token = "0x6001342")]
		[Address(RVA = "0xE5DFAC", Offset = "0xE5DFAC", VA = "0xE5DFAC")]
		internal bool HasRematchId()
		{
			return default(bool);
		}

		[Token(Token = "0x6001343")]
		[Address(RVA = "0xE5E038", Offset = "0xE5E038", VA = "0xE5E038")]
		internal string RematchId()
		{
			return null;
		}

		[Token(Token = "0x6001344")]
		[Address(RVA = "0xE5E0C8", Offset = "0xE5E0C8", VA = "0xE5E0C8")]
		internal byte[] Data()
		{
			return null;
		}

		[Token(Token = "0x6001345")]
		[Address(RVA = "0xE5E2BC", Offset = "0xE5E2BC", VA = "0xE5E2BC")]
		internal string Id()
		{
			return null;
		}

		[Token(Token = "0x6001346")]
		[Address(RVA = "0xE5E34C", Offset = "0xE5E34C", VA = "0xE5E34C", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001347")]
		[Address(RVA = "0xE5E35C", Offset = "0xE5E35C", VA = "0xE5E35C")]
		internal GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch AsTurnBasedMatch(string selfPlayerId)
		{
			return null;
		}

		[Token(Token = "0x6001348")]
		[Address(RVA = "0xE5EBA0", Offset = "0xE5EBA0", VA = "0xE5EBA0")]
		private static GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus ToTurnStatus(Types.MatchStatus status)
		{
			return default(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus);
		}

		[Token(Token = "0x6001349")]
		[Address(RVA = "0xE5EBC4", Offset = "0xE5EBC4", VA = "0xE5EBC4")]
		private static GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus ToMatchStatus(string pendingParticipantId, Types.MatchStatus status)
		{
			return default(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus);
		}

		[Token(Token = "0x600134A")]
		[Address(RVA = "0xE5EC18", Offset = "0xE5EC18", VA = "0xE5EC18")]
		internal static NativeTurnBasedMatch FromPointer(IntPtr selfPointer)
		{
			return null;
		}

		[Token(Token = "0x600134B")]
		[Address(RVA = "0xE5ED20", Offset = "0xE5ED20", VA = "0xE5ED20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8365D4", Offset = "0x8365D4")]
		private MultiplayerParticipant _003CParticipants_003Eb__4_0(UIntPtr index)
		{
			return null;
		}

		[Token(Token = "0x600134C")]
		[Address(RVA = "0xE5EDB0", Offset = "0xE5EDB0", VA = "0xE5EDB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8365E4", Offset = "0x8365E4")]
		private UIntPtr _003CDescription_003Eb__11_0(byte[] out_string, UIntPtr size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x600134D")]
		[Address(RVA = "0xE5EDE4", Offset = "0xE5EDE4", VA = "0xE5EDE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8365F4", Offset = "0x8365F4")]
		private UIntPtr _003CRematchId_003Eb__13_0(byte[] out_string, UIntPtr size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x600134E")]
		[Address(RVA = "0xE5EE18", Offset = "0xE5EE18", VA = "0xE5EE18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836604", Offset = "0x836604")]
		private UIntPtr _003CData_003Eb__14_0(byte[] bytes, UIntPtr size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x600134F")]
		[Address(RVA = "0xE5EE4C", Offset = "0xE5EE4C", VA = "0xE5EE4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836614", Offset = "0x836614")]
		private UIntPtr _003CId_003Eb__15_0(byte[] out_string, UIntPtr size)
		{
			return default(UIntPtr);
		}
	}
}
