using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000B4")]
public interface IHudMenuViewAudio
{
	[Token(Token = "0x6000463")]
	AudioSource FireSoundEvent(BISoundEvents.EventKey eventKey, int value = -1, SoundCategory category = SoundCategory.SFX, float fadeIn = -1f, [Optional] Action callback);

	[Token(Token = "0x6000464")]
	void StopSoundEvent(BISoundEvents.EventKey eventKey, SoundCategory category = SoundCategory.SFX, float fadeout = -1f);

	[Token(Token = "0x6000465")]
	void FireRemoteSoundEvent(string sBundleReference, BISoundEvents.EventKey eventKey, int value = -1, SoundCategory category = SoundCategory.SFX, float fadeIn = -1f, [Optional] Action callback);
}
