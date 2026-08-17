using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004FD")]
	public enum GameTriggerType
	{
		[Token(Token = "0x400178B")]
		Invalid = 0,
		[Token(Token = "0x400178C")]
		CollectionProgress = 1,
		[Token(Token = "0x400178D")]
		GoalEventProgress = 2,
		[Token(Token = "0x400178E")]
		EventTicketActivated = 3,
		[Token(Token = "0x400178F")]
		EventTicketDeactivated = 4,
		[Token(Token = "0x4001790")]
		TutorialComplete = 5,
		[Token(Token = "0x4001791")]
		LapsedSpenderMinutes = 6,
		[Token(Token = "0x4001792")]
		LevelUp = 7
	}
}
