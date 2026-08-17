using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000019")]
	public class TouchScreenKeyboardProxy
	{
		[Token(Token = "0x2000030")]
		public enum TouchScreenKeyboardTypeProxy
		{
			[Token(Token = "0x400014D")]
			Default = 0,
			[Token(Token = "0x400014E")]
			ASCIICapable = 1,
			[Token(Token = "0x400014F")]
			NumbersAndPunctuation = 2,
			[Token(Token = "0x4000150")]
			URL = 3,
			[Token(Token = "0x4000151")]
			NumberPad = 4,
			[Token(Token = "0x4000152")]
			PhonePad = 5,
			[Token(Token = "0x4000153")]
			NamePhonePad = 6,
			[Token(Token = "0x4000154")]
			EmailAddress = 7
		}

		[Token(Token = "0x2000031")]
		public enum Status
		{
			[Token(Token = "0x4000156")]
			Visible = 0,
			[Token(Token = "0x4000157")]
			Done = 1,
			[Token(Token = "0x4000158")]
			Canceled = 2,
			[Token(Token = "0x4000159")]
			LostFocus = 3
		}

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x10")]
		private object _keyboardObject;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type _touchScreenKeyboardTypeType;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly MethodInfo _destroyMethod;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x10")]
		private static readonly MethodInfo _openMethod;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x18")]
		private static MethodInfo _textPropertyGet;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x20")]
		private static MethodInfo _textPropertySet;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x28")]
		private static MethodInfo _hideInputPropertyGet;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x30")]
		private static MethodInfo _hideInputPropertySet;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x38")]
		private static MethodInfo _activePropertyGet;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x40")]
		private static MethodInfo _activePropertySet;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x48")]
		private static MethodInfo _donePropertyGet;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x50")]
		private static MethodInfo _wasCanceledPropertyGet;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x58")]
		private static MethodInfo _statusPropertyGet;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x60")]
		private static MethodInfo _areaPropertyGet;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x68")]
		private static MethodInfo _visiblePropertyGet;

		[Token(Token = "0x1700006B")]
		public string text
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x17DCDC4", Offset = "0x17DCDC4", VA = "0x17DCDC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x17DD828", Offset = "0x17DD828", VA = "0x17DD828")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public static bool hideInput
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x17DEE4C", Offset = "0x17DEE4C", VA = "0x17DEE4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x17DDA8C", Offset = "0x17DDA8C", VA = "0x17DDA8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public bool active
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x17DCF64", Offset = "0x17DCF64", VA = "0x17DCF64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x17DD008", Offset = "0x17DD008", VA = "0x17DD008")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public Status status
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x17DCEC0", Offset = "0x17DCEC0", VA = "0x17DCEC0")]
			get
			{
				return default(Status);
			}
		}

		[Token(Token = "0x1700006F")]
		public bool done
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x17DEF24", Offset = "0x17DEF24", VA = "0x17DEF24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		public bool wasCanceled
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x17DEFC8", Offset = "0x17DEFC8", VA = "0x17DEFC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public static Rect area
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x17DD74C", Offset = "0x17DD74C", VA = "0x17DD74C")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x17000072")]
		public static bool visible
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x17DF06C", Offset = "0x17DF06C", VA = "0x17DF06C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x17DE678", Offset = "0x17DE678", VA = "0x17DE678")]
		static TouchScreenKeyboardProxy()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x17DF144", Offset = "0x17DF144", VA = "0x17DF144", Slot = "1")]
		~TouchScreenKeyboardProxy()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x17DDBD4", Offset = "0x17DDBD4", VA = "0x17DDBD4")]
		public static TouchScreenKeyboardProxy Open(string text, TouchScreenKeyboardTypeProxy keyboardType, bool autocorrection, bool multiline, bool secure, bool alert)
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x17DF23C", Offset = "0x17DF23C", VA = "0x17DF23C")]
		public TouchScreenKeyboardProxy()
		{
		}
	}
}
