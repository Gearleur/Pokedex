// https://www.pokemon.com/us/pokedex/647

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class KeldeoOrdinary : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new KeldeoOrdinary()); }
        }
        #endregion
        
        #region Constructors
        private KeldeoOrdinary()
            : base(
                647,
                "Keldeo",
                "Keldeo",
                TypeWater.Instance,
                TypeFighting.Instance,
                14,
                485,
                "Colt Pokémon",
                "Pokémon Poulain",
                "They say that Keldeo must survive harsh battles and fully develop the horn on its forehead before this Pokémon’s true power will awaken.",
                "Lorsqu’il livre un combat difficile, la corne sur son front se renforce et se développe, ce qui éveillerait sa véritable puissance.",
                91,
                72,
                90,
                129,
                90,
                108
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
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(Megahorn.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(SacredSword.Instance);
            this._moveList.Add(SecretSword.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(FlipTurn.Instance);
        }
        #endregion
    }
}