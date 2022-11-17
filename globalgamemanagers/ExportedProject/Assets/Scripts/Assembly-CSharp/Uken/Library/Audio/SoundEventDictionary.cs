using System;
using Il2CppDummyDll;
using Uken.Core.Extensions;

namespace Uken.Library.Audio
{
	[Serializable]
	[Token(Token = "0x2000446")]
	public class SoundEventDictionary : SerializableDictionary<string, UkenSoundEvent>
	{
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0xAF6F20", Offset = "0xAF6F20", VA = "0xAF6F20")]
		public SoundEventDictionary()
		{
		}
	}
}
