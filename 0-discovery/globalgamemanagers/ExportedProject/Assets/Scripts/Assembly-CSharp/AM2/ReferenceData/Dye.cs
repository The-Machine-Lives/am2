using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000391")]
	public class Dye : RuntimeData<RDDye>, ISubTabItemModel, IItemModel, IInfoText, IDustable
	{
		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] rarityNames;

		[Token(Token = "0x400115A")]
		[FieldOffset(Offset = "0x18")]
		private string m_readableName;

		[Token(Token = "0x400115B")]
		[FieldOffset(Offset = "0x20")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x17000501")]
		public string readableName
		{
			[Token(Token = "0x6001BF0")]
			[Address(RVA = "0x9AFD04", Offset = "0x9AFD04", VA = "0x9AFD04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000502")]
		public string readableItemName
		{
			[Token(Token = "0x6001BF1")]
			[Address(RVA = "0x9AFD0C", Offset = "0x9AFD0C", VA = "0x9AFD0C", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000503")]
		public Color color
		{
			[Token(Token = "0x6001BF2")]
			[Address(RVA = "0x9AFD14", Offset = "0x9AFD14", VA = "0x9AFD14")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x17000504")]
		public EDropTier rarity
		{
			[Token(Token = "0x6001BF3")]
			[Address(RVA = "0x9AFD44", Offset = "0x9AFD44", VA = "0x9AFD44")]
			get
			{
				return default(EDropTier);
			}
		}

		[Token(Token = "0x17000505")]
		public string infoText
		{
			[Token(Token = "0x6001BF4")]
			[Address(RVA = "0x9AFD70", Offset = "0x9AFD70", VA = "0x9AFD70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000506")]
		public string researchInfoText
		{
			[Token(Token = "0x6001BF5")]
			[Address(RVA = "0x9AFD9C", Offset = "0x9AFD9C", VA = "0x9AFD9C", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000507")]
		public string infoImageSource
		{
			[Token(Token = "0x6001BF6")]
			[Address(RVA = "0x9AFDE4", Offset = "0x9AFDE4", VA = "0x9AFDE4", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000508")]
		public string dustInputItem
		{
			[Token(Token = "0x6001BF7")]
			[Address(RVA = "0x9AFE10", Offset = "0x9AFE10", VA = "0x9AFE10", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000509")]
		public long dustOutputAmount
		{
			[Token(Token = "0x6001BF8")]
			[Address(RVA = "0x9AFE3C", Offset = "0x9AFE3C", VA = "0x9AFE3C", Slot = "16")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700050A")]
		public SubTab subTab
		{
			[Token(Token = "0x6001BF9")]
			[Address(RVA = "0x9AFE68", Offset = "0x9AFE68", VA = "0x9AFE68", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050B")]
		public SubTab researchableSubTab
		{
			[Token(Token = "0x6001BFA")]
			[Address(RVA = "0x9AFE70", Offset = "0x9AFE70", VA = "0x9AFE70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050C")]
		public Section section
		{
			[Token(Token = "0x6001BFB")]
			[Address(RVA = "0x9AFE78", Offset = "0x9AFE78", VA = "0x9AFE78", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050D")]
		public Section researchableSection
		{
			[Token(Token = "0x6001BFC")]
			[Address(RVA = "0x9AFE80", Offset = "0x9AFE80", VA = "0x9AFE80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050E")]
		public string description
		{
			[Token(Token = "0x6001BFD")]
			[Address(RVA = "0x9AFE88", Offset = "0x9AFE88", VA = "0x9AFE88", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x9AFED8", Offset = "0x9AFED8", VA = "0x9AFED8", Slot = "4")]
		public override void Initialize(RDDye referenceData)
		{
		}

		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x9B0080", Offset = "0x9B0080", VA = "0x9B0080", Slot = "17")]
		public bool Dust(long count)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x9B00C8", Offset = "0x9B00C8", VA = "0x9B00C8")]
		public Dye()
		{
		}
	}
}
