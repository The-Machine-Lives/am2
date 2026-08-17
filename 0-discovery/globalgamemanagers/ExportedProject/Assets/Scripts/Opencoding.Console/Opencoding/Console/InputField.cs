using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x200000E")]
	internal abstract class InputField
	{
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x10")]
		private string _lastTypedInput;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x18")]
		protected string[] _lastTypedParameters;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81CF5C", Offset = "0x81CF5C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81CF5C", Offset = "0x81CF5C")]
		private Rect _003CHelpButtonRect_003Ek__BackingField;

		[Token(Token = "0x1700001E")]
		public abstract string Input
		{
			[Token(Token = "0x600007E")]
			get;
			[Token(Token = "0x600007F")]
			set;
		}

		[Token(Token = "0x1700001F")]
		public abstract bool HasFocus
		{
			[Token(Token = "0x6000080")]
			get;
		}

		[Token(Token = "0x17000020")]
		public abstract Rect TextFieldRect
		{
			[Token(Token = "0x6000081")]
			get;
		}

		[Token(Token = "0x17000021")]
		public Rect HelpButtonRect
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xE7E4F8", Offset = "0xE7E4F8", VA = "0xE7E4F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DCC8", Offset = "0x81DCC8")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xE89194", Offset = "0xE89194", VA = "0xE89194")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DCD8", Offset = "0x81DCD8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public string LastTypedInput
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xE891A0", Offset = "0xE891A0", VA = "0xE891A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public string[] LastTypedParameters
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xE891A8", Offset = "0xE891A8", VA = "0xE891A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public int CurrentParameterIndex
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xE785C4", Offset = "0xE785C4", VA = "0xE785C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000087")]
		public abstract void OnGUI(Rect containingRect);

		[Token(Token = "0x6000088")]
		public abstract void LoseFocus();

		[Token(Token = "0x6000089")]
		public abstract void Focus();

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xE7BAF4", Offset = "0xE7BAF4", VA = "0xE7BAF4")]
		public void ConfirmInput()
		{
		}

		[Token(Token = "0x600008B")]
		public abstract void ClearInput();

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xE891B0", Offset = "0xE891B0", VA = "0xE891B0")]
		protected InputField()
		{
		}
	}
}
