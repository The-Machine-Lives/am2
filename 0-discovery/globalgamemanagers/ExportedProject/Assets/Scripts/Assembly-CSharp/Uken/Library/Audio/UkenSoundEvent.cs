using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Library.Audio
{
	[Serializable]
	[Token(Token = "0x200044A")]
	public class UkenSoundEvent
	{
		[Token(Token = "0x40013E8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string soundEventName;

		[Token(Token = "0x40013E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<UkenSound> sounds;

		[Token(Token = "0x40013EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public float volume;

		[Token(Token = "0x40013EB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		public float delay;

		[Token(Token = "0x40013EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public bool loops;

		[Token(Token = "0x40013ED")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public UkenSoundPlaybackType playbackType;

		[Token(Token = "0x40013EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public bool fireByValue;

		[Token(Token = "0x40013EF")]
		[FieldOffset(Offset = "0x34")]
		private int m_nIndex;

		[Token(Token = "0x170005AF")]
		public string Description
		{
			[Token(Token = "0x6001FCF")]
			[Address(RVA = "0xAFB590", Offset = "0xAFB590", VA = "0xAFB590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001FCE")]
		[Address(RVA = "0xAFB504", Offset = "0xAFB504", VA = "0xAFB504")]
		public UkenSoundEvent(string aSoundEventName)
		{
		}

		[Token(Token = "0x6001FD0")]
		[Address(RVA = "0xAF8FFC", Offset = "0xAF8FFC", VA = "0xAF8FFC")]
		public UkenSound GetCurrentSound()
		{
			return null;
		}
	}
}
