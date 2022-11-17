using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Firebase.Analytics
{
	[Token(Token = "0x2000003")]
	internal class FirebaseAnalyticsPINVOKE
	{
		[Token(Token = "0x2000004")]
		protected class SWIGExceptionHelper
		{
			[Token(Token = "0x2000005")]
			public delegate void ExceptionDelegate(string message);

			[Token(Token = "0x2000006")]
			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			[Token(Token = "0x4000004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static ExceptionDelegate applicationDelegate;

			[Token(Token = "0x4000005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static ExceptionDelegate arithmeticDelegate;

			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static ExceptionDelegate divideByZeroDelegate;

			[Token(Token = "0x4000007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static ExceptionDelegate indexOutOfRangeDelegate;

			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static ExceptionDelegate invalidCastDelegate;

			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static ExceptionDelegate invalidOperationDelegate;

			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static ExceptionDelegate ioDelegate;

			[Token(Token = "0x400000B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static ExceptionDelegate nullReferenceDelegate;

			[Token(Token = "0x400000C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static ExceptionDelegate outOfMemoryDelegate;

			[Token(Token = "0x400000D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static ExceptionDelegate overflowDelegate;

			[Token(Token = "0x400000E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static ExceptionDelegate systemDelegate;

			[Token(Token = "0x400000F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static ExceptionArgumentDelegate argumentDelegate;

			[Token(Token = "0x4000010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static ExceptionArgumentDelegate argumentNullDelegate;

			[Token(Token = "0x4000011")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			[Token(Token = "0x6000008")]
			[Address(RVA = "0x17FD30C", Offset = "0x17FD30C", VA = "0x17FD30C")]
			static SWIGExceptionHelper()
			{
			}

			[Token(Token = "0x6000009")]
			[Address(RVA = "0x17FC7A8", Offset = "0x17FC7A8", VA = "0x17FC7A8")]
			public SWIGExceptionHelper()
			{
			}

			[PreserveSig]
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x17FD628", Offset = "0x17FD628", VA = "0x17FD628")]
			public static extern void SWIGRegisterExceptionCallbacks_FirebaseAnalytics(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x17FD7B0", Offset = "0x17FD7B0", VA = "0x17FD7B0")]
			public static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseAnalytics(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			[Token(Token = "0x600000C")]
			[Address(RVA = "0x17FC9F4", Offset = "0x17FC9F4", VA = "0x17FC9F4")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817390", Offset = "0x817390")]
			private static void SetPendingApplicationException(string message)
			{
			}

			[Token(Token = "0x600000D")]
			[Address(RVA = "0x17FCA90", Offset = "0x17FCA90", VA = "0x17FCA90")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8173F4", Offset = "0x8173F4")]
			private static void SetPendingArithmeticException(string message)
			{
			}

			[Token(Token = "0x600000E")]
			[Address(RVA = "0x17FCB2C", Offset = "0x17FCB2C", VA = "0x17FCB2C")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817458", Offset = "0x817458")]
			private static void SetPendingDivideByZeroException(string message)
			{
			}

			[Token(Token = "0x600000F")]
			[Address(RVA = "0x17FCBC8", Offset = "0x17FCBC8", VA = "0x17FCBC8")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8174BC", Offset = "0x8174BC")]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			[Token(Token = "0x6000010")]
			[Address(RVA = "0x17FCC64", Offset = "0x17FCC64", VA = "0x17FCC64")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817520", Offset = "0x817520")]
			private static void SetPendingInvalidCastException(string message)
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x17FCD00", Offset = "0x17FCD00", VA = "0x17FCD00")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817584", Offset = "0x817584")]
			private static void SetPendingInvalidOperationException(string message)
			{
			}

			[Token(Token = "0x6000012")]
			[Address(RVA = "0x17FCD9C", Offset = "0x17FCD9C", VA = "0x17FCD9C")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8175E8", Offset = "0x8175E8")]
			private static void SetPendingIOException(string message)
			{
			}

			[Token(Token = "0x6000013")]
			[Address(RVA = "0x17FCE38", Offset = "0x17FCE38", VA = "0x17FCE38")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x81764C", Offset = "0x81764C")]
			private static void SetPendingNullReferenceException(string message)
			{
			}

			[Token(Token = "0x6000014")]
			[Address(RVA = "0x17FCED4", Offset = "0x17FCED4", VA = "0x17FCED4")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8176B0", Offset = "0x8176B0")]
			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			[Token(Token = "0x6000015")]
			[Address(RVA = "0x17FCF70", Offset = "0x17FCF70", VA = "0x17FCF70")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817714", Offset = "0x817714")]
			private static void SetPendingOverflowException(string message)
			{
			}

			[Token(Token = "0x6000016")]
			[Address(RVA = "0x17FD00C", Offset = "0x17FD00C", VA = "0x17FD00C")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817778", Offset = "0x817778")]
			private static void SetPendingSystemException(string message)
			{
			}

			[Token(Token = "0x6000017")]
			[Address(RVA = "0x17FD0A8", Offset = "0x17FD0A8", VA = "0x17FD0A8")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8177DC", Offset = "0x8177DC")]
			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			[Token(Token = "0x6000018")]
			[Address(RVA = "0x17FD14C", Offset = "0x17FD14C", VA = "0x17FD14C")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817840", Offset = "0x817840")]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			[Token(Token = "0x6000019")]
			[Address(RVA = "0x17FD22C", Offset = "0x17FD22C", VA = "0x17FD22C")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8178A4", Offset = "0x8178A4")]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}
		}

		[Token(Token = "0x2000007")]
		public class SWIGPendingException
		{
			[Token(Token = "0x4000012")]
			[ThreadStatic]
			private static Exception pendingException;

			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int numExceptionsPending;

			[Token(Token = "0x6000022")]
			[Address(RVA = "0x17FDA20", Offset = "0x17FDA20", VA = "0x17FDA20")]
			public static void Set(Exception e)
			{
			}

			[Token(Token = "0x6000023")]
			[Address(RVA = "0x17FD884", Offset = "0x17FD884", VA = "0x17FD884")]
			public static Exception Retrieve()
			{
				return null;
			}
		}

		[Token(Token = "0x2000008")]
		protected class SWIGStringHelper
		{
			[Token(Token = "0x2000009")]
			public delegate string SWIGStringDelegate(string message);

			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static SWIGStringDelegate stringDelegate;

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x17FEB6C", Offset = "0x17FEB6C", VA = "0x17FEB6C")]
			static SWIGStringHelper()
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x17FC7B0", Offset = "0x17FC7B0", VA = "0x17FC7B0")]
			public SWIGStringHelper()
			{
			}

			[PreserveSig]
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x17FEC00", Offset = "0x17FEC00", VA = "0x17FEC00")]
			public static extern void SWIGRegisterStringCallback_FirebaseAnalytics(SWIGStringDelegate stringDelegate);

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x17FEB68", Offset = "0x17FEB68", VA = "0x17FEB68")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817908", Offset = "0x817908")]
			private static string CreateString(string cString)
			{
				return null;
			}
		}

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static SWIGExceptionHelper swigExceptionHelper;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static SWIGStringHelper swigStringHelper;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x17FC714", Offset = "0x17FC714", VA = "0x17FC714")]
		static FirebaseAnalyticsPINVOKE()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x17FC7B8", Offset = "0x17FC7B8", VA = "0x17FC7B8")]
		public static extern IntPtr new_Parameter__SWIG_0(string jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x17FC894", Offset = "0x17FC894", VA = "0x17FC894")]
		public static extern IntPtr new_Parameter__SWIG_1(string jarg1, long jarg2);

		[PreserveSig]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x17FC958", Offset = "0x17FC958", VA = "0x17FC958")]
		public static extern void delete_Parameter(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x17FC650", Offset = "0x17FC650", VA = "0x17FC650")]
		public static extern void LogEvent__SWIG_5(string jarg1, IntPtr arg, int jarg2);
	}
}
