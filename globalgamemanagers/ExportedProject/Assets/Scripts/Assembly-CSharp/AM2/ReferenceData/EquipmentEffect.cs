using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000372")]
	public class EquipmentEffect : RuntimeData<RDEquipmentEffect>
	{
		[Token(Token = "0x170004C9")]
		public EEquipmentEffect effect
		{
			[Token(Token = "0x6001B7A")]
			[Address(RVA = "0x9B2444", Offset = "0x9B2444", VA = "0x9B2444")]
			get
			{
				return default(EEquipmentEffect);
			}
		}

		[Token(Token = "0x6001B7B")]
		[Address(RVA = "0x9B2470", Offset = "0x9B2470", VA = "0x9B2470")]
		public EquipmentEffect()
		{
		}

		[Token(Token = "0x6001B7C")]
		[Address(RVA = "0x9B2358", Offset = "0x9B2358", VA = "0x9B2358")]
		public EquipmentTrait GenerateTraitForNewItem()
		{
			return null;
		}

		[Token(Token = "0x6001B7D")]
		[Address(RVA = "0x9B24C0", Offset = "0x9B24C0", VA = "0x9B24C0")]
		private double GetAmount()
		{
			return default(double);
		}
	}
}
