using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Firebase.Extensions
{
	[Token(Token = "0x2000002")]
	public static class TaskExtension
	{
		[Token(Token = "0x2000003")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81847C", Offset = "0x81847C")]
		private sealed class _003CContinueWithOnMainThread_003Ec__AnonStorey8<T>
		{
			[Token(Token = "0x2000004")]
			private sealed class _003CContinueWithOnMainThread_003Ec__AnonStorey9
			{
				[Token(Token = "0x4000002")]
				[FieldOffset(Offset = "0x0")]
				internal Task<T> t;

				[Token(Token = "0x4000003")]
				[FieldOffset(Offset = "0x0")]
				internal _003CContinueWithOnMainThread_003Ec__AnonStorey8<T> _003C_003Ef__ref_00248;

				[Token(Token = "0x6000004")]
				public _003CContinueWithOnMainThread_003Ec__AnonStorey9()
				{
				}

				[Token(Token = "0x6000005")]
				internal bool _003C_003Em__0()
				{
					return default(bool);
				}
			}

			[Token(Token = "0x4000001")]
			[FieldOffset(Offset = "0x0")]
			internal Action<Task<T>> continuation;

			[Token(Token = "0x6000002")]
			public _003CContinueWithOnMainThread_003Ec__AnonStorey8()
			{
			}

			[Token(Token = "0x6000003")]
			internal Task<bool> _003C_003Em__0(Task<T> t)
			{
				return null;
			}
		}

		[Token(Token = "0x6000001")]
		public static Task ContinueWithOnMainThread<T>(this Task<T> task, Action<Task<T>> continuation)
		{
			return null;
		}
	}
}
