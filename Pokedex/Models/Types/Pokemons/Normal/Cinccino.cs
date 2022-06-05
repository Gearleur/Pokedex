// https://www.pokemon.com/us/pokedex/573

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Cinccino : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Cinccino()); }
        }
        #endregion
        
        #region Constructors
        private Cinccino()
            : base(
                573,
                "Cinccino",
                "Pashmilla",
                TypeNormal.Instance,
                5,
                75,
                "Scarf Pokémon",
                "Pokémon Écharpe",
                "A special oil that seeps through their fur helps them avoid attacks. The oil fetches a high price at market.",
                "La sécrétion huileuse de ses poils lui permet de dévier les attaques. Elle s’arrache à prix d’or sur les marchés.",
                75,
                95,
                60,
                65,
                60,
                115
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
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(TailSlap.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(TripleAxel.Instance);
        }
        #endregion
    }
}