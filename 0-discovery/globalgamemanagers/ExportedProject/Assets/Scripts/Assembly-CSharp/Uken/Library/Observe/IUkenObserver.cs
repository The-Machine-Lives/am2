using Il2CppDummyDll;

namespace Uken.Library.Observe
{
	[Token(Token = "0x200040A")]
	public interface IUkenObserver<T>
	{
		[Token(Token = "0x6001EBA")]
		void OnEmit(T value);
	}
}
