using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Configuration;


namespace WebConsultaCep
{
    public partial class frmCadastro : System.Web.UI.Page
    {
        string diretorio = "";
        string nomefoto = "";
        Random rdm = new Random(1);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                urlamigavel UrlAmigavel = new urlamigavel();
              //  UrlAmigavel.AdicionarUrlAmigavel("Cadastro_de_clinte", "frmCadastro.aspx");
              //  hlkProduto.NavigateUrl = "~/Cadastro_de_clinte";
                UrlAmigavel = null;
            }

        }



        public void GravaRegistro()
        {

            if (FileFotoProduto.HasFile)
            {
                //usando o random : é preciso re-criar o mesmo dentro da chamada 
                rdm = new Random();
                diretorio = MapPath("~/Produtos/");
                //usando o Guid.NewGuid() é mais seguro pois este gera uma sequência difícil de se repetir
                nomefoto = Guid.NewGuid().ToString("D") + FileFotoProduto.FileName.Substring(FileFotoProduto.FileName.LastIndexOf("."), 4);
                // nomefoto = "produto" + rdm.Next(99999).ToString() + FileFotoProduto.FileName.Substring(FileFotoProduto.FileName.LastIndexOf("."), 4);
                FileFotoProduto.SaveAs(diretorio + nomefoto);
                listbox.Items.Add(nomefoto);
            }


        }

        public void GeraIntervalo()
        {

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            GravaRegistro();
            CalculaINSS(1000, 15);
        }


        static double CalculaINSS(double salario, double ValorInss)
        {
            return (salario * ValorInss / 100);
        }

        public double CalculaINSS2(double salario, double ValorInss)
        {
            return (salario * ValorInss / 100);
        }
        // usar static public


        public int Calculadora(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            return resultado;
        }


        int retornaA()
        {
            int a = 10;
            return a;
        }



        // soma 2 números
        int soma(int a, int b)
        {
            return a + b;
        }

        // soma 3 números
        int soma(int a, int b, int c)
        {
            return a + b + c;
        }

        // soma 4 números
        int soma(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }


        //Parâmetros nomeados
        int Somar(int x, int y)
        {
            return x + y;
        }


        //Parâmetros Opcionais
        static int SomarOp(int x, int y = 2)
        {
            return x + y;
        }


        private string MostraMensagem(string texto)
        {
            return "mensagem" + texto;
        }


        private string MostraMensagem(string texto, string titulo)
        {
            return texto + titulo;
        }


        public void AdicionarUrlAmigavel(string UrlAmigavel, String NomePagina)
        {
            UrlMapping urlMap = null;
            // Abre o Web.config
            Configuration config = WebConfigurationManager.OpenWebConfiguration("~");
            // Recupera a seção urlMappings, do web.config
            UrlMappingsSection urlMapSection = (UrlMappingsSection)config.GetSection("system.web/urlMappings");
            // Adiciona a URL Amigável a seção, que é salva no Web.Config
            urlMap = new UrlMapping("~/" + UrlAmigavel, NomePagina);
            urlMapSection.UrlMappings.Remove(urlMap);
            urlMapSection.UrlMappings.Add(urlMap);
            // Grava no web.config
            config.Save();
        }




    }
}