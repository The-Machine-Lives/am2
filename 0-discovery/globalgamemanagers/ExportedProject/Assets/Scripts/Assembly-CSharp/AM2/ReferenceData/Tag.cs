using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000332")]
	public class Tag : RuntimeData<RDTag>, ITag, ISubTabItemModel, IItemModel, IInfoText, IDustable
	{
		[Token(Token = "0x4000FC7")]
		[FieldOffset(Offset = "0x18")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x170003F8")]
		public string readableName
		{
			[Token(Token = "0x60019AF")]
			[Address(RVA = "0x9711B0", Offset = "0x9711B0", VA = "0x9711B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F9")]
		public string readableItemName
		{
			[Token(Token = "0x60019B0")]
			[Address(RVA = "0x9711DC", Offset = "0x9711DC", VA = "0x9711DC", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003FA")]
		public bool isDescriptorTag
		{
			[Token(Token = "0x60019B1")]
			[Address(RVA = "0x971208", Offset = "0x971208", VA = "0x971208", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003FB")]
		public SubTab subTab
		{
			[Token(Token = "0x60019B2")]
			[Address(RVA = "0x971210", Offset = "0x971210", VA = "0x971210", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003FC")]
		public SubTab researchableSubTab
		{
			[Token(Token = "0x60019B3")]
			[Address(RVA = "0x971218", Offset = "0x971218", VA = "0x971218", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003FD")]
		public Section section
		{
			[Token(Token = "0x60019B4")]
			[Address(RVA = "0x971220", Offset = "0x971220", VA = "0x971220", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003FE")]
		public Section researchableSection
		{
			[Token(Token = "0x60019B5")]
			[Address(RVA = "0x971228", Offset = "0x971228", VA = "0x971228", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003FF")]
		public string description
		{
			[Token(Token = "0x60019B6")]
			[Address(RVA = "0x971230", Offset = "0x971230", VA = "0x971230", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000400")]
		public string researchInfoText
		{
			[Token(Token = "0x60019B7")]
			[Address(RVA = "0x97125C", Offset = "0x97125C", VA = "0x97125C", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000401")]
		public string infoImageSource
		{
			[Token(Token = "0x60019B8")]
			[Address(RVA = "0x971288", Offset = "0x971288", VA = "0x971288", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000402")]
		public string dustInputItem
		{
			[Token(Token = "0x60019B9")]
			[Address(RVA = "0x9712B4", Offset = "0x9712B4", VA = "0x9712B4", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000403")]
		public long dustOutputAmount
		{
			[Token(Token = "0x60019BA")]
			[Address(RVA = "0x9712E0", Offset = "0x9712E0", VA = "0x9712E0", Slot = "19")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x60019BB")]
		[Address(RVA = "0x97130C", Offset = "0x97130C", VA = "0x97130C", Slot = "4")]
		public override void Initialize(RDTag referenceData)
		{
		}

		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x971410", Offset = "0x971410", VA = "0x971410", Slot = "20")]
		public bool Dust(long count)
		{
			return default(bool);
		}

		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x971458", Offset = "0x971458", VA = "0x971458")]
		public Tag()
		{
		}
	}
}
