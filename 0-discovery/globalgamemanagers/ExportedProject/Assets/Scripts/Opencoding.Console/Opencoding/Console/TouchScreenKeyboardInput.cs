using Il2CppDummyDll;

namespace Opencoding.Console
{
	[Token(Token = "0x2000017")]
	internal class TouchScreenKeyboardInput
	{
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x10")]
		private string _text;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DA9C", Offset = "0x81DA9C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81DA9C", Offset = "0x81DA9C")]
		private bool _003CIsDone_003Ek__BackingField;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DAD8", Offset = "0x81DAD8")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81DAD8", Offset = "0x81DAD8")]
		private bool _003CWasCancelled_003Ek__BackingField;

		[Token(Token = "0x17000066")]
		public string Text
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x17DCA70", Offset = "0x17DCA70", VA = "0x17DCA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x17DCA78", Offset = "0x17DCA78", VA = "0x17DCA78")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public bool IsDone
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x17DCB30", Offset = "0x17DCB30", VA = "0x17DCB30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81E2C8", Offset = "0x81E2C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x17DCB38", Offset = "0x17DCB38", VA = "0x17DCB38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81E2D8", Offset = "0x81E2D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public bool WasCancelled
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x17DCB44", Offset = "0x17DCB44", VA = "0x17DCB44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81E2E8", Offset = "0x81E2E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x17DCB4C", Offset = "0x17DCB4C", VA = "0x17DCB4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81E2F8", Offset = "0x81E2F8")]
			set
			{
			}
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x17DCB58", Offset = "0x17DCB58", VA = "0x17DCB58")]
		public void SetTextFromKeyboard(string text)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x17DCBC8", Offset = "0x17DCBC8", VA = "0x17DCBC8")]
		public TouchScreenKeyboardInput()
		{
		}
	}
}
