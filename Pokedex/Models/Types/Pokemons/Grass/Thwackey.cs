// https://www.pokemon.com/us/pokedex/811

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Thwackey : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Thwackey()); }
        }
        #endregion
        
        #region Constructors
        private Thwackey()
            : base(
                811,
                "Thwackey",
                "Badabouin",
                TypeGrass.Instance,
                7,
                140,
                "Beat Pokémon",
                "Pokémon Percussions",
                "When it’s drumming out rapid beats in battle, it gets so caught up in the rhythm that it won’t even notice that it’s already knocked out its opponent.",
                "Il est tellement concentré à battre à un rythme effréné que même lorsque son adversaire tombe K.O., il ne s’en rend pas compte.",
                70,
                85,
                70,
                55,
                60,
                80
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(WoodHammer.Instance);
            this._moveList.Add(DoubleHit.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(GrassPledge.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(BranchPoke.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}