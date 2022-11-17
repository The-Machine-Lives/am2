using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Library.Audio
{
	[Token(Token = "0x200044B")]
	public class UkenSoundModifier
	{
		[Token(Token = "0x40013F0")]
		[FieldOffset(Offset = "0x10")]
		private float m_fDelay;

		[Token(Token = "0x40013F1")]
		[FieldOffset(Offset = "0x14")]
		private float m_fVolumeDown;

		[Token(Token = "0x40013F2")]
		[FieldOffset(Offset = "0x18")]
		private float m_fVolumeUp;

		[Token(Token = "0x40013F3")]
		[FieldOffset(Offset = "0x1C")]
		private float m_fPitchDown;

		[Token(Token = "0x40013F4")]
		[FieldOffset(Offset = "0x20")]
		private float m_fPitchUp;

		[Token(Token = "0x40013F5")]
		[FieldOffset(Offset = "0x24")]
		private float m_fPanLeft;

		[Token(Token = "0x40013F6")]
		[FieldOffset(Offset = "0x28")]
		private float m_fPanRight;

		[Token(Token = "0x170005B0")]
		public float Delay
		{
			[Token(Token = "0x6001FD3")]
			[Address(RVA = "0xAFA758", Offset = "0xAFA758", VA = "0xAFA758")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6001FD1")]
		[Address(RVA = "0xAFB5D8", Offset = "0xAFB5D8", VA = "0xAFB5D8")]
		public UkenSoundModifier(float delay, float pitchUp, float pitchDown, float panLeft, float panRight)
		{
		}

		[Token(Token = "0x6001FD2")]
		[Address(RVA = "0xAFA62C", Offset = "0xAFA62C", VA = "0xAFA62C")]
		public void ModifySource(AudioSource src)
		{
		}
	}
}
