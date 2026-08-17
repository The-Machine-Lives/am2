using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000016")]
	public abstract class TouchScreenKeyboardInterface
	{
		[Token(Token = "0x200002F")]
		public enum TouchScreenKeyboardTypeProxy
		{
			[Token(Token = "0x4000144")]
			Default = 0,
			[Token(Token = "0x4000145")]
			ASCIICapable = 1,
			[Token(Token = "0x4000146")]
			NumbersAndPunctuation = 2,
			[Token(Token = "0x4000147")]
			URL = 3,
			[Token(Token = "0x4000148")]
			NumberPad = 4,
			[Token(Token = "0x4000149")]
			PhonePad = 5,
			[Token(Token = "0x400014A")]
			NamePhonePad = 6,
			[Token(Token = "0x400014B")]
			EmailAddress = 7
		}

		[Token(Token = "0x1700005F")]
		public abstract string text
		{
			[Token(Token = "0x600013B")]
			get;
			[Token(Token = "0x600013C")]
			set;
		}

		[Token(Token = "0x17000060")]
		public abstract bool hideInput
		{
			[Token(Token = "0x600013D")]
			get;
			[Token(Token = "0x600013E")]
			set;
		}

		[Token(Token = "0x17000061")]
		public abstract bool active
		{
			[Token(Token = "0x600013F")]
			get;
			[Token(Token = "0x6000140")]
			set;
		}

		[Token(Token = "0x17000062")]
		public abstract bool done
		{
			[Token(Token = "0x6000141")]
			get;
		}

		[Token(Token = "0x17000063")]
		public abstract bool wasCanceled
		{
			[Token(Token = "0x6000142")]
			get;
		}

		[Token(Token = "0x17000064")]
		public abstract Rect area
		{
			[Token(Token = "0x6000143")]
			get;
		}

		[Token(Token = "0x17000065")]
		public abstract bool visible
		{
			[Token(Token = "0x6000144")]
			get;
		}

		[Token(Token = "0x6000145")]
		~TouchScreenKeyboardInterface();

		[Token(Token = "0x6000146")]
		public abstract TouchScreenKeyboardProxy Open(string text, TouchScreenKeyboardTypeProxy keyboardType, bool autocorrection, bool multiline, bool secure, bool alert);

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x17DCC20", Offset = "0x17DCC20", VA = "0x17DCC20")]
		protected TouchScreenKeyboardInterface()
		{
		}
	}
}
