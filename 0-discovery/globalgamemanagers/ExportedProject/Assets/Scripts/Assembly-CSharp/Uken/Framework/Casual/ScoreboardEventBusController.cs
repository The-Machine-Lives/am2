using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000565")]
	public class ScoreboardEventBusController : UkenController
	{
		[Token(Token = "0x400199D")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<int, List<IScoreboardEventBusListener>> m_eventBusListeners;

		[Token(Token = "0x400199E")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<IScoreboardEventBusListener> m_eventBusGlobalListeners;

		[Token(Token = "0x6002937")]
		[Address(RVA = "0xA90FC8", Offset = "0xA90FC8", VA = "0xA90FC8")]
		public ScoreboardEventBusController()
		{
		}

		[Token(Token = "0x6002938")]
		[Address(RVA = "0xA91064", Offset = "0xA91064", VA = "0xA91064")]
		public void RegisterListener(IScoreboardEventBusListener eventBusListener)
		{
		}

		[Token(Token = "0x6002939")]
		[Address(RVA = "0xA91110", Offset = "0xA91110", VA = "0xA91110")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x83A52C", Offset = "0x83A52C")]
		public void RegisterListener(IScoreboardEventBusListener listener, IEnumerable<int> events)
		{
		}

		[Token(Token = "0x600293A")]
		[Address(RVA = "0xA91498", Offset = "0xA91498", VA = "0xA91498")]
		public void DispatchEvent(int scoreboardEventBusEventType, int scoreboardEventBusEventValue)
		{
		}

		[Token(Token = "0x600293B")]
		[Address(RVA = "0xA91550", Offset = "0xA91550", VA = "0xA91550")]
		protected void DispatchEvent(ScoreboardEventBusEvent scoreboardEventBusEvent)
		{
		}

		[Token(Token = "0x600293C")]
		[Address(RVA = "0xA9155C", Offset = "0xA9155C", VA = "0xA9155C")]
		protected void DispatchEvents(IDictionary<int, int> scoreboardEventBusEvents)
		{
		}

		[Token(Token = "0x600293D")]
		[Address(RVA = "0xA91868", Offset = "0xA91868", VA = "0xA91868")]
		public void DispatchEvents(List<ScoreboardEventBusEvent> scoreboardEventBusEvents)
		{
		}

		[Token(Token = "0x600293E")]
		[Address(RVA = "0xA91928", Offset = "0xA91928", VA = "0xA91928", Slot = "10")]
		protected virtual void DispatchEventToListeners(ScoreboardEventBusEvent scoreboardEventBusEvent)
		{
		}
	}
}
