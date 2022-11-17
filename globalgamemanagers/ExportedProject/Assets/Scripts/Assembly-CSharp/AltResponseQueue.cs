using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200005A")]
public class AltResponseQueue
{
	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x10")]
	private Queue<SendResponse> _responseQueue;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x18")]
	private readonly object _queueLock;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xAD42C8", Offset = "0xAD42C8", VA = "0xAD42C8")]
	public void Cycle()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xAD43F8", Offset = "0xAD43F8", VA = "0xAD43F8")]
	public void ScheduleResponse(SendResponse newResponse)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xAD4518", Offset = "0xAD4518", VA = "0xAD4518")]
	public AltResponseQueue()
	{
	}
}
