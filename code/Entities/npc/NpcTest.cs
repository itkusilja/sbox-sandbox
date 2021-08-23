using Sandbox;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

[Library("npc_tests", Title = "Test NPC", Spawnable = true)]
public partial class NpcTest : Npc
{
	public override float Speed => 500;
	public override float InitHealth => 200;


	public override void Spawn()
	{
		base.Spawn();

		SetMaterialGroup(3);

		//SetAnimInt("holdtype", 2);
	}



}
