using Newtonsoft.Json;
using SocketIOClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace EventLogger
{
    class Program
    {
        static async Task Main(string[] args)
        {
            

            FileStream fs = new FileStream(@"E:/log.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            TextWriterTraceListener txtListener = new
            TextWriterTraceListener(sw, "txt_listener");

            Trace.Listeners.Add(txtListener);

            Trace.AutoFlush = true;
            Console.OutputEncoding = Encoding.UTF8;
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));



            var uri = new Uri("https://rsoi-semaphore.herokuapp.com");

            var socket = new SocketIO(uri, new SocketIOOptions
            {
                Query = new Dictionary<string, string>
                {
                    //{"token", "io" }
                    {"token", "v3" }
                },
                EIO = 4
            });

           //socket.GetConnectInterval = () => new MyConnectInterval();

            socket.OnConnected += Socket_OnConnected;
            socket.OnDisconnected += Socket_OnDisconnected;
            socket.OnReconnecting += Socket_OnReconnecting;

            await socket.ConnectAsync();

            socket.On("hi", response =>
            {
                Console.WriteLine($"server: {response.GetValue<string>()}");
            });

            List<EventEntity> responses = new List<EventEntity>();
            socket.On("color", async response =>
            {
                await Task.Run(async () =>
                {
                    await new UnitOfWork().EventsRepositore.Add(JsonConvert.DeserializeObject<EventEntity>(response.GetValue<object>().ToString()));
                   
                });
            });         

            Console.ReadLine();
        }

        private static void Socket_OnReconnecting(object sender, int e)
        {
            Console.WriteLine($"Reconnecting: attempt = {e}");
        }

        private static void Socket_OnDisconnected(object sender, string e)
        {
            Console.WriteLine("disconnect: " + e);
        }

        private static async void Socket_OnConnected(object sender, EventArgs e)
        {
            Console.WriteLine("Socket_OnConnected");
            var socket = sender as SocketIO;
            Console.WriteLine("Socket.Id:" + socket.Id);
            await socket.EmitAsync("hi", "EventLogger");

        }


    }

}
