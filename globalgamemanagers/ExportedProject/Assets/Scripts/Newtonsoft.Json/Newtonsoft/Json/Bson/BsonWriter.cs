using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x2000125")]
	[Preserve]
	public class BsonWriter : JsonWriter
	{
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x60")]
		private readonly BsonBinaryWriter _writer;

		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x68")]
		private BsonToken _root;

		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x70")]
		private BsonToken _parent;

		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x78")]
		private string _propertyName;

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xD397E0", Offset = "0xD397E0", VA = "0xD397E0", Slot = "17")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xD39894", Offset = "0xD39894", VA = "0xD39894", Slot = "63")]
		public override void WriteComment(string text)
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xD398FC", Offset = "0xD398FC", VA = "0xD398FC", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xD39964", Offset = "0xD39964", VA = "0xD39964", Slot = "23")]
		public override void WriteRaw(string json)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xD399CC", Offset = "0xD399CC", VA = "0xD399CC", Slot = "24")]
		public override void WriteRawValue(string json)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xD39A34", Offset = "0xD39A34", VA = "0xD39A34", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xD39AD0", Offset = "0xD39AD0", VA = "0xD39AD0", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xD39B44", Offset = "0xD39B44", VA = "0xD39B44", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xD39B70", Offset = "0xD39B70", VA = "0xD39B70", Slot = "6")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xD39AA8", Offset = "0xD39AA8", VA = "0xD39AA8")]
		private void AddParent(BsonToken container)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xD39860", Offset = "0xD39860", VA = "0xD39860")]
		private void RemoveParent()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xD39E64", Offset = "0xD39E64", VA = "0xD39E64")]
		private void AddValue(object value, BsonType type)
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xD39BD4", Offset = "0xD39BD4", VA = "0xD39BD4")]
		internal void AddToken(BsonToken token)
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xD39EE0", Offset = "0xD39EE0", VA = "0xD39EE0", Slot = "62")]
		public override void WriteValue(object value)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xD39EE8", Offset = "0xD39EE8", VA = "0xD39EE8", Slot = "21")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xD39F18", Offset = "0xD39F18", VA = "0xD39F18", Slot = "22")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xD39F48", Offset = "0xD39F48", VA = "0xD39F48", Slot = "25")]
		public override void WriteValue(string value)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xD39FFC", Offset = "0xD39FFC", VA = "0xD39FFC", Slot = "26")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xD3A080", Offset = "0xD3A080", VA = "0xD3A080", Slot = "27")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x8118B4", Offset = "0x8118B4")]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xD3A13C", Offset = "0xD3A13C", VA = "0xD3A13C", Slot = "28")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xD3A1C0", Offset = "0xD3A1C0", VA = "0xD3A1C0", Slot = "29")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x8118C8", Offset = "0x8118C8")]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xD3A27C", Offset = "0xD3A27C", VA = "0xD3A27C", Slot = "30")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xD3A300", Offset = "0xD3A300", VA = "0xD3A300", Slot = "31")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xD3A384", Offset = "0xD3A384", VA = "0xD3A384", Slot = "32")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xD3A408", Offset = "0xD3A408", VA = "0xD3A408", Slot = "33")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xD3A48C", Offset = "0xD3A48C", VA = "0xD3A48C", Slot = "34")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x8118DC", Offset = "0x8118DC")]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xD3A510", Offset = "0xD3A510", VA = "0xD3A510", Slot = "35")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xD3A5EC", Offset = "0xD3A5EC", VA = "0xD3A5EC", Slot = "36")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xD3A670", Offset = "0xD3A670", VA = "0xD3A670", Slot = "37")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x8118F0", Offset = "0x8118F0")]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xD3A6F4", Offset = "0xD3A6F4", VA = "0xD3A6F4", Slot = "38")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xD3A788", Offset = "0xD3A788", VA = "0xD3A788", Slot = "39")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xD3A854", Offset = "0xD3A854", VA = "0xD3A854", Slot = "40")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xD3A8E8", Offset = "0xD3A8E8", VA = "0xD3A8E8", Slot = "60")]
		public override void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xD3A978", Offset = "0xD3A978", VA = "0xD3A978", Slot = "41")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xD3AA38", Offset = "0xD3AA38", VA = "0xD3AA38", Slot = "42")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xD3AAE8", Offset = "0xD3AAE8", VA = "0xD3AAE8", Slot = "61")]
		public override void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xD3ABA0", Offset = "0xD3ABA0", VA = "0xD3ABA0")]
		public void WriteObjectId(byte[] value)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xD3AC78", Offset = "0xD3AC78", VA = "0xD3AC78")]
		public void WriteRegex(string pattern, string options)
		{
		}
	}
}
