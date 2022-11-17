using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x2000257")]
	internal static class JavaUtils
	{
		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x0")]
		private static ConstructorInfo IntPtrConstructor;

		[Token(Token = "0x6001146")]
		[Address(RVA = "0x13325DC", Offset = "0x13325DC", VA = "0x13325DC")]
		internal static AndroidJavaObject JavaObjectFromPointer(IntPtr jobject)
		{
			return null;
		}

		[Token(Token = "0x6001147")]
		[Address(RVA = "0x1332794", Offset = "0x1332794", VA = "0x1332794")]
		internal static AndroidJavaObject NullSafeCall(this AndroidJavaObject target, string methodName, params object[] args)
		{
			return null;
		}
	}
}
