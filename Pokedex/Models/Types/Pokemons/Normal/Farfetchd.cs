// https://www.pokemon.com/us/pokedex/83

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Farfetchd : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Farfetchd()); }
        }
        #endregion
        
        #region Constructors
        private Farfetchd()
            : base(
                83,
                "Farfetch’d",
                "Canarticho",
                TypeNormal.Instance,
                TypeFlying.Instance,
                8,
                150,
                "Wild Duck Pokémon",
                "Pokémon Canard Fou",
                "They use a plant stalk as a weapon, but not all of them use it in the same way. Several distinct styles of stalk fighting have been observed.",
                "Il se bat à l’aide de sa tige. Il existe plusieurs écoles quant à son maniement.",
                52,
                90,
                55,
                58,
                62,
                60
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
            this._moveList.Add(RazorWind.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Gust.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(BraveBird.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(FirstImpression.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}