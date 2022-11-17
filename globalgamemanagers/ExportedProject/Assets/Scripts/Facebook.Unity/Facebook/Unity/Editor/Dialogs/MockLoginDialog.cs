using Il2CppDummyDll;

namespace Facebook.Unity.Editor.Dialogs
{
	[Token(Token = "0x2000079")]
	internal class MockLoginDialog : EditorFacebookMockDialog
	{
		[Token(Token = "0x200007A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816130", Offset = "0x816130")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x40000AF")]
			[FieldOffset(Offset = "0x10")]
			public MockLoginDialog _003C_003E4__this;

			[Token(Token = "0x40000B0")]
			[FieldOffset(Offset = "0x18")]
			public string graphDomain;

			[Token(Token = "0x6000291")]
			[Address(RVA = "0xCD3420", Offset = "0xCD3420", VA = "0xCD3420")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0xCD3488", Offset = "0xCD3488", VA = "0xCD3488")]
			internal void _003CSendSuccessResult_003Eb__0(IGraphResult graphResult)
			{
			}
		}

		[Token(Token = "0x200007B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816140", Offset = "0x816140")]
		private sealed class _003C_003Ec__DisplayClass4_1
		{
			[Token(Token = "0x40000B1")]
			[FieldOffset(Offset = "0x10")]
			public string facebookID;

			[Token(Token = "0x40000B2")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6000293")]
			[Address(RVA = "0xCD37D8", Offset = "0xCD37D8", VA = "0xCD37D8")]
			public _003C_003Ec__DisplayClass4_1()
			{
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0xCD37E0", Offset = "0xCD37E0", VA = "0xCD37E0")]
			internal void _003CSendSuccessResult_003Eb__1(IGraphResult permResult)
			{
			}
		}

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x40")]
		private string accessToken;

		[Token(Token = "0x1700008C")]
		protected override string DialogTitle
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xCD2ECC", Offset = "0xCD2ECC", VA = "0xCD2ECC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xCD2F14", Offset = "0xCD2F14", VA = "0xCD2F14", Slot = "5")]
		protected override void DoGui()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xCD3180", Offset = "0xCD3180", VA = "0xCD3180", Slot = "6")]
		protected override void SendSuccessResult()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xCD3428", Offset = "0xCD3428", VA = "0xCD3428")]
		public MockLoginDialog()
		{
		}
	}
}
