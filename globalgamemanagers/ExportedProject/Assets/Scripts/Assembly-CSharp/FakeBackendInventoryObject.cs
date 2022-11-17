using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inbox.Internal;
using Uken.Library.Inventory;

[Token(Token = "0x2000211")]
[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x81E9B8", Offset = "0x81E9B8")]
public class FakeBackendInventoryObject
{
	[Token(Token = "0x200066D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820678", Offset = "0x820678")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x4001FB2")]
		[FieldOffset(Offset = "0x10")]
		public Action<List<InboxMessageData>> onComplete;

		[Token(Token = "0x6002DC3")]
		[Address(RVA = "0x9C8BB8", Offset = "0x9C8BB8", VA = "0x9C8BB8")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6002DC4")]
		[Address(RVA = "0x9C9CC0", Offset = "0x9C9CC0", VA = "0x9C9CC0")]
		internal void _003CGetUnreadFakeMessages_003Eb__0(InboxData inbox)
		{
		}
	}

	[Token(Token = "0x4000BB0")]
	[FieldOffset(Offset = "0x10")]
	private int maxMessageCount;

	[Token(Token = "0x4000BB1")]
	[FieldOffset(Offset = "0x18")]
	private InventoryController m_inventory;

	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x9C8AD0", Offset = "0x9C8AD0", VA = "0x9C8AD0")]
	public FakeBackendInventoryObject(InventoryController inventory)
	{
	}

	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x9C8B04", Offset = "0x9C8B04", VA = "0x9C8B04")]
	public void GetUnreadFakeMessages(Action<List<InboxMessageData>> onComplete)
	{
	}

	[Token(Token = "0x6000E03")]
	[Address(RVA = "0x9C8C40", Offset = "0x9C8C40", VA = "0x9C8C40")]
	public void DeleteFakeMessage(string messageId)
	{
	}

	[Token(Token = "0x6000E04")]
	[Address(RVA = "0x9C8EC8", Offset = "0x9C8EC8", VA = "0x9C8EC8")]
	public void DeleteAllFakeMessages()
	{
	}

	[Token(Token = "0x6000E05")]
	[Address(RVA = "0x9C8BC0", Offset = "0x9C8BC0", VA = "0x9C8BC0")]
	public void FakeQuery(Action<InboxData> onComplete)
	{
	}

	[Token(Token = "0x6000E06")]
	[Address(RVA = "0x9C923C", Offset = "0x9C923C", VA = "0x9C923C")]
	public void FakePost(InboxMessageData messageData, Action<bool, InboxMessageData> onComplete)
	{
	}

	[Token(Token = "0x6000E07")]
	[Address(RVA = "0x9C9854", Offset = "0x9C9854", VA = "0x9C9854")]
	public void MarkAsRead(string messageID, Action<bool> onComplete)
	{
	}

	[Token(Token = "0x6000E08")]
	[Address(RVA = "0x9C9640", Offset = "0x9C9640", VA = "0x9C9640")]
	private void SaveMessage(InboxMessageData messageData, MetadataItem data)
	{
	}

	[Token(Token = "0x6000E09")]
	[Address(RVA = "0x9C99BC", Offset = "0x9C99BC", VA = "0x9C99BC")]
	private InboxMessageData GetMessage(MetadataItem data)
	{
		return null;
	}

	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x9C9900", Offset = "0x9C9900", VA = "0x9C9900")]
	private MetadataItem FindInboxMessageItem(string messageID)
	{
		return null;
	}

	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x9C9134", Offset = "0x9C9134", VA = "0x9C9134")]
	private InboxData GetInboxData()
	{
		return null;
	}

	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x9C8F74", Offset = "0x9C8F74", VA = "0x9C8F74")]
	private void RunMessageExpiration()
	{
	}

	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0x9C9C58", Offset = "0x9C9C58", VA = "0x9C9C58")]
	private string getItemName(int index)
	{
		return null;
	}

	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0x9C9454", Offset = "0x9C9454", VA = "0x9C9454")]
	private MetadataItem GetFreeInboxItem()
	{
		return null;
	}

	[Token(Token = "0x6000E0F")]
	[Address(RVA = "0x9C8D20", Offset = "0x9C8D20", VA = "0x9C8D20")]
	private MetadataItem GetInboxItem(int index)
	{
		return null;
	}
}
