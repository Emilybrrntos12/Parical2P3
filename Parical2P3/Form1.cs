using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Parical2P3
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer wmpPlayer;
        IWMPPlaylist lista;
        public Form1()
        {
            InitializeComponent();
            wmpPlayer = new WindowsMediaPlayer();
            lista = wmpPlayer.newPlaylist("Reproduccion acutual ", "");
            wmpPlayer.currentPlaylist = lista;
        }

        private void AgregarCancion(string rutaCancion)
        {
            IWMPMedia media = wmpPlayer.newMedia(rutaCancion);
            lista.appendItem(media);

            // Mostrar la canción agregada en la lista de reproducción
            ListaCanciones.Items.Add(media.name);
        }

        private void EliminarCancion(int index)
        {
            lista.removeItem(lista.get_Item(index));
            ListaCanciones.Items.RemoveAt(index);
        }

        private void ReproducirCancion(int index)
        {
            //playlist.setItemPosition(playlist.get_Item(index), 0);
            wmpPlayer.controls.playItem(lista.get_Item(index));
            ListaCanciones.SelectedIndex = index;
        }

        private void ReproducirSiguienteCancion()
        {
            if (lista.count > 0)
            {
                int index = (ListaCanciones.SelectedIndex + 1) % lista.count;
                ReproducirCancion(index);
            }
        }

        //DETENER
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            wmpPlayer.controls.stop();
        }

        private void ListaCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCanciones.SelectedIndex >= 0)
            {
                ReproducirCancion(ListaCanciones.SelectedIndex);
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog cajaDeBusqueda = new OpenFileDialog();
            cajaDeBusqueda.Filter = "Archivos de audio|*.mp3;*.wav;*.wma;*.ogg|Todos los archivos|*.*";
            cajaDeBusqueda.Multiselect = true;

            if (cajaDeBusqueda.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                foreach (string file in cajaDeBusqueda.FileNames)
                {
                    AgregarCancion(file);
                }
            }
        }

        private void Reproducir_Click(object sender, EventArgs e)
        {
            if (ListaCanciones.SelectedIndex >= 0)
            {
                wmpPlayer.controls.play();
            }
        }

        private void Pausa_Click(object sender, EventArgs e)
        {
            wmpPlayer.controls.pause();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            ReproducirSiguienteCancion();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (ListaCanciones.SelectedIndex >= 0)
            {
                EliminarCancion(ListaCanciones.SelectedIndex);
            }
        }
    }
}
