using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x200025E")]
	public class NativeTurnBasedMultiplayerClient : ITurnBasedMultiplayerClient
	{
		[Token(Token = "0x20006DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820BB8", Offset = "0x820BB8")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x400209D")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			[Token(Token = "0x6002F45")]
			[Address(RVA = "0xC6A58C", Offset = "0xC6A58C", VA = "0xC6A58C")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6002F46")]
			[Address(RVA = "0xC6E9E0", Offset = "0xC6E9E0", VA = "0xC6E9E0")]
			internal void _003CCreateQuickMatch_003Eb__0(UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)
			{
			}
		}

		[Token(Token = "0x20006DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820BC8", Offset = "0x820BC8")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x400209E")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			[Token(Token = "0x6002F47")]
			[Address(RVA = "0xC6A730", Offset = "0xC6A730", VA = "0xC6A730")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6002F48")]
			[Address(RVA = "0xC6EA5C", Offset = "0xC6EA5C", VA = "0xC6EA5C")]
			internal void _003CCreateWithInvitationScreen_003Eb__0(UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)
			{
			}
		}

		[Token(Token = "0x20006DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820BD8", Offset = "0x820BD8")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x400209F")]
			[FieldOffset(Offset = "0x10")]
			public Action<UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			[Token(Token = "0x40020A0")]
			[FieldOffset(Offset = "0x18")]
			public uint variant;

			[Token(Token = "0x40020A1")]
			[FieldOffset(Offset = "0x20")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x6002F49")]
			[Address(RVA = "0xC6A8B4", Offset = "0xC6A8B4", VA = "0xC6A8B4")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6002F4A")]
			[Address(RVA = "0xC6EAD8", Offset = "0xC6EAD8", VA = "0xC6EAD8")]
			internal void _003CCreateWithInvitationScreen_003Eb__0(PlayerSelectUIResponse result)
			{
			}
		}

		[Token(Token = "0x20006DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820BE8", Offset = "0x820BE8")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x40020A2")]
			[FieldOffset(Offset = "0x10")]
			public Action<Invitation[]> callback;

			[Token(Token = "0x6002F4B")]
			[Address(RVA = "0xC6A984", Offset = "0xC6A984", VA = "0xC6A984")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6002F4C")]
			[Address(RVA = "0xC6EE34", Offset = "0xC6EE34", VA = "0xC6EE34")]
			internal void _003CGetAllInvitations_003Eb__0(TurnBasedManager.TurnBasedMatchesResponse allMatches)
			{
			}
		}

		[Token(Token = "0x20006E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820BF8", Offset = "0x820BF8")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x40020A3")]
			[FieldOffset(Offset = "0x10")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x40020A4")]
			[FieldOffset(Offset = "0x18")]
			public Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback;

			[Token(Token = "0x6002F4D")]
			[Address(RVA = "0xC6AA6C", Offset = "0xC6AA6C", VA = "0xC6AA6C")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6002F4E")]
			[Address(RVA = "0xC6F1AC", Offset = "0xC6F1AC", VA = "0xC6F1AC")]
			internal void _003CGetAllMatches_003Eb__0(TurnBasedManager.TurnBasedMatchesResponse allMatches)
			{
			}
		}

		[Token(Token = "0x20006E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820C08", Offset = "0x820C08")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x40020A5")]
			[FieldOffset(Offset = "0x10")]
			public string matchId;

			[Token(Token = "0x40020A6")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			[Token(Token = "0x40020A7")]
			[FieldOffset(Offset = "0x20")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x6002F4F")]
			[Address(RVA = "0xC6AB8C", Offset = "0xC6AB8C", VA = "0xC6AB8C")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6002F50")]
			[Address(RVA = "0xC6C42C", Offset = "0xC6C42C", VA = "0xC6C42C")]
			internal void _003CGetMatch_003Eb__0(TurnBasedManager.TurnBasedMatchResponse response)
			{
			}
		}

		[Token(Token = "0x20006E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820C18", Offset = "0x820C18")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x40020A8")]
			[FieldOffset(Offset = "0x10")]
			public Action<UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> userCallback;

			[Token(Token = "0x40020A9")]
			[FieldOffset(Offset = "0x18")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x6002F51")]
			[Address(RVA = "0xC6AB94", Offset = "0xC6AB94", VA = "0xC6AB94")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6002F52")]
			[Address(RVA = "0xC6C678", Offset = "0xC6C678", VA = "0xC6C678")]
			internal void _003CBridgeMatchToUserCallback_003Eb__0(TurnBasedManager.TurnBasedMatchResponse callbackResult)
			{
			}
		}

		[Token(Token = "0x20006E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820C28", Offset = "0x820C28")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x40020AA")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			[Token(Token = "0x40020AB")]
			[FieldOffset(Offset = "0x18")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x6002F53")]
			[Address(RVA = "0xC6ACDC", Offset = "0xC6ACDC", VA = "0xC6ACDC")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6002F54")]
			[Address(RVA = "0xC6C90C", Offset = "0xC6C90C", VA = "0xC6C90C")]
			internal void _003CAcceptFromInbox_003Eb__0(TurnBasedManager.MatchInboxUIResponse callbackResult)
			{
			}
		}

		[Token(Token = "0x20006E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820C38", Offset = "0x820C38")]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			[Token(Token = "0x40020AC")]
			[FieldOffset(Offset = "0x10")]
			public string invitationId;

			[Token(Token = "0x40020AD")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			[Token(Token = "0x40020AE")]
			[FieldOffset(Offset = "0x20")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x40020AF")]
			[FieldOffset(Offset = "0x28")]
			public Action<UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> _003C_003E9__1;

			[Token(Token = "0x6002F55")]
			[Address(RVA = "0xC6AE4C", Offset = "0xC6AE4C", VA = "0xC6AE4C")]
			public _003C_003Ec__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6002F56")]
			[Address(RVA = "0xC6CB68", Offset = "0xC6CB68", VA = "0xC6CB68")]
			internal void _003CAcceptInvitation_003Eb__0(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
			{
			}

			[Token(Token = "0x6002F57")]
			[Address(RVA = "0xC6CCE4", Offset = "0xC6CCE4", VA = "0xC6CCE4")]
			internal void _003CAcceptInvitation_003Eb__1(UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)
			{
			}
		}

		[Token(Token = "0x20006E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820C48", Offset = "0x820C48")]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			[Token(Token = "0x40020B0")]
			[FieldOffset(Offset = "0x10")]
			public Action<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> callback;

			[Token(Token = "0x40020B1")]
			[FieldOffset(Offset = "0x18")]
			public string invitationId;

			[Token(Token = "0x6002F58")]
			[Address(RVA = "0xC6AF38", Offset = "0xC6AF38", VA = "0xC6AF38")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6002F59")]
			[Address(RVA = "0xC6CD60", Offset = "0xC6CD60", VA = "0xC6CD60")]
			internal void _003CFindInvitationWithId_003Eb__0(TurnBasedManager.TurnBasedMatchesResponse allMatches)
			{
			}
		}

		[Token(Token = "0x20006E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820C58", Offset = "0x820C58")]
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			[Token(Token = "0x40020B2")]
			[FieldOffset(Offset = "0x10")]
			public MatchDelegate del;

			[Token(Token = "0x6002F5A")]
			[Address(RVA = "0xC6B054", Offset = "0xC6B054", VA = "0xC6B054")]
			public _003C_003Ec__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6002F5B")]
			[Address(RVA = "0xC6D220", Offset = "0xC6D220", VA = "0xC6D220")]
			internal void _003CRegisterMatchDelegate_003Eb__0(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, bool autoLaunch)
			{
			}
		}

		[Token(Token = "0x20006E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820C68", Offset = "0x820C68")]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			[Token(Token = "0x40020B3")]
			[FieldOffset(Offset = "0x10")]
			public Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> currentDelegate;

			[Token(Token = "0x40020B4")]
			[FieldOffset(Offset = "0x18")]
			public NativeTurnBasedMatch match;

			[Token(Token = "0x40020B5")]
			[FieldOffset(Offset = "0x20")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x40020B6")]
			[FieldOffset(Offset = "0x28")]
			public bool shouldAutolaunch;

			[Token(Token = "0x6002F5C")]
			[Address(RVA = "0xC6B270", Offset = "0xC6B270", VA = "0xC6B270")]
			public _003C_003Ec__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6002F5D")]
			[Address(RVA = "0xC6D268", Offset = "0xC6D268", VA = "0xC6D268")]
			internal void _003CHandleMatchEvent_003Eb__0()
			{
			}
		}

		[Token(Token = "0x20006E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820C78", Offset = "0x820C78")]
		private sealed class _003CWaitForLogin_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40020B7")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40020B8")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40020B9")]
			[FieldOffset(Offset = "0x20")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x40020BA")]
			[FieldOffset(Offset = "0x28")]
			public Action method;

			[Token(Token = "0x17000803")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6002F61")]
				[Address(RVA = "0xC6FD00", Offset = "0xC6FD00", VA = "0xC6FD00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000804")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6002F63")]
				[Address(RVA = "0xC6FD70", Offset = "0xC6FD70", VA = "0xC6FD70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6002F5E")]
			[Address(RVA = "0xC6B424", Offset = "0xC6B424", VA = "0xC6B424")]
			[DebuggerHidden]
			public _003CWaitForLogin_003Ed__17(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002F5F")]
			[Address(RVA = "0xC6FC58", Offset = "0xC6FC58", VA = "0xC6FC58", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6002F60")]
			[Address(RVA = "0xC6FC5C", Offset = "0xC6FC5C", VA = "0xC6FC5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6002F62")]
			[Address(RVA = "0xC6FD08", Offset = "0xC6FD08", VA = "0xC6FD08", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x20006E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820C88", Offset = "0x820C88")]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x40020BB")]
			[FieldOffset(Offset = "0x10")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x40020BC")]
			[FieldOffset(Offset = "0x18")]
			public byte[] data;

			[Token(Token = "0x40020BD")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool> callback;

			[Token(Token = "0x40020BE")]
			[FieldOffset(Offset = "0x28")]
			public Action<TurnBasedManager.TurnBasedMatchResponse> _003C_003E9__1;

			[Token(Token = "0x6002F64")]
			[Address(RVA = "0xC6B604", Offset = "0xC6B604", VA = "0xC6B604")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6002F65")]
			[Address(RVA = "0xC6D478", Offset = "0xC6D478", VA = "0xC6D478")]
			internal void _003CTakeTurn_003Eb__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant pendingParticipant, NativeTurnBasedMatch foundMatch)
			{
			}

			[Token(Token = "0x6002F66")]
			[Address(RVA = "0xC6D554", Offset = "0xC6D554", VA = "0xC6D554")]
			internal void _003CTakeTurn_003Eb__1(TurnBasedManager.TurnBasedMatchResponse result)
			{
			}
		}

		[Token(Token = "0x20006EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820C98", Offset = "0x820C98")]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			[Token(Token = "0x40020BF")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;

			[Token(Token = "0x40020C0")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> onFailure;

			[Token(Token = "0x40020C1")]
			[FieldOffset(Offset = "0x20")]
			public Action<NativeTurnBasedMatch> onVersionMatch;

			[Token(Token = "0x6002F67")]
			[Address(RVA = "0xC6B874", Offset = "0xC6B874", VA = "0xC6B874")]
			public _003C_003Ec__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6002F68")]
			[Address(RVA = "0xC6D69C", Offset = "0xC6D69C", VA = "0xC6D69C")]
			internal void _003CFindEqualVersionMatch_003Eb__0(TurnBasedManager.TurnBasedMatchResponse response)
			{
			}
		}

		[Token(Token = "0x20006EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820CA8", Offset = "0x820CA8")]
		private sealed class _003C_003Ec__DisplayClass20_0
		{
			[Token(Token = "0x40020C2")]
			[FieldOffset(Offset = "0x10")]
			public string participantId;

			[Token(Token = "0x40020C3")]
			[FieldOffset(Offset = "0x18")]
			public Action<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, NativeTurnBasedMatch> onFoundParticipantAndMatch;

			[Token(Token = "0x40020C4")]
			[FieldOffset(Offset = "0x20")]
			public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;

			[Token(Token = "0x40020C5")]
			[FieldOffset(Offset = "0x28")]
			public Action<bool> onFailure;

			[Token(Token = "0x6002F69")]
			[Address(RVA = "0xC6B87C", Offset = "0xC6B87C", VA = "0xC6B87C")]
			public _003C_003Ec__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6002F6A")]
			[Address(RVA = "0xC6D9DC", Offset = "0xC6D9DC", VA = "0xC6D9DC")]
			internal void _003CFindEqualVersionMatchWithParticipant_003Eb__0(NativeTurnBasedMatch foundMatch)
			{
			}
		}

		[Token(Token = "0x20006EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820CB8", Offset = "0x820CB8")]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			[Token(Token = "0x40020C6")]
			[FieldOffset(Offset = "0x10")]
			public MatchOutcome outcome;

			[Token(Token = "0x40020C7")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> callback;

			[Token(Token = "0x40020C8")]
			[FieldOffset(Offset = "0x20")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x40020C9")]
			[FieldOffset(Offset = "0x28")]
			public byte[] data;

			[Token(Token = "0x40020CA")]
			[FieldOffset(Offset = "0x30")]
			public Action<TurnBasedManager.TurnBasedMatchResponse> _003C_003E9__1;

			[Token(Token = "0x6002F6B")]
			[Address(RVA = "0xC6BA74", Offset = "0xC6BA74", VA = "0xC6BA74")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6002F6C")]
			[Address(RVA = "0xC6DDB8", Offset = "0xC6DDB8", VA = "0xC6DDB8")]
			internal void _003CFinish_003Eb__0(NativeTurnBasedMatch foundMatch)
			{
			}

			[Token(Token = "0x6002F6D")]
			[Address(RVA = "0xC6E1D0", Offset = "0xC6E1D0", VA = "0xC6E1D0")]
			internal void _003CFinish_003Eb__1(TurnBasedManager.TurnBasedMatchResponse response)
			{
			}
		}

		[Token(Token = "0x20006ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820CC8", Offset = "0x820CC8")]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			[Token(Token = "0x40020CB")]
			[FieldOffset(Offset = "0x10")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x40020CC")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> callback;

			[Token(Token = "0x40020CD")]
			[FieldOffset(Offset = "0x20")]
			public Action<TurnBasedManager.TurnBasedMatchResponse> _003C_003E9__1;

			[Token(Token = "0x6002F6E")]
			[Address(RVA = "0xC6BC9C", Offset = "0xC6BC9C", VA = "0xC6BC9C")]
			public _003C_003Ec__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6002F6F")]
			[Address(RVA = "0xC6E25C", Offset = "0xC6E25C", VA = "0xC6E25C")]
			internal void _003CAcknowledgeFinished_003Eb__0(NativeTurnBasedMatch foundMatch)
			{
			}

			[Token(Token = "0x6002F70")]
			[Address(RVA = "0xC6E320", Offset = "0xC6E320", VA = "0xC6E320")]
			internal void _003CAcknowledgeFinished_003Eb__1(TurnBasedManager.TurnBasedMatchResponse response)
			{
			}
		}

		[Token(Token = "0x20006EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820CD8", Offset = "0x820CD8")]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			[Token(Token = "0x40020CE")]
			[FieldOffset(Offset = "0x10")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x40020CF")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> callback;

			[Token(Token = "0x40020D0")]
			[FieldOffset(Offset = "0x20")]
			public Action<CommonErrorStatus.MultiplayerStatus> _003C_003E9__1;

			[Token(Token = "0x6002F71")]
			[Address(RVA = "0xC6BDF8", Offset = "0xC6BDF8", VA = "0xC6BDF8")]
			public _003C_003Ec__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6002F72")]
			[Address(RVA = "0xC6E3AC", Offset = "0xC6E3AC", VA = "0xC6E3AC")]
			internal void _003CLeave_003Eb__0(NativeTurnBasedMatch foundMatch)
			{
			}

			[Token(Token = "0x6002F73")]
			[Address(RVA = "0xC6E470", Offset = "0xC6E470", VA = "0xC6E470")]
			internal void _003CLeave_003Eb__1(CommonErrorStatus.MultiplayerStatus status)
			{
			}
		}

		[Token(Token = "0x20006EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820CE8", Offset = "0x820CE8")]
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			[Token(Token = "0x40020D1")]
			[FieldOffset(Offset = "0x10")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x40020D2")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> callback;

			[Token(Token = "0x40020D3")]
			[FieldOffset(Offset = "0x20")]
			public Action<CommonErrorStatus.MultiplayerStatus> _003C_003E9__1;

			[Token(Token = "0x6002F74")]
			[Address(RVA = "0xC6BF5C", Offset = "0xC6BF5C", VA = "0xC6BF5C")]
			public _003C_003Ec__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6002F75")]
			[Address(RVA = "0xC6E4E4", Offset = "0xC6E4E4", VA = "0xC6E4E4")]
			internal void _003CLeaveDuringTurn_003Eb__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant pendingParticipant, NativeTurnBasedMatch foundMatch)
			{
			}

			[Token(Token = "0x6002F76")]
			[Address(RVA = "0xC6E5B8", Offset = "0xC6E5B8", VA = "0xC6E5B8")]
			internal void _003CLeaveDuringTurn_003Eb__1(CommonErrorStatus.MultiplayerStatus status)
			{
			}
		}

		[Token(Token = "0x20006F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820CF8", Offset = "0x820CF8")]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			[Token(Token = "0x40020D4")]
			[FieldOffset(Offset = "0x10")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x40020D5")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> callback;

			[Token(Token = "0x40020D6")]
			[FieldOffset(Offset = "0x20")]
			public Action<CommonErrorStatus.MultiplayerStatus> _003C_003E9__1;

			[Token(Token = "0x6002F77")]
			[Address(RVA = "0xC6C0B8", Offset = "0xC6C0B8", VA = "0xC6C0B8")]
			public _003C_003Ec__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6002F78")]
			[Address(RVA = "0xC6E62C", Offset = "0xC6E62C", VA = "0xC6E62C")]
			internal void _003CCancel_003Eb__0(NativeTurnBasedMatch foundMatch)
			{
			}

			[Token(Token = "0x6002F79")]
			[Address(RVA = "0xC6E6F0", Offset = "0xC6E6F0", VA = "0xC6E6F0")]
			internal void _003CCancel_003Eb__1(CommonErrorStatus.MultiplayerStatus status)
			{
			}
		}

		[Token(Token = "0x20006F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820D08", Offset = "0x820D08")]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			[Token(Token = "0x40020D7")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;

			[Token(Token = "0x6002F7A")]
			[Address(RVA = "0xC6C1D4", Offset = "0xC6C1D4", VA = "0xC6C1D4")]
			public _003C_003Ec__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6002F7B")]
			[Address(RVA = "0xC6E764", Offset = "0xC6E764", VA = "0xC6E764")]
			internal void _003CDismiss_003Eb__0(bool success)
			{
			}
		}

		[Token(Token = "0x20006F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820D18", Offset = "0x820D18")]
		private sealed class _003C_003Ec__DisplayClass29_0
		{
			[Token(Token = "0x40020D8")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

			[Token(Token = "0x40020D9")]
			[FieldOffset(Offset = "0x18")]
			public NativeTurnBasedMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x40020DA")]
			[FieldOffset(Offset = "0x20")]
			public Action<UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> _003C_003E9__2;

			[Token(Token = "0x6002F7C")]
			[Address(RVA = "0xC6C350", Offset = "0xC6C350", VA = "0xC6C350")]
			public _003C_003Ec__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6002F7D")]
			[Address(RVA = "0xC6E80C", Offset = "0xC6E80C", VA = "0xC6E80C")]
			internal void _003CRematch_003Eb__0(bool failed)
			{
			}

			[Token(Token = "0x6002F7E")]
			[Address(RVA = "0xC6E874", Offset = "0xC6E874", VA = "0xC6E874")]
			internal void _003CRematch_003Eb__1(NativeTurnBasedMatch foundMatch)
			{
			}

			[Token(Token = "0x6002F7F")]
			[Address(RVA = "0xC6E964", Offset = "0xC6E964", VA = "0xC6E964")]
			internal void _003CRematch_003Eb__2(UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch m)
			{
			}
		}

		[Token(Token = "0x4000D0E")]
		[FieldOffset(Offset = "0x10")]
		private readonly TurnBasedManager mTurnBasedManager;

		[Token(Token = "0x4000D0F")]
		[FieldOffset(Offset = "0x18")]
		private readonly NativeClient mNativeClient;

		[Token(Token = "0x4000D10")]
		[FieldOffset(Offset = "0x20")]
		private Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> mMatchDelegate;

		[Token(Token = "0x60011C1")]
		[Address(RVA = "0xC6A170", Offset = "0xC6A170", VA = "0xC6A170")]
		internal NativeTurnBasedMultiplayerClient(NativeClient nativeClient, TurnBasedManager manager)
		{
		}

		[Token(Token = "0x60011C2")]
		[Address(RVA = "0xC6A1A8", Offset = "0xC6A1A8", VA = "0xC6A1A8", Slot = "4")]
		public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		[Token(Token = "0x60011C3")]
		[Address(RVA = "0xC6A1B8", Offset = "0xC6A1B8", VA = "0xC6A1B8", Slot = "5")]
		public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		[Token(Token = "0x60011C4")]
		[Address(RVA = "0xC6A65C", Offset = "0xC6A65C", VA = "0xC6A65C", Slot = "6")]
		public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		[Token(Token = "0x60011C5")]
		[Address(RVA = "0xC6A738", Offset = "0xC6A738", VA = "0xC6A738", Slot = "7")]
		public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		[Token(Token = "0x60011C6")]
		[Address(RVA = "0xC6A8BC", Offset = "0xC6A8BC", VA = "0xC6A8BC", Slot = "8")]
		public void GetAllInvitations(Action<Invitation[]> callback)
		{
		}

		[Token(Token = "0x60011C7")]
		[Address(RVA = "0xC6A98C", Offset = "0xC6A98C", VA = "0xC6A98C", Slot = "9")]
		public void GetAllMatches(Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback)
		{
		}

		[Token(Token = "0x60011C8")]
		[Address(RVA = "0xC6AA74", Offset = "0xC6AA74", VA = "0xC6AA74", Slot = "10")]
		public void GetMatch(string matchId, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		[Token(Token = "0x60011C9")]
		[Address(RVA = "0xC6A594", Offset = "0xC6A594", VA = "0xC6A594")]
		private Action<TurnBasedManager.TurnBasedMatchResponse> BridgeMatchToUserCallback(Action<UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> userCallback)
		{
			return null;
		}

		[Token(Token = "0x60011CA")]
		[Address(RVA = "0xC6AB9C", Offset = "0xC6AB9C", VA = "0xC6AB9C", Slot = "11")]
		public void AcceptFromInbox(Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		[Token(Token = "0x60011CB")]
		[Address(RVA = "0xC6ACE4", Offset = "0xC6ACE4", VA = "0xC6ACE4", Slot = "12")]
		public void AcceptInvitation(string invitationId, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		[Token(Token = "0x60011CC")]
		[Address(RVA = "0xC6AE54", Offset = "0xC6AE54", VA = "0xC6AE54")]
		private void FindInvitationWithId(string invitationId, Action<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> callback)
		{
		}

		[Token(Token = "0x60011CD")]
		[Address(RVA = "0xC6AF40", Offset = "0xC6AF40", VA = "0xC6AF40", Slot = "13")]
		public void RegisterMatchDelegate(MatchDelegate del)
		{
		}

		[Token(Token = "0x60011CE")]
		[Address(RVA = "0xC6B05C", Offset = "0xC6B05C", VA = "0xC6B05C")]
		internal void HandleMatchEvent(Types.MultiplayerEvent eventType, string matchId, NativeTurnBasedMatch match)
		{
		}

		[Token(Token = "0x60011CF")]
		[Address(RVA = "0xC6B324", Offset = "0xC6B324", VA = "0xC6B324")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835C28", Offset = "0x835C28")]
		private IEnumerator WaitForLogin(Action method)
		{
			return null;
		}

		[Token(Token = "0x60011D0")]
		[Address(RVA = "0xC6B450", Offset = "0xC6B450", VA = "0xC6B450", Slot = "14")]
		public void TakeTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, string pendingParticipantId, Action<bool> callback)
		{
		}

		[Token(Token = "0x60011D1")]
		[Address(RVA = "0xC6B734", Offset = "0xC6B734", VA = "0xC6B734")]
		private void FindEqualVersionMatch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> onFailure, Action<NativeTurnBasedMatch> onVersionMatch)
		{
		}

		[Token(Token = "0x60011D2")]
		[Address(RVA = "0xC6B60C", Offset = "0xC6B60C", VA = "0xC6B60C")]
		private void FindEqualVersionMatchWithParticipant(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string participantId, Action<bool> onFailure, Action<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, NativeTurnBasedMatch> onFoundParticipantAndMatch)
		{
		}

		[Token(Token = "0x60011D3")]
		[Address(RVA = "0xC6B884", Offset = "0xC6B884", VA = "0xC6B884", Slot = "15")]
		public int GetMaxMatchDataSize()
		{
			return default(int);
		}

		[Token(Token = "0x60011D4")]
		[Address(RVA = "0xC6B8EC", Offset = "0xC6B8EC", VA = "0xC6B8EC", Slot = "16")]
		public void Finish(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, MatchOutcome outcome, Action<bool> callback)
		{
		}

		[Token(Token = "0x60011D5")]
		[Address(RVA = "0xC6BA7C", Offset = "0xC6BA7C", VA = "0xC6BA7C")]
		private static Types.MatchResult ResultToMatchResult(MatchOutcome.ParticipantResult result)
		{
			return default(Types.MatchResult);
		}

		[Token(Token = "0x60011D6")]
		[Address(RVA = "0xC6BB48", Offset = "0xC6BB48", VA = "0xC6BB48", Slot = "17")]
		public void AcknowledgeFinished(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> callback)
		{
		}

		[Token(Token = "0x60011D7")]
		[Address(RVA = "0xC6BCA4", Offset = "0xC6BCA4", VA = "0xC6BCA4", Slot = "18")]
		public void Leave(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> callback)
		{
		}

		[Token(Token = "0x60011D8")]
		[Address(RVA = "0xC6BE00", Offset = "0xC6BE00", VA = "0xC6BE00", Slot = "19")]
		public void LeaveDuringTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string pendingParticipantId, Action<bool> callback)
		{
		}

		[Token(Token = "0x60011D9")]
		[Address(RVA = "0xC6BF64", Offset = "0xC6BF64", VA = "0xC6BF64", Slot = "20")]
		public void Cancel(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool> callback)
		{
		}

		[Token(Token = "0x60011DA")]
		[Address(RVA = "0xC6C0C0", Offset = "0xC6C0C0", VA = "0xC6C0C0", Slot = "21")]
		public void Dismiss(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)
		{
		}

		[Token(Token = "0x60011DB")]
		[Address(RVA = "0xC6C1DC", Offset = "0xC6C1DC", VA = "0xC6C1DC", Slot = "22")]
		public void Rematch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
		{
		}

		[Token(Token = "0x60011DC")]
		[Address(RVA = "0xC6C358", Offset = "0xC6C358", VA = "0xC6C358", Slot = "23")]
		public void DeclineInvitation(string invitationId)
		{
		}

		[Token(Token = "0x60011DD")]
		[Address(RVA = "0xC6C3E4", Offset = "0xC6C3E4", VA = "0xC6C3E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835C8C", Offset = "0x835C8C")]
		private void _003CDeclineInvitation_003Eb__30_0(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
		{
		}
	}
}
