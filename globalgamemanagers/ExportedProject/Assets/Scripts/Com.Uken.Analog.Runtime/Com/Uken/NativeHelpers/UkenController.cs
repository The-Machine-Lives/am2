using Il2CppDummyDll;
using UnityEngine;

namespace Com.Uken.NativeHelpers
{
	[Token(Token = "0x2000002")]
	public abstract class UkenController
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x813DA8", Offset = "0x813DA8")]
		private bool _003CInitialized_003Ek__BackingField;

		[Token(Token = "0x17000001")]
		public bool Initialized
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x16DA5E4", Offset = "0x16DA5E4", VA = "0x16DA5E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815620", Offset = "0x815620")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x16DA5EC", Offset = "0x16DA5EC", VA = "0x16DA5EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815630", Offset = "0x815630")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x16DA5F8", Offset = "0x16DA5F8", VA = "0x16DA5F8", Slot = "4")]
		public virtual void Initialize(MonoBehaviour monoBehaviour)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x16DA604", Offset = "0x16DA604", VA = "0x16DA604", Slot = "5")]
		public virtual bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x16DA60C", Offset = "0x16DA60C", VA = "0x16DA60C", Slot = "6")]
		public virtual void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x16DA610", Offset = "0x16DA610", VA = "0x16DA610", Slot = "7")]
		public virtual void Cleanup()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x16DA618", Offset = "0x16DA618", VA = "0x16DA618", Slot = "8")]
		public virtual void OnDataUpdated()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x16D1978", Offset = "0x16D1978", VA = "0x16D1978")]
		protected UkenController()
		{
		}
	}
}
