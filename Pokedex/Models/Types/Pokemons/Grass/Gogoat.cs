// https://www.pokemon.com/us/pokedex/673

using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Gogoat : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Gogoat()); }
        }
        #endregion
        
        #region Constructors
        private Gogoat()
            : base(
                673,
                "Gogoat",
                "Chevroum",
                TypeGrass.Instance,
                17,
                910,
                "Mount Pokémon",
                "Pokémon Monture",
                "They inhabit mountainous regions. The leader of the herd is decided by a battle of clashing horns.",
                "Ce Pokémon vit dans les régions montagneuses. Le chef du troupeau s’impose à l’issue d’un combat de cornes.",
                123,
                100,
                62,
                97,
                81,
                68
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
            this._moveList.Add(VineWhip.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(HornLeech.Instance);
            this._moveList.Add(StompingTantrum.Instance);
        }
        #endregion
    }
}