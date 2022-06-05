// https://www.pokemon.com/us/pokedex/495

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Snivy : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Snivy()); }
        }
        #endregion
        
        #region Constructors
        private Snivy()
            : base(
                495,
                "Snivy",
                "Vipélierre",
                TypeGrass.Instance,
                6,
                81,
                "Grass Snake Pokémon",
                "Pokémon Serpenterbe",
                "They photosynthesize by bathing their tails in sunlight. When they are not feeling well, their tails droop.",
                "Il laisse sa queue prendre le soleil pour sa photosynthèse. Quand il est malade, sa queue pend tristement.",
                45,
                45,
                55,
                45,
                55,
                63
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(VineWhip.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Wrap.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(GrassPledge.Instance);
            this._moveList.Add(LeafTornado.Instance);
        }
        #endregion
    }
}