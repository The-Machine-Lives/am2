using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Firebase.Platform
{
	[Token(Token = "0x2000003")]
	internal sealed class FirebaseHandler
	{
		[Token(Token = "0x2000004")]
		internal class ApplicationFocusChangedEventArgs : EventArgs
		{
			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8078F0", Offset = "0x8078F0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8078F0", Offset = "0x8078F0")]
			private bool _003CHasFocus_003Ek__BackingField;

			[Token(Token = "0x17000009")]
			public bool HasFocus
			{
				[Token(Token = "0x6000021")]
				[Address(RVA = "0x17D14A0", Offset = "0x17D14A0", VA = "0x17D14A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807B90", Offset = "0x807B90")]
				set
				{
				}
			}

			[Token(Token = "0x6000020")]
			[Address(RVA = "0x17D1438", Offset = "0x17D1438", VA = "0x17D1438")]
			public ApplicationFocusChangedEventArgs()
			{
			}
		}

		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80773C", Offset = "0x80773C")]
		private sealed class _003CCreatePartialOnMainThread_003Ec__AnonStorey0
		{
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x10")]
			internal IFirebaseAppUtils appUtils;

			[Token(Token = "0x6000022")]
			[Address(RVA = "0x17D126C", Offset = "0x17D126C", VA = "0x17D126C")]
			public _003CCreatePartialOnMainThread_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x6000023")]
			[Address(RVA = "0x17D1784", Offset = "0x17D1784", VA = "0x17D1784")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x0")]
		private static FirebaseMonoBehaviour firebaseMonoBehaviour;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80782C", Offset = "0x80782C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x80782C", Offset = "0x80782C")]
		private static IFirebaseAppUtils _003CAppUtils_003Ek__BackingField;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		private static int tickCount;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807868", Offset = "0x807868")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x807868", Offset = "0x807868")]
		private static Dispatcher _003CThreadDispatcher_003Ek__BackingField;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8078A4", Offset = "0x8078A4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8078A4", Offset = "0x8078A4")]
		private bool _003CIsPlayMode_003Ek__BackingField;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		private static FirebaseHandler firebaseHandler;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<EventArgs> Updated;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x20")]
		private EventHandler<ApplicationFocusChangedEventArgs> ApplicationFocusChanged;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8078E0", Offset = "0x8078E0")]
		private static Func<bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000004")]
		public static IFirebaseAppUtils AppUtils
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x17D0EF0", Offset = "0x17D0EF0", VA = "0x17D0EF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807B10", Offset = "0x807B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x17D0E20", Offset = "0x17D0E20", VA = "0x17D0E20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807B20", Offset = "0x807B20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public static int TickCount
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x17D0F58", Offset = "0x17D0F58", VA = "0x17D0F58")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000006")]
		private static Dispatcher ThreadDispatcher
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x17D0FC0", Offset = "0x17D0FC0", VA = "0x17D0FC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807B30", Offset = "0x807B30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x17D1028", Offset = "0x17D1028", VA = "0x17D1028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807B40", Offset = "0x807B40")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool IsPlayMode
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x17D0AF8", Offset = "0x17D0AF8", VA = "0x17D0AF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807B50", Offset = "0x807B50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x17D0C5C", Offset = "0x17D0C5C", VA = "0x17D0C5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807B60", Offset = "0x807B60")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		internal static FirebaseHandler DefaultInstance
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x17D04E8", Offset = "0x17D04E8", VA = "0x17D04E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x17D0DC0", Offset = "0x17D0DC0", VA = "0x17D0DC0")]
		static FirebaseHandler()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x17D0E8C", Offset = "0x17D0E8C", VA = "0x17D0E8C")]
		private FirebaseHandler()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x17D0B00", Offset = "0x17D0B00", VA = "0x17D0B00")]
		internal void StartMonoBehaviour()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17D0C68", Offset = "0x17D0C68", VA = "0x17D0C68")]
		internal void StopMonoBehaviour()
		{
		}

		[Token(Token = "0x6000016")]
		public static TResult RunOnMainThread<TResult>(Func<TResult> f)
		{
			return (TResult)null;
		}

		[Token(Token = "0x6000017")]
		public static Task<TResult> RunOnMainThreadAsync<TResult>(Func<TResult> f)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x17D1140", Offset = "0x17D1140", VA = "0x17D1140")]
		internal static void CreatePartialOnMainThread(IFirebaseAppUtils appUtils)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x17D1274", Offset = "0x17D1274", VA = "0x17D1274")]
		internal static void Create(IFirebaseAppUtils appUtils)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x17D0550", Offset = "0x17D0550", VA = "0x17D0550")]
		internal void Update()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x17D1390", Offset = "0x17D1390", VA = "0x17D1390")]
		internal void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x17D14AC", Offset = "0x17D14AC", VA = "0x17D14AC")]
		internal static void OnMonoBehaviourDestroyed(FirebaseMonoBehaviour behaviour)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x17D157C", Offset = "0x17D157C", VA = "0x17D157C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807B70", Offset = "0x807B70")]
		private static bool _003CStopMonoBehaviour_003Em__0()
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x17D171C", Offset = "0x17D171C", VA = "0x17D171C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807B80", Offset = "0x807B80")]
		private void _003CUpdate_003Em__1()
		{
		}
	}
}
