using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000A6")]
	[Preserve]
	internal abstract class JsonSerializerInternalBase
	{
		[Token(Token = "0x20000A7")]
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object>
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xEEED3C", Offset = "0xEEED3C", VA = "0xEEED3C", Slot = "4")]
			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CSystem_002EObject_003E_002EEquals(object x, object y)
			{
				return default(bool);
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xEEED48", Offset = "0xEEED48", VA = "0xEEED48", Slot = "5")]
			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CSystem_002EObject_003E_002EGetHashCode(object obj)
			{
				return default(int);
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xEEED54", Offset = "0xEEED54", VA = "0xEEED54")]
			public ReferenceEqualsEqualityComparer()
			{
			}
		}

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x10")]
		private ErrorContext _currentErrorContext;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x18")]
		private BidirectionalDictionary<string, object> _mappings;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x20")]
		internal readonly JsonSerializer Serializer;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x28")]
		internal readonly ITraceWriter TraceWriter;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x30")]
		protected JsonSerializerProxy InternalSerializer;

		[Token(Token = "0x170000EA")]
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xD10820", Offset = "0xD10820", VA = "0xD10820")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xD158F0", Offset = "0xD158F0", VA = "0xD158F0")]
		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xD15984", Offset = "0xD15984", VA = "0xD15984")]
		private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xD15A74", Offset = "0xD15A74", VA = "0xD15A74")]
		protected void ClearErrorContext()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xD15B04", Offset = "0xD15B04", VA = "0xD15B04")]
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex)
		{
			return default(bool);
		}
	}
}
