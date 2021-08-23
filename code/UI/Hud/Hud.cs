using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public partial class HudBase : Panel
{
	public Panel HudBG;
	public Panel Crosshair;
	public HudBase()
    {
		HudBG = Add.Panel("HudBaseBG");
		Crosshair = Add.Panel("crosshair");
	}

}


public partial class Vitals : Panel
{
	public Label Health;
	public Label HealthImg;

	public Vitals()
	{
		HealthImg = Add.Label("", "healthImg");
		Health = HealthImg.Add.Label( "100", "healthText" );
	}

	public override void Tick()
	{

		base.Tick();

		var player = Local.Pawn;
		if ( player == null ) return;

		Health.Text = $"{player.Health.CeilToInt()}";
	}
}

public partial class Armour : Panel
{
	public Label Armor;
	public Label ArmorImg;

	public Armour()
	{
		ArmorImg = Add.Label("", "armorImg");
		Armor = ArmorImg.Add.Label("100", "armorText");
	}

	public override void Tick()
	{

		base.Tick();

		var player = Local.Pawn;
		if (player == null) return;

		Armor.Text = $"100";
	}
}

public partial class Ammo : Panel
{
	public Label Weapon;
	public Label WeaponImg;

	public Ammo()
	{

		WeaponImg = Add.Label("", "ammoImg");
		Weapon = WeaponImg.Add.Label("100", "ammoText");
	}

	public override void Tick()
	{
		var player = Local.Pawn;
		if (player == null) return;

		var weapon = player.ActiveChild as Weapon;

		SetClass("active", weapon != null);
		if (weapon == null) return;

		if (weapon.ClipSize == 100)
		{
			SetClass("hidden", true);
		}
		else
		{
			SetClass("hidden", false);
			Weapon.Text = $"{weapon.AmmoClip}/{weapon.ClipSize}";
		}
	}
}


