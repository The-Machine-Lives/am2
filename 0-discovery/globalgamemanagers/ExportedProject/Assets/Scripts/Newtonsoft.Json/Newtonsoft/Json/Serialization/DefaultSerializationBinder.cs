using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000093")]
	[Preserve]
	public class DefaultSerializationBinder : SerializationBinder
	{
		[Token(Token = "0x2000094")]
		internal struct TypeNameKey
		{
			[Token(Token = "0x4000226")]
			[FieldOffset(Offset = "0x0")]
			internal readonly string AssemblyName;

			[Token(Token = "0x4000227")]
			[FieldOffset(Offset = "0x8")]
			internal readonly string TypeName;

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x8A168C", Offset = "0x8A168C", VA = "0x8A168C")]
			public TypeNameKey(string assemblyName, string typeName)
			{
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x8A1694", Offset = "0x8A1694", VA = "0x8A1694", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x8A169C", Offset = "0x8A169C", VA = "0x8A169C", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x8A16A4", Offset = "0x8A16A4", VA = "0x8A16A4")]
			public bool Equals(TypeNameKey other)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DefaultSerializationBinder Instance;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x10")]
		private readonly ThreadSafeStore<TypeNameKey, Type> _typeCache;

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xD10B84", Offset = "0xD10B84", VA = "0xD10B84")]
		private static Type GetTypeFromTypeNameKey(TypeNameKey typeNameKey)
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xD10DF0", Offset = "0xD10DF0", VA = "0xD10DF0", Slot = "5")]
		public override Type BindToType(string assemblyName, string typeName)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xD10E70", Offset = "0xD10E70", VA = "0xD10E70")]
		public DefaultSerializationBinder()
		{
		}
	}
}
