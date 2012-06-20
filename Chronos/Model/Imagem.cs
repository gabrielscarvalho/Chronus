using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace Chronos.Model
{
    public class Imagem
    {
        public string insert(FileUpload uploadImagem, Label saida, string caminho)
        {
            string teste = "";
            //Verifica se arquivo selecionado é um arquivo válido
            if (uploadImagem.HasFile)
            {

                //Verifica tamanho do arquivo
                if (uploadImagem.PostedFile.ContentLength > 4000000)
                {
                    saida.Text = "Limite excedido! Selecione Imagem Menor";
                }
                else
                {
                    //Verifica Extensao do arquivo
                    string verifica = Path.GetExtension(uploadImagem.FileName);
                    if (verifica == ".jpg" || verifica == ".bmp" || verifica == ".png" || verifica == ".gif")
                    {
                        try
                        {
                            //Salva Arquivo de forma criptografada
                            uploadImagem.SaveAs(HttpContext.Current.Server.MapPath(caminho) + md5_encriptar(uploadImagem.FileName) + Path.GetExtension(uploadImagem.FileName));
                            HttpContext.Current.Response.Redirect(HttpContext.Current.Request.RawUrl);

                            teste = HttpContext.Current.Server.MapPath(caminho) + md5_encriptar(uploadImagem.FileName) + Path.GetExtension(uploadImagem.FileName) + Path.GetExtension(uploadImagem.FileName);


                        }
                        catch (Exception ex)
                        {
                            saida.Text = "Erro: " + ex.Message.ToString();
                        }
                    }
                    else
                    {
                        saida.Text = "Extensão não suportada! Somente imagens jpg, bmp, png ou gif";
                    }
                }
            }
            else
            {
                saida.Text = "Você deve escolher um arquivo para o upload.";
            }

            return teste;

        }

        public string md5_encriptar(string md5)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(md5);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string password = s.ToString();
            return password;
        }
    }
}