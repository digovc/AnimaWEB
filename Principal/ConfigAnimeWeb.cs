using NetZ.Web;

namespace AnimeWeb
{
    public sealed class ConfigAnimeWeb : ConfigWeb
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static ConfigAnimeWeb _i;

        public new static ConfigAnimeWeb i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new ConfigAnimeWeb();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private ConfigAnimeWeb()
        {
        }

        #endregion Construtores

        #region Métodos

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}