using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200031D")]
	public class AbilityTraitDisplay
	{
		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8273E8", Offset = "0x8273E8")]
		private string _003Ctitle_003Ek__BackingField;

		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8273F8", Offset = "0x8273F8")]
		private string _003CcurrentAmountText_003Ek__BackingField;

		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x827408", Offset = "0x827408")]
		private string _003CdiffText_003Ek__BackingField;

		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x827418", Offset = "0x827418")]
		private bool _003Clocalized_003Ek__BackingField;

		[Token(Token = "0x170003C1")]
		public string title
		{
			[Token(Token = "0x6001936")]
			[Address(RVA = "0x9AC054", Offset = "0x9AC054", VA = "0x9AC054")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837AB0", Offset = "0x837AB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001937")]
			[Address(RVA = "0x9AC05C", Offset = "0x9AC05C", VA = "0x9AC05C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837AC0", Offset = "0x837AC0")]
			private set
			{
			}
		}

		[Token(Token = "0x170003C2")]
		public string currentAmountText
		{
			[Token(Token = "0x6001938")]
			[Address(RVA = "0x9AC064", Offset = "0x9AC064", VA = "0x9AC064")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837AD0", Offset = "0x837AD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001939")]
			[Address(RVA = "0x9AC06C", Offset = "0x9AC06C", VA = "0x9AC06C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837AE0", Offset = "0x837AE0")]
			private set
			{
			}
		}

		[Token(Token = "0x170003C3")]
		public string diffText
		{
			[Token(Token = "0x600193A")]
			[Address(RVA = "0x9AC074", Offset = "0x9AC074", VA = "0x9AC074")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837AF0", Offset = "0x837AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600193B")]
			[Address(RVA = "0x9AC07C", Offset = "0x9AC07C", VA = "0x9AC07C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837B00", Offset = "0x837B00")]
			private set
			{
			}
		}

		[Token(Token = "0x170003C4")]
		public bool localized
		{
			[Token(Token = "0x600193C")]
			[Address(RVA = "0x9AC084", Offset = "0x9AC084", VA = "0x9AC084")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837B10", Offset = "0x837B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600193D")]
			[Address(RVA = "0x9AC08C", Offset = "0x9AC08C", VA = "0x9AC08C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837B20", Offset = "0x837B20")]
			private set
			{
			}
		}

		[Token(Token = "0x600193E")]
		[Address(RVA = "0x9AC098", Offset = "0x9AC098", VA = "0x9AC098")]
		public AbilityTraitDisplay(string inTitle, double currentAmount, double nextAmount, int decimalPlaces, bool inLocalized, EStatusNumericDisplay displayType, ENumericDisplayType numericType = ENumericDisplayType.None, AM2TextFormatter.ETimeFormat timeFormat = AM2TextFormatter.ETimeFormat.Dynamic)
		{
		}

		[Token(Token = "0x600193F")]
		[Address(RVA = "0x9AC254", Offset = "0x9AC254", VA = "0x9AC254")]
		public AbilityTraitDisplay(string inTitle, string inCurrentAmountText, string inDiffText, bool inLocalized)
		{
		}

		[Token(Token = "0x6001940")]
		[Address(RVA = "0x9AC2A8", Offset = "0x9AC2A8", VA = "0x9AC2A8")]
		public AbilityTraitDisplay(string inTitle)
		{
		}

		[Token(Token = "0x6001941")]
		[Address(RVA = "0x9AC240", Offset = "0x9AC240", VA = "0x9AC240")]
		private void Initialize(string inTitle, string inCurrentAmountText, string inDiffText, bool inLocalized)
		{
		}

		[Token(Token = "0x6001942")]
		[Address(RVA = "0x9AC2D4", Offset = "0x9AC2D4", VA = "0x9AC2D4")]
		private void Initialize(string inTitle)
		{
		}
	}
}
