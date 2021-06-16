using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PikasMod.Items
{
	public class staffLunar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Lunar Staff"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A Moon Lord's eye on a stick... What?");
		}

		public override void SetDefaults()
		{
			item.damage = 256;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 8;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.crit = 76;
			item.value = 1000000;
			item.rare = 7;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("projectileSmallEye");
			item.shoot = mod.ProjectileType("projectileBigEye");
		}

		public override bool AltFunctionUse(Player player)//You use this to allow the item to be right clicked
		{
			return true;

			if (player.altFunctionUse == 2)//Sets what happens on right click(special ability)
			{
				item.damage = 256;
				item.magic = true;
				item.noMelee = true;
				item.width = 40;
				item.height = 40;
				item.useTime = 8;
				item.useAnimation = 20;
				item.useStyle = 4;
				item.knockBack = 6;
				item.crit = 76;
				item.value = 1000000;
				item.rare = 7;
				item.shootSpeed = 40f;
				item.autoReuse = true;
				item.shoot = mod.ProjectileType("projectileBigEye");
			}

			else //Sets what happens on left click(normal use)
			{
				item.damage = 256;
				item.magic = true;
				item.noMelee = true;
				item.width = 40;
				item.height = 40;
				item.useTime = 8;
				item.useAnimation = 20;
				item.useStyle = 4;
				item.knockBack = 6;
				item.crit = 76;
				item.value = 1000000;
				item.rare = 7;
				item.shootSpeed = 12f;
				item.autoReuse = true;
				item.shoot = mod.ProjectileType("projectileSmallEye");
			}
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SuspiciousLookingTentacle);
			recipe.AddIngredient(ItemID.MoonLordTrophy);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}