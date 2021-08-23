using Sandbox;

[Library("weapon_hands", Title = "Hands", Spawnable = true, Group = "Weapons")]
public class Hands : Weapon
{
	static SoundEvent Attack = new SoundEvent("");
	public override float Damage => 0;
	public override bool IsAutomatic => false;
	public override int ClipSize => 0;
	public override int RPM => 40;
	public override float ReloadTime => 4f;
	public override float Spread => 0.1f;
	public override int BulletsPerShot => 0;
	public override string ShootShound => "";
	public override string WorldModelPath => "";
	public override string ViewModelPath => "";
	public override string Brass => null;

	public override void SimulateAnimator(PawnAnimator anim)
	{
		anim.SetParam("holdtype", 0);
		anim.SetParam("aimat_weight", 1.0f);
	}
}
