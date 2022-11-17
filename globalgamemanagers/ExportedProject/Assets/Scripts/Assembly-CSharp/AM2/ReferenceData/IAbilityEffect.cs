using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000314")]
	public interface IAbilityEffect : IReferenceable
	{
		[Token(Token = "0x170003A4")]
		bool isChanneled
		{
			[Token(Token = "0x60018ED")]
			get;
		}

		[Token(Token = "0x170003A5")]
		float channelTickIntervalInSeconds
		{
			[Token(Token = "0x60018EE")]
			get;
		}

		[Token(Token = "0x170003A6")]
		EAbilityEffectType effectType
		{
			[Token(Token = "0x60018EF")]
			get;
		}

		[Token(Token = "0x170003A7")]
		string cureTarget
		{
			[Token(Token = "0x60018F0")]
			get;
		}

		[Token(Token = "0x170003A8")]
		List<string> healthTypes
		{
			[Token(Token = "0x60018F1")]
			get;
		}

		[Token(Token = "0x60018F2")]
		string GetSimpleDisplayText(long level);

		[Token(Token = "0x60018F3")]
		List<AbilityTraitDisplay> GetDetailedDisplayText(long level, bool isSelf, bool isPassive);
	}
}
