using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpServerExample
{
    public class WebServer
    {
        public Boolean Running { get; set; } // Gére si on arréte le serveur
        HttpListener server;

        public event EventHandler OnStart;
        public event EventHandler OnStop;

        public async void Start()
        {
            // Dans le bloc "using", on utilise notre serveur
            // HttpListener implémentant IDisposable,
            // il sera libéré à la fin du bloc de using
            using (server = new HttpListener())
            {

                if (!Running)
                {
                    // On initialise notre serveur
                    server.Prefixes.Add("http://localhost:8000/");
                    server.Start();
                    Running = true;

                    // Ici on attent des requetes t'utilisateurs
                    while (Running)
                    {
                        try
                        {
                            var context = await server.GetContextAsync();

                            // On créer notre processus
                            Thread t = new Thread(OnRequest);

                            // On envoie le contexte au processus
                            t.Start(context);
                        }
                        catch(HttpListenerException)
                        {

                        }
                    }
                }
            }
        }

        // Pour stoper notre serveur
        public void Stop()
        {
            Running = false;
            server.Abort();
            server.Close();
            //server.Stop();
        }

        // Methode executé dans un processus pour chacune des requetes
        public void OnRequest(object? request)
        {
            if (request is HttpListenerContext ctx)
            {
                // Message affiché à chaque requéte
                MessageBox.Show("Nouvelle requete !");

                string page = "<html>Bonjour !</html>";

                // On convertie les caractères en octet UTF-8 (binaire)
                byte[] response = Encoding.UTF8.GetBytes(
                    // On convertie notre chaine de caractère en tableau de caractère
                    page.ToCharArray()
                );

                // On envoie la réponse au client (HTTP)
                ctx.Response.Close(response, true);
            }

        }

        public void  ServerStatus(object sender, EventArgs e)
        {
        }
    }
}
