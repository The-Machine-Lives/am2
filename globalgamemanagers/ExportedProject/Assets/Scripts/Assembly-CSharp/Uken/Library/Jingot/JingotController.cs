using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Framework.Casual;

namespace Uken.Library.Jingot
{
	[Token(Token = "0x2000426")]
	public class JingotController : UkenController
	{
		[Token(Token = "0x20007D9")]
		public delegate string EntityIDFunc(JingotEntityType entityType);

		[Token(Token = "0x20007DA")]
		public delegate string EntityCreatedAtFunc(JingotEntityType entityType);

		[Token(Token = "0x20007DB")]
		public delegate string VersionFunc();

		[Token(Token = "0x20007DC")]
		public delegate string PlatformFunc();

		[Token(Token = "0x20007DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210E8", Offset = "0x8210E8")]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			[Token(Token = "0x40022E1")]
			[FieldOffset(Offset = "0x10")]
			public JingotController _003C_003E4__this;

			[Token(Token = "0x40022E2")]
			[FieldOffset(Offset = "0x18")]
			public JingotEntityType entityType;

			[Token(Token = "0x40022E3")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool> onComplete;

			[Token(Token = "0x6003247")]
			[Address(RVA = "0xBA7D38", Offset = "0xBA7D38", VA = "0xBA7D38")]
			public _003C_003Ec__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6003248")]
			[Address(RVA = "0xBA9188", Offset = "0xBA9188", VA = "0xBA9188")]
			internal void _003CQueryJingotTests_003Eb__0(WebResponse res, WebRequest req)
			{
			}
		}

		[Token(Token = "0x20007DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210F8", Offset = "0x8210F8")]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			[Token(Token = "0x40022E4")]
			[FieldOffset(Offset = "0x10")]
			public ABTestGroup newAssignment;

			[Token(Token = "0x6003249")]
			[Address(RVA = "0xBA89F4", Offset = "0xBA89F4", VA = "0xBA89F4")]
			public _003C_003Ec__DisplayClass21_0()
			{
			}

			[Token(Token = "0x600324A")]
			[Address(RVA = "0xBA923C", Offset = "0xBA923C", VA = "0xBA923C")]
			internal bool _003CLogNightmareJoinABTest_003Eb__0(ABTestGroup a)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400133E")]
		[FieldOffset(Offset = "0x18")]
		private string m_baseUrl;

		[Token(Token = "0x400133F")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<JingotEntityType, List<ABTestGroup>> m_abTestGroups;

		[Token(Token = "0x4001340")]
		[FieldOffset(Offset = "0x28")]
		private Action<WebRequest> m_webRequestFunc;

		[Token(Token = "0x4001341")]
		private const string mc_sJingotFileName = "jingot_4_6";

		[Token(Token = "0x4001342")]
		private const string mc_sAppVersionFilterCriteriaKey = "app_version";

		[Token(Token = "0x4001343")]
		private const string mc_sCreatedAtFilterCriteriaKey = "created_at";

		[Token(Token = "0x4001344")]
		private const string mc_sUserIdFilterCriteriaKey = "user_id";

		[Token(Token = "0x4001345")]
		[FieldOffset(Offset = "0x30")]
		private EntityIDFunc m_GetEntityID;

		[Token(Token = "0x4001346")]
		[FieldOffset(Offset = "0x38")]
		private EntityCreatedAtFunc m_GetEntityCreatedAt;

		[Token(Token = "0x4001347")]
		[FieldOffset(Offset = "0x40")]
		private VersionFunc m_GetVersion;

		[Token(Token = "0x4001348")]
		[FieldOffset(Offset = "0x48")]
		private PlatformFunc m_GetPlatform;

		[Token(Token = "0x4001349")]
		[FieldOffset(Offset = "0x50")]
		private CasualAnalog m_analogController;

		[Token(Token = "0x6001F18")]
		[Address(RVA = "0xBA6674", Offset = "0xBA6674", VA = "0xBA6674")]
		public JingotController(string url, EntityIDFunc getUserID, VersionFunc getVersion, PlatformFunc getPlatform, EntityCreatedAtFunc getEntityCreatedAt, Action<WebRequest> webRequestFunc, CasualAnalog analogController)
		{
		}

		[Token(Token = "0x6001F19")]
		[Address(RVA = "0xBA6734", Offset = "0xBA6734", VA = "0xBA6734")]
		public Dictionary<string, string> GetTestGroups()
		{
			return null;
		}

		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0xBA7404", Offset = "0xBA7404", VA = "0xBA7404")]
		public List<ABTestGroup> GetABTestGroups()
		{
			return null;
		}

		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0xBA78AC", Offset = "0xBA78AC", VA = "0xBA78AC")]
		public void QueryJingotTests(JingotEntityType entityType, Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0xBA8374", Offset = "0xBA8374", VA = "0xBA8374")]
		public void OnQueryComplete(WebResponse response, WebRequest request, JingotEntityType entityType)
		{
		}

		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0xBA8524", Offset = "0xBA8524", VA = "0xBA8524")]
		protected void LogNightmareJoinABTest(JingotEntityType entityType, List<ABTestGroup> newAssigments)
		{
		}

		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0xBA8190", Offset = "0xBA8190", VA = "0xBA8190")]
		protected Dictionary<string, string> GetFilterCriteria(JingotEntityType entityType)
		{
			return null;
		}

		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0xBA8E4C", Offset = "0xBA8E4C", VA = "0xBA8E4C")]
		protected string GetFormattedDateTimeString(string rawDateTime)
		{
			return null;
		}

		[Token(Token = "0x6001F20")]
		[Address(RVA = "0xBA8F34", Offset = "0xBA8F34", VA = "0xBA8F34")]
		protected string GetFilePath()
		{
			return null;
		}

		[Token(Token = "0x6001F21")]
		[Address(RVA = "0xBA8FA8", Offset = "0xBA8FA8", VA = "0xBA8FA8", Slot = "5")]
		public override bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6001F22")]
		[Address(RVA = "0xBA884C", Offset = "0xBA884C", VA = "0xBA884C")]
		public void SaveData()
		{
		}
	}
}
