using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x2000014")]
	public class EventQueue
	{
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x10")]
		private readonly string logDiskPath;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x18")]
		private List<BaseEvent> queuedLogs;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, EventBatch> inFlightLogs;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x28")]
		private int maxEventQueueSize;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x16D1980", Offset = "0x16D1980", VA = "0x16D1980")]
		public EventQueue()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x16D2AE8", Offset = "0x16D2AE8", VA = "0x16D2AE8")]
		public void Cleanup()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x16D2CC8", Offset = "0x16D2CC8", VA = "0x16D2CC8")]
		public int NumLogsQueued()
		{
			return default(int);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x16D2BFC", Offset = "0x16D2BFC", VA = "0x16D2BFC")]
		public void Queue(BaseEvent log)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x16D3058", Offset = "0x16D3058", VA = "0x16D3058")]
		public EventBatch GetBatchForDispatch()
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x16D3510", Offset = "0x16D3510", VA = "0x16D3510")]
		public void StoreInFlightBatch(string requestId, EventBatch batch)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x16D3924", Offset = "0x16D3924", VA = "0x16D3924")]
		public void OnSendFailure(string requestId)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x16D37A4", Offset = "0x16D37A4", VA = "0x16D37A4")]
		public void OnSendSuccess(string requestId)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x16D2404", Offset = "0x16D2404", VA = "0x16D2404")]
		public void SaveToDisk()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x16D1C44", Offset = "0x16D1C44", VA = "0x16D1C44")]
		public void LoadFromDisk()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x16D2D9C", Offset = "0x16D2D9C", VA = "0x16D2D9C")]
		public int NumLogsInFlight()
		{
			return default(int);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x16D1B64", Offset = "0x16D1B64", VA = "0x16D1B64")]
		public void SetMaxEventQueueSize(int size)
		{
		}
	}
}
