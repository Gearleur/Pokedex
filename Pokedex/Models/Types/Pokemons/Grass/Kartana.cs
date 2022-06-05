// https://www.pokemon.com/us/pokedex/798

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Kartana : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Kartana()); }
        }
        #endregion
        
        #region Constructors
        private Kartana()
            : base(
                798,
                "Kartana",
                "Katagami",
                TypeGrass.Instance,
                TypeSteel.Instance,
                3,
                1,
                "Drawn Sword Pokémon",
                "Pokémon Battô",
                "Although it’s alien to this world and a danger here, it’s apparently a common organism in the world where it normally lives.",
                "Cette créature venue d’ailleurs est dangereuse dans notre monde, mais il semblerait qu’elle soit très commune dans le sien.",
                59,
                181,
                131,
                59,
                31,
                109
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
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(VacuumWave.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(SacredSword.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(SteelBeam.Instance);
        }
        #endregion
    }
}