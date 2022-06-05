// https://www.pokemon.com/us/pokedex/843

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ground
{
    internal class Silicobra : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Silicobra()); }
        }
        #endregion
        
        #region Constructors
        private Silicobra()
            : base(
                843,
                "Silicobra",
                "Dunaja",
                TypeGround.Instance,
                22,
                76,
                "Sand Snake Pokémon",
                "Pokémon Serpensable",
                "It spews sand from its nostrils. While the enemy is blinded, it burrows into the ground to hide.",
                "En expulsant du sable par les narines, il aveugle son adversaire et en profite pour se cacher sous terre.",
                52,
                57,
                75,
                35,
                50,
                46
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
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Wrap.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(PoisonTail.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(DragonRush.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DrillRun.Instance);
            this._moveList.Add(Belch.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(SkitterSmack.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}