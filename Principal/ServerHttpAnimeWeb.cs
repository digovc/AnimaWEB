using AnimeWeb.Html.Pagina;
using NetZ.Web.Server;

namespace AnimeWeb
{
    public sealed class ServerHttpAnimeWeb : ServerHttp
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static ServerHttpAnimeWeb _i;

        public static ServerHttpAnimeWeb i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new ServerHttpAnimeWeb();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private ServerHttpAnimeWeb() : base("Servidor HTTP da aplicação AnimeWeb")
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

            return new Resposta(objSolicitacao).addHtml(new PagPrincipalAnimeWeb());
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}