using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	[Token(Token = "0x2000006")]
	[Preserve]
	public enum NotifyCollectionChangedAction
	{
		[Token(Token = "0x4000002")]
		Add = 0,
		[Token(Token = "0x4000003")]
		Remove = 1,
		[Token(Token = "0x4000004")]
		Replace = 2,
		[Token(Token = "0x4000005")]
		Move = 3,
		[Token(Token = "0x4000006")]
		Reset = 4
	}
}
