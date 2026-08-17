using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inbox.Internal;
using Uken.Library.Inventory;

namespace Uken.Library.Inbox
{
	[Token(Token = "0x2000429")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x81FA28", Offset = "0x81FA28")]
	public class Inbox<T> : Inbox where T : InboxMessage, new()
	{
		[Token(Token = "0x400134B")]
		[FieldOffset(Offset = "0x0")]
		private List<T> m_cachedMessages;

		[Token(Token = "0x6001F25")]
		public Inbox(string endpoint, GetUserIDFunc getUserID, Action<WebRequest> webInterface)
		{
		}

		[Token(Token = "0x6001F26")]
		public List<T> GetMessages()
		{
			return null;
		}

		[Token(Token = "0x6001F27")]
		protected override void SetInboxData(InboxData newData)
		{
		}
	}
	[Token(Token = "0x200042A")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x81FA60", Offset = "0x81FA60")]
	public class Inbox : UkenController
	{
		[Token(Token = "0x20007DF")]
		public delegate string GetUserIDFunc();

		[Token(Token = "0x20007E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821108", Offset = "0x821108")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x40022E5")]
			[FieldOffset(Offset = "0x10")]
			public Inbox _003C_003E4__this;

			[Token(Token = "0x40022E6")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> onComplete;

			[Token(Token = "0x600324F")]
			[Address(RVA = "0xB996A0", Offset = "0xB996A0", VA = "0xB996A0")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6003250")]
			[Address(RVA = "0xB9AFE0", Offset = "0xB9AFE0", VA = "0xB9AFE0")]
			internal void _003CQueryData_003Eb__1(WebResponse response, WebRequest request)
			{
			}

			[Token(Token = "0x6003251")]
			[Address(RVA = "0xB9B148", Offset = "0xB9B148", VA = "0xB9B148")]
			internal void _003CQueryData_003Eb__0(InboxData newInbox)
			{
			}
		}

		[Token(Token = "0x20007E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821118", Offset = "0x821118")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x40022E7")]
			[FieldOffset(Offset = "0x10")]
			public Inbox _003C_003E4__this;

			[Token(Token = "0x40022E8")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> onComplete;

			[Token(Token = "0x6003252")]
			[Address(RVA = "0xB99D38", Offset = "0xB99D38", VA = "0xB99D38")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6003253")]
			[Address(RVA = "0xB9B200", Offset = "0xB9B200", VA = "0xB9B200")]
			internal void _003CPostMessage_003Eb__0(WebResponse response, WebRequest request)
			{
			}

			[Token(Token = "0x6003254")]
			[Address(RVA = "0xB9B238", Offset = "0xB9B238", VA = "0xB9B238")]
			internal void _003CPostMessage_003Eb__1(bool success, InboxMessageData returnedMsg)
			{
			}
		}

		[Token(Token = "0x20007E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821128", Offset = "0x821128")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x40022E9")]
			[FieldOffset(Offset = "0x10")]
			public List<string> messageIDs;

			[Token(Token = "0x40022EA")]
			[FieldOffset(Offset = "0x18")]
			public Inbox _003C_003E4__this;

			[Token(Token = "0x40022EB")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool> onComplete;

			[Token(Token = "0x40022EC")]
			[FieldOffset(Offset = "0x28")]
			public Action<bool> _003C_003E9__1;

			[Token(Token = "0x6003255")]
			[Address(RVA = "0xB9A2A8", Offset = "0xB9A2A8", VA = "0xB9A2A8")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6003256")]
			[Address(RVA = "0xB9AAB0", Offset = "0xB9AAB0", VA = "0xB9AAB0")]
			internal void _003CMarkMessagesAsRead_003Eb__0(WebResponse response, WebRequest request)
			{
			}

			[Token(Token = "0x6003257")]
			[Address(RVA = "0xB9ACE8", Offset = "0xB9ACE8", VA = "0xB9ACE8")]
			internal void _003CMarkMessagesAsRead_003Eb__1(bool success)
			{
			}
		}

		[Token(Token = "0x20007E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821138", Offset = "0x821138")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x40022ED")]
			[FieldOffset(Offset = "0x10")]
			public List<string> messageIDs;

			[Token(Token = "0x40022EE")]
			[FieldOffset(Offset = "0x18")]
			public Inbox _003C_003E4__this;

			[Token(Token = "0x40022EF")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool> onComplete;

			[Token(Token = "0x6003258")]
			[Address(RVA = "0xB9A5B0", Offset = "0xB9A5B0", VA = "0xB9A5B0")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6003259")]
			[Address(RVA = "0xB9AD20", Offset = "0xB9AD20", VA = "0xB9AD20")]
			internal void _003CMarkMessagesAsSeen_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x20007E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821148", Offset = "0x821148")]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x40022F0")]
			[FieldOffset(Offset = "0x10")]
			public Inbox _003C_003E4__this;

			[Token(Token = "0x40022F1")]
			[FieldOffset(Offset = "0x18")]
			public InboxMessageData fakeMessage;

			[Token(Token = "0x40022F2")]
			[FieldOffset(Offset = "0x20")]
			public List<InboxMessageData> fakeMessages;

			[Token(Token = "0x600325A")]
			[Address(RVA = "0xB9AAA4", Offset = "0xB9AAA4", VA = "0xB9AAA4")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600325B")]
			[Address(RVA = "0xB9AF58", Offset = "0xB9AF58", VA = "0xB9AF58")]
			internal void _003CPostFakeMessages_003Eb__0(bool success)
			{
			}
		}

		[Token(Token = "0x400134C")]
		[FieldOffset(Offset = "0x18")]
		private Action<WebRequest> m_webInterfaceCB;

		[Token(Token = "0x400134D")]
		[FieldOffset(Offset = "0x20")]
		private GetUserIDFunc m_GetUserID;

		[Token(Token = "0x400134E")]
		[FieldOffset(Offset = "0x28")]
		protected InboxData m_cachedData;

		[Token(Token = "0x400134F")]
		[FieldOffset(Offset = "0x30")]
		private string m_endpoint;

		[Token(Token = "0x4001350")]
		[FieldOffset(Offset = "0x38")]
		private FakeBackendInventoryObject m_inventoryHack;

		[Token(Token = "0x6001F28")]
		[Address(RVA = "0xB9943C", Offset = "0xB9943C", VA = "0xB9943C")]
		public Inbox(string endpoint, GetUserIDFunc getUserID, Action<WebRequest> webInterface)
		{
		}

		[Token(Token = "0x6001F29")]
		[Address(RVA = "0xB9947C", Offset = "0xB9947C", VA = "0xB9947C")]
		private bool BackendFeatureEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6001F2A")]
		[Address(RVA = "0xB994FC", Offset = "0xB994FC", VA = "0xB994FC", Slot = "10")]
		public virtual void QueryData(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6001F2B")]
		[Address(RVA = "0xB99AC4", Offset = "0xB99AC4", VA = "0xB99AC4")]
		public void PostMessage(string senderName, List<string> toEntityIDs, string subject, string message, string msgType, string data, Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6001F2C")]
		[Address(RVA = "0xB99F4C", Offset = "0xB99F4C", VA = "0xB99F4C")]
		public void MarkMessageAsRead(string messageID, Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0xB99FF0", Offset = "0xB99FF0", VA = "0xB99FF0")]
		public void MarkMessagesAsRead(List<string> messageIDs, Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0xB9A3B0", Offset = "0xB9A3B0", VA = "0xB9A3B0")]
		public void MarkMessageAsSeen(string messageID, Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0xB9A454", Offset = "0xB9A454", VA = "0xB9A454")]
		public void MarkMessagesAsSeen(List<string> messageIDs, Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6001F30")]
		[Address(RVA = "0xB9A6B8", Offset = "0xB9A6B8", VA = "0xB9A6B8", Slot = "11")]
		protected virtual void SetInboxData(InboxData newData)
		{
		}

		[Token(Token = "0x6001F31")]
		[Address(RVA = "0xB9A6C0", Offset = "0xB9A6C0", VA = "0xB9A6C0", Slot = "12")]
		protected virtual void OnNewInboxData()
		{
		}

		[Token(Token = "0x6001F32")]
		[Address(RVA = "0xB9A6C4", Offset = "0xB9A6C4", VA = "0xB9A6C4")]
		public void TempInventoryHackHookup(InventoryController inventory)
		{
		}

		[Token(Token = "0x6001F33")]
		[Address(RVA = "0xB9A734", Offset = "0xB9A734", VA = "0xB9A734")]
		public void PortFakeMessagesToInbox()
		{
		}

		[Token(Token = "0x6001F34")]
		[Address(RVA = "0xB9A7CC", Offset = "0xB9A7CC", VA = "0xB9A7CC")]
		private void PostFakeMessages(List<InboxMessageData> fakeMessages)
		{
		}

		[Token(Token = "0x6001F35")]
		[Address(RVA = "0xB9AAAC", Offset = "0xB9AAAC", VA = "0xB9AAAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839004", Offset = "0x839004")]
		private void _003CPortFakeMessagesToInbox_003Eb__17_0(List<InboxMessageData> unreadMessages)
		{
		}
	}
}
