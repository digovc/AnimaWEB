using System.Collections.Generic;
using NetZ.Web;
using NetZ.Web.Server;

namespace AnimaWeb
{
    public sealed class AppAw : AppWeb
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static AppAw _i;

        public new static AppAw i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new AppAw();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private AppAw() : base("AnimeWeb")
        {
        }

        #endregion Construtores

        #region Métodos

        protected override ConfigWeb getObjConfig()
        {
            return ConfigAw.i;
        }

        protected override void inicializarLstSrv(List<ServerBase> lstSrv)
        {
            lstSrv.Add(ServerHttpAw.i);
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}