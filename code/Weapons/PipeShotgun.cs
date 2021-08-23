﻿using Sandbox;

[Library("weapon_pipe", Title = "Pipe Shotgun", Spawnable = true, Group = "Weapons" )]
public class PipeShotgun : Weapon
{
	static SoundEvent Attack = new SoundEvent( "weapons/rust_shotgun/sounds/rust-shotgun-attack.vsnd" );
	public override float Damage => 120;
	public override bool IsAutomatic => false;
	public override int ClipSize => 1;
	public override int RPM => 40;
	public override float ReloadTime => 4f;
	public override float Spread => 0f;
	public override int BulletsPerShot => 1;
	public override string ShootShound => "PipeShotgun.Attack";
	public override string WorldModelPath => "weapons/rust_shotgun/rust_shotgun.vmdl";
	public override string ViewModelPath => "weapons/rust_shotgun/v_rust_shotgun.vmdl";
	public override string Brass => null;
	public override HoldType HoldType => HoldType.Shotgun;
}
