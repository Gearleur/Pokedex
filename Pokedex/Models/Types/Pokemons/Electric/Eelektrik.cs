// https://www.pokemon.com/us/pokedex/603

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Eelektrik : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Eelektrik()); }
        }
        #endregion
        
        #region Constructors
        private Eelektrik()
            : base(
                603,
                "Eelektrik",
                "Lampéroie",
                TypeElectric.Instance,
                12,
                220,
                "EleFish Pokémon",
                "Pokémon Électrophore",
                "These Pokémon have a big appetite. When they spot their prey, they attack it and paralyze it with electricity.",
                "Un Pokémon doté d’un gros appétit. Il paralyse ses proies avec des décharges électriques avant de les manger.",
                65,
                85,
                70,
                75,
                70,
                40
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(Acid.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(AcidSpray.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(ThroatChop.Instance);
        }
        #endregion
    }
}