using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x2000258")]
	public class NativeClient : IPlayGamesClient
	{
		[Token(Token = "0x2000698")]
		private enum AuthState
		{
			[Token(Token = "0x400200D")]
			Unauthenticated = 0,
			[Token(Token = "0x400200E")]
			Authenticated = 1
		}

		[Token(Token = "0x2000699")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820888", Offset = "0x820888")]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			[Token(Token = "0x400200F")]
			[FieldOffset(Offset = "0x10")]
			public NativeClient _003C_003E4__this;

			[Token(Token = "0x4002010")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool, string> callback;

			[Token(Token = "0x6002E5D")]
			[Address(RVA = "0x1332EB8", Offset = "0x1332EB8", VA = "0x1332EB8")]
			public _003C_003Ec__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6002E5E")]
			[Address(RVA = "0x133738C", Offset = "0x133738C", VA = "0x133738C")]
			internal void _003CAuthenticate_003Eb__0(int result)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200069A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820898", Offset = "0x820898")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002011")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4002012")]
			[FieldOffset(Offset = "0x8")]
			public static Action<GooglePlayGames.BasicApi.Achievement[]> _003C_003E9__21_1;

			[Token(Token = "0x6002E60")]
			[Address(RVA = "0x1337380", Offset = "0x1337380", VA = "0x1337380")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6002E61")]
			[Address(RVA = "0x1337388", Offset = "0x1337388", VA = "0x1337388")]
			internal void _003CAuthenticate_003Eb__21_1(GooglePlayGames.BasicApi.Achievement[] ignore)
			{
			}
		}

		[Token(Token = "0x200069B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8208A8", Offset = "0x8208A8")]
		private sealed class _003C_003Ec__DisplayClass22_0<T>
		{
			[Token(Token = "0x4002013")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> callback;

			[Token(Token = "0x6002E62")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6002E63")]
			internal void _003CAsOnGameThreadCallback_003Eb__1(T result)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200069C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8208B8", Offset = "0x8208B8")]
		private sealed class _003C_003Ec__22<T>
		{
			[Token(Token = "0x4002014")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__22<T> _003C_003E9;

			[Token(Token = "0x4002015")]
			[FieldOffset(Offset = "0x0")]
			public static Action<T> _003C_003E9__22_0;

			[Token(Token = "0x6002E65")]
			public _003C_003Ec__22()
			{
			}

			[Token(Token = "0x6002E66")]
			internal void _003CAsOnGameThreadCallback_003Eb__22_0(T _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x200069D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8208C8", Offset = "0x8208C8")]
		private sealed class _003C_003Ec__DisplayClass23_0<T, S>
		{
			[Token(Token = "0x4002016")]
			[FieldOffset(Offset = "0x0")]
			public Action<T, S> callback;

			[Token(Token = "0x4002017")]
			[FieldOffset(Offset = "0x0")]
			public T data;

			[Token(Token = "0x4002018")]
			[FieldOffset(Offset = "0x0")]
			public S msg;

			[Token(Token = "0x6002E67")]
			public _003C_003Ec__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6002E68")]
			internal void _003CInvokeCallbackOnGameThread_003Eb__0()
			{
			}
		}

		[Token(Token = "0x200069E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8208D8", Offset = "0x8208D8")]
		private sealed class _003C_003Ec__DisplayClass24_0<T>
		{
			[Token(Token = "0x4002019")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> callback;

			[Token(Token = "0x400201A")]
			[FieldOffset(Offset = "0x0")]
			public T data;

			[Token(Token = "0x6002E69")]
			public _003C_003Ec__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6002E6A")]
			internal void _003CInvokeCallbackOnGameThread_003Eb__0()
			{
			}
		}

		[Token(Token = "0x200069F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8208E8", Offset = "0x8208E8")]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			[Token(Token = "0x400201B")]
			[FieldOffset(Offset = "0x10")]
			public Action<Invitation, bool> currentHandler;

			[Token(Token = "0x400201C")]
			[FieldOffset(Offset = "0x18")]
			public Invitation invite;

			[Token(Token = "0x400201D")]
			[FieldOffset(Offset = "0x20")]
			public bool shouldAutolaunch;

			[Token(Token = "0x6002E6B")]
			[Address(RVA = "0x1334684", Offset = "0x1334684", VA = "0x1334684")]
			public _003C_003Ec__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6002E6C")]
			[Address(RVA = "0x13375E4", Offset = "0x13375E4", VA = "0x13375E4")]
			internal void _003CHandleInvitation_003Eb__0()
			{
			}
		}

		[Token(Token = "0x20006A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8208F8", Offset = "0x8208F8")]
		private sealed class _003C_003Ec__DisplayClass33_0
		{
			[Token(Token = "0x400201E")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> callback;

			[Token(Token = "0x400201F")]
			[FieldOffset(Offset = "0x18")]
			public NativeClient _003C_003E4__this;

			[Token(Token = "0x4002020")]
			[FieldOffset(Offset = "0x20")]
			public Action _003C_003E9__3;

			[Token(Token = "0x4002021")]
			[FieldOffset(Offset = "0x28")]
			public Action _003C_003E9__4;

			[Token(Token = "0x6002E6D")]
			[Address(RVA = "0x1334D04", Offset = "0x1334D04", VA = "0x1334D04")]
			public _003C_003Ec__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6002E6E")]
			[Address(RVA = "0x133765C", Offset = "0x133765C", VA = "0x133765C")]
			internal void _003CLoadFriends_003Eb__0()
			{
			}

			[Token(Token = "0x6002E6F")]
			[Address(RVA = "0x13376C0", Offset = "0x13376C0", VA = "0x13376C0")]
			internal void _003CLoadFriends_003Eb__1()
			{
			}

			[Token(Token = "0x6002E70")]
			[Address(RVA = "0x1337724", Offset = "0x1337724", VA = "0x1337724")]
			internal void _003CLoadFriends_003Eb__2(ResponseStatus status, List<GooglePlayGames.BasicApi.Multiplayer.Player> players)
			{
			}

			[Token(Token = "0x6002E71")]
			[Address(RVA = "0x1337924", Offset = "0x1337924", VA = "0x1337924")]
			internal void _003CLoadFriends_003Eb__3()
			{
			}

			[Token(Token = "0x6002E72")]
			[Address(RVA = "0x1337988", Offset = "0x1337988", VA = "0x1337988")]
			internal void _003CLoadFriends_003Eb__4()
			{
			}
		}

		[Token(Token = "0x20006A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820908", Offset = "0x820908")]
		private sealed class _003C_003Ec__DisplayClass37_0
		{
			[Token(Token = "0x4002022")]
			[FieldOffset(Offset = "0x10")]
			public uint currentAuthGeneration;

			[Token(Token = "0x4002023")]
			[FieldOffset(Offset = "0x18")]
			public NativeClient _003C_003E4__this;

			[Token(Token = "0x6002E73")]
			[Address(RVA = "0x1335960", Offset = "0x1335960", VA = "0x1335960")]
			public _003C_003Ec__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6002E74")]
			[Address(RVA = "0x13379EC", Offset = "0x13379EC", VA = "0x13379EC")]
			internal void _003CHandleAuthTransition_003Eb__0(GooglePlayGames.Native.PInvoke.PlayerManager.FetchSelfResponse results)
			{
			}
		}

		[Token(Token = "0x20006A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820918", Offset = "0x820918")]
		private sealed class _003C_003Ec__DisplayClass43_0
		{
			[Token(Token = "0x4002024")]
			[FieldOffset(Offset = "0x10")]
			public NativeClient _003C_003E4__this;

			[Token(Token = "0x4002025")]
			[FieldOffset(Offset = "0x18")]
			public Gravity gravity;

			[Token(Token = "0x6002E75")]
			[Address(RVA = "0x1335CCC", Offset = "0x1335CCC", VA = "0x1335CCC")]
			public _003C_003Ec__DisplayClass43_0()
			{
			}

			[Token(Token = "0x6002E76")]
			[Address(RVA = "0x1337A30", Offset = "0x1337A30", VA = "0x1337A30")]
			internal void _003CSetGravityForPopups_003Eb__0()
			{
			}
		}

		[Token(Token = "0x20006A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820928", Offset = "0x820928")]
		private sealed class _003C_003Ec__DisplayClass44_0
		{
			[Token(Token = "0x4002026")]
			[FieldOffset(Offset = "0x10")]
			public NativeClient _003C_003E4__this;

			[Token(Token = "0x4002027")]
			[FieldOffset(Offset = "0x18")]
			public Action<CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback;

			[Token(Token = "0x6002E77")]
			[Address(RVA = "0x1335DB8", Offset = "0x1335DB8", VA = "0x1335DB8")]
			public _003C_003Ec__DisplayClass44_0()
			{
			}

			[Token(Token = "0x6002E78")]
			[Address(RVA = "0x1337B3C", Offset = "0x1337B3C", VA = "0x1337B3C")]
			internal void _003CGetPlayerStats_003Eb__0()
			{
			}
		}

		[Token(Token = "0x20006A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820938", Offset = "0x820938")]
		private sealed class _003C_003Ec__DisplayClass45_0
		{
			[Token(Token = "0x4002028")]
			[FieldOffset(Offset = "0x10")]
			public Action<IUserProfile[]> callback;

			[Token(Token = "0x6002E79")]
			[Address(RVA = "0x1335EB0", Offset = "0x1335EB0", VA = "0x1335EB0")]
			public _003C_003Ec__DisplayClass45_0()
			{
			}

			[Token(Token = "0x6002E7A")]
			[Address(RVA = "0x1337C48", Offset = "0x1337C48", VA = "0x1337C48")]
			internal void _003CLoadUsers_003Eb__0(NativePlayer[] nativeUsers)
			{
			}
		}

		[Token(Token = "0x20006A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820948", Offset = "0x820948")]
		private sealed class _003C_003Ec__DisplayClass45_1
		{
			[Token(Token = "0x4002029")]
			[FieldOffset(Offset = "0x10")]
			public IUserProfile[] users;

			[Token(Token = "0x400202A")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass45_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6002E7B")]
			[Address(RVA = "0x1337E14", Offset = "0x1337E14", VA = "0x1337E14")]
			public _003C_003Ec__DisplayClass45_1()
			{
			}

			[Token(Token = "0x6002E7C")]
			[Address(RVA = "0x1337E1C", Offset = "0x1337E1C", VA = "0x1337E1C")]
			internal void _003CLoadUsers_003Eb__1()
			{
			}
		}

		[Token(Token = "0x20006A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820958", Offset = "0x820958")]
		private sealed class _003C_003Ec__DisplayClass46_0
		{
			[Token(Token = "0x400202B")]
			[FieldOffset(Offset = "0x10")]
			public Action<GooglePlayGames.BasicApi.Achievement[]> callback;

			[Token(Token = "0x6002E7D")]
			[Address(RVA = "0x1336040", Offset = "0x1336040", VA = "0x1336040")]
			public _003C_003Ec__DisplayClass46_0()
			{
			}

			[Token(Token = "0x6002E7E")]
			[Address(RVA = "0x1337E94", Offset = "0x1337E94", VA = "0x1337E94")]
			internal void _003CLoadAchievements_003Eb__0(GooglePlayGames.Native.PInvoke.AchievementManager.FetchAllResponse response)
			{
			}
		}

		[Token(Token = "0x20006A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820968", Offset = "0x820968")]
		private sealed class _003C_003Ec__DisplayClass51_0
		{
			[Token(Token = "0x400202C")]
			[FieldOffset(Offset = "0x10")]
			public Action<UIStatus> cb;

			[Token(Token = "0x6002E7F")]
			[Address(RVA = "0x1336658", Offset = "0x1336658", VA = "0x1336658")]
			public _003C_003Ec__DisplayClass51_0()
			{
			}

			[Token(Token = "0x6002E80")]
			[Address(RVA = "0x133839C", Offset = "0x133839C", VA = "0x133839C")]
			internal void _003CShowAchievementsUI_003Eb__0(CommonErrorStatus.UIStatus result)
			{
			}
		}

		[Token(Token = "0x20006A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820978", Offset = "0x820978")]
		private sealed class _003C_003Ec__DisplayClass53_0
		{
			[Token(Token = "0x400202D")]
			[FieldOffset(Offset = "0x10")]
			public Action<UIStatus> cb;

			[Token(Token = "0x6002E81")]
			[Address(RVA = "0x133683C", Offset = "0x133683C", VA = "0x133683C")]
			public _003C_003Ec__DisplayClass53_0()
			{
			}

			[Token(Token = "0x6002E82")]
			[Address(RVA = "0x133840C", Offset = "0x133840C", VA = "0x133840C")]
			internal void _003CShowLeaderboardUI_003Eb__0(CommonErrorStatus.UIStatus result)
			{
			}
		}

		[Token(Token = "0x20006A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820988", Offset = "0x820988")]
		private sealed class _003C_003Ec__DisplayClass63_0
		{
			[Token(Token = "0x400202E")]
			[FieldOffset(Offset = "0x10")]
			public InvitationReceivedDelegate invitationDelegate;

			[Token(Token = "0x6002E83")]
			[Address(RVA = "0x1337040", Offset = "0x1337040", VA = "0x1337040")]
			public _003C_003Ec__DisplayClass63_0()
			{
			}

			[Token(Token = "0x6002E84")]
			[Address(RVA = "0x133847C", Offset = "0x133847C", VA = "0x133847C")]
			internal void _003CRegisterInvitationDelegate_003Eb__0(Invitation invitation, bool autoAccept)
			{
			}
		}

		[Token(Token = "0x4000CF2")]
		[FieldOffset(Offset = "0x10")]
		private readonly IClientImpl clientImpl;

		[Token(Token = "0x4000CF3")]
		[FieldOffset(Offset = "0x18")]
		private readonly object GameServicesLock;

		[Token(Token = "0x4000CF4")]
		[FieldOffset(Offset = "0x20")]
		private readonly object AuthStateLock;

		[Token(Token = "0x4000CF5")]
		[FieldOffset(Offset = "0x28")]
		private readonly PlayGamesClientConfiguration mConfiguration;

		[Token(Token = "0x4000CF6")]
		[FieldOffset(Offset = "0x58")]
		private GooglePlayGames.Native.PInvoke.GameServices mServices;

		[Token(Token = "0x4000CF7")]
		[FieldOffset(Offset = "0x60")]
		private NativeTurnBasedMultiplayerClient mTurnBasedClient;

		[Token(Token = "0x4000CF8")]
		[FieldOffset(Offset = "0x68")]
		private NativeRealtimeMultiplayerClient mRealTimeClient;

		[Token(Token = "0x4000CF9")]
		[FieldOffset(Offset = "0x70")]
		private ISavedGameClient mSavedGameClient;

		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x78")]
		private IEventsClient mEventsClient;

		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x80")]
		private IVideoClient mVideoClient;

		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x88")]
		private TokenClient mTokenClient;

		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0x90")]
		private Action<Invitation, bool> mInvitationDelegate;

		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x98")]
		private GooglePlayGames.BasicApi.Multiplayer.Player mUser;

		[Token(Token = "0x4000CFF")]
		[FieldOffset(Offset = "0xA0")]
		private List<GooglePlayGames.BasicApi.Multiplayer.Player> mFriends;

		[Token(Token = "0x4000D00")]
		[FieldOffset(Offset = "0xA8")]
		private Action<bool, string> mPendingAuthCallbacks;

		[Token(Token = "0x4000D01")]
		[FieldOffset(Offset = "0xB0")]
		private AuthState mAuthState;

		[Token(Token = "0x4000D02")]
		[FieldOffset(Offset = "0xB4")]
		private uint mAuthGeneration;

		[Token(Token = "0x4000D03")]
		[FieldOffset(Offset = "0xB8")]
		private bool friendsLoading;

		[Token(Token = "0x6001149")]
		[Address(RVA = "0x1332A64", Offset = "0x1332A64", VA = "0x1332A64")]
		internal NativeClient(PlayGamesClientConfiguration configuration, IClientImpl clientImpl)
		{
		}

		[Token(Token = "0x600114A")]
		[Address(RVA = "0x1332B8C", Offset = "0x1332B8C", VA = "0x1332B8C")]
		private GooglePlayGames.Native.PInvoke.GameServices GameServices()
		{
			return null;
		}

		[Token(Token = "0x600114B")]
		[Address(RVA = "0x1332C34", Offset = "0x1332C34", VA = "0x1332C34", Slot = "4")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		[Token(Token = "0x600114C")]
		private static Action<T> AsOnGameThreadCallback<T>(Action<T> callback)
		{
			return null;
		}

		[Token(Token = "0x600114D")]
		private static void InvokeCallbackOnGameThread<T, S>(Action<T, S> callback, T data, S msg)
		{
		}

		[Token(Token = "0x600114E")]
		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data)
		{
		}

		[Token(Token = "0x600114F")]
		[Address(RVA = "0x13336E4", Offset = "0x13336E4", VA = "0x13336E4")]
		private void InitializeGameServices()
		{
		}

		[Token(Token = "0x6001150")]
		[Address(RVA = "0x1332EC0", Offset = "0x1332EC0", VA = "0x1332EC0")]
		private void InitializeTokenClient()
		{
		}

		[Token(Token = "0x6001151")]
		[Address(RVA = "0x13342C4", Offset = "0x13342C4", VA = "0x13342C4")]
		internal void HandleInvitation(Types.MultiplayerEvent eventType, string invitationId, GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
		{
		}

		[Token(Token = "0x6001152")]
		[Address(RVA = "0x133468C", Offset = "0x133468C", VA = "0x133468C", Slot = "13")]
		public string GetUserEmail()
		{
			return null;
		}

		[Token(Token = "0x6001153")]
		[Address(RVA = "0x133484C", Offset = "0x133484C", VA = "0x133484C", Slot = "10")]
		public string GetIdToken()
		{
			return null;
		}

		[Token(Token = "0x6001154")]
		[Address(RVA = "0x1334958", Offset = "0x1334958", VA = "0x1334958", Slot = "11")]
		public string GetServerAuthCode()
		{
			return null;
		}

		[Token(Token = "0x6001155")]
		[Address(RVA = "0x1334A64", Offset = "0x1334A64", VA = "0x1334A64", Slot = "12")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Token(Token = "0x6001156")]
		[Address(RVA = "0x1334794", Offset = "0x1334794", VA = "0x1334794", Slot = "5")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		[Token(Token = "0x6001157")]
		[Address(RVA = "0x1334B38", Offset = "0x1334B38", VA = "0x1334B38", Slot = "8")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Token(Token = "0x6001158")]
		[Address(RVA = "0x1334D0C", Offset = "0x1334D0C", VA = "0x1334D0C", Slot = "35")]
		public IUserProfile[] GetFriends()
		{
			return null;
		}

		[Token(Token = "0x6001159")]
		[Address(RVA = "0x1334E30", Offset = "0x1334E30", VA = "0x1334E30")]
		private void MaybeFinishAuthentication()
		{
		}

		[Token(Token = "0x600115A")]
		[Address(RVA = "0x133508C", Offset = "0x133508C", VA = "0x133508C")]
		private void PopulateUser(uint authGeneration, GooglePlayGames.Native.PInvoke.PlayerManager.FetchSelfResponse response)
		{
		}

		[Token(Token = "0x600115B")]
		[Address(RVA = "0x1335488", Offset = "0x1335488", VA = "0x1335488")]
		private void HandleAuthTransition(Types.AuthOperation operation, CommonErrorStatus.AuthStatus status)
		{
		}

		[Token(Token = "0x600115C")]
		[Address(RVA = "0x1335968", Offset = "0x1335968", VA = "0x1335968")]
		private void ToUnauthenticated()
		{
		}

		[Token(Token = "0x600115D")]
		[Address(RVA = "0x133538C", Offset = "0x133538C", VA = "0x133538C", Slot = "6")]
		public void SignOut()
		{
		}

		[Token(Token = "0x600115E")]
		[Address(RVA = "0x1335AEC", Offset = "0x1335AEC", VA = "0x1335AEC", Slot = "7")]
		public string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x600115F")]
		[Address(RVA = "0x1335B40", Offset = "0x1335B40", VA = "0x1335B40", Slot = "9")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Token(Token = "0x6001160")]
		[Address(RVA = "0x1335B94", Offset = "0x1335B94", VA = "0x1335B94", Slot = "14")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Token(Token = "0x6001161")]
		[Address(RVA = "0x1335BE8", Offset = "0x1335BE8", VA = "0x1335BE8", Slot = "37")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		[Token(Token = "0x6001162")]
		[Address(RVA = "0x1335CD4", Offset = "0x1335CD4", VA = "0x1335CD4", Slot = "15")]
		public void GetPlayerStats(Action<CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
		{
		}

		[Token(Token = "0x6001163")]
		[Address(RVA = "0x1335DC0", Offset = "0x1335DC0", VA = "0x1335DC0", Slot = "16")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Token(Token = "0x6001164")]
		[Address(RVA = "0x1335EB8", Offset = "0x1335EB8", VA = "0x1335EB8", Slot = "17")]
		public void LoadAchievements(Action<GooglePlayGames.BasicApi.Achievement[]> callback)
		{
		}

		[Token(Token = "0x6001165")]
		[Address(RVA = "0x1336048", Offset = "0x1336048", VA = "0x1336048", Slot = "18")]
		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x6001166")]
		[Address(RVA = "0x1336128", Offset = "0x1336128", VA = "0x1336128", Slot = "19")]
		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x6001167")]
		[Address(RVA = "0x1336208", Offset = "0x1336208", VA = "0x1336208", Slot = "20")]
		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x6001168")]
		[Address(RVA = "0x1336388", Offset = "0x1336388", VA = "0x1336388", Slot = "21")]
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x6001169")]
		[Address(RVA = "0x1336508", Offset = "0x1336508", VA = "0x1336508", Slot = "22")]
		public void ShowAchievementsUI(Action<UIStatus> cb)
		{
		}

		[Token(Token = "0x600116A")]
		[Address(RVA = "0x1336660", Offset = "0x1336660", VA = "0x1336660", Slot = "26")]
		public int LeaderboardMaxResults()
		{
			return default(int);
		}

		[Token(Token = "0x600116B")]
		[Address(RVA = "0x13366A8", Offset = "0x13366A8", VA = "0x13366A8", Slot = "23")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> cb)
		{
		}

		[Token(Token = "0x600116C")]
		[Address(RVA = "0x1336844", Offset = "0x1336844", VA = "0x1336844", Slot = "24")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x600116D")]
		[Address(RVA = "0x1336950", Offset = "0x1336950", VA = "0x1336950", Slot = "25")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x600116E")]
		[Address(RVA = "0x1336A08", Offset = "0x1336A08", VA = "0x1336A08", Slot = "27")]
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		[Token(Token = "0x600116F")]
		[Address(RVA = "0x1336B60", Offset = "0x1336B60", VA = "0x1336B60", Slot = "28")]
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		[Token(Token = "0x6001170")]
		[Address(RVA = "0x1336CBC", Offset = "0x1336CBC", VA = "0x1336CBC", Slot = "29")]
		public IRealTimeMultiplayerClient GetRtmpClient()
		{
			return null;
		}

		[Token(Token = "0x6001171")]
		[Address(RVA = "0x1336D80", Offset = "0x1336D80", VA = "0x1336D80", Slot = "30")]
		public ITurnBasedMultiplayerClient GetTbmpClient()
		{
			return null;
		}

		[Token(Token = "0x6001172")]
		[Address(RVA = "0x1336E30", Offset = "0x1336E30", VA = "0x1336E30", Slot = "31")]
		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		[Token(Token = "0x6001173")]
		[Address(RVA = "0x1336EE0", Offset = "0x1336EE0", VA = "0x1336EE0", Slot = "32")]
		public IEventsClient GetEventsClient()
		{
			return null;
		}

		[Token(Token = "0x6001174")]
		[Address(RVA = "0x1336F90", Offset = "0x1336F90", VA = "0x1336F90", Slot = "33")]
		public IVideoClient GetVideoClient()
		{
			return null;
		}

		[Token(Token = "0x6001175")]
		[Address(RVA = "0x1334024", Offset = "0x1334024", VA = "0x1334024", Slot = "34")]
		public void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
		{
		}

		[Token(Token = "0x6001176")]
		[Address(RVA = "0x1337048", Offset = "0x1337048", VA = "0x1337048", Slot = "36")]
		public IntPtr GetApiClient()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6001177")]
		[Address(RVA = "0x1337080", Offset = "0x1337080", VA = "0x1337080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835C08", Offset = "0x835C08")]
		private void _003CInitializeGameServices_003Eb__25_0(Types.MultiplayerEvent eventType, string matchId, NativeTurnBasedMatch match)
		{
		}

		[Token(Token = "0x6001178")]
		[Address(RVA = "0x13370D4", Offset = "0x13370D4", VA = "0x13370D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835C18", Offset = "0x835C18")]
		private void _003CGetFriends_003Eb__34_0(bool ok)
		{
		}
	}
}
