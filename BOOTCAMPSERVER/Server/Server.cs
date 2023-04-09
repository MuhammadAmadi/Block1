using System.Net.Sockets;
using System.Net;
using System.Text;

class Server
{
    IPAddress ipAddres;
    IPEndPoint ipPoint;
    TcpListener server;

    public Server(string ip = "127.0.0.1", int port = 8888)
    {
        ipAddres = IPAddress.Parse(ip);
        ipPoint = new IPEndPoint(ipAddres, port);
        server = new TcpListener(ipPoint);
        server.Start();

        ConnectClient();
    }

    void ConnectClient()
    {
        while (true)
        {
            TcpClient client = server.AcceptTcpClient();
            Thread trd = new Thread(() => PushPoll(client));
            trd.Start();
        }
    }

    void PushPoll(TcpClient client)
    {
        Thread trd = new Thread(() => PoolStream(client));
        trd.Start();
        PushStream(client);
    }

    void PoolStream(TcpClient client)
    {
        StreamReader sRead = new StreamReader(client.GetStream(), Encoding.UTF8);
        while (true)
        {
            string? msg = sRead.ReadLine();
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
            Console.WriteLine($"Входяшее сообшение от клиента: {DateTime.Now:G}\n{msg}\n");
            Console.Write("отправить: > ");
        }
    }

    void PushStream(TcpClient client)
    {
        StreamWriter sWrite = new StreamWriter(client.GetStream(), Encoding.UTF8);
        while (true)
        {
            Console.Write("отправить: > ");
            string? msg = Console.ReadLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
            Console.WriteLine($"Отправленное сообшение: {DateTime.Now:G}\n{msg}\n");
            sWrite.WriteLine(msg);
            sWrite.Flush();
        }
    }

}