using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000293")]
	internal class SnapshotManager
	{
		[Token(Token = "0x2000721")]
		internal class OpenResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6003025")]
			[Address(RVA = "0xE67268", Offset = "0xE67268", VA = "0xE67268")]
			internal OpenResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6003026")]
			[Address(RVA = "0xE672E0", Offset = "0xE672E0", VA = "0xE672E0")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			[Token(Token = "0x6003027")]
			[Address(RVA = "0xE67308", Offset = "0xE67308", VA = "0xE67308")]
			internal CommonErrorStatus.SnapshotOpenStatus ResponseStatus()
			{
				return default(CommonErrorStatus.SnapshotOpenStatus);
			}

			[Token(Token = "0x6003028")]
			[Address(RVA = "0xE67324", Offset = "0xE67324", VA = "0xE67324")]
			internal string ConflictId()
			{
				return null;
			}

			[Token(Token = "0x6003029")]
			[Address(RVA = "0xE67414", Offset = "0xE67414", VA = "0xE67414")]
			internal NativeSnapshotMetadata Data()
			{
				return null;
			}

			[Token(Token = "0x600302A")]
			[Address(RVA = "0xE674F0", Offset = "0xE674F0", VA = "0xE674F0")]
			internal NativeSnapshotMetadata ConflictOriginal()
			{
				return null;
			}

			[Token(Token = "0x600302B")]
			[Address(RVA = "0xE675CC", Offset = "0xE675CC", VA = "0xE675CC")]
			internal NativeSnapshotMetadata ConflictUnmerged()
			{
				return null;
			}

			[Token(Token = "0x600302C")]
			[Address(RVA = "0xE676A8", Offset = "0xE676A8", VA = "0xE676A8", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x600302D")]
			[Address(RVA = "0xE676B8", Offset = "0xE676B8", VA = "0xE676B8")]
			internal static OpenResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			[Token(Token = "0x600302E")]
			[Address(RVA = "0xE67754", Offset = "0xE67754", VA = "0xE67754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B71C", Offset = "0x83B71C")]
			private UIntPtr _003CConflictId_003Eb__3_0(byte[] out_string, UIntPtr out_size)
			{
				return default(UIntPtr);
			}
		}

		[Token(Token = "0x2000722")]
		internal class FetchAllResponse : BaseReferenceHolder
		{
			[Token(Token = "0x600302F")]
			[Address(RVA = "0xE66FA8", Offset = "0xE66FA8", VA = "0xE66FA8")]
			internal FetchAllResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6003030")]
			[Address(RVA = "0xE67020", Offset = "0xE67020", VA = "0xE67020")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x6003031")]
			[Address(RVA = "0xE6703C", Offset = "0xE6703C", VA = "0xE6703C")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			[Token(Token = "0x6003032")]
			[Address(RVA = "0xE67064", Offset = "0xE67064", VA = "0xE67064")]
			internal IEnumerable<NativeSnapshotMetadata> Data()
			{
				return null;
			}

			[Token(Token = "0x6003033")]
			[Address(RVA = "0xE67130", Offset = "0xE67130", VA = "0xE67130", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6003034")]
			[Address(RVA = "0xE67140", Offset = "0xE67140", VA = "0xE67140")]
			internal static FetchAllResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			[Token(Token = "0x6003035")]
			[Address(RVA = "0xE671DC", Offset = "0xE671DC", VA = "0xE671DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B72C", Offset = "0x83B72C")]
			private NativeSnapshotMetadata _003CData_003Eb__3_0(UIntPtr index)
			{
				return null;
			}
		}

		[Token(Token = "0x2000723")]
		internal class CommitResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6003036")]
			[Address(RVA = "0xE66D64", Offset = "0xE66D64", VA = "0xE66D64")]
			internal CommitResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6003037")]
			[Address(RVA = "0xE66DDC", Offset = "0xE66DDC", VA = "0xE66DDC")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x6003038")]
			[Address(RVA = "0xE66DF8", Offset = "0xE66DF8", VA = "0xE66DF8")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			[Token(Token = "0x6003039")]
			[Address(RVA = "0xE66E20", Offset = "0xE66E20", VA = "0xE66E20")]
			internal NativeSnapshotMetadata Data()
			{
				return null;
			}

			[Token(Token = "0x600303A")]
			[Address(RVA = "0xE66EFC", Offset = "0xE66EFC", VA = "0xE66EFC", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x600303B")]
			[Address(RVA = "0xE66F0C", Offset = "0xE66F0C", VA = "0xE66F0C")]
			internal static CommitResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		[Token(Token = "0x2000724")]
		internal class ReadResponse : BaseReferenceHolder
		{
			[Token(Token = "0x600303C")]
			[Address(RVA = "0xE67788", Offset = "0xE67788", VA = "0xE67788")]
			internal ReadResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x600303D")]
			[Address(RVA = "0xE67800", Offset = "0xE67800", VA = "0xE67800")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x600303E")]
			[Address(RVA = "0xE6781C", Offset = "0xE6781C", VA = "0xE6781C")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			[Token(Token = "0x600303F")]
			[Address(RVA = "0xE67844", Offset = "0xE67844", VA = "0xE67844")]
			internal byte[] Data()
			{
				return null;
			}

			[Token(Token = "0x6003040")]
			[Address(RVA = "0xE67948", Offset = "0xE67948", VA = "0xE67948", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6003041")]
			[Address(RVA = "0xE67958", Offset = "0xE67958", VA = "0xE67958")]
			internal static ReadResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			[Token(Token = "0x6003042")]
			[Address(RVA = "0xE679F4", Offset = "0xE679F4", VA = "0xE679F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B73C", Offset = "0x83B73C")]
			private UIntPtr _003CData_003Eb__3_0(byte[] out_bytes, UIntPtr out_size)
			{
				return default(UIntPtr);
			}
		}

		[Token(Token = "0x2000725")]
		internal class SnapshotSelectUIResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6003043")]
			[Address(RVA = "0xE67A28", Offset = "0xE67A28", VA = "0xE67A28")]
			internal SnapshotSelectUIResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6003044")]
			[Address(RVA = "0xE67AA0", Offset = "0xE67AA0", VA = "0xE67AA0")]
			internal CommonErrorStatus.UIStatus RequestStatus()
			{
				return default(CommonErrorStatus.UIStatus);
			}

			[Token(Token = "0x6003045")]
			[Address(RVA = "0xE67ABC", Offset = "0xE67ABC", VA = "0xE67ABC")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			[Token(Token = "0x6003046")]
			[Address(RVA = "0xE67AE4", Offset = "0xE67AE4", VA = "0xE67AE4")]
			internal NativeSnapshotMetadata Data()
			{
				return null;
			}

			[Token(Token = "0x6003047")]
			[Address(RVA = "0xE67BC0", Offset = "0xE67BC0", VA = "0xE67BC0", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6003048")]
			[Address(RVA = "0xE67BD0", Offset = "0xE67BD0", VA = "0xE67BD0")]
			internal static SnapshotSelectUIResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		[Token(Token = "0x4000D26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly GameServices mServices;

		[Token(Token = "0x60013D3")]
		[Address(RVA = "0xE66144", Offset = "0xE66144", VA = "0xE66144")]
		internal SnapshotManager(GameServices services)
		{
		}

		[Token(Token = "0x60013D4")]
		[Address(RVA = "0xE661B4", Offset = "0xE661B4", VA = "0xE661B4")]
		internal void FetchAll(Types.DataSource source, Action<FetchAllResponse> callback)
		{
		}

		[Token(Token = "0x60013D5")]
		[Address(RVA = "0xE65E9C", Offset = "0xE65E9C", VA = "0xE65E9C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836E58", Offset = "0x836E58")]
		internal static void InternalFetchAllCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013D6")]
		[Address(RVA = "0xE662E0", Offset = "0xE662E0", VA = "0xE662E0")]
		internal void SnapshotSelectUI(bool allowCreate, bool allowDelete, uint maxSnapshots, string uiTitle, Action<SnapshotSelectUIResponse> callback)
		{
		}

		[Token(Token = "0x60013D7")]
		[Address(RVA = "0xE65F24", Offset = "0xE65F24", VA = "0xE65F24")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836EBC", Offset = "0x836EBC")]
		internal static void InternalSnapshotSelectUICallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013D8")]
		[Address(RVA = "0xE66440", Offset = "0xE66440", VA = "0xE66440")]
		internal void Open(string fileName, Types.DataSource source, Types.SnapshotConflictPolicy conflictPolicy, Action<OpenResponse> callback)
		{
		}

		[Token(Token = "0x60013D9")]
		[Address(RVA = "0xE65FAC", Offset = "0xE65FAC", VA = "0xE65FAC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836F20", Offset = "0x836F20")]
		internal static void InternalOpenCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013DA")]
		[Address(RVA = "0xE665AC", Offset = "0xE665AC", VA = "0xE665AC")]
		internal void Commit(NativeSnapshotMetadata metadata, NativeSnapshotMetadataChange metadataChange, byte[] updatedData, Action<CommitResponse> callback)
		{
		}

		[Token(Token = "0x60013DB")]
		[Address(RVA = "0xE66780", Offset = "0xE66780", VA = "0xE66780")]
		internal void Resolve(NativeSnapshotMetadata metadata, NativeSnapshotMetadataChange metadataChange, string conflictId, Action<OpenResponse> callback)
		{
		}

		[Token(Token = "0x60013DC")]
		[Address(RVA = "0xE6693C", Offset = "0xE6693C", VA = "0xE6693C")]
		internal void Resolve(NativeSnapshotMetadata metadata, NativeSnapshotMetadataChange metadataChange, string conflictId, byte[] updatedData, Action<OpenResponse> callback)
		{
		}

		[Token(Token = "0x60013DD")]
		[Address(RVA = "0xE66034", Offset = "0xE66034", VA = "0xE66034")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836F84", Offset = "0x836F84")]
		internal static void InternalCommitCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013DE")]
		[Address(RVA = "0xE66B44", Offset = "0xE66B44", VA = "0xE66B44")]
		internal void Delete(NativeSnapshotMetadata metadata)
		{
		}

		[Token(Token = "0x60013DF")]
		[Address(RVA = "0xE66BF0", Offset = "0xE66BF0", VA = "0xE66BF0")]
		internal void Read(NativeSnapshotMetadata metadata, Action<ReadResponse> callback)
		{
		}

		[Token(Token = "0x60013E0")]
		[Address(RVA = "0xE660BC", Offset = "0xE660BC", VA = "0xE660BC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836FE8", Offset = "0x836FE8")]
		internal static void InternalReadCallback(IntPtr response, IntPtr data)
		{
		}
	}
}
