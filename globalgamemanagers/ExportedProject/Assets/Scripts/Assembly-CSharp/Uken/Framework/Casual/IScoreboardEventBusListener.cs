using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000566")]
	public interface IScoreboardEventBusListener
	{
		[Token(Token = "0x600293F")]
		void OnScoreboardEventBusDispatch(ScoreboardEventBusEvent scoreboardEventBusEvent);
	}
}
