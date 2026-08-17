using Il2CppDummyDll;

namespace Uken.Library.Network
{
	[Token(Token = "0x2000410")]
	public interface INetworkStatus
	{
		[Token(Token = "0x6001EE4")]
		bool IsNetworkAvailable();
	}
}
