using Sandbox;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

[Library("npc_zombie", Title = "Zombie", Spawnable = true )]
public partial class NpcZombie : Npc
{
	public override float Speed => 300;
	public override float InitHealth => 200;
	public virtual string ModelPath => "models/citizen/citizen.vmdl";


	SandboxPlayer Target;
	TimeSince timeSinceAttPlayer;

	public override void Spawn()
	{
		base.Spawn();

		RenderColor = Color.Green;
		SetModel(ModelPath);
		//SetAnimInt("holdtype", 2);

	
	}

	private void FindTarget()
    {
		var rply = All.OfType<SandboxPlayer>().ToArray();

		Target = rply[Rand.Int( 0, rply.Count() - 1 )];
    }

	private void AttPlayer()
    {
		var dmg = new DamageInfo()
		{
			Attacker = this,
			Position = Position,
			Damage = 5
		};

		Target.TakeDamage(dmg);
	}

	public override void OnTick()
	{
		if (Target == null || Target.LifeState == LifeState.Dead)
			FindTarget();
		else
        {
			Steer = new NavSteer();
			Steer.Target = Target.Position;

			if (Target.Position.Distance(Position) < 100 && timeSinceAttPlayer > 1f)
			{
				timeSinceAttPlayer = 0f;

				AttPlayer();
			}
		}
	}
}
