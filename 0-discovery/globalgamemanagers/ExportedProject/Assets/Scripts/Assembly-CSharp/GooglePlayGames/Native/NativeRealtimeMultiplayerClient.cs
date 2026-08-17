using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x200025C")]
	public class NativeRealtimeMultiplayerClient : IRealTimeMultiplayerClient
	{
		[Token(Token = "0x20006B2")]
		private class NoopListener : RealTimeMultiplayerListener
		{
			[Token(Token = "0x6002E9A")]
			[Address(RVA = "0xC65150", Offset = "0xC65150", VA = "0xC65150", Slot = "4")]
			public void OnRoomSetupProgress(float percent)
			{
			}

			[Token(Token = "0x6002E9B")]
			[Address(RVA = "0xC65154", Offset = "0xC65154", VA = "0xC65154", Slot = "5")]
			public void OnRoomConnected(bool success)
			{
			}

			[Token(Token = "0x6002E9C")]
			[Address(RVA = "0xC65158", Offset = "0xC65158", VA = "0xC65158", Slot = "6")]
			public void OnLeftRoom()
			{
			}

			[Token(Token = "0x6002E9D")]
			[Address(RVA = "0xC6515C", Offset = "0xC6515C", VA = "0xC6515C", Slot = "7")]
			public void OnParticipantLeft(Participant participant)
			{
			}

			[Token(Token = "0x6002E9E")]
			[Address(RVA = "0xC65160", Offset = "0xC65160", VA = "0xC65160", Slot = "8")]
			public void OnPeersConnected(string[] participantIds)
			{
			}

			[Token(Token = "0x6002E9F")]
			[Address(RVA = "0xC65164", Offset = "0xC65164", VA = "0xC65164", Slot = "9")]
			public void OnPeersDisconnected(string[] participantIds)
			{
			}

			[Token(Token = "0x6002EA0")]
			[Address(RVA = "0xC65168", Offset = "0xC65168", VA = "0xC65168", Slot = "10")]
			public void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
			{
			}

			[Token(Token = "0x6002EA1")]
			[Address(RVA = "0xC6516C", Offset = "0xC6516C", VA = "0xC6516C")]
			public NoopListener()
			{
			}
		}

		[Token(Token = "0x20006B3")]
		private class RoomSession
		{
			[Token(Token = "0x4002038")]
			[FieldOffset(Offset = "0x10")]
			private readonly object mLifecycleLock;

			[Token(Token = "0x4002039")]
			[FieldOffset(Offset = "0x18")]
			private readonly OnGameThreadForwardingListener mListener;

			[Token(Token = "0x400203A")]
			[FieldOffset(Offset = "0x20")]
			private readonly RealtimeManager mManager;

			[Token(Token = "0x400203B")]
			[FieldOffset(Offset = "0x28")]
			private string mCurrentPlayerId;

			[Token(Token = "0x400203C")]
			[FieldOffset(Offset = "0x30")]
			private State mState;

			[Token(Token = "0x400203D")]
			[FieldOffset(Offset = "0x38")]
			private bool mStillPreRoomCreation;

			[Token(Token = "0x400203E")]
			[FieldOffset(Offset = "0x40")]
			private Invitation mInvitation;

			[Token(Token = "0x400203F")]
			[FieldOffset(Offset = "0x48")]
			private bool mShowingUI;

			[Token(Token = "0x4002040")]
			[FieldOffset(Offset = "0x4C")]
			private uint mMinPlayersToStart;

			[Token(Token = "0x17000801")]
			internal bool ShowingUI
			{
				[Token(Token = "0x6002EA3")]
				[Address(RVA = "0xC65CC4", Offset = "0xC65CC4", VA = "0xC65CC4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002EA4")]
				[Address(RVA = "0xC63ED8", Offset = "0xC63ED8", VA = "0xC63ED8")]
				set
				{
				}
			}

			[Token(Token = "0x17000802")]
			internal uint MinPlayersToStart
			{
				[Token(Token = "0x6002EA5")]
				[Address(RVA = "0xC60724", Offset = "0xC60724", VA = "0xC60724")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6002EA6")]
				[Address(RVA = "0xC6071C", Offset = "0xC6071C", VA = "0xC6071C")]
				set
				{
				}
			}

			[Token(Token = "0x6002EA2")]
			[Address(RVA = "0xC65A2C", Offset = "0xC65A2C", VA = "0xC65A2C")]
			internal RoomSession(RealtimeManager manager, RealTimeMultiplayerListener listener)
			{
			}

			[Token(Token = "0x6002EA7")]
			[Address(RVA = "0xC63F04", Offset = "0xC63F04", VA = "0xC63F04")]
			internal RealtimeManager Manager()
			{
				return null;
			}

			[Token(Token = "0x6002EA8")]
			[Address(RVA = "0xC65CE8", Offset = "0xC65CE8", VA = "0xC65CE8")]
			internal bool IsActive()
			{
				return default(bool);
			}

			[Token(Token = "0x6002EA9")]
			[Address(RVA = "0xC61CB4", Offset = "0xC61CB4", VA = "0xC61CB4")]
			internal string SelfPlayerId()
			{
				return null;
			}

			[Token(Token = "0x6002EAA")]
			[Address(RVA = "0xC5FA88", Offset = "0xC5FA88", VA = "0xC5FA88")]
			public void SetInvitation(Invitation invitation)
			{
			}

			[Token(Token = "0x6002EAB")]
			[Address(RVA = "0xC65D20", Offset = "0xC65D20", VA = "0xC65D20")]
			public Invitation GetInvitation()
			{
				return null;
			}

			[Token(Token = "0x6002EAC")]
			[Address(RVA = "0xC616B8", Offset = "0xC616B8", VA = "0xC616B8")]
			internal OnGameThreadForwardingListener OnGameThreadListener()
			{
				return null;
			}

			[Token(Token = "0x6002EAD")]
			[Address(RVA = "0xC616B0", Offset = "0xC616B0", VA = "0xC616B0")]
			internal void EnterState(State handler)
			{
			}

			[Token(Token = "0x6002EAE")]
			[Address(RVA = "0xC65B18", Offset = "0xC65B18", VA = "0xC65B18")]
			internal void EnterState(State handler, bool fireStateEnteredEvent)
			{
			}

			[Token(Token = "0x6002EAF")]
			[Address(RVA = "0xC60508", Offset = "0xC60508", VA = "0xC60508")]
			internal void LeaveRoom()
			{
			}

			[Token(Token = "0x6002EB0")]
			[Address(RVA = "0xC65D28", Offset = "0xC65D28", VA = "0xC65D28")]
			internal void ShowWaitingRoomUI()
			{
			}

			[Token(Token = "0x6002EB1")]
			[Address(RVA = "0xC60734", Offset = "0xC60734", VA = "0xC60734")]
			internal void StartRoomCreation(string currentPlayerId, Action createRoom)
			{
			}

			[Token(Token = "0x6002EB2")]
			[Address(RVA = "0xC61394", Offset = "0xC61394", VA = "0xC61394")]
			internal void OnRoomStatusChanged(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002EB3")]
			[Address(RVA = "0xC61298", Offset = "0xC61298", VA = "0xC61298")]
			internal void OnConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002EB4")]
			[Address(RVA = "0xC6118C", Offset = "0xC6118C", VA = "0xC6118C")]
			internal void OnParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			[Token(Token = "0x6002EB5")]
			[Address(RVA = "0xC5F814", Offset = "0xC5F814", VA = "0xC5F814")]
			internal void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
			{
			}

			[Token(Token = "0x6002EB6")]
			[Address(RVA = "0xC610E0", Offset = "0xC610E0", VA = "0xC610E0")]
			internal void OnDataReceived(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
			{
			}

			[Token(Token = "0x6002EB7")]
			[Address(RVA = "0xC65D6C", Offset = "0xC65D6C", VA = "0xC65D6C")]
			internal void SendMessageToAll(bool reliable, byte[] data)
			{
			}

			[Token(Token = "0x6002EB8")]
			[Address(RVA = "0xC65DB8", Offset = "0xC65DB8", VA = "0xC65DB8")]
			internal void SendMessageToAll(bool reliable, byte[] data, int offset, int length)
			{
			}

			[Token(Token = "0x6002EB9")]
			[Address(RVA = "0xC65E24", Offset = "0xC65E24", VA = "0xC65E24")]
			internal void SendMessage(bool reliable, string participantId, byte[] data)
			{
			}

			[Token(Token = "0x6002EBA")]
			[Address(RVA = "0xC65E78", Offset = "0xC65E78", VA = "0xC65E78")]
			internal void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length)
			{
			}

			[Token(Token = "0x6002EBB")]
			[Address(RVA = "0xC65EE8", Offset = "0xC65EE8", VA = "0xC65EE8")]
			internal List<Participant> GetConnectedParticipants()
			{
				return null;
			}

			[Token(Token = "0x6002EBC")]
			[Address(RVA = "0xC65F24", Offset = "0xC65F24", VA = "0xC65F24", Slot = "4")]
			internal virtual Participant GetSelf()
			{
				return null;
			}

			[Token(Token = "0x6002EBD")]
			[Address(RVA = "0xC65F60", Offset = "0xC65F60", VA = "0xC65F60", Slot = "5")]
			internal virtual Participant GetParticipant(string participantId)
			{
				return null;
			}

			[Token(Token = "0x6002EBE")]
			[Address(RVA = "0xC65FA4", Offset = "0xC65FA4", VA = "0xC65FA4", Slot = "6")]
			internal virtual bool IsRoomConnected()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20006B4")]
		private class OnGameThreadForwardingListener
		{
			[Token(Token = "0x200088D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821728", Offset = "0x821728")]
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				[Token(Token = "0x4002463")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadForwardingListener _003C_003E4__this;

				[Token(Token = "0x4002464")]
				[FieldOffset(Offset = "0x18")]
				public float percent;

				[Token(Token = "0x60033CC")]
				[Address(RVA = "0xC651E4", Offset = "0xC651E4", VA = "0xC651E4")]
				public _003C_003Ec__DisplayClass2_0()
				{
				}

				[Token(Token = "0x60033CD")]
				[Address(RVA = "0xC652CC", Offset = "0xC652CC", VA = "0xC652CC")]
				internal void _003CRoomSetupProgress_003Eb__0()
				{
				}
			}

			[Token(Token = "0x200088E")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821738", Offset = "0x821738")]
			private sealed class _003C_003Ec__DisplayClass3_0
			{
				[Token(Token = "0x4002465")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadForwardingListener _003C_003E4__this;

				[Token(Token = "0x4002466")]
				[FieldOffset(Offset = "0x18")]
				public bool success;

				[Token(Token = "0x60033CE")]
				[Address(RVA = "0xC651EC", Offset = "0xC651EC", VA = "0xC651EC")]
				public _003C_003Ec__DisplayClass3_0()
				{
				}

				[Token(Token = "0x60033CF")]
				[Address(RVA = "0xC653A0", Offset = "0xC653A0", VA = "0xC653A0")]
				internal void _003CRoomConnected_003Eb__0()
				{
				}
			}

			[Token(Token = "0x200088F")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821748", Offset = "0x821748")]
			private sealed class _003C_003Ec__DisplayClass5_0
			{
				[Token(Token = "0x4002467")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadForwardingListener _003C_003E4__this;

				[Token(Token = "0x4002468")]
				[FieldOffset(Offset = "0x18")]
				public string[] participantIds;

				[Token(Token = "0x60033D0")]
				[Address(RVA = "0xC651F4", Offset = "0xC651F4", VA = "0xC651F4")]
				public _003C_003Ec__DisplayClass5_0()
				{
				}

				[Token(Token = "0x60033D1")]
				[Address(RVA = "0xC65474", Offset = "0xC65474", VA = "0xC65474")]
				internal void _003CPeersConnected_003Eb__0()
				{
				}
			}

			[Token(Token = "0x2000890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821758", Offset = "0x821758")]
			private sealed class _003C_003Ec__DisplayClass6_0
			{
				[Token(Token = "0x4002469")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadForwardingListener _003C_003E4__this;

				[Token(Token = "0x400246A")]
				[FieldOffset(Offset = "0x18")]
				public string[] participantIds;

				[Token(Token = "0x60033D2")]
				[Address(RVA = "0xC651FC", Offset = "0xC651FC", VA = "0xC651FC")]
				public _003C_003Ec__DisplayClass6_0()
				{
				}

				[Token(Token = "0x60033D3")]
				[Address(RVA = "0xC65544", Offset = "0xC65544", VA = "0xC65544")]
				internal void _003CPeersDisconnected_003Eb__0()
				{
				}
			}

			[Token(Token = "0x2000891")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821768", Offset = "0x821768")]
			private sealed class _003C_003Ec__DisplayClass7_0
			{
				[Token(Token = "0x400246B")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadForwardingListener _003C_003E4__this;

				[Token(Token = "0x400246C")]
				[FieldOffset(Offset = "0x18")]
				public bool isReliable;

				[Token(Token = "0x400246D")]
				[FieldOffset(Offset = "0x20")]
				public string senderId;

				[Token(Token = "0x400246E")]
				[FieldOffset(Offset = "0x28")]
				public byte[] data;

				[Token(Token = "0x60033D4")]
				[Address(RVA = "0xC65204", Offset = "0xC65204", VA = "0xC65204")]
				public _003C_003Ec__DisplayClass7_0()
				{
				}

				[Token(Token = "0x60033D5")]
				[Address(RVA = "0xC65614", Offset = "0xC65614", VA = "0xC65614")]
				internal void _003CRealTimeMessageReceived_003Eb__0()
				{
				}
			}

			[Token(Token = "0x2000892")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821778", Offset = "0x821778")]
			private sealed class _003C_003Ec__DisplayClass8_0
			{
				[Token(Token = "0x400246F")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadForwardingListener _003C_003E4__this;

				[Token(Token = "0x4002470")]
				[FieldOffset(Offset = "0x18")]
				public Participant participant;

				[Token(Token = "0x60033D6")]
				[Address(RVA = "0xC6520C", Offset = "0xC6520C", VA = "0xC6520C")]
				public _003C_003Ec__DisplayClass8_0()
				{
				}

				[Token(Token = "0x60033D7")]
				[Address(RVA = "0xC65700", Offset = "0xC65700", VA = "0xC65700")]
				internal void _003CParticipantLeft_003Eb__0()
				{
				}
			}

			[Token(Token = "0x4002041")]
			[FieldOffset(Offset = "0x10")]
			private readonly RealTimeMultiplayerListener mListener;

			[Token(Token = "0x6002EBF")]
			[Address(RVA = "0xC65174", Offset = "0xC65174", VA = "0xC65174")]
			internal OnGameThreadForwardingListener(RealTimeMultiplayerListener listener)
			{
			}

			[Token(Token = "0x6002EC0")]
			[Address(RVA = "0xC63148", Offset = "0xC63148", VA = "0xC63148")]
			public void RoomSetupProgress(float percent)
			{
			}

			[Token(Token = "0x6002EC1")]
			[Address(RVA = "0xC616C0", Offset = "0xC616C0", VA = "0xC616C0")]
			public void RoomConnected(bool success)
			{
			}

			[Token(Token = "0x6002EC2")]
			[Address(RVA = "0xC62A60", Offset = "0xC62A60", VA = "0xC62A60")]
			public void LeftRoom()
			{
			}

			[Token(Token = "0x6002EC3")]
			[Address(RVA = "0xC627A8", Offset = "0xC627A8", VA = "0xC627A8")]
			public void PeersConnected(string[] participantIds)
			{
			}

			[Token(Token = "0x6002EC4")]
			[Address(RVA = "0xC6288C", Offset = "0xC6288C", VA = "0xC6288C")]
			public void PeersDisconnected(string[] participantIds)
			{
			}

			[Token(Token = "0x6002EC5")]
			[Address(RVA = "0xC64F08", Offset = "0xC64F08", VA = "0xC64F08")]
			public void RealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
			{
			}

			[Token(Token = "0x6002EC6")]
			[Address(RVA = "0xC63C64", Offset = "0xC63C64", VA = "0xC63C64")]
			public void ParticipantLeft(Participant participant)
			{
			}

			[Token(Token = "0x6002EC7")]
			[Address(RVA = "0xC65214", Offset = "0xC65214", VA = "0xC65214")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B59C", Offset = "0x83B59C")]
			private void _003CLeftRoom_003Eb__4_0()
			{
			}
		}

		[Token(Token = "0x20006B5")]
		internal abstract class State
		{
			[Token(Token = "0x6002EC8")]
			[Address(RVA = "0xC66024", Offset = "0xC66024", VA = "0xC66024", Slot = "4")]
			internal virtual void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
			{
			}

			[Token(Token = "0x6002EC9")]
			[Address(RVA = "0xC660D0", Offset = "0xC660D0", VA = "0xC660D0", Slot = "5")]
			internal virtual bool IsActive()
			{
				return default(bool);
			}

			[Token(Token = "0x6002ECA")]
			[Address(RVA = "0xC66184", Offset = "0xC66184", VA = "0xC66184", Slot = "6")]
			internal virtual void LeaveRoom()
			{
			}

			[Token(Token = "0x6002ECB")]
			[Address(RVA = "0xC66230", Offset = "0xC66230", VA = "0xC66230", Slot = "7")]
			internal virtual void ShowWaitingRoomUI(uint minimumParticipantsBeforeStarting)
			{
			}

			[Token(Token = "0x6002ECC")]
			[Address(RVA = "0xC662DC", Offset = "0xC662DC", VA = "0xC662DC", Slot = "8")]
			internal virtual void OnStateEntered()
			{
			}

			[Token(Token = "0x6002ECD")]
			[Address(RVA = "0xC66388", Offset = "0xC66388", VA = "0xC66388", Slot = "9")]
			internal virtual void OnRoomStatusChanged(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002ECE")]
			[Address(RVA = "0xC66434", Offset = "0xC66434", VA = "0xC66434", Slot = "10")]
			internal virtual void OnConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002ECF")]
			[Address(RVA = "0xC664E0", Offset = "0xC664E0", VA = "0xC664E0", Slot = "11")]
			internal virtual void OnParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			[Token(Token = "0x6002ED0")]
			[Address(RVA = "0xC6658C", Offset = "0xC6658C", VA = "0xC6658C", Slot = "12")]
			internal virtual void OnDataReceived(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
			{
			}

			[Token(Token = "0x6002ED1")]
			[Address(RVA = "0xC66638", Offset = "0xC66638", VA = "0xC66638", Slot = "13")]
			internal virtual void SendToSpecificRecipient(string recipientId, byte[] data, int offset, int length, bool isReliable)
			{
			}

			[Token(Token = "0x6002ED2")]
			[Address(RVA = "0xC666E4", Offset = "0xC666E4", VA = "0xC666E4", Slot = "14")]
			internal virtual void SendToAll(byte[] data, int offset, int length, bool isReliable)
			{
			}

			[Token(Token = "0x6002ED3")]
			[Address(RVA = "0xC66790", Offset = "0xC66790", VA = "0xC66790", Slot = "15")]
			internal virtual List<Participant> GetConnectedParticipants()
			{
				return null;
			}

			[Token(Token = "0x6002ED4")]
			[Address(RVA = "0xC66868", Offset = "0xC66868", VA = "0xC66868", Slot = "16")]
			internal virtual Participant GetSelf()
			{
				return null;
			}

			[Token(Token = "0x6002ED5")]
			[Address(RVA = "0xC6691C", Offset = "0xC6691C", VA = "0xC6691C", Slot = "17")]
			internal virtual Participant GetParticipant(string participantId)
			{
				return null;
			}

			[Token(Token = "0x6002ED6")]
			[Address(RVA = "0xC669D0", Offset = "0xC669D0", VA = "0xC669D0", Slot = "18")]
			internal virtual bool IsRoomConnected()
			{
				return default(bool);
			}

			[Token(Token = "0x6002ED7")]
			[Address(RVA = "0xC614CC", Offset = "0xC614CC", VA = "0xC614CC")]
			protected State()
			{
			}
		}

		[Token(Token = "0x20006B6")]
		private abstract class MessagingEnabledState : State
		{
			[Serializable]
			[Token(Token = "0x2000893")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821788", Offset = "0x821788")]
			private sealed class _003C_003Ec
			{
				[Token(Token = "0x4002471")]
				[FieldOffset(Offset = "0x0")]
				public static readonly _003C_003Ec _003C_003E9;

				[Token(Token = "0x4002472")]
				[FieldOffset(Offset = "0x8")]
				public static Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, string> _003C_003E9__5_0;

				[Token(Token = "0x4002473")]
				[FieldOffset(Offset = "0x10")]
				public static Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, Participant> _003C_003E9__5_1;

				[Token(Token = "0x4002474")]
				[FieldOffset(Offset = "0x18")]
				public static Func<Participant, string> _003C_003E9__5_2;

				[Token(Token = "0x4002475")]
				[FieldOffset(Offset = "0x20")]
				public static Func<Participant, bool> _003C_003E9__12_0;

				[Token(Token = "0x60033D9")]
				[Address(RVA = "0xC65090", Offset = "0xC65090", VA = "0xC65090")]
				public _003C_003Ec()
				{
				}

				[Token(Token = "0x60033DA")]
				[Address(RVA = "0xC65098", Offset = "0xC65098", VA = "0xC65098")]
				internal string _003CUpdateCurrentRoom_003Eb__5_0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
				{
					return null;
				}

				[Token(Token = "0x60033DB")]
				[Address(RVA = "0xC650C4", Offset = "0xC650C4", VA = "0xC650C4")]
				internal Participant _003CUpdateCurrentRoom_003Eb__5_1(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
				{
					return null;
				}

				[Token(Token = "0x60033DC")]
				[Address(RVA = "0xC650F0", Offset = "0xC650F0", VA = "0xC650F0")]
				internal string _003CUpdateCurrentRoom_003Eb__5_2(Participant p)
				{
					return null;
				}

				[Token(Token = "0x60033DD")]
				[Address(RVA = "0xC65120", Offset = "0xC65120", VA = "0xC65120")]
				internal bool _003CGetConnectedParticipants_003Eb__12_0(Participant p)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x4002042")]
			[FieldOffset(Offset = "0x10")]
			protected readonly RoomSession mSession;

			[Token(Token = "0x4002043")]
			[FieldOffset(Offset = "0x18")]
			protected NativeRealTimeRoom mRoom;

			[Token(Token = "0x4002044")]
			[FieldOffset(Offset = "0x20")]
			protected Dictionary<string, GooglePlayGames.Native.PInvoke.MultiplayerParticipant> mNativeParticipants;

			[Token(Token = "0x4002045")]
			[FieldOffset(Offset = "0x28")]
			protected Dictionary<string, Participant> mParticipants;

			[Token(Token = "0x6002ED8")]
			[Address(RVA = "0xC618A8", Offset = "0xC618A8", VA = "0xC618A8")]
			internal MessagingEnabledState(RoomSession session, NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002ED9")]
			[Address(RVA = "0xC645BC", Offset = "0xC645BC", VA = "0xC645BC")]
			internal void UpdateCurrentRoom(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002EDA")]
			[Address(RVA = "0xC64880", Offset = "0xC64880", VA = "0xC64880", Slot = "9")]
			internal sealed override void OnRoomStatusChanged(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002EDB")]
			[Address(RVA = "0xC648B8", Offset = "0xC648B8", VA = "0xC648B8", Slot = "19")]
			internal virtual void HandleRoomStatusChanged(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002EDC")]
			[Address(RVA = "0xC648BC", Offset = "0xC648BC", VA = "0xC648BC", Slot = "10")]
			internal sealed override void OnConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002EDD")]
			[Address(RVA = "0xC648F4", Offset = "0xC648F4", VA = "0xC648F4", Slot = "20")]
			internal virtual void HandleConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002EDE")]
			[Address(RVA = "0xC648F8", Offset = "0xC648F8", VA = "0xC648F8", Slot = "11")]
			internal sealed override void OnParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			[Token(Token = "0x6002EDF")]
			[Address(RVA = "0xC64930", Offset = "0xC64930", VA = "0xC64930", Slot = "21")]
			internal virtual void HandleParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			[Token(Token = "0x6002EE0")]
			[Address(RVA = "0xC64934", Offset = "0xC64934", VA = "0xC64934", Slot = "15")]
			internal sealed override List<Participant> GetConnectedParticipants()
			{
				return null;
			}

			[Token(Token = "0x6002EE1")]
			[Address(RVA = "0xC64A88", Offset = "0xC64A88", VA = "0xC64A88", Slot = "13")]
			internal override void SendToSpecificRecipient(string recipientId, byte[] data, int offset, int length, bool isReliable)
			{
			}

			[Token(Token = "0x6002EE2")]
			[Address(RVA = "0xC64CC8", Offset = "0xC64CC8", VA = "0xC64CC8", Slot = "14")]
			internal override void SendToAll(byte[] data, int offset, int length, bool isReliable)
			{
			}

			[Token(Token = "0x6002EE3")]
			[Address(RVA = "0xC64E94", Offset = "0xC64E94", VA = "0xC64E94", Slot = "12")]
			internal override void OnDataReceived(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
			{
			}
		}

		[Token(Token = "0x20006B7")]
		private class BeforeRoomCreateStartedState : State
		{
			[Token(Token = "0x4002046")]
			[FieldOffset(Offset = "0x10")]
			private readonly RoomSession mContainingSession;

			[Token(Token = "0x6002EE4")]
			[Address(RVA = "0xC62EF8", Offset = "0xC62EF8", VA = "0xC62EF8")]
			internal BeforeRoomCreateStartedState(RoomSession session)
			{
			}

			[Token(Token = "0x6002EE5")]
			[Address(RVA = "0xC62F68", Offset = "0xC62F68", VA = "0xC62F68", Slot = "6")]
			internal override void LeaveRoom()
			{
			}
		}

		[Token(Token = "0x20006B8")]
		private class RoomCreationPendingState : State
		{
			[Token(Token = "0x4002047")]
			[FieldOffset(Offset = "0x10")]
			private readonly RoomSession mContainingSession;

			[Token(Token = "0x6002EE6")]
			[Address(RVA = "0xC657D0", Offset = "0xC657D0", VA = "0xC657D0")]
			internal RoomCreationPendingState(RoomSession session)
			{
			}

			[Token(Token = "0x6002EE7")]
			[Address(RVA = "0xC65840", Offset = "0xC65840", VA = "0xC65840", Slot = "4")]
			internal override void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
			{
			}

			[Token(Token = "0x6002EE8")]
			[Address(RVA = "0xC65978", Offset = "0xC65978", VA = "0xC65978", Slot = "5")]
			internal override bool IsActive()
			{
				return default(bool);
			}

			[Token(Token = "0x6002EE9")]
			[Address(RVA = "0xC65980", Offset = "0xC65980", VA = "0xC65980", Slot = "6")]
			internal override void LeaveRoom()
			{
			}
		}

		[Token(Token = "0x20006B9")]
		private class ConnectingState : MessagingEnabledState
		{
			[Token(Token = "0x4002048")]
			private const float InitialPercentComplete = 20f;

			[Token(Token = "0x4002049")]
			[FieldOffset(Offset = "0x0")]
			private static readonly HashSet<Types.ParticipantStatus> FailedStatuses;

			[Token(Token = "0x400204A")]
			[FieldOffset(Offset = "0x30")]
			private HashSet<string> mConnectedParticipants;

			[Token(Token = "0x400204B")]
			[FieldOffset(Offset = "0x38")]
			private float mPercentComplete;

			[Token(Token = "0x400204C")]
			[FieldOffset(Offset = "0x3C")]
			private float mPercentPerParticipant;

			[Token(Token = "0x6002EEA")]
			[Address(RVA = "0xC63040", Offset = "0xC63040", VA = "0xC63040")]
			internal ConnectingState(NativeRealTimeRoom room, RoomSession session)
			{
			}

			[Token(Token = "0x6002EEB")]
			[Address(RVA = "0xC630F8", Offset = "0xC630F8", VA = "0xC630F8", Slot = "8")]
			internal override void OnStateEntered()
			{
			}

			[Token(Token = "0x6002EEC")]
			[Address(RVA = "0xC6322C", Offset = "0xC6322C", VA = "0xC6322C", Slot = "20")]
			internal override void HandleConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002EED")]
			[Address(RVA = "0xC63ADC", Offset = "0xC63ADC", VA = "0xC63ADC", Slot = "21")]
			internal override void HandleParticipantStatusChanged(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			[Token(Token = "0x6002EEE")]
			[Address(RVA = "0xC63D48", Offset = "0xC63D48", VA = "0xC63D48", Slot = "6")]
			internal override void LeaveRoom()
			{
			}

			[Token(Token = "0x6002EEF")]
			[Address(RVA = "0xC63DFC", Offset = "0xC63DFC", VA = "0xC63DFC", Slot = "7")]
			internal override void ShowWaitingRoomUI(uint minimumParticipantsBeforeStarting)
			{
			}

			[Token(Token = "0x6002EF1")]
			[Address(RVA = "0xC63FE0", Offset = "0xC63FE0", VA = "0xC63FE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B5AC", Offset = "0x83B5AC")]
			private void _003CLeaveRoom_003Eb__9_0()
			{
			}

			[Token(Token = "0x6002EF2")]
			[Address(RVA = "0xC64020", Offset = "0xC64020", VA = "0xC64020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B5BC", Offset = "0x83B5BC")]
			private void _003CShowWaitingRoomUI_003Eb__10_0(RealtimeManager.WaitingRoomUIResponse response)
			{
			}
		}

		[Token(Token = "0x20006BA")]
		private class ActiveState : MessagingEnabledState
		{
			[Token(Token = "0x2000894")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821798", Offset = "0x821798")]
			private sealed class _003C_003Ec__DisplayClass5_0
			{
				[Token(Token = "0x4002476")]
				[FieldOffset(Offset = "0x10")]
				public string selfId;

				[Token(Token = "0x60033DE")]
				[Address(RVA = "0xC626E0", Offset = "0xC626E0", VA = "0xC626E0")]
				public _003C_003Ec__DisplayClass5_0()
				{
				}

				[Token(Token = "0x60033DF")]
				[Address(RVA = "0xC62DE8", Offset = "0xC62DE8", VA = "0xC62DE8")]
				internal bool _003CHandleConnectedSetChanged_003Eb__4(string peerId)
				{
					return default(bool);
				}

				[Token(Token = "0x60033E0")]
				[Address(RVA = "0xC62E2C", Offset = "0xC62E2C", VA = "0xC62E2C")]
				internal bool _003CHandleConnectedSetChanged_003Eb__5(string peerId)
				{
					return default(bool);
				}

				[Token(Token = "0x60033E1")]
				[Address(RVA = "0xC62E70", Offset = "0xC62E70", VA = "0xC62E70")]
				internal bool _003CHandleConnectedSetChanged_003Eb__6(string peer)
				{
					return default(bool);
				}

				[Token(Token = "0x60033E2")]
				[Address(RVA = "0xC62EB4", Offset = "0xC62EB4", VA = "0xC62EB4")]
				internal bool _003CHandleConnectedSetChanged_003Eb__7(string peer)
				{
					return default(bool);
				}
			}

			[Serializable]
			[Token(Token = "0x2000895")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8217A8", Offset = "0x8217A8")]
			private sealed class _003C_003Ec
			{
				[Token(Token = "0x4002477")]
				[FieldOffset(Offset = "0x0")]
				public static readonly _003C_003Ec _003C_003E9;

				[Token(Token = "0x4002478")]
				[FieldOffset(Offset = "0x8")]
				public static Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, string> _003C_003E9__5_0;

				[Token(Token = "0x4002479")]
				[FieldOffset(Offset = "0x10")]
				public static Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, Participant> _003C_003E9__5_1;

				[Token(Token = "0x400247A")]
				[FieldOffset(Offset = "0x18")]
				public static Func<Participant, string> _003C_003E9__5_2;

				[Token(Token = "0x400247B")]
				[FieldOffset(Offset = "0x20")]
				public static Func<Participant, string> _003C_003E9__5_3;

				[Token(Token = "0x60033E4")]
				[Address(RVA = "0xC62B58", Offset = "0xC62B58", VA = "0xC62B58")]
				public _003C_003Ec()
				{
				}

				[Token(Token = "0x60033E5")]
				[Address(RVA = "0xC62B60", Offset = "0xC62B60", VA = "0xC62B60")]
				internal string _003CHandleConnectedSetChanged_003Eb__5_0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
				{
					return null;
				}

				[Token(Token = "0x60033E6")]
				[Address(RVA = "0xC62C20", Offset = "0xC62C20", VA = "0xC62C20")]
				internal Participant _003CHandleConnectedSetChanged_003Eb__5_1(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
				{
					return null;
				}

				[Token(Token = "0x60033E7")]
				[Address(RVA = "0xC62D84", Offset = "0xC62D84", VA = "0xC62D84")]
				internal string _003CHandleConnectedSetChanged_003Eb__5_2(Participant p)
				{
					return null;
				}

				[Token(Token = "0x60033E8")]
				[Address(RVA = "0xC62DB4", Offset = "0xC62DB4", VA = "0xC62DB4")]
				internal string _003CHandleConnectedSetChanged_003Eb__5_3(Participant p)
				{
					return null;
				}
			}

			[Token(Token = "0x6002EF3")]
			[Address(RVA = "0xC61898", Offset = "0xC61898", VA = "0xC61898")]
			internal ActiveState(NativeRealTimeRoom room, RoomSession session)
			{
			}

			[Token(Token = "0x6002EF4")]
			[Address(RVA = "0xC61924", Offset = "0xC61924", VA = "0xC61924", Slot = "8")]
			internal override void OnStateEntered()
			{
			}

			[Token(Token = "0x6002EF5")]
			[Address(RVA = "0xC619C8", Offset = "0xC619C8", VA = "0xC619C8", Slot = "18")]
			internal override bool IsRoomConnected()
			{
				return default(bool);
			}

			[Token(Token = "0x6002EF6")]
			[Address(RVA = "0xC619D0", Offset = "0xC619D0", VA = "0xC619D0", Slot = "17")]
			internal override Participant GetParticipant(string participantId)
			{
				return null;
			}

			[Token(Token = "0x6002EF7")]
			[Address(RVA = "0xC61AC4", Offset = "0xC61AC4", VA = "0xC61AC4", Slot = "16")]
			internal override Participant GetSelf()
			{
				return null;
			}

			[Token(Token = "0x6002EF8")]
			[Address(RVA = "0xC61CD8", Offset = "0xC61CD8", VA = "0xC61CD8", Slot = "20")]
			internal override void HandleConnectedSetChanged(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002EF9")]
			[Address(RVA = "0xC62970", Offset = "0xC62970", VA = "0xC62970", Slot = "6")]
			internal override void LeaveRoom()
			{
			}

			[Token(Token = "0x6002EFA")]
			[Address(RVA = "0xC62A24", Offset = "0xC62A24", VA = "0xC62A24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B5CC", Offset = "0x83B5CC")]
			private void _003CLeaveRoom_003Eb__6_0()
			{
			}
		}

		[Token(Token = "0x20006BB")]
		private class ShutdownState : State
		{
			[Token(Token = "0x400204D")]
			[FieldOffset(Offset = "0x10")]
			private readonly RoomSession mSession;

			[Token(Token = "0x6002EFB")]
			[Address(RVA = "0xC61640", Offset = "0xC61640", VA = "0xC61640")]
			internal ShutdownState(RoomSession session)
			{
			}

			[Token(Token = "0x6002EFC")]
			[Address(RVA = "0xC65FE0", Offset = "0xC65FE0", VA = "0xC65FE0", Slot = "5")]
			internal override bool IsActive()
			{
				return default(bool);
			}

			[Token(Token = "0x6002EFD")]
			[Address(RVA = "0xC65FE8", Offset = "0xC65FE8", VA = "0xC65FE8", Slot = "6")]
			internal override void LeaveRoom()
			{
			}
		}

		[Token(Token = "0x20006BC")]
		private class LeavingRoom : State
		{
			[Token(Token = "0x400204E")]
			[FieldOffset(Offset = "0x10")]
			private readonly RoomSession mSession;

			[Token(Token = "0x400204F")]
			[FieldOffset(Offset = "0x18")]
			private readonly NativeRealTimeRoom mRoomToLeave;

			[Token(Token = "0x4002050")]
			[FieldOffset(Offset = "0x20")]
			private readonly Action mLeavingCompleteCallback;

			[Token(Token = "0x6002EFE")]
			[Address(RVA = "0xC617A8", Offset = "0xC617A8", VA = "0xC617A8")]
			internal LeavingRoom(RoomSession session, NativeRealTimeRoom room, Action leavingCompleteCallback)
			{
			}

			[Token(Token = "0x6002EFF")]
			[Address(RVA = "0xC64470", Offset = "0xC64470", VA = "0xC64470", Slot = "5")]
			internal override bool IsActive()
			{
				return default(bool);
			}

			[Token(Token = "0x6002F00")]
			[Address(RVA = "0xC64478", Offset = "0xC64478", VA = "0xC64478", Slot = "8")]
			internal override void OnStateEntered()
			{
			}

			[Token(Token = "0x6002F01")]
			[Address(RVA = "0xC64528", Offset = "0xC64528", VA = "0xC64528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B5DC", Offset = "0x83B5DC")]
			private void _003COnStateEntered_003Eb__5_0(CommonErrorStatus.ResponseStatus status)
			{
			}
		}

		[Token(Token = "0x20006BD")]
		private class AbortingRoomCreationState : State
		{
			[Token(Token = "0x4002051")]
			[FieldOffset(Offset = "0x10")]
			private readonly RoomSession mSession;

			[Token(Token = "0x6002F02")]
			[Address(RVA = "0xC6145C", Offset = "0xC6145C", VA = "0xC6145C")]
			internal AbortingRoomCreationState(RoomSession session)
			{
			}

			[Token(Token = "0x6002F03")]
			[Address(RVA = "0xC614D4", Offset = "0xC614D4", VA = "0xC614D4", Slot = "5")]
			internal override bool IsActive()
			{
				return default(bool);
			}

			[Token(Token = "0x6002F04")]
			[Address(RVA = "0xC614DC", Offset = "0xC614DC", VA = "0xC614DC", Slot = "4")]
			internal override void HandleRoomResponse(RealtimeManager.RealTimeRoomResponse response)
			{
			}

			[Token(Token = "0x6002F05")]
			[Address(RVA = "0xC61858", Offset = "0xC61858", VA = "0xC61858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B5EC", Offset = "0x83B5EC")]
			private void _003CHandleRoomResponse_003Eb__3_0()
			{
			}
		}

		[Token(Token = "0x20006BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8209F8", Offset = "0x8209F8")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4002052")]
			[FieldOffset(Offset = "0x10")]
			public RoomSession newSession;

			[Token(Token = "0x4002053")]
			[FieldOffset(Offset = "0x18")]
			public NativeRealtimeMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x6002F06")]
			[Address(RVA = "0xC60F4C", Offset = "0xC60F4C", VA = "0xC60F4C")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}
		}

		[Token(Token = "0x20006BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A08", Offset = "0x820A08")]
		private sealed class _003C_003Ec__DisplayClass7_1
		{
			[Token(Token = "0x4002054")]
			[FieldOffset(Offset = "0x10")]
			public RealtimeRoomConfig config;

			[Token(Token = "0x4002055")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6002F07")]
			[Address(RVA = "0xC60F54", Offset = "0xC60F54", VA = "0xC60F54")]
			public _003C_003Ec__DisplayClass7_1()
			{
			}
		}

		[Token(Token = "0x20006C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A18", Offset = "0x820A18")]
		private sealed class _003C_003Ec__DisplayClass7_2
		{
			[Token(Token = "0x4002056")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;

			[Token(Token = "0x4002057")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals2;

			[Token(Token = "0x6002F08")]
			[Address(RVA = "0xC60F5C", Offset = "0xC60F5C", VA = "0xC60F5C")]
			public _003C_003Ec__DisplayClass7_2()
			{
			}

			[Token(Token = "0x6002F09")]
			[Address(RVA = "0xC60F64", Offset = "0xC60F64", VA = "0xC60F64")]
			internal void _003CCreateQuickGame_003Eb__0()
			{
			}
		}

		[Token(Token = "0x20006C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A28", Offset = "0x820A28")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x4002058")]
			[FieldOffset(Offset = "0x10")]
			public RoomSession session;

			[Token(Token = "0x6002F0A")]
			[Address(RVA = "0xC6107C", Offset = "0xC6107C", VA = "0xC6107C")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6002F0B")]
			[Address(RVA = "0xC61084", Offset = "0xC61084", VA = "0xC61084")]
			internal void _003CHelperForSession_003Eb__0(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant, byte[] data, bool isReliable)
			{
			}

			[Token(Token = "0x6002F0C")]
			[Address(RVA = "0xC61148", Offset = "0xC61148", VA = "0xC61148")]
			internal void _003CHelperForSession_003Eb__1(NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
			{
			}

			[Token(Token = "0x6002F0D")]
			[Address(RVA = "0xC61264", Offset = "0xC61264", VA = "0xC61264")]
			internal void _003CHelperForSession_003Eb__2(NativeRealTimeRoom room)
			{
			}

			[Token(Token = "0x6002F0E")]
			[Address(RVA = "0xC61360", Offset = "0xC61360", VA = "0xC61360")]
			internal void _003CHelperForSession_003Eb__3(NativeRealTimeRoom room)
			{
			}
		}

		[Token(Token = "0x20006C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A38", Offset = "0x820A38")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4002059")]
			[FieldOffset(Offset = "0x10")]
			public NativeRealtimeMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x400205A")]
			[FieldOffset(Offset = "0x18")]
			public uint variant;

			[Token(Token = "0x6002F0F")]
			[Address(RVA = "0x133BF48", Offset = "0x133BF48", VA = "0x133BF48")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}
		}

		[Token(Token = "0x20006C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A48", Offset = "0x820A48")]
		private sealed class _003C_003Ec__DisplayClass10_1
		{
			[Token(Token = "0x400205B")]
			[FieldOffset(Offset = "0x10")]
			public RoomSession newRoom;

			[Token(Token = "0x400205C")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6002F10")]
			[Address(RVA = "0x133BF50", Offset = "0x133BF50", VA = "0x133BF50")]
			public _003C_003Ec__DisplayClass10_1()
			{
			}

			[Token(Token = "0x6002F11")]
			[Address(RVA = "0x133C970", Offset = "0x133C970", VA = "0x133C970")]
			internal void _003CCreateWithInvitationScreen_003Eb__0(PlayerSelectUIResponse response)
			{
			}
		}

		[Token(Token = "0x20006C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A58", Offset = "0x820A58")]
		private sealed class _003C_003Ec__DisplayClass10_2
		{
			[Token(Token = "0x400205D")]
			[FieldOffset(Offset = "0x10")]
			public RealtimeRoomConfig config;

			[Token(Token = "0x400205E")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass10_1 CS_0024_003C_003E8__locals2;

			[Token(Token = "0x6002F12")]
			[Address(RVA = "0x133CF4C", Offset = "0x133CF4C", VA = "0x133CF4C")]
			public _003C_003Ec__DisplayClass10_2()
			{
			}
		}

		[Token(Token = "0x20006C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A68", Offset = "0x820A68")]
		private sealed class _003C_003Ec__DisplayClass10_3
		{
			[Token(Token = "0x400205F")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;

			[Token(Token = "0x4002060")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass10_2 CS_0024_003C_003E8__locals3;

			[Token(Token = "0x6002F13")]
			[Address(RVA = "0x133CF54", Offset = "0x133CF54", VA = "0x133CF54")]
			public _003C_003Ec__DisplayClass10_3()
			{
			}

			[Token(Token = "0x6002F14")]
			[Address(RVA = "0x133CF5C", Offset = "0x133CF5C", VA = "0x133CF5C")]
			internal void _003CCreateWithInvitationScreen_003Eb__1()
			{
			}
		}

		[Token(Token = "0x20006C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A78", Offset = "0x820A78")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x4002061")]
			[FieldOffset(Offset = "0x10")]
			public Action<Invitation[]> callback;

			[Token(Token = "0x6002F15")]
			[Address(RVA = "0x133C0D8", Offset = "0x133C0D8", VA = "0x133C0D8")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6002F16")]
			[Address(RVA = "0x133D084", Offset = "0x133D084", VA = "0x133D084")]
			internal void _003CGetAllInvitations_003Eb__0(RealtimeManager.FetchInvitationsResponse response)
			{
			}
		}

		[Token(Token = "0x20006C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A88", Offset = "0x820A88")]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			[Token(Token = "0x4002062")]
			[FieldOffset(Offset = "0x10")]
			public RoomSession newRoom;

			[Token(Token = "0x4002063")]
			[FieldOffset(Offset = "0x18")]
			public NativeRealtimeMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x6002F17")]
			[Address(RVA = "0x133C35C", Offset = "0x133C35C", VA = "0x133C35C")]
			public _003C_003Ec__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6002F18")]
			[Address(RVA = "0x133D574", Offset = "0x133D574", VA = "0x133D574")]
			internal void _003CAcceptFromInbox_003Eb__0(RealtimeManager.RoomInboxUIResponse response)
			{
			}
		}

		[Token(Token = "0x20006C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820A98", Offset = "0x820A98")]
		private sealed class _003C_003Ec__DisplayClass13_1
		{
			[Token(Token = "0x4002064")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation;

			[Token(Token = "0x4002065")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x4002066")]
			[FieldOffset(Offset = "0x20")]
			public Action<RealtimeManager.RealTimeRoomResponse> _003C_003E9__2;

			[Token(Token = "0x6002F19")]
			[Address(RVA = "0xC5F678", Offset = "0xC5F678", VA = "0xC5F678")]
			public _003C_003Ec__DisplayClass13_1()
			{
			}

			[Token(Token = "0x6002F1A")]
			[Address(RVA = "0xC5F680", Offset = "0xC5F680", VA = "0xC5F680")]
			internal void _003CAcceptFromInbox_003Eb__2(RealtimeManager.RealTimeRoomResponse acceptResponse)
			{
			}
		}

		[Token(Token = "0x20006C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820AA8", Offset = "0x820AA8")]
		private sealed class _003C_003Ec__DisplayClass13_2
		{
			[Token(Token = "0x4002067")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;

			[Token(Token = "0x4002068")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass13_1 CS_0024_003C_003E8__locals2;

			[Token(Token = "0x6002F1B")]
			[Address(RVA = "0xC5FA90", Offset = "0xC5FA90", VA = "0xC5FA90")]
			public _003C_003Ec__DisplayClass13_2()
			{
			}

			[Token(Token = "0x6002F1C")]
			[Address(RVA = "0xC5FA98", Offset = "0xC5FA98", VA = "0xC5FA98")]
			internal void _003CAcceptFromInbox_003Eb__1()
			{
			}
		}

		[Token(Token = "0x20006CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820AB8", Offset = "0x820AB8")]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			[Token(Token = "0x4002069")]
			[FieldOffset(Offset = "0x10")]
			public string invitationId;

			[Token(Token = "0x400206A")]
			[FieldOffset(Offset = "0x18")]
			public NativeRealtimeMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x6002F1D")]
			[Address(RVA = "0xC5FBC0", Offset = "0xC5FBC0", VA = "0xC5FBC0")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}
		}

		[Token(Token = "0x20006CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820AC8", Offset = "0x820AC8")]
		private sealed class _003C_003Ec__DisplayClass14_1
		{
			[Token(Token = "0x400206B")]
			[FieldOffset(Offset = "0x10")]
			public RoomSession newRoom;

			[Token(Token = "0x400206C")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6002F1E")]
			[Address(RVA = "0xC5FBC8", Offset = "0xC5FBC8", VA = "0xC5FBC8")]
			public _003C_003Ec__DisplayClass14_1()
			{
			}

			[Token(Token = "0x6002F1F")]
			[Address(RVA = "0xC5FBD0", Offset = "0xC5FBD0", VA = "0xC5FBD0")]
			internal void _003CAcceptInvitation_003Eb__0(RealtimeManager.FetchInvitationsResponse response)
			{
			}
		}

		[Token(Token = "0x20006CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820AD8", Offset = "0x820AD8")]
		private sealed class _003C_003Ec__DisplayClass14_2
		{
			[Token(Token = "0x400206D")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation;

			[Token(Token = "0x400206E")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass14_1 CS_0024_003C_003E8__locals2;

			[Token(Token = "0x6002F20")]
			[Address(RVA = "0xC60634", Offset = "0xC60634", VA = "0xC60634")]
			public _003C_003Ec__DisplayClass14_2()
			{
			}
		}

		[Token(Token = "0x20006CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820AE8", Offset = "0x820AE8")]
		private sealed class _003C_003Ec__DisplayClass14_3
		{
			[Token(Token = "0x400206F")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;

			[Token(Token = "0x4002070")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass14_2 CS_0024_003C_003E8__locals3;

			[Token(Token = "0x6002F21")]
			[Address(RVA = "0xC6072C", Offset = "0xC6072C", VA = "0xC6072C")]
			public _003C_003Ec__DisplayClass14_3()
			{
			}

			[Token(Token = "0x6002F22")]
			[Address(RVA = "0xC60958", Offset = "0xC60958", VA = "0xC60958")]
			internal void _003CAcceptInvitation_003Eb__1()
			{
			}
		}

		[Token(Token = "0x20006CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820AF8", Offset = "0x820AF8")]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			[Token(Token = "0x4002071")]
			[FieldOffset(Offset = "0x10")]
			public string invitationId;

			[Token(Token = "0x4002072")]
			[FieldOffset(Offset = "0x18")]
			public NativeRealtimeMultiplayerClient _003C_003E4__this;

			[Token(Token = "0x6002F23")]
			[Address(RVA = "0xC60A80", Offset = "0xC60A80", VA = "0xC60A80")]
			public _003C_003Ec__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6002F24")]
			[Address(RVA = "0xC60A88", Offset = "0xC60A88", VA = "0xC60A88")]
			internal void _003CDeclineInvitation_003Eb__0(RealtimeManager.FetchInvitationsResponse response)
			{
			}
		}

		[Token(Token = "0x4000D08")]
		[FieldOffset(Offset = "0x10")]
		private readonly object mSessionLock;

		[Token(Token = "0x4000D09")]
		[FieldOffset(Offset = "0x18")]
		private readonly NativeClient mNativeClient;

		[Token(Token = "0x4000D0A")]
		[FieldOffset(Offset = "0x20")]
		private readonly RealtimeManager mRealtimeManager;

		[Token(Token = "0x4000D0B")]
		[FieldOffset(Offset = "0x28")]
		private RoomSession mCurrentSession;

		[Token(Token = "0x6001196")]
		[Address(RVA = "0x13341A8", Offset = "0x13341A8", VA = "0x13341A8")]
		internal NativeRealtimeMultiplayerClient(NativeClient nativeClient, RealtimeManager manager)
		{
		}

		[Token(Token = "0x6001197")]
		[Address(RVA = "0x133B09C", Offset = "0x133B09C", VA = "0x133B09C")]
		private RoomSession GetTerminatedSession()
		{
			return null;
		}

		[Token(Token = "0x6001198")]
		[Address(RVA = "0x133B16C", Offset = "0x133B16C", VA = "0x133B16C", Slot = "4")]
		public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, RealTimeMultiplayerListener listener)
		{
		}

		[Token(Token = "0x6001199")]
		[Address(RVA = "0x133B17C", Offset = "0x133B17C", VA = "0x133B17C", Slot = "5")]
		public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, RealTimeMultiplayerListener listener)
		{
		}

		[Token(Token = "0x600119A")]
		[Address(RVA = "0x133B9C8", Offset = "0x133B9C8", VA = "0x133B9C8")]
		private static GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper HelperForSession(RoomSession session)
		{
			return null;
		}

		[Token(Token = "0x600119B")]
		[Address(RVA = "0x133BB98", Offset = "0x133BB98", VA = "0x133BB98")]
		private void HandleAppPausing(bool paused)
		{
		}

		[Token(Token = "0x600119C")]
		[Address(RVA = "0x133BC64", Offset = "0x133BC64", VA = "0x133BC64", Slot = "6")]
		public void CreateWithInvitationScreen(uint minOpponents, uint maxOppponents, uint variant, RealTimeMultiplayerListener listener)
		{
		}

		[Token(Token = "0x600119D")]
		[Address(RVA = "0x133BF58", Offset = "0x133BF58", VA = "0x133BF58", Slot = "7")]
		public void ShowWaitingRoomUI()
		{
		}

		[Token(Token = "0x600119E")]
		[Address(RVA = "0x133C010", Offset = "0x133C010", VA = "0x133C010", Slot = "8")]
		public void GetAllInvitations(Action<Invitation[]> callback)
		{
		}

		[Token(Token = "0x600119F")]
		[Address(RVA = "0x133C0E0", Offset = "0x133C0E0", VA = "0x133C0E0", Slot = "9")]
		public void AcceptFromInbox(RealTimeMultiplayerListener listener)
		{
		}

		[Token(Token = "0x60011A0")]
		[Address(RVA = "0x133C364", Offset = "0x133C364", VA = "0x133C364", Slot = "10")]
		public void AcceptInvitation(string invitationId, RealTimeMultiplayerListener listener)
		{
		}

		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x133C608", Offset = "0x133C608", VA = "0x133C608", Slot = "18")]
		public Invitation GetInvitation()
		{
			return null;
		}

		[Token(Token = "0x60011A2")]
		[Address(RVA = "0x133BC30", Offset = "0x133BC30", VA = "0x133BC30", Slot = "19")]
		public void LeaveRoom()
		{
		}

		[Token(Token = "0x60011A3")]
		[Address(RVA = "0x133C63C", Offset = "0x133C63C", VA = "0x133C63C", Slot = "11")]
		public void SendMessageToAll(bool reliable, byte[] data)
		{
		}

		[Token(Token = "0x60011A4")]
		[Address(RVA = "0x133C688", Offset = "0x133C688", VA = "0x133C688", Slot = "12")]
		public void SendMessageToAll(bool reliable, byte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x60011A5")]
		[Address(RVA = "0x133C6EC", Offset = "0x133C6EC", VA = "0x133C6EC", Slot = "13")]
		public void SendMessage(bool reliable, string participantId, byte[] data)
		{
		}

		[Token(Token = "0x60011A6")]
		[Address(RVA = "0x133C740", Offset = "0x133C740", VA = "0x133C740", Slot = "14")]
		public void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x60011A7")]
		[Address(RVA = "0x133C7AC", Offset = "0x133C7AC", VA = "0x133C7AC", Slot = "15")]
		public List<Participant> GetConnectedParticipants()
		{
			return null;
		}

		[Token(Token = "0x60011A8")]
		[Address(RVA = "0x133C7E0", Offset = "0x133C7E0", VA = "0x133C7E0", Slot = "16")]
		public Participant GetSelf()
		{
			return null;
		}

		[Token(Token = "0x60011A9")]
		[Address(RVA = "0x133C818", Offset = "0x133C818", VA = "0x133C818", Slot = "17")]
		public Participant GetParticipant(string participantId)
		{
			return null;
		}

		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x133C858", Offset = "0x133C858", VA = "0x133C858", Slot = "20")]
		public bool IsRoomConnected()
		{
			return default(bool);
		}

		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x133C890", Offset = "0x133C890", VA = "0x133C890", Slot = "21")]
		public void DeclineInvitation(string invitationId)
		{
		}

		[Token(Token = "0x60011AC")]
		private static T WithDefault<T>(T presented, T defaultValue) where T : class
		{
			return null;
		}
	}
}
