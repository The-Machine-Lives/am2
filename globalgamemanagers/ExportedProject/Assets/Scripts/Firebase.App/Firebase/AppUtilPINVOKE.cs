using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x2000002")]
	internal class AppUtilPINVOKE
	{
		[Token(Token = "0x2000003")]
		protected class SWIGExceptionHelper
		{
			[Token(Token = "0x2000004")]
			public delegate void ExceptionDelegate(string message);

			[Token(Token = "0x2000005")]
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

			[Token(Token = "0x600001B")]
			[Address(RVA = "0x1798624", Offset = "0x1798624", VA = "0x1798624")]
			static SWIGExceptionHelper()
			{
			}

			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1797348", Offset = "0x1797348", VA = "0x1797348")]
			public SWIGExceptionHelper()
			{
			}

			[PreserveSig]
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1798940", Offset = "0x1798940", VA = "0x1798940")]
			public static extern void SWIGRegisterExceptionCallbacks_AppUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x1798AC8", Offset = "0x1798AC8", VA = "0x1798AC8")]
			public static extern void SWIGRegisterExceptionCallbacksArgument_AppUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			[Token(Token = "0x600001F")]
			[Address(RVA = "0x1797D0C", Offset = "0x1797D0C", VA = "0x1797D0C")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D2A0", Offset = "0x80D2A0")]
			private static void SetPendingApplicationException(string message)
			{
			}

			[Token(Token = "0x6000020")]
			[Address(RVA = "0x1797DA8", Offset = "0x1797DA8", VA = "0x1797DA8")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D304", Offset = "0x80D304")]
			private static void SetPendingArithmeticException(string message)
			{
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0x1797E44", Offset = "0x1797E44", VA = "0x1797E44")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D368", Offset = "0x80D368")]
			private static void SetPendingDivideByZeroException(string message)
			{
			}

			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1797EE0", Offset = "0x1797EE0", VA = "0x1797EE0")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D3CC", Offset = "0x80D3CC")]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			[Token(Token = "0x6000023")]
			[Address(RVA = "0x1797F7C", Offset = "0x1797F7C", VA = "0x1797F7C")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D430", Offset = "0x80D430")]
			private static void SetPendingInvalidCastException(string message)
			{
			}

			[Token(Token = "0x6000024")]
			[Address(RVA = "0x1798018", Offset = "0x1798018", VA = "0x1798018")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D494", Offset = "0x80D494")]
			private static void SetPendingInvalidOperationException(string message)
			{
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x17980B4", Offset = "0x17980B4", VA = "0x17980B4")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D4F8", Offset = "0x80D4F8")]
			private static void SetPendingIOException(string message)
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1798150", Offset = "0x1798150", VA = "0x1798150")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D55C", Offset = "0x80D55C")]
			private static void SetPendingNullReferenceException(string message)
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x17981EC", Offset = "0x17981EC", VA = "0x17981EC")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D5C0", Offset = "0x80D5C0")]
			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1798288", Offset = "0x1798288", VA = "0x1798288")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D624", Offset = "0x80D624")]
			private static void SetPendingOverflowException(string message)
			{
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1798324", Offset = "0x1798324", VA = "0x1798324")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D688", Offset = "0x80D688")]
			private static void SetPendingSystemException(string message)
			{
			}

			[Token(Token = "0x600002A")]
			[Address(RVA = "0x17983C0", Offset = "0x17983C0", VA = "0x17983C0")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D6EC", Offset = "0x80D6EC")]
			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			[Token(Token = "0x600002B")]
			[Address(RVA = "0x1798464", Offset = "0x1798464", VA = "0x1798464")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D750", Offset = "0x80D750")]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			[Token(Token = "0x600002C")]
			[Address(RVA = "0x1798544", Offset = "0x1798544", VA = "0x1798544")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D7B4", Offset = "0x80D7B4")]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}
		}

		[Token(Token = "0x2000006")]
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
				[Token(Token = "0x6000035")]
				[Address(RVA = "0x17961D0", Offset = "0x17961D0", VA = "0x17961D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1798B9C", Offset = "0x1798B9C", VA = "0x1798B9C")]
			public static void Set(Exception e)
			{
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1796274", Offset = "0x1796274", VA = "0x1796274")]
			public static Exception Retrieve()
			{
				return null;
			}
		}

		[Token(Token = "0x2000007")]
		protected class SWIGStringHelper
		{
			[Token(Token = "0x2000008")]
			public delegate string SWIGStringDelegate(string message);

			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static SWIGStringDelegate stringDelegate;

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1799CE8", Offset = "0x1799CE8", VA = "0x1799CE8")]
			static SWIGStringHelper()
			{
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1797350", Offset = "0x1797350", VA = "0x1797350")]
			public SWIGStringHelper()
			{
			}

			[PreserveSig]
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1799D7C", Offset = "0x1799D7C", VA = "0x1799D7C")]
			public static extern void SWIGRegisterStringCallback_AppUtil(SWIGStringDelegate stringDelegate);

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1799CE4", Offset = "0x1799CE4", VA = "0x1799CE4")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D818", Offset = "0x80D818")]
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

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x17972B4", Offset = "0x17972B4", VA = "0x17972B4")]
		static AppUtilPINVOKE()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1797358", Offset = "0x1797358", VA = "0x1797358")]
		public static extern void delete_FutureBase(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x17973F4", Offset = "0x17973F4", VA = "0x17973F4")]
		public static extern int FutureBase_status(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1797490", Offset = "0x1797490", VA = "0x1797490")]
		public static extern int FutureBase_error(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x179752C", Offset = "0x179752C", VA = "0x179752C")]
		public static extern string FutureBase_error_message(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x17975E0", Offset = "0x17975E0", VA = "0x17975E0")]
		public static extern IntPtr FutureVoid_SWIG_OnCompletion(HandleRef jarg1, FutureVoid.SWIG_CompletionDelegate jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x179769C", Offset = "0x179769C", VA = "0x179769C")]
		public static extern void FutureVoid_SWIG_FreeCompletionData(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1797748", Offset = "0x1797748", VA = "0x1797748")]
		public static extern void delete_FutureVoid(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x17977E4", Offset = "0x17977E4", VA = "0x17977E4")]
		public static extern string FirebaseApp_NameInternal_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1797898", Offset = "0x1797898", VA = "0x1797898")]
		public static extern IntPtr FirebaseApp_CreateInternal__SWIG_0();

		[PreserveSig]
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1797924", Offset = "0x1797924", VA = "0x1797924")]
		internal static extern void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x17979C0", Offset = "0x17979C0", VA = "0x17979C0")]
		internal static extern int FirebaseApp_GetLogLevelInternal();

		[PreserveSig]
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1797A4C", Offset = "0x1797A4C", VA = "0x1797A4C")]
		internal static extern void FirebaseApp_RegisterLibraryInternal(string jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1797B20", Offset = "0x1797B20", VA = "0x1797B20")]
		public static extern void FirebaseApp_AppSetDefaultConfigPath(string jarg1);

		[PreserveSig]
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1797BCC", Offset = "0x1797BCC", VA = "0x1797BCC")]
		public static extern string FirebaseApp_DefaultName_get();

		[PreserveSig]
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1796144", Offset = "0x1796144", VA = "0x1796144")]
		public static extern void PollCallbacks();

		[PreserveSig]
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x17964D4", Offset = "0x17964D4", VA = "0x17964D4")]
		public static extern void AppEnableLogCallback(bool jarg1);

		[PreserveSig]
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1796634", Offset = "0x1796634", VA = "0x1796634")]
		public static extern void SetEnabledAllAppCallbacks(bool jarg1);

		[PreserveSig]
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x17967A4", Offset = "0x17967A4", VA = "0x17967A4")]
		public static extern void SetEnabledAppCallbackByName(string jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1796930", Offset = "0x1796930", VA = "0x1796930")]
		public static extern bool GetEnabledAppCallbackByName(string jarg1);

		[PreserveSig]
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1796AAC", Offset = "0x1796AAC", VA = "0x1796AAC")]
		public static extern void SetLogFunction(LogUtil.LogMessageDelegate jarg1);

		[PreserveSig]
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1796C14", Offset = "0x1796C14", VA = "0x1796C14")]
		public static extern int CheckAndroidDependencies();

		[PreserveSig]
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1796D4C", Offset = "0x1796D4C", VA = "0x1796D4C")]
		public static extern IntPtr FixAndroidDependencies();

		[PreserveSig]
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x17970E0", Offset = "0x17970E0", VA = "0x17970E0")]
		internal static extern void InitializePlayServicesInternal();

		[PreserveSig]
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1797228", Offset = "0x1797228", VA = "0x1797228")]
		internal static extern void TerminatePlayServicesInternal();

		[PreserveSig]
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1797C70", Offset = "0x1797C70", VA = "0x1797C70")]
		public static extern IntPtr FutureVoid_SWIGUpcast(IntPtr jarg1);
	}
}
