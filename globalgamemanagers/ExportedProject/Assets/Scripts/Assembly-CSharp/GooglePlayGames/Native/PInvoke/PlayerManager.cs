using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200028D")]
	internal class PlayerManager
	{
		[Token(Token = "0x2000714")]
		internal class FetchListResponse : BaseReferenceHolder, IEnumerable<NativePlayer>, IEnumerable
		{
			[Token(Token = "0x6002FEF")]
			[Address(RVA = "0xE62204", Offset = "0xE62204", VA = "0xE62204")]
			internal FetchListResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6002FF0")]
			[Address(RVA = "0xE6227C", Offset = "0xE6227C", VA = "0xE6227C", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6002FF1")]
			[Address(RVA = "0xE62098", Offset = "0xE62098", VA = "0xE62098")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x6002FF2")]
			[Address(RVA = "0xE620D0", Offset = "0xE620D0", VA = "0xE620D0", Slot = "6")]
			public IEnumerator<NativePlayer> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6002FF3")]
			[Address(RVA = "0xE62298", Offset = "0xE62298", VA = "0xE62298", Slot = "7")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6002FF4")]
			[Address(RVA = "0xE620B4", Offset = "0xE620B4", VA = "0xE620B4")]
			internal UIntPtr Length()
			{
				return default(UIntPtr);
			}

			[Token(Token = "0x6002FF5")]
			[Address(RVA = "0xE6229C", Offset = "0xE6229C", VA = "0xE6229C")]
			internal NativePlayer GetElement(UIntPtr index)
			{
				return null;
			}

			[Token(Token = "0x6002FF6")]
			[Address(RVA = "0xE6239C", Offset = "0xE6239C", VA = "0xE6239C")]
			internal static FetchListResponse FromPointer(IntPtr selfPointer)
			{
				return null;
			}

			[Token(Token = "0x6002FF7")]
			[Address(RVA = "0xE62430", Offset = "0xE62430", VA = "0xE62430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B6FC", Offset = "0x83B6FC")]
			private NativePlayer _003CGetEnumerator_003Eb__3_0(UIntPtr index)
			{
				return null;
			}
		}

		[Token(Token = "0x2000715")]
		internal class FetchResponseCollector
		{
			[Token(Token = "0x400210E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int pendingCount;

			[Token(Token = "0x400210F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal List<NativePlayer> results;

			[Token(Token = "0x4002110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Action<NativePlayer[]> callback;

			[Token(Token = "0x6002FF8")]
			[Address(RVA = "0xE61864", Offset = "0xE61864", VA = "0xE61864")]
			public FetchResponseCollector()
			{
			}
		}

		[Token(Token = "0x2000716")]
		internal class FetchResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6002FF9")]
			[Address(RVA = "0xE62434", Offset = "0xE62434", VA = "0xE62434")]
			internal FetchResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6002FFA")]
			[Address(RVA = "0xE624AC", Offset = "0xE624AC", VA = "0xE624AC", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6002FFB")]
			[Address(RVA = "0xE61AA0", Offset = "0xE61AA0", VA = "0xE61AA0")]
			internal NativePlayer GetPlayer()
			{
				return null;
			}

			[Token(Token = "0x6002FFC")]
			[Address(RVA = "0xE61A84", Offset = "0xE61A84", VA = "0xE61A84")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x6002FFD")]
			[Address(RVA = "0xE624C8", Offset = "0xE624C8", VA = "0xE624C8")]
			internal static FetchResponse FromPointer(IntPtr selfPointer)
			{
				return null;
			}
		}

		[Token(Token = "0x2000717")]
		internal class FetchSelfResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6002FFE")]
			[Address(RVA = "0xE6255C", Offset = "0xE6255C", VA = "0xE6255C")]
			internal FetchSelfResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6002FFF")]
			[Address(RVA = "0xE625D4", Offset = "0xE625D4", VA = "0xE625D4")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x6003000")]
			[Address(RVA = "0xE625F0", Offset = "0xE625F0", VA = "0xE625F0")]
			internal NativePlayer Self()
			{
				return null;
			}

			[Token(Token = "0x6003001")]
			[Address(RVA = "0xE6266C", Offset = "0xE6266C", VA = "0xE6266C", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6003002")]
			[Address(RVA = "0xE62688", Offset = "0xE62688", VA = "0xE62688")]
			internal static FetchSelfResponse FromPointer(IntPtr selfPointer)
			{
				return null;
			}
		}

		[Token(Token = "0x2000718")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E58", Offset = "0x820E58")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x4002111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayerManager _003C_003E4__this;

			[Token(Token = "0x4002112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FetchResponseCollector coll;

			[Token(Token = "0x4002113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<FetchResponse> _003C_003E9__0;

			[Token(Token = "0x6003003")]
			[Address(RVA = "0xE6185C", Offset = "0xE6185C", VA = "0xE6185C")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6003004")]
			[Address(RVA = "0xE6219C", Offset = "0xE6219C", VA = "0xE6219C")]
			internal void _003CFetchList_003Eb__0(FetchResponse rsp)
			{
			}
		}

		[Token(Token = "0x2000719")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E68", Offset = "0x820E68")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4002114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayerManager _003C_003E4__this;

			[Token(Token = "0x4002115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<ResponseStatus, List<GooglePlayGames.BasicApi.Multiplayer.Player>> callback;

			[Token(Token = "0x6003005")]
			[Address(RVA = "0xE61CBC", Offset = "0xE61CBC", VA = "0xE61CBC")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6003006")]
			[Address(RVA = "0xE621D0", Offset = "0xE621D0", VA = "0xE621D0")]
			internal void _003CFetchFriends_003Eb__0(FetchListResponse rsp)
			{
			}
		}

		[Token(Token = "0x4000D24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly GameServices mGameServices;

		[Token(Token = "0x600138F")]
		[Address(RVA = "0xE61438", Offset = "0xE61438", VA = "0xE61438")]
		internal PlayerManager(GameServices services)
		{
		}

		[Token(Token = "0x6001390")]
		[Address(RVA = "0xE614A8", Offset = "0xE614A8", VA = "0xE614A8")]
		internal void FetchSelf(Action<FetchSelfResponse> callback)
		{
		}

		[Token(Token = "0x6001391")]
		[Address(RVA = "0xE612A0", Offset = "0xE612A0", VA = "0xE612A0")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836818", Offset = "0x836818")]
		private static void InternalFetchSelfCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x6001392")]
		[Address(RVA = "0xE615D0", Offset = "0xE615D0", VA = "0xE615D0")]
		internal void FetchList(string[] userIds, Action<NativePlayer[]> callback)
		{
		}

		[Token(Token = "0x6001393")]
		[Address(RVA = "0xE61328", Offset = "0xE61328", VA = "0xE61328")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x83687C", Offset = "0x83687C")]
		private static void InternalFetchCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x6001394")]
		[Address(RVA = "0xE618D4", Offset = "0xE618D4", VA = "0xE618D4")]
		internal void HandleFetchResponse(FetchResponseCollector collector, FetchResponse resp)
		{
		}

		[Token(Token = "0x6001395")]
		[Address(RVA = "0xE61B1C", Offset = "0xE61B1C", VA = "0xE61B1C")]
		internal void FetchFriends(Action<ResponseStatus, List<GooglePlayGames.BasicApi.Multiplayer.Player>> callback)
		{
		}

		[Token(Token = "0x6001396")]
		[Address(RVA = "0xE613B0", Offset = "0xE613B0", VA = "0xE613B0")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8368E0", Offset = "0x8368E0")]
		private static void InternalFetchConnectedCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x6001397")]
		[Address(RVA = "0xE61CC4", Offset = "0xE61CC4", VA = "0xE61CC4")]
		internal void HandleFetchCollected(FetchListResponse rsp, Action<ResponseStatus, List<GooglePlayGames.BasicApi.Multiplayer.Player>> callback)
		{
		}
	}
}
