using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20002D1")]
	public interface OnStateLoadedListener
	{
		[Token(Token = "0x600163E")]
		void OnStateLoaded(bool success, int slot, byte[] data);

		[Token(Token = "0x600163F")]
		byte[] OnStateConflict(int slot, byte[] localData, byte[] serverData);

		[Token(Token = "0x6001640")]
		void OnStateSaved(bool success, int slot);
	}
}
