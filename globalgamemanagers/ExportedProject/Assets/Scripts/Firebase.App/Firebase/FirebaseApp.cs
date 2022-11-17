using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x200000C")]
	public sealed class FirebaseApp : IDisposable
	{
		[Token(Token = "0x200000D")]
		public class EnableModuleParams
		{
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x80D164", Offset = "0x80D164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D164", Offset = "0x80D164")]
			private string _003CCppModuleName_003Ek__BackingField;

			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x80D1A0", Offset = "0x80D1A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D1A0", Offset = "0x80D1A0")]
			private string _003CCSharpClassName_003Ek__BackingField;

			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D1DC", Offset = "0x80D1DC")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x80D1DC", Offset = "0x80D1DC")]
			private bool _003CAlwaysEnable_003Ek__BackingField;

			[Token(Token = "0x17000007")]
			public string CppModuleName
			{
				[Token(Token = "0x6000071")]
				[Address(RVA = "0x179CF04", Offset = "0x179CF04", VA = "0x179CF04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D8CC", Offset = "0x80D8CC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000072")]
				[Address(RVA = "0x179EAA8", Offset = "0x179EAA8", VA = "0x179EAA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D8DC", Offset = "0x80D8DC")]
				set
				{
				}
			}

			[Token(Token = "0x17000008")]
			public string CSharpClassName
			{
				[Token(Token = "0x6000073")]
				[Address(RVA = "0x179CEFC", Offset = "0x179CEFC", VA = "0x179CEFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D8EC", Offset = "0x80D8EC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000074")]
				[Address(RVA = "0x179EAA0", Offset = "0x179EAA0", VA = "0x179EAA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D8FC", Offset = "0x80D8FC")]
				set
				{
				}
			}

			[Token(Token = "0x17000009")]
			public bool AlwaysEnable
			{
				[Token(Token = "0x6000075")]
				[Address(RVA = "0x179CF0C", Offset = "0x179CF0C", VA = "0x179CF0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D90C", Offset = "0x80D90C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000076")]
				[Address(RVA = "0x179EAB0", Offset = "0x179EAB0", VA = "0x179EAB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D91C", Offset = "0x80D91C")]
				set
				{
				}
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x179CEB8", Offset = "0x179CEB8", VA = "0x179CEB8")]
			public EnableModuleParams(string csharp, string cpp, bool always = false)
			{
			}
		}

		[Token(Token = "0x200000E")]
		private delegate FirebaseApp CreateDelegate();

		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D0C0", Offset = "0x80D0C0")]
		private sealed class _003CCheckDependencies_003Ec__AnonStorey2
		{
			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal DependencyStatus status;

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x179E018", Offset = "0x179E018", VA = "0x179E018")]
			public _003CCheckDependencies_003Ec__AnonStorey2()
			{
			}

			[Token(Token = "0x600007C")]
			[Address(RVA = "0x179E860", Offset = "0x179E860", VA = "0x179E860")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x2000010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D0D0", Offset = "0x80D0D0")]
		private sealed class _003CFixDependenciesAsync_003Ec__AnonStorey3
		{
			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Task task;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Action<Task> _003C_003Ef__am_0024cache0;

			[Token(Token = "0x600007D")]
			[Address(RVA = "0x179E29C", Offset = "0x179E29C", VA = "0x179E29C")]
			public _003CFixDependenciesAsync_003Ec__AnonStorey3()
			{
			}

			[Token(Token = "0x600007E")]
			[Address(RVA = "0x179E8C8", Offset = "0x179E8C8", VA = "0x179E8C8")]
			internal void _003C_003Em__0()
			{
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0x179E9B4", Offset = "0x179E9B4", VA = "0x179E9B4")]
			private static void _003C_003Em__1(Task t)
			{
			}
		}

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool swigCMemOwn;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly object disposeLock;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string name;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private EventHandler AppDisposed;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, FirebaseApp> nameToProxy;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<IntPtr, FirebaseApp> cPtrToProxy;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool AppUtilCallbacksInitialized;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static object AppUtilCallbacksLock;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool PreventOnAllAppsDestroyed;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private static bool crashlyticsInitializationAttempted;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static int CheckDependenciesThread;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static object CheckDependenciesThreadLock;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D114", Offset = "0x80D114")]
		private static CreateDelegate _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D124", Offset = "0x80D124")]
		private static Func<bool> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D134", Offset = "0x80D134")]
		private static Func<DependencyStatus> _003C_003Ef__am_0024cache2;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D144", Offset = "0x80D144")]
		private static Func<Task<DependencyStatus>, Task<DependencyStatus>> _003C_003Ef__am_0024cache3;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D154", Offset = "0x80D154")]
		private static Func<Task, Task<DependencyStatus>> _003C_003Ef__am_0024cache4;

		[Token(Token = "0x17000002")]
		public static FirebaseApp DefaultInstance
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x179B0F8", Offset = "0x179B0F8", VA = "0x179B0F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public string Name
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x179BFB4", Offset = "0x179BFB4", VA = "0x179BFB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public static LogLevel LogLevel
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x179BFBC", Offset = "0x179BFBC", VA = "0x179BFBC")]
			get
			{
				return default(LogLevel);
			}
		}

		[Token(Token = "0x17000005")]
		internal string NameInternal
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x179D8E0", Offset = "0x179D8E0", VA = "0x179D8E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static string DefaultName
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x179B184", Offset = "0x179B184", VA = "0x179B184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x179A840", Offset = "0x179A840", VA = "0x179A840")]
		internal FirebaseApp(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x179A8A4", Offset = "0x179A8A4", VA = "0x179A8A4")]
		static FirebaseApp()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x179AACC", Offset = "0x179AACC", VA = "0x179AACC")]
		internal static HandleRef getCPtr(FirebaseApp obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x179AB3C", Offset = "0x179AB3C", VA = "0x179AB3C", Slot = "1")]
		~FirebaseApp()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x179ABB0", Offset = "0x179ABB0", VA = "0x179ABB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x179AEE4", Offset = "0x179AEE4", VA = "0x179AEE4")]
		internal static void TranslateDllNotFoundException(Action closureToExecute)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x179B24C", Offset = "0x179B24C", VA = "0x179B24C")]
		public static FirebaseApp GetInstance(string name)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x179B3E4", Offset = "0x179B3E4", VA = "0x179B3E4")]
		public static FirebaseApp Create()
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x179C018", Offset = "0x179C018", VA = "0x179C018")]
		private void AddReference()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x179AC44", Offset = "0x179AC44", VA = "0x179AC44")]
		private void RemoveReference()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x179C440", Offset = "0x179C440", VA = "0x179C440")]
		private static void InitializeAppUtilCallbacks()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x179C2A8", Offset = "0x179C2A8", VA = "0x179C2A8")]
		private static void OnAllAppsDestroyed()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x179CFB4", Offset = "0x179CFB4", VA = "0x179CFB4")]
		private static bool InitializeCrashlyticsIfPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x179B684", Offset = "0x179B684", VA = "0x179B684")]
		private static FirebaseApp CreateAndTrack(CreateDelegate createDelegate, FirebaseApp existingProxy)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x179DAA8", Offset = "0x179DAA8", VA = "0x179DAA8")]
		private static void SetCheckDependenciesThread(int threadId)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x179B4D0", Offset = "0x179B4D0", VA = "0x179B4D0")]
		private static void ThrowIfCheckDependenciesRunning()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x179D9B8", Offset = "0x179D9B8", VA = "0x179D9B8")]
		private static bool IsCheckDependenciesRunning()
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x179DCB0", Offset = "0x179DCB0", VA = "0x179DCB0")]
		public static Task<DependencyStatus> CheckDependenciesAsync()
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x179DE2C", Offset = "0x179DE2C", VA = "0x179DE2C")]
		public static Task<DependencyStatus> CheckAndFixDependenciesAsync()
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x179DF58", Offset = "0x179DF58", VA = "0x179DF58")]
		public static DependencyStatus CheckDependencies()
		{
			return default(DependencyStatus);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x179E020", Offset = "0x179E020", VA = "0x179E020")]
		private static DependencyStatus CheckDependenciesInternal()
		{
			return default(DependencyStatus);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x179E1DC", Offset = "0x179E1DC", VA = "0x179E1DC")]
		public static Task FixDependenciesAsync()
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x179E2A4", Offset = "0x179E2A4", VA = "0x179E2A4")]
		private static void ResetDefaultAppCPtr()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x179E454", Offset = "0x179E454", VA = "0x179E454")]
		internal static FirebaseApp CreateInternal()
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x179C1B0", Offset = "0x179C1B0", VA = "0x179C1B0")]
		internal static void ReleaseReferenceInternal(FirebaseApp app)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x179D80C", Offset = "0x179D80C", VA = "0x179D80C")]
		internal static void RegisterLibraryInternal(string library, string version)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x179D2E4", Offset = "0x179D2E4", VA = "0x179D2E4")]
		internal static void AppSetDefaultConfigPath(string path)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x179E54C", Offset = "0x179E54C", VA = "0x179E54C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D87C", Offset = "0x80D87C")]
		private static FirebaseApp _003CCreate_003Em__0()
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x179E5A8", Offset = "0x179E5A8", VA = "0x179E5A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D88C", Offset = "0x80D88C")]
		private static bool _003CCreateAndTrack_003Em__1()
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x179E604", Offset = "0x179E604", VA = "0x179E604")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D89C", Offset = "0x80D89C")]
		private static DependencyStatus _003CCheckDependenciesAsync_003Em__2()
		{
			return default(DependencyStatus);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x179E6A4", Offset = "0x179E6A4", VA = "0x179E6A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D8AC", Offset = "0x80D8AC")]
		private static Task<DependencyStatus> _003CCheckAndFixDependenciesAsync_003Em__3(Task<DependencyStatus> checkTask)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x179E804", Offset = "0x179E804", VA = "0x179E804")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D8BC", Offset = "0x80D8BC")]
		private static Task<DependencyStatus> _003CCheckAndFixDependenciesAsync_003Em__4(Task t)
		{
			return null;
		}
	}
}
