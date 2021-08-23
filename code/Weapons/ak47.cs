using Sandbox;

[Library("weapon_ak47", Title = "AK-47", Spawnable = true, Group = "Weapons" )]
public class AK47 : Weapon
{

	public override float Damage => 25;
	public override bool IsAutomatic => true;
	public override int RPM => 600;
	public override float ReloadTime => 3f;
	public override float Spread => 0.15f;
	public override int ClipSize => 30;
	public override string ShootShound => "ak47-1";
	public override string WorldModelPath => "models/weapons/ak47/w_tct_ak47.vmdl";
	public override string ViewModelPath => "models/weapons/ak47/v_tct_ak47.vmdl";
	public override HoldType HoldType => HoldType.SMG;
}
