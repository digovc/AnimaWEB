using AnimaWeb.Html.Componente;
using NetZ.Web.Html.Pagina;

namespace AnimaWeb.Html.Pagina
{
    public sealed class PagPrincipalAw : PagPrincipal
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private DivMenuPrincipal _divMenuPrincipal;

        private DivMenuPrincipal divMenuPrincipal
        {
            get
            {
                if (_divMenuPrincipal != null)
                {
                    return _divMenuPrincipal;
                }

                _divMenuPrincipal = new DivMenuPrincipal();

                return _divMenuPrincipal;
            }
        }

        #endregion Atributos

        #region Construtores

        public PagPrincipalAw() : base("Principal")
        {
        }

        #endregion Construtores

        #region Métodos

        protected override void montarLayout()
        {
            base.montarLayout();

            this.divMenuPrincipal.setPai(this);
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}