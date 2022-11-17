using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000570")]
	public class UserSegments : DepotController
	{
		[Token(Token = "0x40019E9")]
		[FieldOffset(Offset = "0x20")]
		private Features m_features;

		[Token(Token = "0x40019EA")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, UserSegment> m_segmentCache;

		[Token(Token = "0x40019EB")]
		[FieldOffset(Offset = "0x30")]
		private UserProfiler m_userProfiler;

		[Token(Token = "0x1700074C")]
		private DepotEntity<RDUserSegment> m_UserSegments
		{
			[Token(Token = "0x60029B1")]
			[Address(RVA = "0xAA0658", Offset = "0xAA0658", VA = "0xAA0658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60029B2")]
		[Address(RVA = "0xAA07BC", Offset = "0xAA07BC", VA = "0xAA07BC")]
		public UserSegments(CasualDataStoreController controller, Features features, UserProfiler userProfiler)
		{
		}

		[Token(Token = "0x60029B3")]
		[Address(RVA = "0xA95E88", Offset = "0xA95E88", VA = "0xA95E88")]
		public UserSegment FindOrCreate(string reference)
		{
			return null;
		}

		[Token(Token = "0x60029B4")]
		[Address(RVA = "0xAA0858", Offset = "0xAA0858", VA = "0xAA0858")]
		public bool Evaluate(string reference)
		{
			return default(bool);
		}
	}
}
