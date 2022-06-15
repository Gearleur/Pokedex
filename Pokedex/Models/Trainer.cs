using Pokedex.Models.Events;

namespace Pokedex.Models
{
    internal class Trainer
    {
        #region Variables
        private String _name;
        private List<PokeInstance> _pokemons;

        private PokeInstance? _activePokemon; 

        private Event? _event;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// Trainer's has at least one pokemon not KO
        /// </summary>
        public bool CanFight
        {
            get
            {
                bool canFight = false;
                foreach (PokeInstance pokemon in this._pokemons)
                {
                    if (!pokemon.IsKo)
                        canFight = true;
                }
                return canFight;

                // Same query with LINQ
                /* return this._pokemons
                 *     .Any(pokemon => !pokemon.IsKo);
				 */
            }
        }

        /// <summary>
        /// Trainer's name
        /// </summary>
        public String Name
        {
            get { return this._name; }
        }

        /// <summary>
        /// Trainer's Pokemon
        /// </summary>
        public List<PokeInstance> Pokemons
        {
            get { return this._pokemons; }
        }

        public PokeInstance? ActivePokemon
        {
            get { return this._activePokemon; }
            set { this._activePokemon = value; }
        }

        public Event? EventDo
        {
            get { return this._event; }
            set { this._event = value; }
        }


        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Trainer's name</param>
        public Trainer(
            String name
        )
        {
            this._name = name;

            // Init pokemon list
            this._pokemons = new List<PokeInstance>();
            this._activePokemon = _pokemons.FirstOrDefault();
            this._event = null;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add pokemon to inventory
        /// </summary>
        /// <param name="pokemon">Pokemon to add</param>
        /// <returns>True if okay, otherwise false</returns>
        public bool AddPokemon(PokeInstance pokemon)
        {
            // If there are less than 6 pokemons, it's possible to add one more
            if (this._pokemons.Count < 6)
            {
                this._pokemons.Add(pokemon);

                return true;
            }
            return false;
        }

        public void RemovePokemon(PokeInstance pokemon)
        {
            this._pokemons.Remove(pokemon);
        }

        public void SetActivePokemon(PokeInstance pokemon)
        {
            this._activePokemon = pokemon;
        }

        public void SetActivePokemon(int index)
        {
            this._activePokemon = this._pokemons[index];
        }

        public void showPokemonActive()
        {
            if (this._activePokemon != null)
            {
                Console.WriteLine($"{this._activePokemon.Nickname}");
                for (int i = 0; _activePokemon.Moves[i] is not null; i++)
                {
                        Console.WriteLine($"{this._activePokemon.Moves[i]!.NameFr}");
                }
            }
            else
            {
                Console.WriteLine("No active pokemon");
            }
        }

        public void showPokemonInventory()
        {
            foreach (PokeInstance pokemon in this._pokemons)
            {
                Console.WriteLine($"----------------------------------------");
                Console.WriteLine($"|{pokemon.Pokemon.Id}{"".PadRight(38 - pokemon.Pokemon.Id.ToString().Length)}|");
                Console.WriteLine($"|{pokemon.Pokemon.NameFr}: {pokemon.Nickname}{"".PadRight(36 - pokemon.Pokemon.NameFr.Length - pokemon.Nickname.Length)}|");
                Console.WriteLine($"|HP: {pokemon.CalcHp()}{"".PadRight(34-pokemon.CalcHp().ToString().Length)}|");
                Console.WriteLine($"----------------------------------------");
                Console.WriteLine();
            }
        }

        public void showPokemonInventory(int index)
        {
            Console.WriteLine($"{this._pokemons[index].Nickname}");
        }

        public void BeginFight()
        {
            if (this._activePokemon == null)
            {
                this._activePokemon = this._pokemons.FirstOrDefault();
            }
        }

        public void EndFight()
        {
            this._activePokemon = null;
        }

        public void SelectMove(int index)
        {
            int choice = index;
            while (choice < 1 || choice > this.ActivePokemon!.Moves.Length)
            {
                Console.WriteLine("Invalid move index");
                Console.WriteLine("Please enter a valid move index");
                choice = int.Parse(Console.ReadLine()!);
            }
            this._event = new EventMove(this.ActivePokemon!, this.ActivePokemon!.Moves[choice - 1]!);          
        }

        public void SelectPokemon()
        {
            Console.WriteLine();
            showPokemonInventory();
            int choice = int.Parse(Console.ReadLine()!);
            while (choice < 1 || choice > this.Pokemons.Count || this.Pokemons[choice - 1].IsKo)
            {
                Console.WriteLine("Invalid pokemon index");
                Console.WriteLine("Please enter a valid pokemon index");
                choice = int.Parse(Console.ReadLine()!);
            }
            this._event = new EventChangePokemon(this, this.Pokemons[choice - 1]);
            this.ActivePokemon = this.Pokemons[choice - 1];
        }
        #endregion
    }
}
