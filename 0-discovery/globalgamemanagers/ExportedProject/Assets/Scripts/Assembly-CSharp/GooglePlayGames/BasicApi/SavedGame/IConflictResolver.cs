using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x20002EF")]
	public interface IConflictResolver
	{
		[Token(Token = "0x6001711")]
		void ChooseMetadata(ISavedGameMetadata chosenMetadata);

		[Token(Token = "0x6001712")]
		void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData);
	}
}
