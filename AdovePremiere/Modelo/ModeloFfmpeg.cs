using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdovePremiere
{
    public class ModeloFfmpeg
    {

        public void ejecutarFfmpeg(String comando, String mensaje)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    CreateNoWindow = false,
                    FileName = "cmd.exe",
                    WindowStyle = ProcessWindowStyle.Minimized,
                    Arguments = comando
                };
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
                MessageBox.Show(mensaje, "Listo");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error...");
            }
        }

        public void convertirFormato(String ruta, String nombre, String formato)
        {
            String comando = $"/c ffmpeg -i {ruta}\\{nombre}.{formato}";
            String mensaje = "Video convertido con exito.";
            ejecutarFfmpeg(comando, mensaje);
        }

        public void verResolucion(String ruta)
        {
            String comando = $"/c ffprobe -v error -select_streams v:0 -show_entries stream=width,height -of csv=s=x:p=0 {ruta}";
            ejecutarFfmpeg(comando, "");
        }

        public void cambiarResolucion(String ruta, String nombre, String resolucion, String formato)
        {
            String comando = $"/c ffmpeg -i {ruta} -vf scale={resolucion} {nombre}.{formato}";
            String mensaje = "Se cambio la resolucion del video con exito.";
            ejecutarFfmpeg(comando, mensaje);
        }

        public void extraerAudio(String ruta, String nombre, String formato)
        {
            String comando = $"/c ffmpeg -i {ruta} -vn -ar 44100 -ac 2 -ab 192k -f mp3 {nombre}.{formato}";
            String mensaje = "Se extrajo el sonido con exito.";
            ejecutarFfmpeg(comando, mensaje);
        }

        public void removerAudio(String ruta, String nombre, String formato)
        {
            String comando = $"/c ffmpeg -i {ruta} -c copy -an {nombre}.{formato}";
            String mensaje = "Se removio el sonido con exito";
            ejecutarFfmpeg(comando, mensaje);
        }

        public void extraerImagenes(String ruta, String nombre, String inicio, String fin)
        {
            String comando = $"/c ffmpeg.exe -ss {inicio} - t {fin} - i {ruta} - qscale: v 2 - r 10.0 {nombre} -% 4d.jpg";
            String mensaje = "Se extrajeron las imagenes correctamente.";
            ejecutarFfmpeg(comando, mensaje);
        }

    }
}
