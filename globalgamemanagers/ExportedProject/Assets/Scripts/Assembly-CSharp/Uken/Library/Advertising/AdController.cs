using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Advertising
{
	[Token(Token = "0x200044E")]
	public class AdController : UkenController
	{
		[Token(Token = "0x2000801")]
		public enum AdStockState
		{
			[Token(Token = "0x400231F")]
			Undefined = 0,
			[Token(Token = "0x4002320")]
			Ready = 1,
			[Token(Token = "0x4002321")]
			NotAvailable = 2,
			[Token(Token = "0x4002322")]
			Disabled = 3,
			[Token(Token = "0x4002323")]
			Waiting = 4,
			[Token(Token = "0x4002324")]
			NoFill = 5
		}

		[Token(Token = "0x6001FD8")]
		[Address(RVA = "0xAEE914", Offset = "0xAEE914", VA = "0xAEE914")]
		public AdController()
		{
		}
	}
}
