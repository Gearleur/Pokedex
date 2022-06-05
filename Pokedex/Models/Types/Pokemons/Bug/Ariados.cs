// https://www.pokemon.com/us/pokedex/168

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Ariados : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Ariados()); }
        }
        #endregion
        
        #region Constructors
        private Ariados()
            : base(
                168,
                "Ariados",
                "Migalos",
                TypeBug.Instance,
                TypePoison.Instance,
                11,
                335,
                "Long Leg Pokémon",
                "Pokémon Long-Patte",
                "It spews threads from its mouth to catch its prey. When night falls, it leaves its web to go hunt aggressively.",
                "Il capture ses proies en projetant un fil qu’il sécrète. À la nuit tombée, il quitte sa toile et part chasser activement.",
                70,
                90,
                70,
                60,
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
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Constrict.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowSneak.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(FellStinger.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(StompingTantrum.Instance);
        }
        #endregion
    }
}