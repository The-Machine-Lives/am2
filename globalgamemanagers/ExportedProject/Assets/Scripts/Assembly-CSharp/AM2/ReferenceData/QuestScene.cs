using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000344")]
	public class QuestScene : ActionScene<RDQuestScene>
	{
		[Token(Token = "0x4000FF7")]
		[FieldOffset(Offset = "0x50")]
		private QuestController m_questController;

		[Token(Token = "0x17000421")]
		public string text
		{
			[Token(Token = "0x6001A0A")]
			[Address(RVA = "0x9B9D94", Offset = "0x9B9D94", VA = "0x9B9D94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000422")]
		public string questReference
		{
			[Token(Token = "0x6001A0B")]
			[Address(RVA = "0x9B1C84", Offset = "0x9B1C84", VA = "0x9B1C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x9B9DC0", Offset = "0x9B9DC0", VA = "0x9B9DC0")]
		public QuestScene()
		{
		}

		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x9B9ED0", Offset = "0x9B9ED0", VA = "0x9B9ED0", Slot = "21")]
		public override void OnSceneStart(ZoneController zoneController)
		{
		}
	}
}
