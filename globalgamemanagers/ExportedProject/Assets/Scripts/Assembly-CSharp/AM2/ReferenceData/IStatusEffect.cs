using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200031C")]
	public interface IStatusEffect : IReferenceable
	{
		[Token(Token = "0x6001934")]
		List<AbilityTraitDisplay> GetDetailedDisplayText(string buffName, long level, bool isSelf, bool isPassive);

		[Token(Token = "0x6001935")]
		BISoundEvents.EventKey GetSoundEventKey(BuffActorEvent buffEvent);
	}
}
