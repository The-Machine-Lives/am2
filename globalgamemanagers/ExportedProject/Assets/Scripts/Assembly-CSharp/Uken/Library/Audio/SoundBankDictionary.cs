using System;
using Il2CppDummyDll;
using Uken.Core.Extensions;

namespace Uken.Library.Audio
{
	[Serializable]
	[Token(Token = "0x2000445")]
	public class SoundBankDictionary : SerializableDictionary<string, UkenSoundBank>
	{
		[Token(Token = "0x6001FC8")]
		[Address(RVA = "0xAF6ED0", Offset = "0xAF6ED0", VA = "0xAF6ED0")]
		public SoundBankDictionary()
		{
		}
	}
}
