// https://www.pokemon.com/us/pokedex/503

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Samurott : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Samurott()); }
        }
        #endregion
        
        #region Constructors
        private Samurott()
            : base(
                503,
                "Samurott",
                "Clamiral",
                TypeWater.Instance,
                15,
                946,
                "Formidable Pokémon",
                "Pokémon Dignitaire",
                "One swing of the sword incorporated in its armor can fell an opponent. A simple glare from one of them quiets everybody.",
                "Il peut terrasser ses ennemis d’un coup de la lame enchâssée dans son armure, et les faire taire d’un seul regard.",
                95,
                100,
                85,
                108,
                70,
                70
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(Megahorn.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(HydroCannon.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(WaterPledge.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(RazorShell.Instance);
            this._moveList.Add(Liquidation.Instance);
        }
        #endregion
    }
}