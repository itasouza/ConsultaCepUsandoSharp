using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text;
using System.IO;
using System.Xml.Linq;

namespace WebConsultaCep
{
    public partial class frmConsultaCep : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            string cep = txtCep.Text;
            string chave = "mmmmmmmmmmm";

            HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create(
                string.Format("http://www.devmedia.com.br/devware/cep/service/?cep={0}&chave={1}", cep, chave));
            HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();
           
            int cont;
            byte[] buffer = new byte[1000];
            StringBuilder sb = new StringBuilder();
            string temp;

            Stream stream = resposta.GetResponseStream();
           
            do
            {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);

            } while (cont > 0);

            XDocument xml = XDocument.Parse(sb.ToString());

            if (xml.Element("webservicecep").Element("resultado_txt").Value.Equals("Sucesso"))
            {
                txtBairro.Text = xml.Element("webservicecep").Element("bairro").Value;
                txtCidade.Text = xml.Element("webservicecep").Element("cidade").Value;
                txtLogradouro.Text = xml.Element("webservicecep").Element("logradouro").Value;
                txtEstado.Text = xml.Element("webservicecep").Element("uf").Value;
            }
            else
            {
               // MessageBox.Show(xml.Element("webservicecep").Element("resultado_txt").Value);

            }

        }
    }
}