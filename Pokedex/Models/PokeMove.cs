// https://www.pokebip.com/pokedex/pokedex_5G_liste_des_attaques.html

using Pokedex.Enums;

namespace Pokedex.Models
{
    internal class PokeMove
    {
        #region  Variables
        private Int32 _accuracy;
        private Int32 _id;
        private Int32 _power;

        private String _descriptionEn;
        private String _descriptionFr;
        private String _nameEn;
        private String _nameFr;

        private DamageClass _damage;

        private PokeType _type;
        #endregion

        #region Getters & Setters
        /// <summary>
        /// Get Ability accuracy
        /// </summary>
        public Int32 Accuracy
        {
            get { return this._accuracy; }
        }

        /// <summary>
        /// Get Ability damage type
        /// </summary>
        public DamageClass Damage
        {
            get { return this._damage; }
        }

        /// <summary>
        /// Get Ability english description
        /// </summary>
        public String DescriptionEn
        {
            get { return this._descriptionEn; }
        }

        /// <summary>
        /// Get Ability french description
        /// </summary>
        public String DescriptionFr
        {
            get { return this._descriptionFr; }
        }

        /// <summary>
        /// Get Ability Id
        /// </summary>
        public Int32 Id
        {
            get { return this._id; }
        }

        /// <summary>
        /// Get Ability english name
        /// </summary>
        public String NameEn
        {
            get { return this._nameEn; }
        }

        /// <summary>
        /// Get Ability french name
        /// </summary>
        public String NameFr
        {
            get { return this._nameFr; }
        }

        /// <summary>
        /// Get Ability power
        /// </summary>
        public Int32 Power
        {
            get { return this._power; }
        }

        /// <summary>
        /// Get Ability Type
        /// </summary>
        public PokeType Type
        {
            get { return this._type; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="id">Ability id</param>
        /// <param name="nameEn">Ability english name</param>
        /// <param name="nameFr">Ability french name</param>
        /// <param name="power">Ability power</param>
        /// <param name="accuracy">Ability accuracy</param>
        /// <param name="damage">Ability move</param>
        /// <param name="type">Ability type</param>
        public PokeMove(Int32 id, String nameEn, String nameFr, String descriptionEn, String descriptionFr, Int32 power, Int32 accuracy, DamageClass damage, PokeType type)
        {
            this._accuracy = accuracy;
            this._damage = damage;
            this._descriptionEn = descriptionEn;
            this._descriptionFr = descriptionFr;
            this._id = id;
            this._nameEn = nameEn;
            this._nameFr = nameFr;
            this._power = power;
            this._type = type;
        }
        #endregion
    }
}
