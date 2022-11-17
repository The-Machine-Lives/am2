using System.Collections.Generic;
using Il2CppDummyDll;

namespace Opencoding.Shared.Utils
{
	[Token(Token = "0x2000003")]
	public class Email
	{
		[Token(Token = "0x2000004")]
		public class Attachment
		{
			[Token(Token = "0x4000006")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808274", Offset = "0x808274")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x808274", Offset = "0x808274")]
			private string _003CFilename_003Ek__BackingField;

			[Token(Token = "0x4000007")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8082B0", Offset = "0x8082B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8082B0", Offset = "0x8082B0")]
			private string _003CMimeType_003Ek__BackingField;

			[Token(Token = "0x4000008")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8082EC", Offset = "0x8082EC")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8082EC", Offset = "0x8082EC")]
			private byte[] _003CData_003Ek__BackingField;

			[Token(Token = "0x17000006")]
			public string Filename
			{
				[Token(Token = "0x600000C")]
				[Address(RVA = "0x1812390", Offset = "0x1812390", VA = "0x1812390")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808440", Offset = "0x808440")]
				get
				{
					return null;
				}
				[Token(Token = "0x600000D")]
				[Address(RVA = "0x1812398", Offset = "0x1812398", VA = "0x1812398")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808450", Offset = "0x808450")]
				private set
				{
				}
			}

			[Token(Token = "0x17000007")]
			private string MimeType
			{
				[Token(Token = "0x600000E")]
				[Address(RVA = "0x18123A0", Offset = "0x18123A0", VA = "0x18123A0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808460", Offset = "0x808460")]
				set
				{
				}
			}

			[Token(Token = "0x17000008")]
			public byte[] Data
			{
				[Token(Token = "0x600000F")]
				[Address(RVA = "0x18123A8", Offset = "0x18123A8", VA = "0x18123A8")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808470", Offset = "0x808470")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000010")]
				[Address(RVA = "0x18123B0", Offset = "0x18123B0", VA = "0x18123B0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808480", Offset = "0x808480")]
				private set
				{
				}
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x18123B8", Offset = "0x18123B8", VA = "0x18123B8")]
			public Attachment(string path, string mimeType)
			{
			}
		}

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808148", Offset = "0x808148")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x808148", Offset = "0x808148")]
		private string _003CMessage_003Ek__BackingField;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808184", Offset = "0x808184")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x808184", Offset = "0x808184")]
		private string _003CToAddress_003Ek__BackingField;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8081C0", Offset = "0x8081C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8081C0", Offset = "0x8081C0")]
		private string _003CSubject_003Ek__BackingField;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8081FC", Offset = "0x8081FC")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8081FC", Offset = "0x8081FC")]
		private bool _003CIsHTML_003Ek__BackingField;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808238", Offset = "0x808238")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x808238", Offset = "0x808238")]
		private List<Attachment> _003CAttachments_003Ek__BackingField;

		[Token(Token = "0x17000001")]
		public string Message
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x18122D4", Offset = "0x18122D4", VA = "0x18122D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8083B0", Offset = "0x8083B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x18122DC", Offset = "0x18122DC", VA = "0x18122DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8083C0", Offset = "0x8083C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public string ToAddress
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x18122E4", Offset = "0x18122E4", VA = "0x18122E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8083D0", Offset = "0x8083D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x18122EC", Offset = "0x18122EC", VA = "0x18122EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8083E0", Offset = "0x8083E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public string Subject
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x18122F4", Offset = "0x18122F4", VA = "0x18122F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8083F0", Offset = "0x8083F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x18122FC", Offset = "0x18122FC", VA = "0x18122FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808400", Offset = "0x808400")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public bool IsHTML
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1812304", Offset = "0x1812304", VA = "0x1812304")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808410", Offset = "0x808410")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000005")]
		public List<Attachment> Attachments
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x181230C", Offset = "0x181230C", VA = "0x181230C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808420", Offset = "0x808420")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x1812314", Offset = "0x1812314", VA = "0x1812314")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808430", Offset = "0x808430")]
			set
			{
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x181231C", Offset = "0x181231C", VA = "0x181231C")]
		public Email()
		{
		}
	}
}
