using System;
using System.Collections.Generic;
using NetZ.Web;
using NetZ.Web.Server;

namespace AnimeWeb
{
    public sealed class AppAnimeWeb : AppWeb
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static AppAnimeWeb _i;

        public new static AppAnimeWeb i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new AppAnimeWeb();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private AppAnimeWeb() : base("AnimeWeb")
        {
        }

        #endregion Construtores

        #region Métodos

        protected override ConfigWeb getObjConfig()
        {
            return ConfigAnimeWeb.i;
        }

        protected override void inicializarLstSrv(List<ServerBase> lstSrv)
        {
            lstSrv.Add(ServerHttpAnimeWeb.i);
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}