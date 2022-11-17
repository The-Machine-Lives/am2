using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x2000261")]
	internal class UnsupportedSavedGamesClient : ISavedGameClient
	{
		[Token(Token = "0x4000D12")]
		[FieldOffset(Offset = "0x10")]
		private readonly string mMessage;

		[Token(Token = "0x60011EC")]
		[Address(RVA = "0xE6B40C", Offset = "0xE6B40C", VA = "0xE6B40C")]
		public UnsupportedSavedGamesClient(string message)
		{
		}

		[Token(Token = "0x60011ED")]
		[Address(RVA = "0xE6B47C", Offset = "0xE6B47C", VA = "0xE6B47C", Slot = "4")]
		public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
		{
		}

		[Token(Token = "0x60011EE")]
		[Address(RVA = "0xE6B4F0", Offset = "0xE6B4F0", VA = "0xE6B4F0", Slot = "5")]
		public void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Token(Token = "0x60011EF")]
		[Address(RVA = "0xE6B564", Offset = "0xE6B564", VA = "0xE6B564", Slot = "6")]
		public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback)
		{
		}

		[Token(Token = "0x60011F0")]
		[Address(RVA = "0xE6B5D8", Offset = "0xE6B5D8", VA = "0xE6B5D8", Slot = "7")]
		public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback)
		{
		}

		[Token(Token = "0x60011F1")]
		[Address(RVA = "0xE6B64C", Offset = "0xE6B64C", VA = "0xE6B64C", Slot = "8")]
		public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
		{
		}

		[Token(Token = "0x60011F2")]
		[Address(RVA = "0xE6B6C0", Offset = "0xE6B6C0", VA = "0xE6B6C0", Slot = "9")]
		public void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback)
		{
		}

		[Token(Token = "0x60011F3")]
		[Address(RVA = "0xE6B734", Offset = "0xE6B734", VA = "0xE6B734", Slot = "10")]
		public void Delete(ISavedGameMetadata metadata)
		{
		}
	}
}
