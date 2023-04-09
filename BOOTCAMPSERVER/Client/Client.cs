using System.Net.Sockets;
using System.Text;


class Client
{
    TcpClient client;
    StreamWriter sWrite;
    StreamReader sRead;

    public Client(string ip = "127.0.0.1", int port = 8888)
    {
        client = new TcpClient(ip, port);
        sWrite = new StreamWriter(client.GetStream(), Encoding.UTF8);
        sRead = new StreamReader(client.GetStream(), Encoding.UTF8);
        PushPoll();
    }

    void PushPoll()
    {
        Thread trd = new Thread(() => PoolStream());
        trd.Start();
        PushStream();
    }

    void PoolStream()
    {
        while (true)
        {
            string? msg = sRead.ReadLine();
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
            Console.WriteLine($"Входяшее сообшение от сервера: {DateTime.Now:G}\n{msg}\n");
            Console.Write("отправить: > ");
        }
    }

    void PushStream()
    {
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