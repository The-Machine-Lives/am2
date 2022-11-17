using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Framework.Casual.Leaderboards;
using Uken.Library.Inventory;
using Uken.Library.PlatformInbox.Internal;

namespace Uken.Framework.Casual.Signals
{
	[Token(Token = "0x200058B")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x820268", Offset = "0x820268")]
	public class SignalsAndStorageController : UkenController
	{
		[Token(Token = "0x2000864")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8215D8", Offset = "0x8215D8")]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			[Token(Token = "0x4002411")]
			[FieldOffset(Offset = "0x10")]
			public string leaderboardName;

			[Token(Token = "0x600339D")]
			[Address(RVA = "0xA921AC", Offset = "0xA921AC", VA = "0xA921AC")]
			public _003C_003Ec__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600339E")]
			[Address(RVA = "0xA92B00", Offset = "0xA92B00", VA = "0xA92B00")]
			internal void _003CGenerateInboxMessage_003Eb__0(PlatformInboxResponseCode responseCode)
			{
			}
		}

		[Token(Token = "0x4001A4C")]
		[FieldOffset(Offset = "0x18")]
		private List<ISignalsAndStorageListener> m_listeners;

		[Token(Token = "0x4001A4D")]
		[FieldOffset(Offset = "0x20")]
		private LeaderboardController m_leaderboardController;

		[Token(Token = "0x4001A4E")]
		[FieldOffset(Offset = "0x28")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x6002A6B")]
		[Address(RVA = "0xA91E90", Offset = "0xA91E90", VA = "0xA91E90")]
		public static void GenerateInboxMessage(string itemName, long quantity, string leaderboardName, string senderName, string subject)
		{
		}

		[Token(Token = "0x6002A6C")]
		[Address(RVA = "0xA921B4", Offset = "0xA921B4", VA = "0xA921B4")]
		public SignalsAndStorageController(LeaderboardController leaderboardController, InventoryController inventoryController)
		{
		}

		[Token(Token = "0x6002A6D")]
		[Address(RVA = "0xA9223C", Offset = "0xA9223C", VA = "0xA9223C")]
		public void RegisterListener(ISignalsAndStorageListener listener)
		{
		}

		[Token(Token = "0x6002A6E")]
		[Address(RVA = "0xA922EC", Offset = "0xA922EC", VA = "0xA922EC")]
		public void UnregisterListener(ISignalsAndStorageListener listener)
		{
		}

		[Token(Token = "0x6002A6F")]
		[Address(RVA = "0xA9239C", Offset = "0xA9239C", VA = "0xA9239C")]
		public void BroadcastSignal(Signal signalData)
		{
		}

		[Token(Token = "0x6002A70")]
		[Address(RVA = "0xA925BC", Offset = "0xA925BC", VA = "0xA925BC")]
		private void RunBatchedOperations(List<BatchableOperation> operations)
		{
		}
	}
}
