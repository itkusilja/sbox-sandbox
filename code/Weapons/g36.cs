﻿using Sandbox;

[Library("weapon_g36", Title = "G36", Spawnable = true, Group = "Weapons" )]
public class G36 : Weapon
{

	public override float Damage => 25;
	public override bool IsAutomatic => true;
	public override int RPM => 600;
	public override float ReloadTime => 3f;
	public override float Spread => 0.15f;
	public override int ClipSize => 30;
	public override string ShootShound => "m4a1_unsil-1";
	public override string WorldModelPath => "models/weapons/g36/w_hk_g36c.vmdl";
	public override string ViewModelPath => "models/weapons/g36/v_rif_g362.vmdl";
	public override HoldType HoldType => HoldType.SMG;
}
