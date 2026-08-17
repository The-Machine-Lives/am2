using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual.Signals
{
	[Token(Token = "0x200058A")]
	public interface ISignalsAndStorageListener
	{
		[Token(Token = "0x6002A6A")]
		List<BatchableOperation> SignalBroadcasted(Signal signalData);
	}
}
