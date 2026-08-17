using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003A1")]
	public class QuestSystem : RuntimeData<RDQuestSystem>
	{
		[Token(Token = "0x1700053B")]
		public string questTabUnlocker
		{
			[Token(Token = "0x6001C53")]
			[Address(RVA = "0x9BA000", Offset = "0x9BA000", VA = "0x9BA000")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C54")]
		[Address(RVA = "0x9BA02C", Offset = "0x9BA02C", VA = "0x9BA02C")]
		public QuestSystem()
		{
		}
	}
}
