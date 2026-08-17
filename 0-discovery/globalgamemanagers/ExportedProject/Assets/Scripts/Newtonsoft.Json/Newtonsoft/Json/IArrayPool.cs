using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000012")]
	[Preserve]
	public interface IArrayPool<T>
	{
		[Token(Token = "0x6000010")]
		T[] Rent(int minimumLength);

		[Token(Token = "0x6000011")]
		void Return(T[] array);
	}
}
