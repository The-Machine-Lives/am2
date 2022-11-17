using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Library.Audio;
using UnityEngine;

[Token(Token = "0x20000B6")]
public class AM2SoundController : UkenSoundController, IHudMenuViewAudio
{
	[Token(Token = "0x4000307")]
	private const float mc_fMusicFadeout = 2f;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool m_bLobbyMusicActive;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool m_bGameMusicActive;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	private bool m_bBonusMusicActive;

	[Token(Token = "0x400030B")]
	private const string mc_sSettingsMutePlayerPrefsPrefix = "uken_local_settings_mute_";

	[Token(Token = "0x6000466")]
	[Address(RVA = "0xAC4BE4", Offset = "0xAC4BE4", VA = "0xAC4BE4")]
	public static bool Muted()
	{
		return default(bool);
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0xAC4CD0", Offset = "0xAC4CD0", VA = "0xAC4CD0")]
	public static AudioSource PlaySoundEvent(BISoundEvents.EventKey eventKey, int value = -1, SoundCategory category = SoundCategory.SFX, float fadeIn = -1f, [Optional] Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0xAC4ED8", Offset = "0xAC4ED8", VA = "0xAC4ED8")]
	public static void StopSound(BISoundEvents.EventKey eventKey, SoundCategory category = SoundCategory.SFX, float fadeout = -1f)
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0xAC50EC", Offset = "0xAC50EC", VA = "0xAC50EC")]
	public static BISoundEvents.EventKey ChooseSoundEvent(BISoundEvents.EventKey defaultEvent, BISoundEvents.EventKey overrideEvent)
	{
		return default(BISoundEvents.EventKey);
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0xAC50F8", Offset = "0xAC50F8", VA = "0xAC50F8")]
	public AM2SoundController()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0xAC5200", Offset = "0xAC5200", VA = "0xAC5200")]
	public void StartGameMusic(string sStageKey)
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0xAC533C", Offset = "0xAC533C", VA = "0xAC533C")]
	public void StopGameMusic()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xAC536C", Offset = "0xAC536C", VA = "0xAC536C")]
	public void StartLobbyMusic()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0xAC53B4", Offset = "0xAC53B4", VA = "0xAC53B4")]
	public void StopLobbyMusic()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0xAC5248", Offset = "0xAC5248", VA = "0xAC5248", Slot = "14")]
	public void FireRemoteSoundEvent(string sBundleReference, BISoundEvents.EventKey eventKey, int value = -1, SoundCategory category = SoundCategory.SFX, float fadeIn = -1f, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0xAC4DFC", Offset = "0xAC4DFC", VA = "0xAC4DFC", Slot = "12")]
	public AudioSource FireSoundEvent(BISoundEvents.EventKey eventKey, int value = -1, SoundCategory category = SoundCategory.SFX, float fadeIn = -1f, [Optional] Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0xAC4FEC", Offset = "0xAC4FEC", VA = "0xAC4FEC", Slot = "13")]
	public void StopSoundEvent(BISoundEvents.EventKey eventKey, SoundCategory category = SoundCategory.SFX, float fadeout = -1f)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0xAC53E4", Offset = "0xAC53E4", VA = "0xAC53E4", Slot = "11")]
	protected override string GetCategoryName(int nCategory)
	{
		return null;
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xAC54EC", Offset = "0xAC54EC", VA = "0xAC54EC")]
	public void SetCategoryVolume(SoundCategory category, float volume)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0xAC54F4", Offset = "0xAC54F4", VA = "0xAC54F4")]
	public bool CategoryMuted(SoundCategory category)
	{
		return default(bool);
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0xAC54FC", Offset = "0xAC54FC", VA = "0xAC54FC")]
	public void SetCategoryMuted(SoundCategory category, bool muted)
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0xAC5508", Offset = "0xAC5508", VA = "0xAC5508", Slot = "5")]
	public override bool LoadContent()
	{
		return default(bool);
	}
}
