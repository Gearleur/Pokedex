// https://www.pokemon.com/us/pokedex/69

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Bellsprout : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Bellsprout()); }
        }
        #endregion
        
        #region Constructors
        private Bellsprout()
            : base(
                69,
                "Bellsprout",
                "Chétiflor",
                TypeGrass.Instance,
                TypePoison.Instance,
                7,
                40,
                "Flower Pokémon",
                "Pokémon Fleur",
                "Prefers hot and humid places. It ensnares tiny bugs with its vines and devours them.",
                "Il préfère les endroits chauds et humides. Il capture les Pokémon Insecte avec ses lianes pour les dévorer.",
                50,
                75,
                35,
                70,
                30,
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(VineWhip.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Wrap.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Acid.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(AcidSpray.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Belch.Instance);
            this._moveList.Add(Infestation.Instance);
        }
        #endregion
    }
}