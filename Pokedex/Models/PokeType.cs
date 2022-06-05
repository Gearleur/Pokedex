// https://www.pokemon.com/us/pokedex/

using System.Diagnostics.CodeAnalysis;

namespace Pokedex.Models
{
    internal abstract class PokeType
    {
        #region Variables
        private String _color;
        private String _nameEn;
        private String _nameFr;
        protected Dictionary<PokeType, double>? _typeAffinities;
        #endregion

        #region Getters & Setters
        /// <summary>
        /// Get Type color
        /// </summary>
        public String Color
        {
            get { return _color; }
        }

        /// <summary>
        /// Type's name (french and english)
        /// </summary>
        public String Name
        {
            get { return String.Format("{0} ({1})", this._nameFr, this._nameEn); }
        }

        /// <summary>
        /// Type's english name
        /// </summary>
        public String NameEn
        {
            get { return _nameEn; }
        }

        /// <summary>
        /// Type's french name
        /// </summary>
        public String NameFr
        {
            get { return _nameFr; }
        }

        /// <summary>
        /// Type's affinities with other types
        /// </summary>
        public Dictionary<PokeType, double> TypeAffinities
        {
            get
            {
                // If the dictionary is not yet initialized
                if (this._typeAffinities == null)
                    // Initialize it as defined in the child class
                    this.InitTypeAffinities();

                return this._typeAffinities;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="nameEn">Type english name</param>
        /// <param name="nameFr">Type french name</param>
        /// <param name="color">Type color in hexa</param>
        public PokeType(
            String nameEn,
            String nameFr,
            String color
        )
        {
            this._color = color;
            this._nameEn = nameEn;
            this._nameFr = nameFr;
            this._typeAffinities = null;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the damage multiplier of the attacking type unto this type
        /// </summary>
        /// <param name="attacker">The attacking type</param>
        /// <returns>Damage multiplier as a double</returns>
        public double GetAffinity(PokeType attacker)
        {
            return this.TypeAffinities.GetValueOrDefault(attacker, 1);

            /* Equivalent to:
			 * if (this.Affinities.ContainsKey(attacker))
             *     return this.Affinities[attacker];
             * else
             *     return 1;
			 */
        }

        /// <summary>
        /// Initializes the _typeAffinities field
        /// </summary>
		/// <paramref name="_typeAffinities"/>	
		/// <remarks>Abstract</remarks>
        [MemberNotNull(nameof(_typeAffinities))]
        protected abstract void InitTypeAffinities();
        #endregion
    }
}
