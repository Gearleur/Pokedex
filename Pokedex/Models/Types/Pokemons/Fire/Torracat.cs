// https://www.pokemon.com/us/pokedex/726

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Torracat : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Torracat()); }
        }
        #endregion
        
        #region Constructors
        private Torracat()
            : base(
                726,
                "Torracat",
                "Matoufeu",
                TypeFire.Instance,
                7,
                250,
                "Fire Cat Pokémon",
                "Pokémon Chat Feu",
                "When facing a powerful enemy, Torracat’s fighting spirit gets pumped up, and its fire bell blazes hotter.",
                "Quand il fait face à un adversaire redoutable, il redouble de combativité et la puissance calorifère de sa clochette augmente.",
                65,
                85,
                50,
                80,
                50,
                90
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
            this._moveList.Add(PayDay.Instance);
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Lick.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(FirePledge.Instance);
            this._moveList.Add(DualChop.Instance);
        }
        #endregion
    }
}