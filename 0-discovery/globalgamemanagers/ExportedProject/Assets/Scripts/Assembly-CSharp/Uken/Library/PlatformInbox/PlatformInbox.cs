using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using Uken.Library.PlatformInbox.Internal;
using Uken.Library.ReferenceData;
using Uken.Library.UkenTime;

namespace Uken.Library.PlatformInbox
{
	[Token(Token = "0x2000400")]
	public class PlatformInbox : DepotController
	{
		[Token(Token = "0x20007C9")]
		public enum MessageType
		{
			[Token(Token = "0x40022B6")]
			text = 0,
			[Token(Token = "0x40022B7")]
			item = 1
		}

		[Token(Token = "0x20007CA")]
		public delegate string GetUserIDFunc();

		[Token(Token = "0x20007CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821058", Offset = "0x821058")]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			[Token(Token = "0x40022B8")]
			[FieldOffset(Offset = "0x10")]
			public PlatformInbox _003C_003E4__this;

			[Token(Token = "0x40022B9")]
			[FieldOffset(Offset = "0x18")]
			public Action<PlatformInboxResponseCode> onComplete;

			[Token(Token = "0x600321C")]
			[Address(RVA = "0xB307B0", Offset = "0xB307B0", VA = "0xB307B0")]
			public _003C_003Ec__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600321D")]
			[Address(RVA = "0xB31B18", Offset = "0xB31B18", VA = "0xB31B18")]
			internal void _003CQueryData_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x20007CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821068", Offset = "0x821068")]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x40022BA")]
			[FieldOffset(Offset = "0x10")]
			public PlatformInbox _003C_003E4__this;

			[Token(Token = "0x40022BB")]
			[FieldOffset(Offset = "0x18")]
			public Action<PlatformInboxResponseCode> onComplete;

			[Token(Token = "0x600321E")]
			[Address(RVA = "0xB30964", Offset = "0xB30964", VA = "0xB30964")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600321F")]
			[Address(RVA = "0xB31EA0", Offset = "0xB31EA0", VA = "0xB31EA0")]
			internal void _003CPostMessage_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x20007CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821078", Offset = "0x821078")]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			[Token(Token = "0x40022BC")]
			[FieldOffset(Offset = "0x10")]
			public PlatformInbox _003C_003E4__this;

			[Token(Token = "0x40022BD")]
			[FieldOffset(Offset = "0x18")]
			public Action<PlatformInboxResponseCode> onComplete;

			[Token(Token = "0x6003220")]
			[Address(RVA = "0xB30C24", Offset = "0xB30C24", VA = "0xB30C24")]
			public _003C_003Ec__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6003221")]
			[Address(RVA = "0xB31FE0", Offset = "0xB31FE0", VA = "0xB31FE0")]
			internal void _003CSendMessageHasBeenSeenRequest_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x40012BB")]
		private const string c_defaultFrom = "Guest";

		[Token(Token = "0x40012BC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime Epoch;

		[Token(Token = "0x40012BD")]
		private const float QueryInterval = 300f;

		[Token(Token = "0x40012BE")]
		[FieldOffset(Offset = "0x20")]
		private RuntimeItemModelDataCache<InboxMessage, RDInboxMessage> m_inboxMessageCache;

		[Token(Token = "0x40012BF")]
		[FieldOffset(Offset = "0x28")]
		private readonly Action<WebRequest> m_webInterfaceCB;

		[Token(Token = "0x40012C0")]
		[FieldOffset(Offset = "0x30")]
		private readonly GetUserIDFunc m_GetUserID;

		[Token(Token = "0x40012C1")]
		[FieldOffset(Offset = "0x38")]
		private readonly string m_endpoint;

		[Token(Token = "0x40012C2")]
		[FieldOffset(Offset = "0x40")]
		private readonly InventoryController m_inventoryController;

		[Token(Token = "0x40012C3")]
		[FieldOffset(Offset = "0x48")]
		private readonly UkenTimeController m_timeController;

		[Token(Token = "0x40012C4")]
		[FieldOffset(Offset = "0x50")]
		private float m_timeSinceLastQuery;

		[Token(Token = "0x40012C5")]
		[FieldOffset(Offset = "0x58")]
		private UkenObservable<List<MessageItem>> m_messageObservable;

		[Token(Token = "0x6001E83")]
		[Address(RVA = "0xB302E4", Offset = "0xB302E4", VA = "0xB302E4")]
		public PlatformInbox(DataStoreController dataStoreController, string endpoint, GetUserIDFunc getUserID, Action<WebRequest> webInterface, InventoryController inventoryController, UkenTimeController timeController)
		{
		}

		[Token(Token = "0x6001E84")]
		[Address(RVA = "0xB303FC", Offset = "0xB303FC", VA = "0xB303FC", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x6001E85")]
		[Address(RVA = "0xB305C4", Offset = "0xB305C4", VA = "0xB305C4", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6001E86")]
		[Address(RVA = "0xB30670", Offset = "0xB30670", VA = "0xB30670", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6001E87")]
		[Address(RVA = "0xB30698", Offset = "0xB30698", VA = "0xB30698")]
		public void QueryData(Action<PlatformInboxResponseCode> onComplete)
		{
		}

		[Token(Token = "0x6001E88")]
		[Address(RVA = "0xB307B8", Offset = "0xB307B8", VA = "0xB307B8")]
		public void PostMessage(List<string> toEntityIDs, string senderName, string subject, string message, string data, string dataType, Action<PlatformInboxResponseCode> onComplete)
		{
		}

		[Token(Token = "0x6001E89")]
		[Address(RVA = "0xB3096C", Offset = "0xB3096C", VA = "0xB3096C")]
		public void MarkMessageAsRead(MessageItem messageItem, Action<PlatformInboxResponseCode> onComplete)
		{
		}

		[Token(Token = "0x6001E8A")]
		[Address(RVA = "0xB30AA4", Offset = "0xB30AA4", VA = "0xB30AA4")]
		private void RecordInboxMessageDeletion(InboxMessage inboxMessage, MessageItem messageItem)
		{
		}

		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0xB30B08", Offset = "0xB30B08", VA = "0xB30B08")]
		private void SendMessageHasBeenSeenRequest(string messageID, Action<PlatformInboxResponseCode> onComplete)
		{
		}

		[Token(Token = "0x6001E8C")]
		[Address(RVA = "0xB30C2C", Offset = "0xB30C2C", VA = "0xB30C2C")]
		public UkenUnsubscriber<List<MessageItem>> SubscribeToMessages(IUkenObserver<List<MessageItem>> observer, bool signalOnSubscribe)
		{
			return null;
		}

		[Token(Token = "0x6001E8D")]
		[Address(RVA = "0xB30CA4", Offset = "0xB30CA4", VA = "0xB30CA4")]
		private PlatformInboxResponseCode GetResponseCode(WebResponse response)
		{
			return default(PlatformInboxResponseCode);
		}

		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0xB30CE4", Offset = "0xB30CE4", VA = "0xB30CE4")]
		private int DateTimeToUnixTime(DateTime datetime)
		{
			return default(int);
		}

		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0xB30DFC", Offset = "0xB30DFC", VA = "0xB30DFC")]
		private List<MessageItem> GetAllMessageItems()
		{
			return null;
		}

		[Token(Token = "0x6001E90")]
		[Address(RVA = "0xB305EC", Offset = "0xB305EC", VA = "0xB305EC")]
		private void EmitMessageChanges()
		{
		}

		[Token(Token = "0x6001E91")]
		[Address(RVA = "0xB30FDC", Offset = "0xB30FDC", VA = "0xB30FDC")]
		private void DetectAndCreateMessagesFromRefDataSource()
		{
		}

		[Token(Token = "0x6001E92")]
		[Address(RVA = "0xB31698", Offset = "0xB31698", VA = "0xB31698")]
		private void CreateOrUpdateMessage(string messageItemReference, string userFrom, string subject, string messageBody, DateTime expirationDate, string rewardItemReference, long rewardAmount, string messageSource, int iteration)
		{
		}

		[Token(Token = "0x6001E93")]
		[Address(RVA = "0xB31384", Offset = "0xB31384", VA = "0xB31384")]
		private void DeleteExpiredMessages()
		{
		}
	}
}
