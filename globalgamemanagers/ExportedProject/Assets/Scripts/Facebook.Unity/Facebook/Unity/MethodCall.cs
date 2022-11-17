using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x200001F")]
	internal abstract class MethodCall<T> where T : IResult
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816240", Offset = "0x816240")]
		private string _003CMethodName_003Ek__BackingField;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816250", Offset = "0x816250")]
		private FacebookDelegate<T> _003CCallback_003Ek__BackingField;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816260", Offset = "0x816260")]
		private FacebookBase _003CFacebookImpl_003Ek__BackingField;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816270", Offset = "0x816270")]
		private MethodArguments _003CParameters_003Ek__BackingField;

		[Token(Token = "0x1700002F")]
		public string MethodName
		{
			[Token(Token = "0x60000E7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816860", Offset = "0x816860")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816870", Offset = "0x816870")]
			private set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public FacebookDelegate<T> Callback
		{
			[Token(Token = "0x60000E9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816880", Offset = "0x816880")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60000EA")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816890", Offset = "0x816890")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		protected FacebookBase FacebookImpl
		{
			[Token(Token = "0x60000EB")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8168A0", Offset = "0x8168A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		protected MethodArguments Parameters
		{
			[Token(Token = "0x60000EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8168B0", Offset = "0x8168B0")]
			set
			{
			}
		}

		[Token(Token = "0x60000E6")]
		public MethodCall(FacebookBase facebookImpl, string methodName)
		{
		}

		[Token(Token = "0x60000ED")]
		public abstract void Call([Optional] MethodArguments args);
	}
}
