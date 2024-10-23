using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aula09.Ativ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"c:\windows\web\wallpaper", "*.jpg", SearchOption.AllDirectories);
            imagemListBox1.Items.AddRange(arquivos);

            //Ler do arquivo favoritos
            string path = ObterNomeArquivoConfiguracao();

            if (File.Exists(path))
            {
                var reader = new StreamReader(path);
                while (!reader.EndOfStream)
                {
                    string arquivo = reader.ReadLine();
                    favoritosListBox1.Items.Add(arquivo);
                }
                reader.Close();
            }

            
        
        }

        private void imagemListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagemListBox1.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private string ObterNomeArquivoConfiguracao()
        {
            var pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "imagensConfig.txt";
            string path = Path.Combine(pasta, arquivo);
            return path;

        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            favoritosListBox1.Items.Add(imagemListBox1.Text);
            GravarConfiguração();
            
        }

        private void GravarConfiguração()
        {
            string path = ObterNomeArquivoConfiguracao();
            var writer = new StreamWriter(path);
            foreach (string arquivo in favoritosListBox1.Items)
            {
                writer.WriteLine(arquivo);
            }
            writer.Close();
        }

        private void favoritosListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = favoritosListBox1.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            if(favoritosListBox1.SelectedItem != null)
            {
                string itemSelecionado = favoritosListBox1.SelectedItem.ToString();
                favoritosListBox1.Items.Remove(itemSelecionado);
                GravarConfiguração();
            }
            
        }
    }
}
