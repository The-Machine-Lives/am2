using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x20002ED")]
	public delegate void ConflictCallback(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData);
}
