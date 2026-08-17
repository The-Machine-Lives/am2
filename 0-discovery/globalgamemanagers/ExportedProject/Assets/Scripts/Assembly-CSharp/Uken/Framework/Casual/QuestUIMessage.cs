using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004BA")]
	public class QuestUIMessage
	{
		[Token(Token = "0x400161A")]
		[FieldOffset(Offset = "0x10")]
		public EQuestMessageSource source;

		[Token(Token = "0x400161B")]
		[FieldOffset(Offset = "0x18")]
		public HashSet<string> untouchedQuests;

		[Token(Token = "0x400161C")]
		[FieldOffset(Offset = "0x20")]
		public HashSet<string> completedQuests;

		[Token(Token = "0x400161D")]
		[FieldOffset(Offset = "0x28")]
		public HashSet<string> touchedQuests;

		[Token(Token = "0x6002397")]
		[Address(RVA = "0xA80B1C", Offset = "0xA80B1C", VA = "0xA80B1C")]
		public QuestUIMessage()
		{
		}
	}
}
