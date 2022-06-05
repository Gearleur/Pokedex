// https://www.pokemon.com/us/pokedex/833

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Chewtle : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Chewtle()); }
        }
        #endregion
        
        #region Constructors
        private Chewtle()
            : base(
                833,
                "Chewtle",
                "Khélocrok",
                TypeWater.Instance,
                3,
                85,
                "Snapping Pokémon",
                "Pokémon Mordillage",
                "It starts off battles by attacking with its rock-hard horn, but as soon as the opponent flinches, this Pokémon bites down and never lets go.",
                "La corne sur sa tête est aussi dure que la roche. Il s’en sert pour se battre et lorsque l’ennemi flanche, il le mord et ne le lâche plus.",
                50,
                64,
                50,
                38,
                38,
                44
            )
        { }
        #endregion

        #region Methods
        /// <summary>
        /// Implementation of the parent method
        /// </summary>
        /// <seealso cref="Pokemon.InitMoveList"/>
        public override void InitMoveList()
        {
            this._moveList = new List<PokeMove>();
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(JawLock.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(SkitterSmack.Instance);
        }
        #endregion
    }
}