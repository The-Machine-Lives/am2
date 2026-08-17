using System;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000044")]
	[Preserve]
	internal abstract class ReflectionDelegateFactory
	{
		[Token(Token = "0x60001E7")]
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x60001E9")]
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);

		[Token(Token = "0x60001EA")]
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

		[Token(Token = "0x60001EB")]
		public abstract Func<T> CreateDefaultConstructor<T>(Type type);

		[Token(Token = "0x60001EC")]
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);

		[Token(Token = "0x60001ED")]
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);

		[Token(Token = "0x60001EE")]
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);

		[Token(Token = "0x60001EF")]
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x176C4A8", Offset = "0x176C4A8", VA = "0x176C4A8")]
		protected ReflectionDelegateFactory()
		{
		}
	}
}
