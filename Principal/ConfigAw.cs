using NetZ.Web;

namespace AnimaWeb
{
    public sealed class ConfigAw : ConfigWeb
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static ConfigAw _i;

        public new static ConfigAw i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new ConfigAw();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private ConfigAw()
        {
        }

        #endregion Construtores

        #region Métodos

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}