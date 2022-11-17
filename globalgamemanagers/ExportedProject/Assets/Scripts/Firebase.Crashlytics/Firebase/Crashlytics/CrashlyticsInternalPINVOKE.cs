using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Firebase.Crashlytics
{
	[Token(Token = "0x2000003")]
	internal class CrashlyticsInternalPINVOKE
	{
		[Token(Token = "0x2000004")]
		protected class SWIGExceptionHelper
		{
			[Token(Token = "0x2000005")]
			public delegate void ExceptionDelegate(string message);

			[Token(Token = "0x2000006")]
			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			[Token(Token = "0x4000003")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static ExceptionDelegate applicationDelegate;

			[Token(Token = "0x4000004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static ExceptionDelegate arithmeticDelegate;

			[Token(Token = "0x4000005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static ExceptionDelegate divideByZeroDelegate;

			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static ExceptionDelegate indexOutOfRangeDelegate;

			[Token(Token = "0x4000007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static ExceptionDelegate invalidCastDelegate;

			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static ExceptionDelegate invalidOperationDelegate;

			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static ExceptionDelegate ioDelegate;

			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static ExceptionDelegate nullReferenceDelegate;

			[Token(Token = "0x400000B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static ExceptionDelegate outOfMemoryDelegate;

			[Token(Token = "0x400000C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static ExceptionDelegate overflowDelegate;

			[Token(Token = "0x400000D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static ExceptionDelegate systemDelegate;

			[Token(Token = "0x400000E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static ExceptionArgumentDelegate argumentDelegate;

			[Token(Token = "0x400000F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static ExceptionArgumentDelegate argumentNullDelegate;

			[Token(Token = "0x4000010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x17A5A60", Offset = "0x17A5A60", VA = "0x17A5A60")]
			static SWIGExceptionHelper()
			{
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x17A354C", Offset = "0x17A354C", VA = "0x17A354C")]
			public SWIGExceptionHelper()
			{
			}

			[PreserveSig]
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x17A5D7C", Offset = "0x17A5D7C", VA = "0x17A5D7C")]
			internal static extern void SWIGRegisterExceptionCallbacks_CrashlyticsInternal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x17A5F04", Offset = "0x17A5F04", VA = "0x17A5F04")]
			internal static extern void SWIGRegisterExceptionCallbacksArgument_CrashlyticsInternal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x17A5148", Offset = "0x17A5148", VA = "0x17A5148")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817C38", Offset = "0x817C38")]
			private static void SetPendingApplicationException(string message)
			{
			}

			[Token(Token = "0x6000032")]
			[Address(RVA = "0x17A51E4", Offset = "0x17A51E4", VA = "0x17A51E4")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817C9C", Offset = "0x817C9C")]
			private static void SetPendingArithmeticException(string message)
			{
			}

			[Token(Token = "0x6000033")]
			[Address(RVA = "0x17A5280", Offset = "0x17A5280", VA = "0x17A5280")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817D00", Offset = "0x817D00")]
			private static void SetPendingDivideByZeroException(string message)
			{
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0x17A531C", Offset = "0x17A531C", VA = "0x17A531C")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817D64", Offset = "0x817D64")]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0x17A53B8", Offset = "0x17A53B8", VA = "0x17A53B8")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817DC8", Offset = "0x817DC8")]
			private static void SetPendingInvalidCastException(string message)
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x17A5454", Offset = "0x17A5454", VA = "0x17A5454")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817E2C", Offset = "0x817E2C")]
			private static void SetPendingInvalidOperationException(string message)
			{
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x17A54F0", Offset = "0x17A54F0", VA = "0x17A54F0")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817E90", Offset = "0x817E90")]
			private static void SetPendingIOException(string message)
			{
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x17A558C", Offset = "0x17A558C", VA = "0x17A558C")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817EF4", Offset = "0x817EF4")]
			private static void SetPendingNullReferenceException(string message)
			{
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x17A5628", Offset = "0x17A5628", VA = "0x17A5628")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817F58", Offset = "0x817F58")]
			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x17A56C4", Offset = "0x17A56C4", VA = "0x17A56C4")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x817FBC", Offset = "0x817FBC")]
			private static void SetPendingOverflowException(string message)
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0x17A5760", Offset = "0x17A5760", VA = "0x17A5760")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x818020", Offset = "0x818020")]
			private static void SetPendingSystemException(string message)
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x17A57FC", Offset = "0x17A57FC", VA = "0x17A57FC")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x818084", Offset = "0x818084")]
			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			[Token(Token = "0x600003D")]
			[Address(RVA = "0x17A58A0", Offset = "0x17A58A0", VA = "0x17A58A0")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8180E8", Offset = "0x8180E8")]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x17A5980", Offset = "0x17A5980", VA = "0x17A5980")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x81814C", Offset = "0x81814C")]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}
		}

		[Token(Token = "0x2000007")]
		public class SWIGPendingException
		{
			[Token(Token = "0x4000011")]
			[ThreadStatic]
			private static Exception pendingException;

			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int numExceptionsPending;

			[Token(Token = "0x17000001")]
			public static bool Pending
			{
				[Token(Token = "0x6000048")]
				[Address(RVA = "0x17A72C0", Offset = "0x17A72C0", VA = "0x17A72C0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x17A72B8", Offset = "0x17A72B8", VA = "0x17A72B8")]
			public SWIGPendingException()
			{
			}

			[Token(Token = "0x6000049")]
			[Address(RVA = "0x17A6174", Offset = "0x17A6174", VA = "0x17A6174")]
			public static void Set(Exception e)
			{
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0x17A5FD8", Offset = "0x17A5FD8", VA = "0x17A5FD8")]
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

			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static SWIGStringDelegate stringDelegate;

			[Token(Token = "0x600004C")]
			[Address(RVA = "0x17A736C", Offset = "0x17A736C", VA = "0x17A736C")]
			static SWIGStringHelper()
			{
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x17A3554", Offset = "0x17A3554", VA = "0x17A3554")]
			public SWIGStringHelper()
			{
			}

			[PreserveSig]
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x17A7400", Offset = "0x17A7400", VA = "0x17A7400")]
			internal static extern void SWIGRegisterStringCallback_CrashlyticsInternal(SWIGStringDelegate stringDelegate);

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x17A7368", Offset = "0x17A7368", VA = "0x17A7368")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8181B0", Offset = "0x8181B0")]
			private static string CreateString(string cString)
			{
				return null;
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static SWIGExceptionHelper swigExceptionHelper;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static SWIGStringHelper swigStringHelper;

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x17A34B8", Offset = "0x17A34B8", VA = "0x17A34B8")]
		static CrashlyticsInternalPINVOKE()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x17A355C", Offset = "0x17A355C", VA = "0x17A355C")]
		public CrashlyticsInternalPINVOKE()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x17A3564", Offset = "0x17A3564", VA = "0x17A3564")]
		public static extern void StackFrames_Clear(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x17A3600", Offset = "0x17A3600", VA = "0x17A3600")]
		public static extern void StackFrames_Add(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x17A36AC", Offset = "0x17A36AC", VA = "0x17A36AC")]
		public static extern uint StackFrames_size(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x17A3748", Offset = "0x17A3748", VA = "0x17A3748")]
		public static extern uint StackFrames_capacity(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x17A37E4", Offset = "0x17A37E4", VA = "0x17A37E4")]
		public static extern void StackFrames_reserve(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x17A3890", Offset = "0x17A3890", VA = "0x17A3890")]
		public static extern IntPtr new_StackFrames__SWIG_0();

		[PreserveSig]
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x17A391C", Offset = "0x17A391C", VA = "0x17A391C")]
		public static extern IntPtr new_StackFrames__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x17A39B8", Offset = "0x17A39B8", VA = "0x17A39B8")]
		public static extern IntPtr new_StackFrames__SWIG_2(int jarg1);

		[PreserveSig]
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x17A3A54", Offset = "0x17A3A54", VA = "0x17A3A54")]
		public static extern IntPtr StackFrames_getitemcopy(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x17A3B00", Offset = "0x17A3B00", VA = "0x17A3B00")]
		public static extern IntPtr StackFrames_getitem(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x17A3BAC", Offset = "0x17A3BAC", VA = "0x17A3BAC")]
		public static extern void StackFrames_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x17A3C60", Offset = "0x17A3C60", VA = "0x17A3C60")]
		public static extern void StackFrames_AddRange(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x17A3D0C", Offset = "0x17A3D0C", VA = "0x17A3D0C")]
		public static extern IntPtr StackFrames_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x17A3DC0", Offset = "0x17A3DC0", VA = "0x17A3DC0")]
		public static extern void StackFrames_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x17A3E74", Offset = "0x17A3E74", VA = "0x17A3E74")]
		public static extern void StackFrames_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x17A3F28", Offset = "0x17A3F28", VA = "0x17A3F28")]
		public static extern void StackFrames_RemoveAt(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x17A3FD4", Offset = "0x17A3FD4", VA = "0x17A3FD4")]
		public static extern void StackFrames_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17A4088", Offset = "0x17A4088", VA = "0x17A4088")]
		public static extern IntPtr StackFrames_Repeat(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17A4134", Offset = "0x17A4134", VA = "0x17A4134")]
		public static extern void StackFrames_Reverse__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x17A41D0", Offset = "0x17A41D0", VA = "0x17A41D0")]
		public static extern void StackFrames_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x17A4284", Offset = "0x17A4284", VA = "0x17A4284")]
		public static extern void StackFrames_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x17A4338", Offset = "0x17A4338", VA = "0x17A4338")]
		public static extern void delete_StackFrames(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x17A43D4", Offset = "0x17A43D4", VA = "0x17A43D4")]
		public static extern void FirebaseCrashlyticsFrame_library_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x17A4494", Offset = "0x17A4494", VA = "0x17A4494")]
		public static extern string FirebaseCrashlyticsFrame_library_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x17A4548", Offset = "0x17A4548", VA = "0x17A4548")]
		public static extern void FirebaseCrashlyticsFrame_symbol_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x17A4608", Offset = "0x17A4608", VA = "0x17A4608")]
		public static extern string FirebaseCrashlyticsFrame_symbol_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x17A46BC", Offset = "0x17A46BC", VA = "0x17A46BC")]
		public static extern void FirebaseCrashlyticsFrame_fileName_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x17A477C", Offset = "0x17A477C", VA = "0x17A477C")]
		public static extern string FirebaseCrashlyticsFrame_fileName_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x17A4830", Offset = "0x17A4830", VA = "0x17A4830")]
		public static extern void FirebaseCrashlyticsFrame_lineNumber_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x17A48F0", Offset = "0x17A48F0", VA = "0x17A48F0")]
		public static extern string FirebaseCrashlyticsFrame_lineNumber_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x17A49A4", Offset = "0x17A49A4", VA = "0x17A49A4")]
		public static extern IntPtr new_FirebaseCrashlyticsFrame();

		[PreserveSig]
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x17A4A30", Offset = "0x17A4A30", VA = "0x17A4A30")]
		public static extern void delete_FirebaseCrashlyticsFrame(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x17A4ACC", Offset = "0x17A4ACC", VA = "0x17A4ACC")]
		internal static extern void delete_FirebaseCrashlyticsInternal(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x17A4B68", Offset = "0x17A4B68", VA = "0x17A4B68")]
		public static extern IntPtr FirebaseCrashlyticsInternal_GetInstance__SWIG_0(HandleRef jarg1, out int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x17A4C14", Offset = "0x17A4C14", VA = "0x17A4C14")]
		public static extern IntPtr FirebaseCrashlyticsInternal_GetInstance__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x17A4CB0", Offset = "0x17A4CB0", VA = "0x17A4CB0")]
		public static extern void FirebaseCrashlyticsInternal_Log(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x17A4D70", Offset = "0x17A4D70", VA = "0x17A4D70")]
		public static extern void FirebaseCrashlyticsInternal_SetCustomKey(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x17A4E4C", Offset = "0x17A4E4C", VA = "0x17A4E4C")]
		public static extern void FirebaseCrashlyticsInternal_SetUserId(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x17A4F0C", Offset = "0x17A4F0C", VA = "0x17A4F0C")]
		public static extern void FirebaseCrashlyticsInternal_LogException(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x17A4FF8", Offset = "0x17A4FF8", VA = "0x17A4FF8")]
		public static extern bool FirebaseCrashlyticsInternal_IsCrashlyticsCollectionEnabled(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x17A509C", Offset = "0x17A509C", VA = "0x17A509C")]
		public static extern void FirebaseCrashlyticsInternal_SetCrashlyticsCollectionEnabled(HandleRef jarg1, bool jarg2);
	}
}
