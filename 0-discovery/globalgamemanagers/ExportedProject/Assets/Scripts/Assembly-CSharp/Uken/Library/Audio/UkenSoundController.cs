using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;
using UnityEngine;

namespace Uken.Library.Audio
{
	[Token(Token = "0x2000444")]
	public class UkenSoundController : UkenController
	{
		[Token(Token = "0x20007F8")]
		private class SourceData
		{
			[Token(Token = "0x4002302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sKey;

			[Token(Token = "0x4002303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AudioSource oSource;

			[Token(Token = "0x600329A")]
			[Address(RVA = "0xAF9148", Offset = "0xAF9148", VA = "0xAF9148")]
			public SourceData(string s, AudioSource o)
			{
			}
		}

		[Token(Token = "0x20007F9")]
		private class SoundCategoryData
		{
			[Token(Token = "0x4002304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float m_fVolume;

			[Token(Token = "0x4002305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool m_bMute;

			[Token(Token = "0x4002306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AudioSource m_oSource;

			[Token(Token = "0x600329B")]
			[Address(RVA = "0xAF79C4", Offset = "0xAF79C4", VA = "0xAF79C4")]
			public SoundCategoryData(float fVolume, AudioSource oSource)
			{
			}
		}

		[Token(Token = "0x20007FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8211B8", Offset = "0x8211B8")]
		private sealed class _003CFadeInSound_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4002308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4002309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AudioSource src;

			[Token(Token = "0x400230A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float fadeInTime;

			[Token(Token = "0x400230B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float _003CfEndTime_003E5__2;

			[Token(Token = "0x400230C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float _003CfDuration_003E5__3;

			[Token(Token = "0x400230D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float _003CfFinalVolume_003E5__4;

			[Token(Token = "0x1700081D")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600329F")]
				[Address(RVA = "0xAFABC8", Offset = "0xAFABC8", VA = "0xAFABC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700081E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60032A1")]
				[Address(RVA = "0xAFAC38", Offset = "0xAFAC38", VA = "0xAFAC38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600329C")]
			[Address(RVA = "0xAF8FD0", Offset = "0xAF8FD0", VA = "0xAF8FD0")]
			[DebuggerHidden]
			public _003CFadeInSound_003Ed__24(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600329D")]
			[Address(RVA = "0xAFA930", Offset = "0xAFA930", VA = "0xAFA930", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600329E")]
			[Address(RVA = "0xAFA934", Offset = "0xAFA934", VA = "0xAFA934", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60032A0")]
			[Address(RVA = "0xAFABD0", Offset = "0xAFABD0", VA = "0xAFABD0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x20007FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8211C8", Offset = "0x8211C8")]
		private sealed class _003CStopAndFadeOut_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400230E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400230F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4002310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject obj;

			[Token(Token = "0x4002311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float fadeout;

			[Token(Token = "0x4002312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UkenSoundController _003C_003E4__this;

			[Token(Token = "0x4002313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string soundKey;

			[Token(Token = "0x4002314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int category;

			[Token(Token = "0x4002315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private AudioSource _003Csrc_003E5__2;

			[Token(Token = "0x4002316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float _003CfEndTime_003E5__3;

			[Token(Token = "0x4002317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float _003CfDuration_003E5__4;

			[Token(Token = "0x4002318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private float _003CfStartVolume_003E5__5;

			[Token(Token = "0x1700081F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60032A5")]
				[Address(RVA = "0xAFAEE0", Offset = "0xAFAEE0", VA = "0xAFAEE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000820")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60032A7")]
				[Address(RVA = "0xAFAF50", Offset = "0xAFAF50", VA = "0xAFAF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60032A2")]
			[Address(RVA = "0xAF9704", Offset = "0xAF9704", VA = "0xAF9704")]
			[DebuggerHidden]
			public _003CStopAndFadeOut_003Ed__27(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60032A3")]
			[Address(RVA = "0xAFAC40", Offset = "0xAFAC40", VA = "0xAFAC40", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60032A4")]
			[Address(RVA = "0xAFAC44", Offset = "0xAFAC44", VA = "0xAFAC44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60032A6")]
			[Address(RVA = "0xAFAEE8", Offset = "0xAFAEE8", VA = "0xAFAEE8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x20007FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8211D8", Offset = "0x8211D8")]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			[Token(Token = "0x4002319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource src;

			[Token(Token = "0x60032A8")]
			[Address(RVA = "0xAF9730", Offset = "0xAF9730", VA = "0xAF9730")]
			public _003C_003Ec__DisplayClass28_0()
			{
			}

			[Token(Token = "0x60032A9")]
			[Address(RVA = "0xAFA8A4", Offset = "0xAFA8A4", VA = "0xAFA8A4")]
			internal bool _003CStopAndDestroy_003Eb__0(SourceData d)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40013BE")]
		private const string mc_sPlayerPrefsPrefix = "uken_sound_category_";

		[Token(Token = "0x40013BF")]
		private const string mc_sMutedSetting = "mute";

		[Token(Token = "0x40013C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float globalVolume;

		[Token(Token = "0x40013C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool globalMute;

		[Token(Token = "0x40013C2")]
		public const float DefaultCrossfadeDuration = 2f;

		[Token(Token = "0x40013C3")]
		public const int DefaultSourcePriority = 128;

		[Token(Token = "0x40013C4")]
		public const int BGMSourcePriority = 200;

		[Token(Token = "0x40013C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, SoundCategoryData> m_dictCategories;

		[Token(Token = "0x40013C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<int, List<SourceData>> m_dictLoopingSoundEvents;

		[Token(Token = "0x40013C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UkenAudioClip> fadingAudio;

		[Token(Token = "0x40013C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject audioParent;

		[Token(Token = "0x40013C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UkenSoundData m_data;

		[Token(Token = "0x40013CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, UkenSoundData> m_downloadedData;

		[Token(Token = "0x6001FAF")]
		[Address(RVA = "0xAF745C", Offset = "0xAF745C", VA = "0xAF745C")]
		public UkenSoundController(Dictionary<int, CategoryInitData> soundCategories)
		{
		}

		[Token(Token = "0x6001FB0")]
		[Address(RVA = "0xAF7A04", Offset = "0xAF7A04", VA = "0xAF7A04", Slot = "10")]
		public virtual void Deinitialize()
		{
		}

		[Token(Token = "0x6001FB1")]
		[Address(RVA = "0xAF7B88", Offset = "0xAF7B88", VA = "0xAF7B88", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6001FB2")]
		[Address(RVA = "0xAF8208", Offset = "0xAF8208", VA = "0xAF8208", Slot = "7")]
		public override void Update(float fDeltaTime)
		{
		}

		[Token(Token = "0x6001FB3")]
		public T BuildRemoteSoundData<T>(Dictionary<string, List<string>> dictEvents) where T : UkenSoundData
		{
			return null;
		}

		[Token(Token = "0x6001FB4")]
		[Address(RVA = "0xAF834C", Offset = "0xAF834C", VA = "0xAF834C")]
		public void AddRemoteSounds(string bundleReference, UkenSoundData data)
		{
		}

		[Token(Token = "0x6001FB5")]
		[Address(RVA = "0xAF83F0", Offset = "0xAF83F0", VA = "0xAF83F0")]
		protected void FireRemoteSoundEvent(string bundleReference, string eventKey, int nValue, int category, float fadeIn = -1f, [Optional] Action callback)
		{
		}

		[Token(Token = "0x6001FB6")]
		[Address(RVA = "0xAF881C", Offset = "0xAF881C", VA = "0xAF881C")]
		protected AudioSource FireSoundEvent(string eventKey, int nValue, int category, float fadeIn = -1f, [Optional] Action callback)
		{
			return null;
		}

		[Token(Token = "0x6001FB7")]
		[Address(RVA = "0xAF8508", Offset = "0xAF8508", VA = "0xAF8508")]
		private AudioSource FireSoundEventInternal(string eventKey, UkenSoundData data, int nValue, int category, float fadeIn, Action callback)
		{
			return null;
		}

		[Token(Token = "0x6001FB8")]
		[Address(RVA = "0xAF8F38", Offset = "0xAF8F38", VA = "0xAF8F38")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x83906C", Offset = "0x83906C")]
		private IEnumerator FadeInSound(AudioSource src, float fadeInTime)
		{
			return null;
		}

		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0xAF883C", Offset = "0xAF883C", VA = "0xAF883C")]
		private AudioSource PlaySoundEvent(UkenSoundEvent soundEvent, int category, int nValue, float fadeIn, Action onComplete)
		{
			return null;
		}

		[Token(Token = "0x6001FBA")]
		[Address(RVA = "0xAF9180", Offset = "0xAF9180", VA = "0xAF9180")]
		protected void StopAudio(string soundKey, int category, float fadeout = 0f)
		{
		}

		[Token(Token = "0x6001FBB")]
		[Address(RVA = "0xAF9618", Offset = "0xAF9618", VA = "0xAF9618")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8390D0", Offset = "0x8390D0")]
		private IEnumerator StopAndFadeOut(GameObject obj, string soundKey, int category, float fadeout)
		{
			return null;
		}

		[Token(Token = "0x6001FBC")]
		[Address(RVA = "0xAF9374", Offset = "0xAF9374", VA = "0xAF9374")]
		private void StopAndDestroy(GameObject obj, string soundKey, int category)
		{
		}

		[Token(Token = "0x6001FBD")]
		[Address(RVA = "0xAF9738", Offset = "0xAF9738", VA = "0xAF9738")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x839134", Offset = "0x839134")]
		protected void PlayRandomSound(List<string> resourcePaths, int category, UkenSoundModifier randomizer)
		{
		}

		[Token(Token = "0x6001FBE")]
		[Address(RVA = "0xAF982C", Offset = "0xAF982C", VA = "0xAF982C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x839144", Offset = "0x839144")]
		protected void PlaySound(string resourcePath, int category, UkenSoundModifier randomizer)
		{
		}

		[Token(Token = "0x6001FBF")]
		[Address(RVA = "0xAF9AD4", Offset = "0xAF9AD4", VA = "0xAF9AD4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x839154", Offset = "0x839154")]
		public void PlaySound(AudioClip clip, int category, [Optional] UkenSoundModifier randomizer)
		{
		}

		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0xAF9EB8", Offset = "0xAF9EB8", VA = "0xAF9EB8")]
		protected void PlayLoopingAudioSource(string resourcePath, int category, bool crossfade, float fadeDuration)
		{
		}

		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0xAF998C", Offset = "0xAF998C", VA = "0xAF998C")]
		private void LoadAndPlaySound(string resourcePath, int category, UkenSoundModifier randomizer)
		{
		}

		[Token(Token = "0x6001FC2")]
		[Address(RVA = "0xAF9C18", Offset = "0xAF9C18", VA = "0xAF9C18")]
		private void InternalPlaySound(AudioSource source, AudioClip clip, UkenSoundModifier randomizer)
		{
		}

		[Token(Token = "0x6001FC3")]
		[Address(RVA = "0xAFA760", Offset = "0xAFA760", VA = "0xAFA760")]
		protected void SetCategoryVolume(int category, float volume)
		{
		}

		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0xAF9888", Offset = "0xAF9888", VA = "0xAF9888")]
		protected bool CategoryMuted(int category)
		{
			return default(bool);
		}

		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0xAF7FA8", Offset = "0xAF7FA8", VA = "0xAF7FA8")]
		protected void SetCategoryMuted(int category, bool muted)
		{
		}

		[Token(Token = "0x6001FC6")]
		[Address(RVA = "0xAFA87C", Offset = "0xAFA87C", VA = "0xAFA87C", Slot = "11")]
		protected virtual string GetCategoryName(int nCategory)
		{
			return null;
		}

		[Token(Token = "0x6001FC7")]
		[Address(RVA = "0xAF7778", Offset = "0xAF7778", VA = "0xAF7778")]
		private AudioSource GenerateAudioSource(int category, int priority)
		{
			return null;
		}
	}
}
