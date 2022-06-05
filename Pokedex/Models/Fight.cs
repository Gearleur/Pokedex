using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Pokedex.Models.Weathers;
using Pokedex.Models.Events;

namespace Pokedex.Models
{
	/// <summary>
	/// Represents a Pokemon between two Trainers
	/// </summary>
	/// <see cref="Trainer"/>
    class Fight
    {
        #region Variables
        private Trainer _playerA;
        private Trainer _playerB;

        private Weather _weather;

        private int _turn;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// The first player
        /// </summary>
        public Trainer PlayerA
        { get { return this._playerA; } }
        
		/// <summary>
		/// The second player
		/// </summary>
		/// <value></value>
		public Trainer PlayerB
        { get { return this._playerB; } }

		/// <summary>
		/// The current weather effect active
		/// </summary>
        public Weather Weather
        {
            get { return this._weather; }
            set
			{ 
				this._weather.OnExit();
				this._weather = value;
				this._weather.OnEnter();
			}
        }

        /// <summary>
        /// get the number of turn
        /// </summary>
        public int Turn
        { get { return this._turn; } }
        #endregion

        #region Constructors
        /// <summary>
		/// The default constructor
		/// </summary>
		/// <param name="playerA">The first player</param>
		/// <param name="playerB">The second player</param>
		public Fight
        (
            Trainer playerA,
            Trainer playerB
        )
        {
            this._playerA = playerA;
            this._playerB = playerB;

            this._weather = WeatherClear.Instance;
        }
		
		/// <summary>
		/// Superseeds the default constructor with a Weather paramater
		/// </summary>
		/// <param name="weather"></param>
		/// <inheritdoc cref="Fight(Trainer, Trainer)"/>
		public Fight
		(
			Trainer playerA,
			Trainer playerB,
			Weather weather
		) : this(playerA, playerB)
		{
			this._weather = weather;
		}
        #endregion

        #region Methods
		/// <summary>
		/// Handles the general outline of a fight
		/// </summary>
		/// <returns>The winning player</returns>
        public Trainer DoCombat()
        {
            int turn = 1;

            _playerA.BeginFight();
            _playerB.BeginFight();

			// While both players can still fight
            while (this._playerA.CanFight
				   && this._playerB.CanFight)
            {
                this.DoTurn();

                turn++;
            }

            if (this._playerA.CanFight)
            {
                return this._playerA;
            }
            else if (this._playerB.CanFight)
            {
                return this._playerB;
            }
            return null!;
            
            /* cond ? if_true : if_false */
            
            /* if (this._playerA.CanFight)
             *     return this._playerA;
             * return this._playerB;
             */
        }

        public bool IsPokeChange(Trainer player)
        {
            return player.EventDo!.GetType() == typeof(EventChangePokemon);
        }

        public void ApplyDamage(Trainer player, Trainer opponent)
        {
            if (player.EventDo!.GetType() == typeof(EventMove))
            {
                EventMove eventDamage = (EventMove)player.EventDo;

                int damage = DamageHandler.CalcDamage(player.ActivePokemon!, opponent.ActivePokemon!, (player.EventDo as EventMove)!.Move, weather: this._weather);

                opponent.ActivePokemon!.TakeDamage(damage);
            }
        }

        public List<Trainer> OrderEvent(Trainer faster,Trainer slower)
        {
            //int speed = faster.ActivePokemon.Speed;
            if (faster.EventDo!.GetType() == typeof(EventChangePokemon))
            {
                return new List<Trainer>() { faster, slower };
            }
            else if (slower.EventDo!.GetType() == typeof(EventChangePokemon))
            {
                return new List<Trainer>() { slower, faster };
            }
            // else if (faster.ActivePokemon.Speed < slower.ActivePokemon.Speed)
            // {
            //     return new List<Trainer>() { faster, slower };
            // }
            // else if (faster.ActivePokemon.Speed > slower.ActivePokemon.Speed)
            // {
            //     return new List<Trainer>() { slower, faster };
            // }
            else
            {
                return new List<Trainer>() { faster, slower };
            }
        }

        public void TakeChoice(Trainer player)
        {
            int choice;
            Console.WriteLine("Choose an Action:");
            while (int.TryParse(Console.ReadLine(), out choice) is false
                    || choice is < 1 or > 5)
                    Console.WriteLine("Invalid input");
                Console.WriteLine();
            
            if ( choice >= 1 && choice <= 4)
            {
                player.SelectMove(choice);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Choose a Pokemon:");
                player.SelectPokemon();
                
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

		/// <summary>
		/// Handles the finer workings of a singular turn
		/// </summary>
		/// <see cref="DamageHandler.CalcDamage(PokeInstance, PokeInstance, PokeMove, Weather)"/>
		/// <see cref="Trainer.CanFight"/>
		/// <see cref="PokeInstance.TakeDamage(int)"/>
		/// <see cref="Fight.Weather"/>
        private void DoTurn()
        {
			this._weather.OnTurnStart(this);

            // Code to implement for project
            // To calc damage, use DamageHandler.CalcDamage(attacker, defender, move, this._weather);
            // To apply damage, use pokemonInstance.TakeDamage(damage)
            // To get trainer pokemons, use trainer.Pokemons
            // To check if a trainer has at least on pokemon fit for combat, use trainer.CanFight

            // You can simulate each trainer turn, or develop a simple AI to simulate the second trainer's turn
            // (simple means not like Arthur, okay ?)

            // Change the weather:
            // this.Weather = newWeather.Instance;
            _turn++;
            showfight();

            showInterface(_playerA);
            if (this._playerA.ActivePokemon!.IsKo)
            {
                _playerA.SelectPokemon();
            }
            else
            {
                TakeChoice(_playerA);
            }


            showInterface(_playerB);
            if (this._playerB.ActivePokemon!.IsKo)
            {
                _playerB.SelectPokemon();
            }
            else
            {
                TakeChoice(_playerB);
            }

            List<Trainer> order = OrderEvent(_playerA, _playerB);
            if (!IsPokeChange(order[0]))
            {
                ApplyDamage(order[0], order[1]);
            }
            if (!IsPokeChange(order[1]))
            {
                ApplyDamage(order[1], order[0]);
            }

            Console.Clear();
            //
            
            this._weather.OnTurnEnd(this);
        }

        #endregion
        #region Showdown
        public void HealthBar(PokeInstance pokemon)
        {
            // TODO
            int dashConvert = (int)(pokemon.Pokemon.StatHp / 20);
            int currentDash = (int)(pokemon.Hp / dashConvert);
            int remainingDash = 20 - currentDash;

            string healthDisplay = "";
            for (int i = 0; i < currentDash; i++)
            {
                healthDisplay += "-";
            }
            string RemainingHealth = "";
            for (int i = 0; i < remainingDash; i++)
            {
                RemainingHealth += " ";
            }
            Console.Write($"|{healthDisplay}{RemainingHealth}|");
        }


        public void showfight()
        {
            int legnthA = this._playerA.ActivePokemon!.Nickname.Length + this._playerA.ActivePokemon.Level.ToString().Length;
            int legnthB = this._playerB.ActivePokemon!.Nickname.Length + this._playerB.ActivePokemon.Level.ToString().Length;
            string spaceA = "";
            string spaceB = "";
            for (int i = 0; i < (35 - legnthA); i++)
            {
                spaceA += " ";
            }
            for (int i = 0; i < (35 - legnthB); i++)
            {
                spaceB += " ";
            }
            Console.WriteLine($"{this._playerA.Name} vs {this._playerB.Name}");
            Console.WriteLine($"Turn: {_turn}");
            Console.WriteLine();
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"|{this._playerB.ActivePokemon.Nickname}{spaceB}{this._playerB.ActivePokemon.Level}| HP: {this._playerB.ActivePokemon.Hp}/{this._playerB.ActivePokemon.Pokemon.StatHp}");
            Console.Write($"| HP: ");
            HealthBar(this._playerB.ActivePokemon);
            Console.WriteLine($"        |");
            Console.WriteLine($"------------------------------------");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"                                  ------------------------------------");
            Console.WriteLine($"                                  |{this._playerA.ActivePokemon.Nickname}{spaceA}{this._playerA.ActivePokemon.Level}| HP: {this._playerA.ActivePokemon.Hp}/{this._playerA.ActivePokemon.Pokemon.StatHp}");
            Console.Write($"                                  | HP: ");
            HealthBar(this._playerA.ActivePokemon);
            Console.WriteLine($"        |");
            Console.WriteLine($"                                  ------------------------------------");
        }

        public void showInterface1(Trainer player)
        {
            int nb = player.Pokemons.Count;
            int[] lenghtA = new int[nb];
            string[] spaceA = new string[nb];
            for (int i = 0; i < nb; i++)
            {
                lenghtA[i] = player.ActivePokemon!.Moves[i]!.NameFr.Length;
                for (int j = 0; j < (30 - lenghtA[i]); j++)
                {
                    spaceA[i] += " ";
                }
            }
            Console.WriteLine("-------------------------------------------------------------");
            if (nb == 1)
            {Console.Write($"|{this._playerA.ActivePokemon!.Moves[0]!.NameEn}{spaceA[0]}|                             ");}
            if (nb == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write($"|{this._playerA.ActivePokemon!.Moves[i]!.NameEn}{spaceA[i]}|");
                }
                Console.WriteLine("-------------------------------------------------------------");
            }
            else if (nb == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write($"|{this._playerA.ActivePokemon!.Moves[i]!.NameEn}{spaceA[i]}|");
                }
                Console.WriteLine("-------------------------------------------------------------");
                Console.Write($"|{this._playerA.ActivePokemon!.Moves[2]!.NameEn}{spaceA[2]}|                            ");
                Console.WriteLine("-------------------------------------------------------------");
            }
            else if (nb == 4)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write($"|{this._playerA.ActivePokemon!.Moves[i]!.NameEn}{spaceA[i]}|");
                }
                Console.WriteLine("-------------------------------------------------------------");
                for (int i = 2; i < 4; i++)
                {
                    Console.Write($"|{this._playerA.ActivePokemon!.Moves[i]!.NameEn}{spaceA[i]}|");
                }
                Console.WriteLine("-------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------------");
            }
        }

        public void showInterface(Trainer player)
        {
            for (int i = 0; player.ActivePokemon!.Moves[i] is not null; i++)
            {
                Console.Write($"\t{i + 1}/ {player.ActivePokemon.Moves[i]!.NameFr}");
            }
        }   
        #endregion
    }
}