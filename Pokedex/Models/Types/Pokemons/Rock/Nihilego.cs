// https://www.pokemon.com/us/pokedex/793

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Nihilego : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Nihilego()); }
        }
        #endregion
        
        #region Constructors
        private Nihilego()
            : base(
                793,
                "Nihilego",
                "Zéroïd",
                TypeRock.Instance,
                TypePoison.Instance,
                12,
                555,
                "Parasite Pokémon",
                "Pokémon Parasite",
                "It appeared in this world from an Ultra Wormhole. Nihilego appears to be a parasite that lives by feeding on people and Pokémon.",
                "Il est venu dans ce monde à travers une Ultra-Brèche. Tel un parasite, il aurait besoin d’un hôte, Pokémon ou humain, pour survivre.",
                109,
                53,
                47,
                127,
                131,
                103
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Wrap.Instance);
            this._moveList.Add(Acid.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Constrict.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(PowerGem.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(HeadSmash.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(AcidSpray.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(MeteorBeam.Instance);
        }
        #endregion
    }
}