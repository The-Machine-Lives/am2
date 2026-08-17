using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000338")]
	public interface IActionScene : IReferenceable, IWeighted, IItemModel, IInfoText
	{
		[Token(Token = "0x1700040D")]
		EActionSceneType sceneType
		{
			[Token(Token = "0x60019D3")]
			get;
		}

		[Token(Token = "0x1700040E")]
		RewardGroup onStartRewardGroup
		{
			[Token(Token = "0x60019D4")]
			get;
		}

		[Token(Token = "0x1700040F")]
		List<IAbilityEffect> friendlyStartEffects
		{
			[Token(Token = "0x60019D5")]
			get;
		}

		[Token(Token = "0x60019D6")]
		List<Reward> GetSceneRewards();

		[Token(Token = "0x60019D7")]
		long GetQuantity();

		[Token(Token = "0x60019D8")]
		bool IsSceneInfinite();

		[Token(Token = "0x60019D9")]
		bool IsQuantityReached();

		[Token(Token = "0x60019DA")]
		void OnSceneStart(ZoneController zoneController);
	}
}
