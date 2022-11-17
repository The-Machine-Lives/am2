using Il2CppDummyDll;

namespace Opencoding.Console
{
	[Token(Token = "0x200001E")]
	public class SaveFileData
	{
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DB14", Offset = "0x81DB14")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81DB14", Offset = "0x81DB14")]
		private byte[] _003CData_003Ek__BackingField;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DB50", Offset = "0x81DB50")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81DB50", Offset = "0x81DB50")]
		private string _003CName_003Ek__BackingField;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DB8C", Offset = "0x81DB8C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81DB8C", Offset = "0x81DB8C")]
		private SaveFileDataType _003CDataType_003Ek__BackingField;

		[Token(Token = "0x1700007C")]
		public byte[] Data
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0xE8C798", Offset = "0xE8C798", VA = "0xE8C798")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81E318", Offset = "0x81E318")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xE8FAD4", Offset = "0xE8FAD4", VA = "0xE8FAD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81E328", Offset = "0x81E328")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public string Name
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0xE8C7A0", Offset = "0xE8C7A0", VA = "0xE8C7A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81E338", Offset = "0x81E338")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0xE8FADC", Offset = "0xE8FADC", VA = "0xE8FADC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81E348", Offset = "0x81E348")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public SaveFileDataType DataType
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0xE8C7A8", Offset = "0xE8C7A8", VA = "0xE8C7A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81E358", Offset = "0x81E358")]
			get
			{
				return default(SaveFileDataType);
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0xE8FAE4", Offset = "0xE8FAE4", VA = "0xE8FAE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81E368", Offset = "0x81E368")]
			set
			{
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE8FAEC", Offset = "0xE8FAEC", VA = "0xE8FAEC")]
		public SaveFileData(string name, byte[] data, SaveFileDataType dataType)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE8FB2C", Offset = "0xE8FB2C", VA = "0xE8FB2C")]
		public SaveFileData(string name, string data, SaveFileDataType dataType)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE8C6B8", Offset = "0xE8C6B8", VA = "0xE8C6B8")]
		public string GetMimeType()
		{
			return null;
		}
	}
}
