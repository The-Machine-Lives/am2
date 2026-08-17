using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x20000A5")]
public class QuestProgressLogData : CasualAnalogData
{
	[Token(Token = "0x6000436")]
	[Address(RVA = "0x9E9338", Offset = "0x9E9338", VA = "0x9E9338")]
	public QuestProgressLogData(Quest quest, Task task, int delta, float taskQuantity)
	{
	}
}
