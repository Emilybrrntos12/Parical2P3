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
        Queue<int> cola;

        public Form1()
        {
            InitializeComponent();
            wmpPlayer = new WindowsMediaPlayer();
            lista = wmpPlayer.newPlaylist("Reproduccion acutual ", "");
            wmpPlayer.currentPlaylist = lista;
            cola = new Queue<int>();
        }

        private void AgregarCancion(string rutaCancion)
        {
            IWMPMedia media = wmpPlayer.newMedia(rutaCancion);
            lista.appendItem(media);

            // Mostrar la canción agregada en la lista de reproducción
            ListaCanciones.Items.Add(media.name);

            // Agregar la canción a la cola
            cola.Enqueue(lista.count - 1);
        }

        private void EliminarCancion(int index)
        {
            // Eliminar la canción de la lista y de la cola
            lista.removeItem(lista.get_Item(index));
            ListaCanciones.Items.RemoveAt(index);
            cola = new Queue<int>(cola.Where(i => i != index).Select(i => i < index ? i : i - 1));
        }

        private void ReproducirCancion(int index)
        {
            //playlist.setItemPosition(playlist.get_Item(index), 0);
            wmpPlayer.controls.playItem(lista.get_Item(index));
            ListaCanciones.SelectedIndex = index;
        }

        private void ReproducirSiguienteCancion()
        {
            if (cola.Count > 0)
            {
                int index = cola.Dequeue();
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
                // Reiniciar la cola y agregar la canción seleccionada y todas las siguientes
                int index = ListaCanciones.SelectedIndex;
                cola = new Queue<int>();
                for (int i = index; i < lista.count; i++)
                {
                    cola.Enqueue(i);
                }

                ReproducirCancion(index);
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

                // Si la cola estaba vacía, comenzar a reproducir desde la primera canción
                if (cola.Count == 0)
                {
                    ReproducirCancion(0);
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
