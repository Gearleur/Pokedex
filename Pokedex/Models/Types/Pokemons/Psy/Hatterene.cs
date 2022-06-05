// https://www.pokemon.com/us/pokedex/858

using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Hatterene : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Hatterene()); }
        }
        #endregion
        
        #region Constructors
        private Hatterene()
            : base(
                858,
                "Hatterene",
                "Sorcilence",
                TypePsy.Instance,
                TypeFairy.Instance,
                21,
                51,
                "Silent Pokémon",
                "Pokémon Silencieux",
                "If you’re too loud around it, you risk being torn apart by the claws on its tentacle. This Pokémon is also known as the Forest Witch.",
                "On l’appelle aussi la « sorcière de la forêt ». Ce Pokémon lacère quiconque fait trop de bruit avec les griffes de son tentacule.",
                57,
                90,
                95,
                136,
                103,
                29
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
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(MistyExplosion.Instance);
        }
        #endregion
    }
}