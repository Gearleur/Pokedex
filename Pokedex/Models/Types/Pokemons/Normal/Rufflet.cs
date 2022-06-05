// https://www.pokemon.com/us/pokedex/627

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Rufflet : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Rufflet()); }
        }
        #endregion
        
        #region Constructors
        private Rufflet()
            : base(
                627,
                "Rufflet",
                "Furaiglon",
                TypeNormal.Instance,
                TypeFlying.Instance,
                5,
                105,
                "Eaglet Pokémon",
                "Pokémon Aiglon",
                "A combative Pokémon, it’s ready to pick a fight with anyone. It has talons that can crush hard berries.",
                "Sa poigne est telle qu’il peut réduire en miettes les plus dures des Baies. Belliqueux de nature, il n’hésite pas à défier tout le monde.",
                70,
                83,
                50,
                37,
                50,
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(WingAttack.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(CrushClaw.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(BraveBird.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(SkyDrop.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}