using AnimaWeb.Html.Pagina;
using NetZ.Web.Server;

namespace AnimaWeb
{
    public sealed class ServerHttpAw : ServerHttp
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static ServerHttpAw _i;

        public static ServerHttpAw i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new ServerHttpAw();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private ServerHttpAw() : base("Servidor HTTP da aplicação AnimeWeb")
        {
        }

        #endregion Construtores

        #region Métodos

        public override Resposta responder(Solicitacao objSolicitacao)
        {
            Resposta objResposta = base.responder(objSolicitacao);

            if (objResposta != null)
            {
                return objResposta;
            }

            return new Resposta(objSolicitacao).addHtml(new PagPrincipalAw());
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}