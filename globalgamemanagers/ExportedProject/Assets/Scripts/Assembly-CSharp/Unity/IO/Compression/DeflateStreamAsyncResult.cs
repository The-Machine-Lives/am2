using System;
using System.Threading;
using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005EA")]
	internal class DeflateStreamAsyncResult : IAsyncResult
	{
		[Token(Token = "0x4001C74")]
		[FieldOffset(Offset = "0x10")]
		public byte[] buffer;

		[Token(Token = "0x4001C75")]
		[FieldOffset(Offset = "0x18")]
		public int offset;

		[Token(Token = "0x4001C76")]
		[FieldOffset(Offset = "0x1C")]
		public int count;

		[Token(Token = "0x4001C77")]
		[FieldOffset(Offset = "0x20")]
		public bool isWrite;

		[Token(Token = "0x4001C78")]
		[FieldOffset(Offset = "0x28")]
		private object m_AsyncObject;

		[Token(Token = "0x4001C79")]
		[FieldOffset(Offset = "0x30")]
		private object m_AsyncState;

		[Token(Token = "0x4001C7A")]
		[FieldOffset(Offset = "0x38")]
		private AsyncCallback m_AsyncCallback;

		[Token(Token = "0x4001C7B")]
		[FieldOffset(Offset = "0x40")]
		private object m_Result;

		[Token(Token = "0x4001C7C")]
		[FieldOffset(Offset = "0x48")]
		internal bool m_CompletedSynchronously;

		[Token(Token = "0x4001C7D")]
		[FieldOffset(Offset = "0x4C")]
		private int m_InvokedCallback;

		[Token(Token = "0x4001C7E")]
		[FieldOffset(Offset = "0x50")]
		private int m_Completed;

		[Token(Token = "0x4001C7F")]
		[FieldOffset(Offset = "0x58")]
		private object m_Event;

		[Token(Token = "0x1700078B")]
		public object AsyncState
		{
			[Token(Token = "0x6002BB7")]
			[Address(RVA = "0xAAC8B4", Offset = "0xAAC8B4", VA = "0xAAC8B4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700078C")]
		public WaitHandle AsyncWaitHandle
		{
			[Token(Token = "0x6002BB8")]
			[Address(RVA = "0xAABE78", Offset = "0xAABE78", VA = "0xAABE78", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700078D")]
		public bool CompletedSynchronously
		{
			[Token(Token = "0x6002BB9")]
			[Address(RVA = "0xAAC8BC", Offset = "0xAAC8BC", VA = "0xAAC8BC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700078E")]
		public bool IsCompleted
		{
			[Token(Token = "0x6002BBA")]
			[Address(RVA = "0xAAA660", Offset = "0xAAA660", VA = "0xAAA660", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700078F")]
		internal object Result
		{
			[Token(Token = "0x6002BBB")]
			[Address(RVA = "0xAAADD4", Offset = "0xAAADD4", VA = "0xAAADD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002BB6")]
		[Address(RVA = "0xAAA5E4", Offset = "0xAAA5E4", VA = "0xAAA5E4")]
		public DeflateStreamAsyncResult(object asyncObject, object asyncState, AsyncCallback asyncCallback, byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6002BBC")]
		[Address(RVA = "0xAABF9C", Offset = "0xAABF9C", VA = "0xAABF9C")]
		internal void Close()
		{
		}

		[Token(Token = "0x6002BBD")]
		[Address(RVA = "0xAAA650", Offset = "0xAAA650", VA = "0xAAA650")]
		internal void InvokeCallback(bool completedSynchronously, object result)
		{
		}

		[Token(Token = "0x6002BBE")]
		[Address(RVA = "0xAAAA78", Offset = "0xAAAA78", VA = "0xAAAA78")]
		internal void InvokeCallback(object result)
		{
		}

		[Token(Token = "0x6002BBF")]
		[Address(RVA = "0xAAC8C4", Offset = "0xAAC8C4", VA = "0xAAC8C4")]
		private void Complete(bool completedSynchronously, object result)
		{
		}

		[Token(Token = "0x6002BC0")]
		[Address(RVA = "0xAAC8D4", Offset = "0xAAC8D4", VA = "0xAAC8D4")]
		private void Complete(object result)
		{
		}
	}
}
