// https://www.pokemon.com/us/pokedex/611

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dragon
{
    internal class Fraxure : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Fraxure()); }
        }
        #endregion
        
        #region Constructors
        private Fraxure()
            : base(
                611,
                "Fraxure",
                "Incisache",
                TypeDragon.Instance,
                10,
                360,
                "Axe Jaw Pokémon",
                "Pokémon Hachomenton",
                "Its skin is as hard as a suit of armor. Fraxure’s favorite strategy is to tackle its opponents, stabbing them with its tusks at the same time.",
                "Son épiderme est dur comme une armure. Il est passé maître dans l’art de charger l’ennemi tout en le transperçant de ses crocs.",
                66,
                117,
                70,
                40,
                50,
                67
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
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BreakingSwipe.Instance);
            this._moveList.Add(ScaleShot.Instance);
        }
        #endregion
    }
}