using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Items
{
    public class VanillaRecipeEdits : ModSystem
    {
        public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];
                int result = recipe.createItem.type;

                if (IsGemHook(result) && !HasIngredient(recipe, ItemID.Hook))
                    recipe.AddIngredient(ItemID.Hook);

                if (result == ItemID.BladeofGrass && !HasIngredient(recipe, ItemID.RichMahogany))
                    recipe.AddIngredient(ItemID.RichMahogany, 15);

                if (result == ItemID.IvyWhip && !HasIngredient(recipe, ItemID.RichMahogany))
                    recipe.AddIngredient(ItemID.RichMahogany, 12);

                if (result == ItemID.ThornWhip && !HasIngredient(recipe, ItemID.RichMahogany))
                    recipe.AddIngredient(ItemID.RichMahogany, 15);

                if (result == ItemID.JungleHat && !HasIngredient(recipe, ItemID.Vine))
                    recipe.AddIngredient(ItemID.Vine, 2);

                if (result == ItemID.ThornChakram && !HasIngredient(recipe, ItemID.Vine))
                    recipe.AddIngredient(ItemID.Vine, 2);
            }
        }

        private static bool IsGemHook(int type)
        {
            return type is ItemID.AmberHook or ItemID.AmethystHook or ItemID.DiamondHook
                or ItemID.EmeraldHook or ItemID.RubyHook or ItemID.SapphireHook or ItemID.TopazHook;
        }

        private static bool HasIngredient(Recipe recipe, int itemType)
        {
            foreach (Item ingredient in recipe.requiredItem)
            {
                if (ingredient.type == itemType)
                    return true;
            }

            return false;
        }
    }
}
