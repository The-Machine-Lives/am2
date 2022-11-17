using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Library.Audio
{
	[Serializable]
	[Token(Token = "0x2000441")]
	public class UkenSoundBank
	{
		[Token(Token = "0x40013B9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string soundBankName;

		[Token(Token = "0x40013BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public SoundEventDictionary soundEvents;

		[Token(Token = "0x40013BB")]
		[FieldOffset(Offset = "0x20")]
		private List<UkenSoundEvent> currentlyLoopingSounds;

		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0xAF6FBC", Offset = "0xAF6FBC", VA = "0xAF6FBC")]
		public UkenSoundBank(string aSoundBankName)
		{
		}

		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0xAF7034", Offset = "0xAF7034", VA = "0xAF7034")]
		private void StopAllLoopingSounds()
		{
		}
	}
}
