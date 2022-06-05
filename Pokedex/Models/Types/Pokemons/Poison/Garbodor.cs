// https://www.pokemon.com/us/pokedex/569

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Poison
{
    internal class Garbodor : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Garbodor()); }
        }
        #endregion
        
        #region Constructors
        private Garbodor()
            : base(
                569,
                "Garbodor",
                "Miasmax",
                TypePoison.Instance,
                19,
                1073,
                "Trash Heap Pokémon",
                "Pokémon Dépotoir",
                "The toxic liquid it launches from its right arm is so virulent that it can kill a weakened creature instantly.",
                "Le liquide qu’il projette de son bras droit est si toxique que si une créature fragile en est aspergée, elle succombe sur-le-champ.",
                80,
                95,
                82,
                60,
                82,
                75
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
            this._moveList.Add(Pound.Instance);
            this._moveList.Add(DoubleSlap.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Sludge.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(MetalClaw.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(AcidSpray.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Belch.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BodyPress.Instance);
        }
        #endregion
    }
}