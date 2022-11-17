using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x2000119")]
	[Preserve]
	public class BsonReader : JsonReader
	{
		[Token(Token = "0x200011A")]
		private enum BsonReaderState
		{
			[Token(Token = "0x40003F1")]
			Normal = 0,
			[Token(Token = "0x40003F2")]
			ReferenceStart = 1,
			[Token(Token = "0x40003F3")]
			ReferenceRef = 2,
			[Token(Token = "0x40003F4")]
			ReferenceId = 3,
			[Token(Token = "0x40003F5")]
			CodeWScopeStart = 4,
			[Token(Token = "0x40003F6")]
			CodeWScopeCode = 5,
			[Token(Token = "0x40003F7")]
			CodeWScopeScope = 6,
			[Token(Token = "0x40003F8")]
			CodeWScopeScopeObject = 7,
			[Token(Token = "0x40003F9")]
			CodeWScopeScopeEnd = 8
		}

		[Token(Token = "0x200011B")]
		private class ContainerContext
		{
			[Token(Token = "0x40003FA")]
			[FieldOffset(Offset = "0x10")]
			public readonly BsonType Type;

			[Token(Token = "0x40003FB")]
			[FieldOffset(Offset = "0x14")]
			public int Length;

			[Token(Token = "0x40003FC")]
			[FieldOffset(Offset = "0x18")]
			public int Position;

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0xD38580", Offset = "0xD38580", VA = "0xD38580")]
			public ContainerContext(BsonType type)
			{
			}
		}

		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] SeqRange1;

		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] SeqRange2;

		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] SeqRange3;

		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] SeqRange4;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x78")]
		private readonly BinaryReader _reader;

		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x80")]
		private readonly List<ContainerContext> _stack;

		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x88")]
		private byte[] _byteBuffer;

		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x90")]
		private char[] _charBuffer;

		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x98")]
		private BsonType _currentElementType;

		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x9C")]
		private BsonReaderState _bsonReaderState;

		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0xA0")]
		private ContainerContext _currentContext;

		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0xA8")]
		private bool _readRootValueAsArray;

		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0xA9")]
		private bool _jsonNet35BinaryCompatibility;

		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0xAC")]
		private DateTimeKind _dateTimeKindHandling;

		[Token(Token = "0x170001C7")]
		public DateTimeKind DateTimeKindHandling
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xD3798C", Offset = "0xD3798C", VA = "0xD3798C")]
			get
			{
				return default(DateTimeKind);
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xD37994", Offset = "0xD37994", VA = "0xD37994")]
		private string ReadElement()
		{
			return null;
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xD37CE0", Offset = "0xD37CE0", VA = "0xD37CE0", Slot = "10")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xD3847C", Offset = "0xD3847C", VA = "0xD3847C", Slot = "20")]
		public override void Close()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xD38278", Offset = "0xD38278", VA = "0xD38278")]
		private bool ReadCodeWScope()
		{
			return default(bool);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xD380C8", Offset = "0xD380C8", VA = "0xD380C8")]
		private bool ReadReference()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xD37EC8", Offset = "0xD37EC8", VA = "0xD37EC8")]
		private bool ReadNormal()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xD38BAC", Offset = "0xD38BAC", VA = "0xD38BAC")]
		private void PopContext()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xD385AC", Offset = "0xD385AC", VA = "0xD385AC")]
		private void PushContext(ContainerContext newContext)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xD38B6C", Offset = "0xD38B6C", VA = "0xD38B6C")]
		private byte ReadByte()
		{
			return default(byte);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xD3866C", Offset = "0xD3866C", VA = "0xD3866C")]
		private void ReadType(BsonType type)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xD38D78", Offset = "0xD38D78", VA = "0xD38D78")]
		private byte[] ReadBinary(out BsonBinaryType binaryType)
		{
			return null;
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xD379FC", Offset = "0xD379FC", VA = "0xD379FC")]
		private string ReadString()
		{
			return null;
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xD38514", Offset = "0xD38514", VA = "0xD38514")]
		private string ReadLengthString()
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xD38F70", Offset = "0xD38F70", VA = "0xD38F70")]
		private string GetString(int length)
		{
			return null;
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xD38ED0", Offset = "0xD38ED0", VA = "0xD38ED0")]
		private int GetLastFullCharStop(int start)
		{
			return default(int);
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xD39250", Offset = "0xD39250", VA = "0xD39250")]
		private int BytesInSequence(byte b)
		{
			return default(int);
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xD38E20", Offset = "0xD38E20", VA = "0xD38E20")]
		private void EnsureBuffers()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xD38D34", Offset = "0xD38D34", VA = "0xD38D34")]
		private double ReadDouble()
		{
			return default(double);
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xD384D0", Offset = "0xD384D0", VA = "0xD384D0")]
		private int ReadInt32()
		{
			return default(int);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xD38DDC", Offset = "0xD38DDC", VA = "0xD38DDC")]
		private long ReadInt64()
		{
			return default(long);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xD379BC", Offset = "0xD379BC", VA = "0xD379BC")]
		private BsonType ReadType()
		{
			return default(BsonType);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xD38CE0", Offset = "0xD38CE0", VA = "0xD38CE0")]
		private void MovePosition(int count)
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xD38624", Offset = "0xD38624", VA = "0xD38624")]
		private byte[] ReadBytes(int count)
		{
			return null;
		}
	}
}
