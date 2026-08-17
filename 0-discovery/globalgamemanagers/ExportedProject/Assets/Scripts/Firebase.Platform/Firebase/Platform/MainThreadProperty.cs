using System;
using Il2CppDummyDll;

namespace Firebase.Platform
{
	[Token(Token = "0x2000025")]
	internal class MainThreadProperty<T>
	{
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x0")]
		private Func<T> getPropertyDelegate;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x0")]
		private int lastGetPropertyTickCount;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x0")]
		private T cachedValue;

		[Token(Token = "0x17000024")]
		public T Value
		{
			[Token(Token = "0x6000089")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x6000088")]
		public MainThreadProperty(Func<T> getPropertyDelegate)
		{
		}

		[Token(Token = "0x600008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807D58", Offset = "0x807D58")]
		private T _003Cget_Value_003Em__0()
		{
			return (T)null;
		}
	}
}
