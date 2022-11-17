using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004D9")]
	public class CasualGameLoader
	{
		[Token(Token = "0x2000841")]
		public class LoadingFunction
		{
			[Token(Token = "0x40023A4")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8330A0", Offset = "0x8330A0")]
			private Guid _003CsequenceID_003Ek__BackingField;

			[Token(Token = "0x40023A5")]
			[FieldOffset(Offset = "0x20")]
			private Action<Action<bool>> startLoad;

			[Token(Token = "0x40023A6")]
			[FieldOffset(Offset = "0x28")]
			private Action<bool> onLoadComplete;

			[Token(Token = "0x40023A7")]
			[FieldOffset(Offset = "0x30")]
			public string debugName;

			[Token(Token = "0x1700082F")]
			public Guid sequenceID
			{
				[Token(Token = "0x6003350")]
				[Address(RVA = "0xA53988", Offset = "0xA53988", VA = "0xA53988")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BCFC", Offset = "0x83BCFC")]
				get
				{
					return default(Guid);
				}
				[Token(Token = "0x6003351")]
				[Address(RVA = "0xA54308", Offset = "0xA54308", VA = "0xA54308")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BD0C", Offset = "0x83BD0C")]
				private set
				{
				}
			}

			[Token(Token = "0x6003352")]
			[Address(RVA = "0xA53A94", Offset = "0xA53A94", VA = "0xA53A94")]
			public LoadingFunction(string DebugName, Action<Action<bool>> StartLoad, Action<bool> OnLoadComplete)
			{
			}

			[Token(Token = "0x6003353")]
			[Address(RVA = "0xA541BC", Offset = "0xA541BC", VA = "0xA541BC")]
			public void Start()
			{
			}
		}

		[Token(Token = "0x40016EA")]
		[FieldOffset(Offset = "0x0")]
		public static string LoadingEventType;

		[Token(Token = "0x40016EB")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, float> eventTiming;

		[Token(Token = "0x40016EC")]
		[FieldOffset(Offset = "0x18")]
		public Queue<LoadingFunction> LoadingFunctions;

		[Token(Token = "0x40016ED")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F0BC", Offset = "0x82F0BC")]
		private int _003CTotalSteps_003Ek__BackingField;

		[Token(Token = "0x40016EE")]
		[FieldOffset(Offset = "0x24")]
		private bool loadHasStarted;

		[Token(Token = "0x40016EF")]
		[FieldOffset(Offset = "0x28")]
		private LoadingFunction activeLoadingFunction;

		[Token(Token = "0x40016F0")]
		[FieldOffset(Offset = "0x30")]
		private List<Guid> cancelledLoadingFunctions;

		[Token(Token = "0x40016F1")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F0CC", Offset = "0x82F0CC")]
		private int _003CLoadSequenceFailures_003Ek__BackingField;

		[Token(Token = "0x40016F2")]
		[FieldOffset(Offset = "0x40")]
		private Action<bool> onLoadComplete;

		[Token(Token = "0x40016F3")]
		[FieldOffset(Offset = "0x48")]
		public bool GarbageCollectBetweenFunctions;

		[Token(Token = "0x1700063A")]
		public int TotalSteps
		{
			[Token(Token = "0x6002539")]
			[Address(RVA = "0xA537F0", Offset = "0xA537F0", VA = "0xA537F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839E1C", Offset = "0x839E1C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600253A")]
			[Address(RVA = "0xA537F8", Offset = "0xA537F8", VA = "0xA537F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839E2C", Offset = "0x839E2C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700063B")]
		public int LoadSequenceFailures
		{
			[Token(Token = "0x600253B")]
			[Address(RVA = "0xA53800", Offset = "0xA53800", VA = "0xA53800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839E3C", Offset = "0x839E3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600253C")]
			[Address(RVA = "0xA53808", Offset = "0xA53808", VA = "0xA53808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839E4C", Offset = "0x839E4C")]
			private set
			{
			}
		}

		[Token(Token = "0x600253D")]
		[Address(RVA = "0xA53810", Offset = "0xA53810", VA = "0xA53810")]
		public CasualGameLoader()
		{
		}

		[Token(Token = "0x600253E")]
		[Address(RVA = "0xA538E0", Offset = "0xA538E0", VA = "0xA538E0")]
		public void RegisterOnLoadComplete(Action<bool> OnLoadComplete)
		{
		}

		[Token(Token = "0x600253F")]
		[Address(RVA = "0xA538E8", Offset = "0xA538E8", VA = "0xA538E8")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6002540")]
		[Address(RVA = "0xA53994", Offset = "0xA53994", VA = "0xA53994")]
		public void RegisterLoadingEvent(string debugName, Action<Action<bool>> functionToLoad)
		{
		}

		[Token(Token = "0x6002541")]
		[Address(RVA = "0xA53B40", Offset = "0xA53B40", VA = "0xA53B40")]
		public float PercentComplete()
		{
			return default(float);
		}

		[Token(Token = "0x6002542")]
		[Address(RVA = "0xA53BD4", Offset = "0xA53BD4", VA = "0xA53BD4")]
		public int StepsRemaining()
		{
			return default(int);
		}

		[Token(Token = "0x6002543")]
		[Address(RVA = "0xA53C34", Offset = "0xA53C34", VA = "0xA53C34")]
		public bool HasLoadingStarted()
		{
			return default(bool);
		}

		[Token(Token = "0x6002544")]
		[Address(RVA = "0xA53C3C", Offset = "0xA53C3C", VA = "0xA53C3C")]
		public void LoadNext()
		{
		}

		[Token(Token = "0x6002545")]
		[Address(RVA = "0xA53D88", Offset = "0xA53D88", VA = "0xA53D88")]
		protected void OnLoadFunctionCompleted(bool success)
		{
		}

		[Token(Token = "0x6002546")]
		[Address(RVA = "0xA54224", Offset = "0xA54224", VA = "0xA54224")]
		public bool IsGameReady()
		{
			return default(bool);
		}
	}
}
