using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using Pokedex.Enums;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Grass;
using Pokedex.Models.Pokemons.Normal;
using HarmonyLib;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Psy;

namespace Tests
{
	[TestClass]
	/// <summary>
	/// Handles tests to the PokeInstance class
	/// </summary>
	/// <see cref='PokeInstance'>
	public class TestPokeInstanceClass
	{
		[TestMethod]
		/// <summary>
		/// Tests a PokeInstance's properties
		/// </summary>
		/// <see cref="PokeInstance.Nickname"/>
		/// <see cref="PokeInstance.Gender"/>
		/// <see cref="PokeInstance.Level"/>
		/// <see cref="PokeInstance.Pokemon"/>
		/// <see cref="Pokemon.NameEn"/>
		/// <see cref="Pokemon.GenusEn"/>
		/// <see cref="Pokemon.Id"/>
		/// <see cref="Pokemon.Height"/>
		/// <see cref="Pokemon.Weight"/>
		public void PokemonAttributes()
		{
			var arceus = new PokeInstance(Arceus.Instance, "God", 100, Gender.Unknown);

			Assert.AreEqual("God", arceus.Nickname, $"Nickname should be 'God', is {arceus.Nickname}");
			Assert.AreEqual(Gender.Unknown, arceus.Gender, $"Gender should be 'Unknown', is {arceus.Gender}");
			Assert.AreEqual(100, arceus.Level, $"Level should be '100', is {arceus.Level}");
			Assert.AreEqual("Arceus", arceus.Pokemon.NameEn, $"Name should be 'Arceus', is {arceus.Pokemon.NameEn}");
			Assert.AreEqual("Alpha Pokémon", arceus.Pokemon.GenusEn, $"Genus should be 'Alpha Pokémon', is {arceus.Pokemon.GenusEn}");
			Assert.AreEqual(493, arceus.Pokemon.Id, $"ID should be '493', is {arceus.Pokemon.Id}");
			Assert.AreEqual(32, arceus.Pokemon.Height, $"Height should be '32', is {arceus.Pokemon.Height}");
			Assert.AreEqual(3200, arceus.Pokemon.Weight, $"Weight should be '3200', is {arceus.Pokemon.Weight}");
		}

		[TestMethod]
		/// <summary>
		/// Tests a PokeInstance's stats calculations
		/// </summary>
		/// <see cref="PokeInstance.CalcHp()"/>
		/// <see cref="PokeInstance.CalcAtk()"/>
		/// <see cref="PokeInstance.CalcDef()"/>
		/// <see cref="PokeInstance.CalcSpAtk()"/>
		/// <see cref="PokeInstance.CalcSpDef()"/>
		/// <see cref="PokeInstance.CalcSpd()"/>
		public void PokemonStats()
		{
			var arceus = new PokeInstance(Arceus.Instance, "God", 100, Gender.Unknown);
			var shaymin = new PokeInstance(ShayminLand.Instance, "Plant God", 50, Gender.Unknown);

			Assert.AreEqual(350, arceus.CalcHp(), $"HP stat should be 350, is {arceus.CalcHp()}");
			// Assert.AreEqual(245, arceus.CalcAtk(), $"Attack stat should be 245, is {arceus.CalcAtk()}");
			// Assert.AreEqual(245, arceus.CalcDef(), $"Defense stat should be 245, is {arceus.CalcDef()}");
			// Assert.AreEqual(245, arceus.CalcSpAtk(), $"Special Attack stat should be 245, is {arceus.CalcSpAtk()}");
			// Assert.AreEqual(245, arceus.CalcSpDef(), $"Special Defense stat should be 245, is {arceus.CalcSpDef()}");
			// Assert.AreEqual(245, arceus.CalcSpd(), $"Speed stat should be 245, is {arceus.CalcSpd()}");

			Assert.AreEqual(160, shaymin.CalcHp(), $"HP stat should be 160, is {shaymin.CalcHp()}");
			// Assert.AreEqual(105, shaymin.CalcAtk(), $"Attack stat should be 105, is {shaymin.CalcAtk()}");
			// Assert.AreEqual(105, shaymin.CalcDef(), $"Defense stat should be 105, is {shaymin.CalcDefe)}");
			// Assert.AreEqual(105, shaymin.CalcSpAtk(), $"Special Attack stat should be 105, is {shaymin.CalcSpAtk()}");
			// Assert.AreEqual(105, shaymin.CalcSpDef(), $"Special Defense stat should be 105, is {shaymin.CalcSpDef()}");
			// Assert.AreEqual(105, shaymin.CalcSpd(), $"Speed stat should be 105, is {shaymin.CalcSpd()}");
		}

		/// <summary>
		/// Tests a PokeInstance's TakeDamage and Heal methods
		/// </summary>
		/// <see cref="PokeInstance.TakeDamage(int)"/>
		/// <see cref="PokeInstance.Heal()"/>
		[TestMethod]
		public void PokemonTakeDamage()
		{
			var arceus = new PokeInstance(Arceus.Instance, "God", 100, Gender.Unknown);

			// Change MaxHP to a fixed 150
			var arceusMaxHP = typeof(PokeInstance).GetMethod(nameof(PokeInstance.CalcHp))!;
			PatchToFixedValue(arceusMaxHP, 150);

			arceus.Heal();
			arceus.TakeDamage(100);
			Assert.AreEqual(50, arceus.Hp, $"HP should be 50, is {arceus.Hp}");

			arceus.Heal();
			arceus.TakeDamage(200);
			Assert.AreEqual(0, arceus.Hp, $"HP should be 0, is {arceus.Hp}");

			arceus.Heal();
			arceus.TakeDamage(-100);
			Assert.AreEqual(150, arceus.Hp, $"HP should be 150, is {arceus.Hp}");

			// Revert the MaxHP back to normal
			UnpatchFixedValue(arceusMaxHP);
		}
		
		/// <summary>
		/// Tests a PokeInstance's LearnMove method
		/// </summary>
		/// <see cref="PokeInstance.LearnMove(PokeMove)"/>
		/// <see cref="PokeInstance.LearnMove(PokeMove, int)"/>
		[TestMethod]
		public void PokemonMoves()
		{
			var arceus = new PokeInstance(Arceus.Instance, "God", 100, Gender.Unknown);

			Assert.IsTrue(arceus.LearnMove(Judgment.Instance), "LearnMove failed, whereas it should not, as the move was both learnable, a free spot was available, and it was not already learned");
			Assert.AreEqual(Judgment.Instance, arceus.Moves[0], $"Move[0] should be Judgment, is {arceus.Moves[0]}");
			Assert.AreEqual(null, arceus.Moves[1], $"Move[1] should be null, is {arceus.Moves[1]}");
			Assert.AreEqual(null, arceus.Moves[2], $"Move[2] should be null, is {arceus.Moves[2]}");
			Assert.AreEqual(null, arceus.Moves[3], $"Move[3] should be null, is {arceus.Moves[3]}");

			Assert.IsFalse(arceus.LearnMove(Judgment.Instance), "LearnMove succeeded, whereas it should not, as the move was already known");

			Assert.IsFalse(arceus.LearnMove(RoarOfTime.Instance), "LearnMove succeeded, whereas it should not, as the move was not learnable");

			arceus.LearnMove(Cut.Instance);
			Assert.AreEqual(Cut.Instance, arceus.Moves[1], $"Move[1] should be Cut, is {arceus.Moves[1]}");
			arceus.LearnMove(Fly.Instance);
			Assert.AreEqual(Fly.Instance, arceus.Moves[2], $"Move[2] should be Fly, is {arceus.Moves[2]}");
			arceus.LearnMove(Surf.Instance);
			Assert.AreEqual(Surf.Instance, arceus.Moves[3], $"Move[3] should be Surf, is {arceus.Moves[3]}");

			Assert.IsFalse(arceus.LearnMove(DreamEater.Instance), "LearnMove succeeded, whereas it should not, as there was no empty spot available");
		}

		#region DON'T TOUCH
		private static Harmony __harmony = new Harmony("TestFixedValue");
		private static MethodInfo __prefix = typeof(TestPokeInstanceClass).GetMethod(nameof(ForceFixedValue), BindingFlags.Static | BindingFlags.NonPublic)!;
		private static int __value = 0;

		private static void PatchToFixedValue(MethodInfo method, int value)
		{
			__value = value;
			__harmony.Patch(method, prefix: new HarmonyMethod(__prefix));
		}

		private static void UnpatchFixedValue(MethodInfo method)
		{
			__harmony.Unpatch(method, __prefix);
		}

		private static bool ForceFixedValue(ref int __result)
		{ __result = __value; return false; }
		#endregion
	}
}