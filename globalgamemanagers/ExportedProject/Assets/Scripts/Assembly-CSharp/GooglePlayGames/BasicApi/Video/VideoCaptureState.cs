using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	[Token(Token = "0x20002E9")]
	public class VideoCaptureState
	{
		[Token(Token = "0x4000DC2")]
		[FieldOffset(Offset = "0x10")]
		private bool mIsCapturing;

		[Token(Token = "0x4000DC3")]
		[FieldOffset(Offset = "0x14")]
		private VideoCaptureMode mCaptureMode;

		[Token(Token = "0x4000DC4")]
		[FieldOffset(Offset = "0x18")]
		private VideoQualityLevel mQualityLevel;

		[Token(Token = "0x4000DC5")]
		[FieldOffset(Offset = "0x1C")]
		private bool mIsOverlayVisible;

		[Token(Token = "0x4000DC6")]
		[FieldOffset(Offset = "0x1D")]
		private bool mIsPaused;

		[Token(Token = "0x170002E3")]
		public bool IsCapturing
		{
			[Token(Token = "0x6001700")]
			[Address(RVA = "0x1466920", Offset = "0x1466920", VA = "0x1466920")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002E4")]
		public VideoCaptureMode CaptureMode
		{
			[Token(Token = "0x6001701")]
			[Address(RVA = "0x1466928", Offset = "0x1466928", VA = "0x1466928")]
			get
			{
				return default(VideoCaptureMode);
			}
		}

		[Token(Token = "0x170002E5")]
		public VideoQualityLevel QualityLevel
		{
			[Token(Token = "0x6001702")]
			[Address(RVA = "0x1466930", Offset = "0x1466930", VA = "0x1466930")]
			get
			{
				return default(VideoQualityLevel);
			}
		}

		[Token(Token = "0x170002E6")]
		public bool IsOverlayVisible
		{
			[Token(Token = "0x6001703")]
			[Address(RVA = "0x1466938", Offset = "0x1466938", VA = "0x1466938")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002E7")]
		public bool IsPaused
		{
			[Token(Token = "0x6001704")]
			[Address(RVA = "0x1466940", Offset = "0x1466940", VA = "0x1466940")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016FF")]
		[Address(RVA = "0x14668BC", Offset = "0x14668BC", VA = "0x14668BC")]
		internal VideoCaptureState(bool isCapturing, VideoCaptureMode captureMode, VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused)
		{
		}

		[Token(Token = "0x6001705")]
		[Address(RVA = "0x1466948", Offset = "0x1466948", VA = "0x1466948", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
