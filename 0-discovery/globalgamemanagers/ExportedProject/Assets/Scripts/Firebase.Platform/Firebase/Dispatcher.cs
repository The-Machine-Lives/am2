using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x200001E")]
	internal class Dispatcher
	{
		[Token(Token = "0x200001F")]
		private class CallbackStorage<TResult>
		{
			[Token(Token = "0x400003A")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x807A98", Offset = "0x807A98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807A98", Offset = "0x807A98")]
			private TResult _003CResult_003Ek__BackingField;

			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807AD4", Offset = "0x807AD4")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x807AD4", Offset = "0x807AD4")]
			private Exception _003CException_003Ek__BackingField;

			[Token(Token = "0x17000021")]
			public TResult Result
			{
				[Token(Token = "0x6000077")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807D18", Offset = "0x807D18")]
				get
				{
					return (TResult)null;
				}
				[Token(Token = "0x6000078")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807D28", Offset = "0x807D28")]
				set
				{
				}
			}

			[Token(Token = "0x17000022")]
			public Exception Exception
			{
				[Token(Token = "0x6000079")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807D38", Offset = "0x807D38")]
				get
				{
					return null;
				}
				[Token(Token = "0x600007A")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807D48", Offset = "0x807D48")]
				set
				{
				}
			}

			[Token(Token = "0x6000076")]
			public CallbackStorage()
			{
			}
		}

		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8077CC", Offset = "0x8077CC")]
		private sealed class _003CRun_003Ec__AnonStorey0<TResult>
		{
			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x0")]
			internal Func<TResult> callback;

			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x0")]
			internal CallbackStorage<TResult> result;

			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x0")]
			internal EventWaitHandle waitHandle;

			[Token(Token = "0x600007B")]
			public _003CRun_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x600007C")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x2000021")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8077DC", Offset = "0x8077DC")]
		private sealed class _003CRunAsync_003Ec__AnonStorey1<TResult>
		{
			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x0")]
			internal TaskCompletionSource<TResult> tcs;

			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x0")]
			internal Func<TResult> callback;

			[Token(Token = "0x600007D")]
			public _003CRunAsync_003Ec__AnonStorey1()
			{
			}

			[Token(Token = "0x600007E")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x10")]
		private int ownerThreadId;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x18")]
		private Queue<Action> queue;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x17CEDC4", Offset = "0x17CEDC4", VA = "0x17CEDC4")]
		public Dispatcher()
		{
		}

		[Token(Token = "0x6000071")]
		public TResult Run<TResult>(Func<TResult> callback)
		{
			return (TResult)null;
		}

		[Token(Token = "0x6000072")]
		public Task<TResult> RunAsync<TResult>(Func<TResult> callback)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		internal static Task<TResult> RunAsyncNow<TResult>(Func<TResult> callback)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x17CEE5C", Offset = "0x17CEE5C", VA = "0x17CEE5C")]
		internal bool ManagesThisThread()
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x17CEEA4", Offset = "0x17CEEA4", VA = "0x17CEEA4")]
		public void PollJobs()
		{
		}
	}
}
