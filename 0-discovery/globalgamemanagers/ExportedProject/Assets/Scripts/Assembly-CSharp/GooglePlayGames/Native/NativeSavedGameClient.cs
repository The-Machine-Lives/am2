using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x200025D")]
	internal class NativeSavedGameClient : ISavedGameClient
	{
		[Token(Token = "0x20006CF")]
		private class NativeConflictResolver : IConflictResolver
		{
			[Token(Token = "0x4002073")]
			[FieldOffset(Offset = "0x10")]
			private readonly GooglePlayGames.Native.PInvoke.SnapshotManager mManager;

			[Token(Token = "0x4002074")]
			[FieldOffset(Offset = "0x18")]
			private readonly string mConflictId;

			[Token(Token = "0x4002075")]
			[FieldOffset(Offset = "0x20")]
			private readonly NativeSnapshotMetadata mOriginal;

			[Token(Token = "0x4002076")]
			[FieldOffset(Offset = "0x28")]
			private readonly NativeSnapshotMetadata mUnmerged;

			[Token(Token = "0x4002077")]
			[FieldOffset(Offset = "0x30")]
			private readonly Action<SavedGameRequestStatus, ISavedGameMetadata> mCompleteCallback;

			[Token(Token = "0x4002078")]
			[FieldOffset(Offset = "0x38")]
			private readonly Action mRetryFileOpen;

			[Token(Token = "0x6002F25")]
			[Address(RVA = "0xC69078", Offset = "0xC69078", VA = "0xC69078")]
			internal NativeConflictResolver(GooglePlayGames.Native.PInvoke.SnapshotManager manager, string conflictId, NativeSnapshotMetadata original, NativeSnapshotMetadata unmerged, Action<SavedGameRequestStatus, ISavedGameMetadata> completeCallback, Action retryOpen)
			{
			}

			[Token(Token = "0x6002F26")]
			[Address(RVA = "0xC69434", Offset = "0xC69434", VA = "0xC69434", Slot = "5")]
			public void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData)
			{
			}

			[Token(Token = "0x6002F27")]
			[Address(RVA = "0xC69654", Offset = "0xC69654", VA = "0xC69654", Slot = "4")]
			public void ChooseMetadata(ISavedGameMetadata chosenMetadata)
			{
			}

			[Token(Token = "0x6002F28")]
			[Address(RVA = "0xC6980C", Offset = "0xC6980C", VA = "0xC6980C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B5FC", Offset = "0x83B5FC")]
			private void _003CResolveConflict_003Eb__7_0(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)
			{
			}

			[Token(Token = "0x6002F29")]
			[Address(RVA = "0xC69910", Offset = "0xC69910", VA = "0xC69910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B60C", Offset = "0x83B60C")]
			private void _003CChooseMetadata_003Eb__8_0(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)
			{
			}
		}

		[Token(Token = "0x20006D0")]
		private class Prefetcher
		{
			[Serializable]
			[Token(Token = "0x2000896")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8217B8", Offset = "0x8217B8")]
			private sealed class _003C_003Ec
			{
				[Token(Token = "0x400247C")]
				[FieldOffset(Offset = "0x0")]
				public static readonly _003C_003Ec _003C_003E9;

				[Token(Token = "0x400247D")]
				[FieldOffset(Offset = "0x8")]
				public static Action<SavedGameRequestStatus, ISavedGameMetadata> _003C_003E9__8_0;

				[Token(Token = "0x400247E")]
				[FieldOffset(Offset = "0x10")]
				public static Action<SavedGameRequestStatus, ISavedGameMetadata> _003C_003E9__9_0;

				[Token(Token = "0x60033EA")]
				[Address(RVA = "0xC6A160", Offset = "0xC6A160", VA = "0xC6A160")]
				public _003C_003Ec()
				{
				}

				[Token(Token = "0x60033EB")]
				[Address(RVA = "0xC6A168", Offset = "0xC6A168", VA = "0xC6A168")]
				internal void _003COnOriginalDataRead_003Eb__8_0(SavedGameRequestStatus _003Cp0_003E, ISavedGameMetadata _003Cp1_003E)
				{
				}

				[Token(Token = "0x60033EC")]
				[Address(RVA = "0xC6A16C", Offset = "0xC6A16C", VA = "0xC6A16C")]
				internal void _003COnUnmergedDataRead_003Eb__9_0(SavedGameRequestStatus _003Cp0_003E, ISavedGameMetadata _003Cp1_003E)
				{
				}
			}

			[Token(Token = "0x4002079")]
			[FieldOffset(Offset = "0x10")]
			private readonly object mLock;

			[Token(Token = "0x400207A")]
			[FieldOffset(Offset = "0x18")]
			private bool mOriginalDataFetched;

			[Token(Token = "0x400207B")]
			[FieldOffset(Offset = "0x20")]
			private byte[] mOriginalData;

			[Token(Token = "0x400207C")]
			[FieldOffset(Offset = "0x28")]
			private bool mUnmergedDataFetched;

			[Token(Token = "0x400207D")]
			[FieldOffset(Offset = "0x30")]
			private byte[] mUnmergedData;

			[Token(Token = "0x400207E")]
			[FieldOffset(Offset = "0x38")]
			private Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;

			[Token(Token = "0x400207F")]
			[FieldOffset(Offset = "0x40")]
			private readonly Action<byte[], byte[]> mDataFetchedCallback;

			[Token(Token = "0x6002F2A")]
			[Address(RVA = "0xC6917C", Offset = "0xC6917C", VA = "0xC6917C")]
			internal Prefetcher(Action<byte[], byte[]> dataFetchedCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
			{
			}

			[Token(Token = "0x6002F2B")]
			[Address(RVA = "0xC69A14", Offset = "0xC69A14", VA = "0xC69A14")]
			internal void OnOriginalDataRead(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse readResponse)
			{
			}

			[Token(Token = "0x6002F2C")]
			[Address(RVA = "0xC69E2C", Offset = "0xC69E2C", VA = "0xC69E2C")]
			internal void OnUnmergedDataRead(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse readResponse)
			{
			}

			[Token(Token = "0x6002F2D")]
			[Address(RVA = "0xC69CE4", Offset = "0xC69CE4", VA = "0xC69CE4")]
			private void MaybeProceed()
			{
			}
		}

		[Token(Token = "0x20006D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820B08", Offset = "0x820B08")]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x4002080")]
			[FieldOffset(Offset = "0x10")]
			public ConflictResolutionStrategy resolutionStrategy;

			[Token(Token = "0x4002081")]
			[FieldOffset(Offset = "0x18")]
			public Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;

			[Token(Token = "0x6002F2E")]
			[Address(RVA = "0xC66D54", Offset = "0xC66D54", VA = "0xC66D54")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6002F2F")]
			[Address(RVA = "0xC68640", Offset = "0xC68640", VA = "0xC68640")]
			internal void _003COpenWithAutomaticConflictResolution_003Eb__0(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData)
			{
			}
		}

		[Token(Token = "0x20006D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820B18", Offset = "0x820B18")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x4002082")]
			[FieldOffset(Offset = "0x10")]
			public ConflictCallback conflictCallback;

			[Token(Token = "0x6002F30")]
			[Address(RVA = "0xC670AC", Offset = "0xC670AC", VA = "0xC670AC")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6002F31")]
			[Address(RVA = "0xC689F4", Offset = "0xC689F4", VA = "0xC689F4")]
			internal void _003CToOnGameThread_003Eb__0(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData)
			{
			}
		}

		[Token(Token = "0x20006D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820B28", Offset = "0x820B28")]
		private sealed class _003C_003Ec__DisplayClass6_1
		{
			[Token(Token = "0x4002083")]
			[FieldOffset(Offset = "0x10")]
			public IConflictResolver resolver;

			[Token(Token = "0x4002084")]
			[FieldOffset(Offset = "0x18")]
			public ISavedGameMetadata original;

			[Token(Token = "0x4002085")]
			[FieldOffset(Offset = "0x20")]
			public byte[] originalData;

			[Token(Token = "0x4002086")]
			[FieldOffset(Offset = "0x28")]
			public ISavedGameMetadata unmerged;

			[Token(Token = "0x4002087")]
			[FieldOffset(Offset = "0x30")]
			public byte[] unmergedData;

			[Token(Token = "0x4002088")]
			[FieldOffset(Offset = "0x38")]
			public _003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6002F32")]
			[Address(RVA = "0xC68B74", Offset = "0xC68B74", VA = "0xC68B74")]
			public _003C_003Ec__DisplayClass6_1()
			{
			}

			[Token(Token = "0x6002F33")]
			[Address(RVA = "0xC68B7C", Offset = "0xC68B7C", VA = "0xC68B7C")]
			internal void _003CToOnGameThread_003Eb__1()
			{
			}
		}

		[Token(Token = "0x20006D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820B38", Offset = "0x820B38")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x4002089")]
			[FieldOffset(Offset = "0x10")]
			public Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;

			[Token(Token = "0x400208A")]
			[FieldOffset(Offset = "0x18")]
			public NativeSavedGameClient _003C_003E4__this;

			[Token(Token = "0x400208B")]
			[FieldOffset(Offset = "0x20")]
			public string filename;

			[Token(Token = "0x400208C")]
			[FieldOffset(Offset = "0x28")]
			public DataSource source;

			[Token(Token = "0x400208D")]
			[FieldOffset(Offset = "0x2C")]
			public ConflictResolutionStrategy resolutionStrategy;

			[Token(Token = "0x400208E")]
			[FieldOffset(Offset = "0x30")]
			public bool prefetchDataOnConflict;

			[Token(Token = "0x400208F")]
			[FieldOffset(Offset = "0x38")]
			public ConflictCallback conflictCallback;

			[Token(Token = "0x4002090")]
			[FieldOffset(Offset = "0x40")]
			public Action _003C_003E9__1;

			[Token(Token = "0x6002F34")]
			[Address(RVA = "0xC67254", Offset = "0xC67254", VA = "0xC67254")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6002F35")]
			[Address(RVA = "0xC68BF0", Offset = "0xC68BF0", VA = "0xC68BF0")]
			internal void _003CInternalOpen_003Eb__0(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)
			{
			}

			[Token(Token = "0x6002F36")]
			[Address(RVA = "0xC69228", Offset = "0xC69228", VA = "0xC69228")]
			internal void _003CInternalOpen_003Eb__1()
			{
			}
		}

		[Token(Token = "0x20006D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820B48", Offset = "0x820B48")]
		private sealed class _003C_003Ec__DisplayClass8_1
		{
			[Token(Token = "0x4002091")]
			[FieldOffset(Offset = "0x10")]
			public NativeConflictResolver resolver;

			[Token(Token = "0x4002092")]
			[FieldOffset(Offset = "0x18")]
			public NativeSnapshotMetadata original;

			[Token(Token = "0x4002093")]
			[FieldOffset(Offset = "0x20")]
			public NativeSnapshotMetadata unmerged;

			[Token(Token = "0x4002094")]
			[FieldOffset(Offset = "0x28")]
			public _003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6002F37")]
			[Address(RVA = "0xC69070", Offset = "0xC69070", VA = "0xC69070")]
			public _003C_003Ec__DisplayClass8_1()
			{
			}

			[Token(Token = "0x6002F38")]
			[Address(RVA = "0xC69298", Offset = "0xC69298", VA = "0xC69298")]
			internal void _003CInternalOpen_003Eb__2(byte[] originalData, byte[] unmergedData)
			{
			}
		}

		[Token(Token = "0x20006D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820B58", Offset = "0x820B58")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x4002095")]
			[FieldOffset(Offset = "0x10")]
			public Action<SavedGameRequestStatus, byte[]> completedCallback;

			[Token(Token = "0x6002F39")]
			[Address(RVA = "0xC67574", Offset = "0xC67574", VA = "0xC67574")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6002F3A")]
			[Address(RVA = "0xC69310", Offset = "0xC69310", VA = "0xC69310")]
			internal void _003CReadBinaryData_003Eb__0(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse response)
			{
			}
		}

		[Token(Token = "0x20006D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820B68", Offset = "0x820B68")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4002096")]
			[FieldOffset(Offset = "0x10")]
			public Action<SelectUIStatus, ISavedGameMetadata> callback;

			[Token(Token = "0x6002F3B")]
			[Address(RVA = "0xC6777C", Offset = "0xC6777C", VA = "0xC6777C")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6002F3C")]
			[Address(RVA = "0xC682B4", Offset = "0xC682B4", VA = "0xC682B4")]
			internal void _003CShowSelectSavedGameUI_003Eb__0(GooglePlayGames.Native.PInvoke.SnapshotManager.SnapshotSelectUIResponse response)
			{
			}
		}

		[Token(Token = "0x20006D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820B78", Offset = "0x820B78")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x4002097")]
			[FieldOffset(Offset = "0x10")]
			public Action<SavedGameRequestStatus, ISavedGameMetadata> callback;

			[Token(Token = "0x6002F3D")]
			[Address(RVA = "0xC67A60", Offset = "0xC67A60", VA = "0xC67A60")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6002F3E")]
			[Address(RVA = "0xC683B0", Offset = "0xC683B0", VA = "0xC683B0")]
			internal void _003CCommitUpdate_003Eb__0(GooglePlayGames.Native.PInvoke.SnapshotManager.CommitResponse response)
			{
			}
		}

		[Token(Token = "0x20006D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820B88", Offset = "0x820B88")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x4002098")]
			[FieldOffset(Offset = "0x10")]
			public Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback;

			[Token(Token = "0x6002F3F")]
			[Address(RVA = "0xC67D58", Offset = "0xC67D58", VA = "0xC67D58")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6002F40")]
			[Address(RVA = "0xC684D4", Offset = "0xC684D4", VA = "0xC684D4")]
			internal void _003CFetchAllSavedGames_003Eb__0(GooglePlayGames.Native.PInvoke.SnapshotManager.FetchAllResponse response)
			{
			}
		}

		[Token(Token = "0x20006DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820B98", Offset = "0x820B98")]
		private sealed class _003C_003Ec__DisplayClass22_0<T1, T2>
		{
			[Token(Token = "0x4002099")]
			[FieldOffset(Offset = "0x0")]
			public Action<T1, T2> toConvert;

			[Token(Token = "0x6002F41")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6002F42")]
			internal void _003CToOnGameThread_003Eb__0(T1 val1, T2 val2)
			{
			}
		}

		[Token(Token = "0x20006DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820BA8", Offset = "0x820BA8")]
		private sealed class _003C_003Ec__DisplayClass22_1<T1, T2>
		{
			[Token(Token = "0x400209A")]
			[FieldOffset(Offset = "0x0")]
			public T1 val1;

			[Token(Token = "0x400209B")]
			[FieldOffset(Offset = "0x0")]
			public T2 val2;

			[Token(Token = "0x400209C")]
			[FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass22_0<T1, T2> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6002F43")]
			public _003C_003Ec__DisplayClass22_1()
			{
			}

			[Token(Token = "0x6002F44")]
			internal void _003CToOnGameThread_003Eb__1()
			{
			}
		}

		[Token(Token = "0x4000D0C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Regex ValidFilenameRegex;

		[Token(Token = "0x4000D0D")]
		[FieldOffset(Offset = "0x10")]
		private readonly GooglePlayGames.Native.PInvoke.SnapshotManager mSnapshotManager;

		[Token(Token = "0x60011AD")]
		[Address(RVA = "0xC66A84", Offset = "0xC66A84", VA = "0xC66A84")]
		internal NativeSavedGameClient(GooglePlayGames.Native.PInvoke.SnapshotManager manager)
		{
		}

		[Token(Token = "0x60011AE")]
		[Address(RVA = "0xC66AF4", Offset = "0xC66AF4", VA = "0xC66AF4")]
		public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Token(Token = "0x60011AF")]
		[Address(RVA = "0xC67098", Offset = "0xC67098", VA = "0xC67098", Slot = "4")]
		public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Token(Token = "0x60011B0")]
		[Address(RVA = "0xC66D5C", Offset = "0xC66D5C", VA = "0xC66D5C")]
		private ConflictCallback ToOnGameThread(ConflictCallback conflictCallback)
		{
			return null;
		}

		[Token(Token = "0x60011B1")]
		[Address(RVA = "0xC670B4", Offset = "0xC670B4", VA = "0xC670B4", Slot = "5")]
		public void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Token(Token = "0x60011B2")]
		[Address(RVA = "0xC66E90", Offset = "0xC66E90", VA = "0xC66E90")]
		private void InternalOpen(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Token(Token = "0x60011B3")]
		[Address(RVA = "0xC67334", Offset = "0xC67334", VA = "0xC67334", Slot = "6")]
		public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback)
		{
		}

		[Token(Token = "0x60011B4")]
		[Address(RVA = "0xC6757C", Offset = "0xC6757C", VA = "0xC6757C", Slot = "7")]
		public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback)
		{
		}

		[Token(Token = "0x60011B5")]
		[Address(RVA = "0xC67784", Offset = "0xC67784", VA = "0xC67784", Slot = "8")]
		public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
		{
		}

		[Token(Token = "0x60011B6")]
		[Address(RVA = "0xC67BDC", Offset = "0xC67BDC", VA = "0xC67BDC", Slot = "9")]
		public void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback)
		{
		}

		[Token(Token = "0x60011B7")]
		[Address(RVA = "0xC67D60", Offset = "0xC67D60", VA = "0xC67D60", Slot = "10")]
		public void Delete(ISavedGameMetadata metadata)
		{
		}

		[Token(Token = "0x60011B8")]
		[Address(RVA = "0xC66DF8", Offset = "0xC66DF8", VA = "0xC66DF8")]
		internal static bool IsValidFilename(string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x60011B9")]
		[Address(RVA = "0xC67E68", Offset = "0xC67E68", VA = "0xC67E68")]
		private static Types.SnapshotConflictPolicy AsConflictPolicy(ConflictResolutionStrategy strategy)
		{
			return default(Types.SnapshotConflictPolicy);
		}

		[Token(Token = "0x60011BA")]
		[Address(RVA = "0xC67F34", Offset = "0xC67F34", VA = "0xC67F34")]
		private static SavedGameRequestStatus AsRequestStatus(CommonErrorStatus.SnapshotOpenStatus status)
		{
			return default(SavedGameRequestStatus);
		}

		[Token(Token = "0x60011BB")]
		[Address(RVA = "0xC6725C", Offset = "0xC6725C", VA = "0xC6725C")]
		private static Types.DataSource AsDataSource(DataSource source)
		{
			return default(Types.DataSource);
		}

		[Token(Token = "0x60011BC")]
		[Address(RVA = "0xC6800C", Offset = "0xC6800C", VA = "0xC6800C")]
		private static SavedGameRequestStatus AsRequestStatus(CommonErrorStatus.ResponseStatus status)
		{
			return default(SavedGameRequestStatus);
		}

		[Token(Token = "0x60011BD")]
		[Address(RVA = "0xC6815C", Offset = "0xC6815C", VA = "0xC6815C")]
		private static SelectUIStatus AsUIStatus(CommonErrorStatus.UIStatus uiStatus)
		{
			return default(SelectUIStatus);
		}

		[Token(Token = "0x60011BE")]
		[Address(RVA = "0xC67A68", Offset = "0xC67A68", VA = "0xC67A68")]
		private static NativeSnapshotMetadataChange AsMetadataChange(SavedGameMetadataUpdate update)
		{
			return null;
		}

		[Token(Token = "0x60011BF")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}
	}
}
