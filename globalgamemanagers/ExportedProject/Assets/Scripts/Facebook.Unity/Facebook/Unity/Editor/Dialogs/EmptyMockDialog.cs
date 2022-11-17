using Il2CppDummyDll;

namespace Facebook.Unity.Editor.Dialogs
{
	[Token(Token = "0x2000078")]
	internal class EmptyMockDialog : EditorFacebookMockDialog
	{
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816640", Offset = "0x816640")]
		private string _003CEmptyDialogTitle_003Ek__BackingField;

		[Token(Token = "0x1700008A")]
		public string EmptyDialogTitle
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0xCD2D50", Offset = "0xCD2D50", VA = "0xCD2D50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x817110", Offset = "0x817110")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0xCD2D58", Offset = "0xCD2D58", VA = "0xCD2D58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x817120", Offset = "0x817120")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		protected override string DialogTitle
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xCD2D60", Offset = "0xCD2D60", VA = "0xCD2D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xCD2D68", Offset = "0xCD2D68", VA = "0xCD2D68", Slot = "5")]
		protected override void DoGui()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xCD2D6C", Offset = "0xCD2D6C", VA = "0xCD2D6C", Slot = "6")]
		protected override void SendSuccessResult()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xCD2EBC", Offset = "0xCD2EBC", VA = "0xCD2EBC")]
		public EmptyMockDialog()
		{
		}
	}
}
