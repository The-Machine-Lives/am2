using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000008")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x2000029")]
		public enum SelectedTouchDetector
		{
			[Token(Token = "0x400012F")]
			NONE = 0,
			[Token(Token = "0x4000130")]
			TWO_FINGER_SWIPE_DOWN = 1,
			[Token(Token = "0x4000131")]
			THREE_FINGERS_HELD = 2
		}

		[Token(Token = "0x200002A")]
		public enum SelectedScreenshotCaptureMode
		{
			[Token(Token = "0x4000133")]
			DISABLED = 0,
			[Token(Token = "0x4000134")]
			CAPTURE_MAIN_CAMERA = 1,
			[Token(Token = "0x4000135")]
			CAPTURE_FULL_SCREEN = 2
		}

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CB40", Offset = "0x81CB40")]
		public new bool DontDestroyOnLoad;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CB78", Offset = "0x81CB78")]
		public bool AutoSetVersion;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CBB0", Offset = "0x81CBB0")]
		public string GameVersion;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CBE8", Offset = "0x81CBE8")]
		public string EnableIfDefined;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CC20", Offset = "0x81CC20")]
		public string DisableIfDefined;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CC58", Offset = "0x81CC58")]
		public bool OnlyInDevBuilds;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x39")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CC90", Offset = "0x81CC90")]
		public bool ShowOnException;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CCC8", Offset = "0x81CCC8")]
		public SelectedTouchDetector TouchDetector;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CD00", Offset = "0x81CD00")]
		public string OpenAndCloseKeys;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CD38", Offset = "0x81CD38")]
		public bool ShowSeparateExceptionButton;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CD70", Offset = "0x81CD70")]
		public bool ShowSeparateAssertButton;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x4A")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CDA8", Offset = "0x81CDA8")]
		public bool DisableUGUIWhenOpen;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x4B")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CDE0", Offset = "0x81CDE0")]
		public bool PauseGameWhenOpen;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CE18", Offset = "0x81CE18")]
		public bool ShowRecentCommands;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CE50", Offset = "0x81CE50")]
		public string DefaultToEmailAddress;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RangeAttribute", RVA = "0x81CE88", Offset = "0x81CE88")]
		public float EditorScaleFactor;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x81CEA0", Offset = "0x81CEA0")]
		public float MobileScaleFactorPortrait;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RangeAttribute", RVA = "0x81CEB8", Offset = "0x81CEB8")]
		public float MobileScaleFactorLandscape;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "RangeAttribute", RVA = "0x81CED0", Offset = "0x81CED0")]
		public float StandaloneScaleFactor;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81CEE8", Offset = "0x81CEE8")]
		public SelectedScreenshotCaptureMode LogScreenshotCaptureMode;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x6C")]
		private float _oldEditorScaleFactor;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x70")]
		private float _oldMobileScaleFactorLandscape;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x74")]
		private float _oldMobileScaleFactorPortrait;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x78")]
		private float _oldStandaloneScaleFactor;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xE7B3E4", Offset = "0xE7B3E4", VA = "0xE7B3E4")]
		public bool HasChangedSinceLastCall()
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE902DC", Offset = "0xE902DC", VA = "0xE902DC")]
		public Settings()
		{
		}
	}
}
