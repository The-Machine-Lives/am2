using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Library.Audio
{
	[Serializable]
	[Token(Token = "0x2000440")]
	public class UkenSound
	{
		[Token(Token = "0x40013B1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string audioPath;

		[Token(Token = "0x40013B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public float volume;

		[Token(Token = "0x40013B3")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public bool useRandomPitch;

		[Token(Token = "0x40013B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public float pitchMin;

		[Token(Token = "0x40013B5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		public float pitchMax;

		[Token(Token = "0x40013B6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public bool localized;

		[Token(Token = "0x40013B7")]
		[FieldOffset(Offset = "0x29")]
		public bool confirmDelete;

		[Token(Token = "0x40013B8")]
		[FieldOffset(Offset = "0x2A")]
		private bool delete;

		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0xAF6F70", Offset = "0xAF6F70", VA = "0xAF6F70")]
		public UkenSound(string sAudioEntry)
		{
		}

		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0xAF6FA8", Offset = "0xAF6FA8", VA = "0xAF6FA8")]
		public bool ShouldDelete()
		{
			return default(bool);
		}

		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0xAF6FB0", Offset = "0xAF6FB0", VA = "0xAF6FB0")]
		public void SetDeleteFlag()
		{
		}
	}
}
