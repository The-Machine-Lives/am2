using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual.Signals;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004FB")]
	public class GameTriggers : DepotController, ISignalsAndStorageListener
	{
		[Token(Token = "0x4001782")]
		[FieldOffset(Offset = "0x20")]
		protected CasualGame m_game;

		[Token(Token = "0x4001783")]
		[FieldOffset(Offset = "0x28")]
		protected SignalsAndStorageController m_signals;

		[Token(Token = "0x4001784")]
		[FieldOffset(Offset = "0x30")]
		protected List<Action<List<string>>> m_callbacks;

		[Token(Token = "0x4001785")]
		[FieldOffset(Offset = "0x38")]
		protected bool m_isDataUpdated;

		[Token(Token = "0x17000692")]
		protected DepotEntity<RDGameTrigger> m_triggers
		{
			[Token(Token = "0x600264F")]
			[Address(RVA = "0xA6849C", Offset = "0xA6849C", VA = "0xA6849C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002650")]
		[Address(RVA = "0xA68604", Offset = "0xA68604", VA = "0xA68604")]
		public GameTriggers(CasualGame game, DataStoreController dataStoreController)
		{
		}

		[Token(Token = "0x6002651")]
		[Address(RVA = "0xA68690", Offset = "0xA68690", VA = "0xA68690", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6002652")]
		[Address(RVA = "0xA686D4", Offset = "0xA686D4", VA = "0xA686D4", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x6002653")]
		[Address(RVA = "0xA68720", Offset = "0xA68720", VA = "0xA68720", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6002654")]
		[Address(RVA = "0xA68758", Offset = "0xA68758", VA = "0xA68758")]
		public void RegisterCallback(Action<List<string>> callback)
		{
		}

		[Token(Token = "0x6002655")]
		[Address(RVA = "0xA68808", Offset = "0xA68808", VA = "0xA68808")]
		public void UnregisterCallback(Action<List<string>> callback)
		{
		}

		[Token(Token = "0x6002656")]
		[Address(RVA = "0xA688B8", Offset = "0xA688B8", VA = "0xA688B8", Slot = "10")]
		public List<BatchableOperation> SignalBroadcasted(Signal signal)
		{
			return null;
		}
	}
}
