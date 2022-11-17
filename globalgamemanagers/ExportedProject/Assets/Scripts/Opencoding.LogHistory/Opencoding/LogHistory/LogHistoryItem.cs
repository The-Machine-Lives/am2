using Il2CppDummyDll;

namespace Opencoding.LogHistory
{
	[Token(Token = "0x2000004")]
	public class LogHistoryItem
	{
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		public LogHistoryLogType _Type;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		public string _StackTrace;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x20")]
		public string _LogMessage;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x28")]
		public string _FirstLineOfLogMessage;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x30")]
		public float _Time;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x34")]
		public int _Id;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		private static int _Counter;

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x180B8D0", Offset = "0x180B8D0", VA = "0x180B8D0")]
		public LogHistoryItem(LogHistoryLogType type, string message, float time, string stackTrace = "")
		{
		}
	}
}
