using Il2CppDummyDll;

namespace Facebook.Unity.Editor.Dialogs
{
	[Token(Token = "0x200007C")]
	internal class MockShareDialog : EditorFacebookMockDialog
	{
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816650", Offset = "0x816650")]
		private string _003CSubTitle_003Ek__BackingField;

		[Token(Token = "0x1700008D")]
		public string SubTitle
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0xCD41F8", Offset = "0xCD41F8", VA = "0xCD41F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x817130", Offset = "0x817130")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000296")]
			[Address(RVA = "0xCD4200", Offset = "0xCD4200", VA = "0xCD4200")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x817140", Offset = "0x817140")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		protected override string DialogTitle
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0xCD4208", Offset = "0xCD4208", VA = "0xCD4208", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xCD4268", Offset = "0xCD4268", VA = "0xCD4268", Slot = "5")]
		protected override void DoGui()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xCD426C", Offset = "0xCD426C", VA = "0xCD426C", Slot = "6")]
		protected override void SendSuccessResult()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xCD463C", Offset = "0xCD463C", VA = "0xCD463C", Slot = "7")]
		protected override void SendCancelResult()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xCD44F8", Offset = "0xCD44F8", VA = "0xCD44F8")]
		private string GenerateFakePostID()
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xCD4760", Offset = "0xCD4760", VA = "0xCD4760")]
		public MockShareDialog()
		{
		}
	}
}
