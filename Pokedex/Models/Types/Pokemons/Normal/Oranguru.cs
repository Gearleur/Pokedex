// https://www.pokemon.com/us/pokedex/765

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Oranguru : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Oranguru()); }
        }
        #endregion
        
        #region Constructors
        private Oranguru()
            : base(
                765,
                "Oranguru",
                "Gouroutan",
                TypeNormal.Instance,
                TypePsy.Instance,
                15,
                760,
                "Sage Pokémon",
                "Pokémon Grand Sage",
                "It knows the forest inside and out. If it comes across a wounded Pokémon, Oranguru will gather medicinal herbs to treat it.",
                "Il connaît la forêt sur le bout des doigts. Lorsqu’il trouve un Pokémon blessé, il cherche des plantes médicinales pour le soigner.",
                90,
                60,
                80,
                90,
                110,
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(Extrasensory.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(TerrainPulse.Instance);
        }
        #endregion
    }
}