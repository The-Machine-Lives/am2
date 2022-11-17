using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x200000E")]
	public class Constants
	{
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int MAX_BATCH_SIZE;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int SYNC_DELAY;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int REQUEST_TIMEOUT;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int SESSION_ID_TIMEOUT;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string API_KEY_HEADER;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly float INITIAL_DISPATCH_BACKOFF;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly float MAX_DISPATCH_BACKOFF;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x20")]
		public static readonly float SAVE_TO_DISK_DELAY;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x16D6680", Offset = "0x16D6680", VA = "0x16D6680")]
		public Constants()
		{
		}
	}
}
