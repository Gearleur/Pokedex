using Pokedex.Enums;
using Pokedex.Models;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Pokemons.Electric;
using Pokedex.Models.Pokemons.Fire;
using Pokedex.Models.Pokemons.Normal;
using Pokedex.Models.Pokemons.Water;
using Pokedex.Models.Weathers;

namespace Pokedex
{
    class Program
    {
        static void Main(String[] args)
        {
            // Create our trainer
            Trainer student = new Trainer("Student");

            // Create our pokemons
            PokeInstance pikachu = new PokeInstance(Raichu.Instance, "Pika", 25, Gender.Male, 18);
            PokeInstance charizard = new PokeInstance(Charizard.Instance, "Draco", 85, Gender.Male, 500);
            PokeInstance squirtle = new PokeInstance(Squirtle.Instance, "carapuce", 8, Gender.Female);

            // Learn moves
            pikachu.LearnMove(ThunderPunch.Instance);
            pikachu.LearnMove(Headbutt.Instance);
            pikachu.LearnMove(Thunderbolt.Instance);
            charizard.LearnMove(Crunch.Instance);
            charizard.LearnMove(Overheat.Instance);
            charizard.LearnMove(Rage.Instance);
            squirtle.LearnMove(Tackle.Instance);
            squirtle.LearnMove(IceBeam.Instance);
            squirtle.LearnMove(Surf.Instance);

            // Add pokemons in our inventory
            student.AddPokemon(pikachu);
            student.AddPokemon(charizard);
            student.AddPokemon(squirtle);
            student.SetActivePokemon(squirtle);

            // Create the rival
            Trainer rival = new Trainer("Asshole");

            // Create rival's pokemons
            PokeInstance dieu = new PokeInstance(Arceus.Instance, "Dieu : La communauté", 100, Gender.Unknown, 10);
            PokeInstance gott = new PokeInstance(Arceus.Instance, "Dieu : Les deux tours", 100, Gender.Unknown, 10);
            PokeInstance 神様 = new PokeInstance(Arceus.Instance, "Dieu : Le retour", 100, Gender.Unknown, 10);

            // Learn moves
            dieu.LearnMove(Judgment.Instance);
            dieu.LearnMove(Headbutt.Instance);
            gott.LearnMove(Judgment.Instance);
            gott.LearnMove(Headbutt.Instance);
            神様.LearnMove(Judgment.Instance);
            神様.LearnMove(Headbutt.Instance);

            // Add pokemons to rival inventory
            rival.AddPokemon(dieu);
            rival.AddPokemon(gott);
            rival.AddPokemon(神様);
            rival.SetActivePokemon(rival.Pokemons[0]);
            rival.ActivePokemon!.LearnMove(Judgment.Instance,0);
            rival.ActivePokemon!.LearnMove(Thunder.Instance,1);
            rival.ActivePokemon!.LearnMove(Wrap.Instance,2);
            rival.ActivePokemon!.LearnMove(VoltSwitch.Instance,3);


            // Annouce the fight!
            Console.WriteLine($"{rival.Name} challenged {student.Name} to a Pokemon duel!");

            // Create the fight instance
            Fight octogon = new Fight(rival, student);

			// Enter the octogon
			Trainer winner = octogon.DoCombat();

            if (winner == null)
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine($"{winner.Name} won the fight!");
            }
        }
    }
}