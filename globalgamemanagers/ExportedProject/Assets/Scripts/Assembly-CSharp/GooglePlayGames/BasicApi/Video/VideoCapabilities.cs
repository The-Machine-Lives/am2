using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	[Token(Token = "0x20002E8")]
	public class VideoCapabilities
	{
		[Serializable]
		[Token(Token = "0x200079C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F58", Offset = "0x820F58")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002214")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4002215")]
			[FieldOffset(Offset = "0x8")]
			public static Func<bool, string> _003C_003E9__14_0;

			[Token(Token = "0x4002216")]
			[FieldOffset(Offset = "0x10")]
			public static Func<bool, string> _003C_003E9__14_1;

			[Token(Token = "0x6003195")]
			[Address(RVA = "0x146685C", Offset = "0x146685C", VA = "0x146685C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6003196")]
			[Address(RVA = "0x1466864", Offset = "0x1466864", VA = "0x1466864")]
			internal string _003CToString_003Eb__14_0(bool p)
			{
				return null;
			}

			[Token(Token = "0x6003197")]
			[Address(RVA = "0x1466890", Offset = "0x1466890", VA = "0x1466890")]
			internal string _003CToString_003Eb__14_1(bool p)
			{
				return null;
			}
		}

		[Token(Token = "0x4000DBD")]
		[FieldOffset(Offset = "0x10")]
		private bool mIsCameraSupported;

		[Token(Token = "0x4000DBE")]
		[FieldOffset(Offset = "0x11")]
		private bool mIsMicSupported;

		[Token(Token = "0x4000DBF")]
		[FieldOffset(Offset = "0x12")]
		private bool mIsWriteStorageSupported;

		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0x18")]
		private bool[] mCaptureModesSupported;

		[Token(Token = "0x4000DC1")]
		[FieldOffset(Offset = "0x20")]
		private bool[] mQualityLevelsSupported;

		[Token(Token = "0x170002E0")]
		public bool IsCameraSupported
		{
			[Token(Token = "0x60016F9")]
			[Address(RVA = "0x146624C", Offset = "0x146624C", VA = "0x146624C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002E1")]
		public bool IsMicSupported
		{
			[Token(Token = "0x60016FA")]
			[Address(RVA = "0x1466254", Offset = "0x1466254", VA = "0x1466254")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002E2")]
		public bool IsWriteStorageSupported
		{
			[Token(Token = "0x60016FB")]
			[Address(RVA = "0x146625C", Offset = "0x146625C", VA = "0x146625C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x14661E8", Offset = "0x14661E8", VA = "0x14661E8")]
		internal VideoCapabilities(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported)
		{
		}

		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x1466264", Offset = "0x1466264", VA = "0x1466264")]
		public bool SupportsCaptureMode(VideoCaptureMode captureMode)
		{
			return default(bool);
		}

		[Token(Token = "0x60016FD")]
		[Address(RVA = "0x1466334", Offset = "0x1466334", VA = "0x1466334")]
		public bool SupportsQualityLevel(VideoQualityLevel qualityLevel)
		{
			return default(bool);
		}

		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x1466404", Offset = "0x1466404", VA = "0x1466404", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
