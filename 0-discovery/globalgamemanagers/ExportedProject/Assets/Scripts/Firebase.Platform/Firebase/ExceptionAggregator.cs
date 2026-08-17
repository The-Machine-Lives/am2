using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x2000017")]
	internal class ExceptionAggregator
	{
		[Token(Token = "0x4000032")]
		[ThreadStatic]
		private static List<Exception> threadLocalExceptions;

		[Token(Token = "0x1700001B")]
		private static List<Exception> Exceptions
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x17CF150", Offset = "0x17CF150", VA = "0x17CF150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x17CF234", Offset = "0x17CF234", VA = "0x17CF234")]
		public static Exception GetAndClearPendingExceptions()
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x17CF374", Offset = "0x17CF374", VA = "0x17CF374")]
		public static void ThrowAndClearPendingExceptions()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x17CF414", Offset = "0x17CF414", VA = "0x17CF414")]
		public static Exception LogException(Exception exception)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x17CF03C", Offset = "0x17CF03C", VA = "0x17CF03C")]
		public static void Wrap(Action action)
		{
		}
	}
}
