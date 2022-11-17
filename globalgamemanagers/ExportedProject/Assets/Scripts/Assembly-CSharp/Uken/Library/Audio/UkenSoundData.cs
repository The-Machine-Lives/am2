using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Library.Audio
{
	[Token(Token = "0x2000448")]
	public class UkenSoundData : ScriptableObject
	{
		[Token(Token = "0x20007FD")]
		private class RemoteSoundData
		{
			[Token(Token = "0x400231A")]
			[FieldOffset(Offset = "0x10")]
			public SoundBankDictionary soundBanks;

			[Token(Token = "0x60032AA")]
			public T ToUkenSoundData<T>() where T : UkenSoundData
			{
				return null;
			}

			[Token(Token = "0x60032AB")]
			[Address(RVA = "0xAFB4A0", Offset = "0xAFB4A0", VA = "0xAFB4A0")]
			public RemoteSoundData()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x40013CE")]
		public const string mc_sDefaultBank = "Generic";

		[NonSerialized]
		[Token(Token = "0x40013CF")]
		public const string mc_sDefaultRemoteBank = "Generic";

		[NonSerialized]
		[Token(Token = "0x40013D0")]
		[FieldOffset(Offset = "0x18")]
		public bool showBanks;

		[NonSerialized]
		[Token(Token = "0x40013D1")]
		[FieldOffset(Offset = "0x19")]
		public bool showSoundBankAdds;

		[NonSerialized]
		[Token(Token = "0x40013D2")]
		[FieldOffset(Offset = "0x1A")]
		public bool showSoundBankDeletes;

		[NonSerialized]
		[Token(Token = "0x40013D3")]
		[FieldOffset(Offset = "0x1B")]
		public bool showSoundEventAdds;

		[NonSerialized]
		[Token(Token = "0x40013D4")]
		[FieldOffset(Offset = "0x1C")]
		public bool showSoundEventDeletes;

		[NonSerialized]
		[Token(Token = "0x40013D5")]
		[FieldOffset(Offset = "0x1D")]
		public bool showSoundAdds;

		[NonSerialized]
		[Token(Token = "0x40013D6")]
		[FieldOffset(Offset = "0x1E")]
		public bool showSoundDeletes;

		[NonSerialized]
		[Token(Token = "0x40013D7")]
		[FieldOffset(Offset = "0x1F")]
		public bool showSoundBankNameEdits;

		[NonSerialized]
		[Token(Token = "0x40013D8")]
		[FieldOffset(Offset = "0x20")]
		public bool showSoundEventNameEdits;

		[NonSerialized]
		[Token(Token = "0x40013D9")]
		[FieldOffset(Offset = "0x21")]
		public bool showPlaySoundEvents;

		[NonSerialized]
		[Token(Token = "0x40013DA")]
		[FieldOffset(Offset = "0x22")]
		public bool showPlaySound;

		[NonSerialized]
		[Token(Token = "0x40013DB")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, bool> showSoundBanks;

		[NonSerialized]
		[Token(Token = "0x40013DC")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, bool> showSoundBanksSoundEvents;

		[NonSerialized]
		[Token(Token = "0x40013DD")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, bool> showSoundEvents;

		[NonSerialized]
		[Token(Token = "0x40013DE")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, bool> showSoundEventsSounds;

		[NonSerialized]
		[Token(Token = "0x40013DF")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, bool> showSounds;

		[Token(Token = "0x40013E0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public SoundBankDictionary soundBanks;

		[NonSerialized]
		[Token(Token = "0x40013E1")]
		[FieldOffset(Offset = "0x58")]
		private bool m_bInit;

		[Token(Token = "0x40013E2")]
		[FieldOffset(Offset = "0x60")]
		protected UkenSoundBankData bankInfo;

		[Token(Token = "0x40013E3")]
		public const string UkenSoundAssetName = "UkenSoundData";

		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0xAFAF58", Offset = "0xAFAF58", VA = "0xAFAF58", Slot = "4")]
		public virtual void InitializeSoundBankData()
		{
		}

		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0xAFAFB8", Offset = "0xAFAFB8", VA = "0xAFAFB8")]
		private UkenSoundEvent GetSoundEvent(string sKey)
		{
			return null;
		}

		[Token(Token = "0x6001FCC")]
		public T BuildFromDictionary<T>(Dictionary<string, List<string>> sounds) where T : UkenSoundData
		{
			return null;
		}

		[Token(Token = "0x6001FCD")]
		[Address(RVA = "0xAFB398", Offset = "0xAFB398", VA = "0xAFB398")]
		public UkenSoundData()
		{
		}
	}
}
