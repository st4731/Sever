﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Server
{
    class 소켓
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint IP = new IPEndPoint(IPAddress.Any, 5000);
        void 서버()
        {
            socket.Bind(IP);//실제 주소로 배정.
            socket.Listen(3);//접속을 기다리는 상태 숫자는 최대 연결수 같음.
            while (true)
            {
                Socket 클라이언트소켓 = (Socket)socket.Accept();//연결
            }
        }
    /*class Server
    {
        static byte[] Buffer { get; set; }
        string str;
        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint ep = new IPEndPoint(IPAddress.Any, 5000);
        Server() {
            
            sock.Bind(ep);
            sock.Listen(10);
            Socket accept = sock.Accept();
            Buffer = new byte[accept.SendBufferSize];
            int read = accept.Receive(Buffer);
            byte[] format = new byte[read];
            for (int i = 0; i < read; ++i)
            {
                format[i] = Buffer[i];
            }
            str = Encoding.UTF8.GetString(format);
            Var_static.strdata = str;
            Console.Write(str + "\r\n");
            Console.Write(Json.id +" "+Json.pw+ "\r\n");
            Console.Read();
            accept.Close();
            sock.Close();

        }
    }*/
   /* public class socket {
        public static TcpListener tcp_Listener; // TCP 통신 Listener 
        public static Thread Thread; // Thread 객체
        public static NetworkStream Stream;// 전송되는 값 받아오는 객체
        public static void 서버()
        {
            string IP = "210.93.84.206";//Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
           Console.WriteLine(IP);
           IPAddress ipAddress = IPAddress.Parse(IP);
           tcp_Listener = new TcpListener(ipAddress, 5000); // TCP Listener Thread 정의
           Thread = new Thread(new ThreadStart(쓰레드)); // Listen Thread 생성
           Console.WriteLine("쓰레드 시작");
           Thread.Start(); // Thread 시작.
        }
        public static void 쓰레드()
        {
            try
            {
                tcp_Listener.Start();
                while (true)
                {
                    TcpClient client = tcp_Listener.AcceptTcpClient();//클라이언트 접속.
                    Console.WriteLine("접속완료후 다음 쓰레드 시작");
                    Console.WriteLine(client);
                    Thread startClientThread = new Thread(new ParameterizedThreadStart(받음상시대기)); // Client로 부터 접속
                    Console.WriteLine("시작");
                    startClientThread.Start(client);
                }
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
        }
        public static void 받음상시대기(object client)
        {
            Console.WriteLine("받음 시작");
            try
            {
                TcpClient tcpClient = (TcpClient)client; // tcp Client 생성
                Console.WriteLine(tcpClient);
                Stream = tcpClient.GetStream(); // Client로 부터 Stream 받아오기/
                Console.WriteLine(Stream);
                if (Stream != null)
                {
                    byte[] message = new byte[4096]; // Message Byte 생성
                    int byteRead; // byte 받아오기
                    JArray jArray = new JArray();
                    jArray.Add("1번 값");
                    jArray.Add("2번 값");
                    JObject jObject = new JObject();
                    jObject["이름"] = jArray;
                    string json = jObject.ToString();
                    string test = "12213";
                    byte[] data = Encoding.UTF8.GetBytes(test);
                    Stream.Write(data, 0, data.Length);
                    Console.WriteLine(data);

                    while (true)
                    {
                        byteRead = 0;
                        byteRead = Stream.Read(message, 0, 4096); // 클라이언트로 부터 Stream Read..
                        UTF8Encoding encoder = new UTF8Encoding(); // 변환
                        Console.WriteLine("출력 진입전");
                        출력(message, byteRead);
                        //Json.unPasing(Stream);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static string strBuffer = string.Empty; // Listener로 부터 받아오는 buffer 
        public static int mbyteSize = 0;  // byte Size    
        public const int 문자길이 = 10000; // 지정된 문자길이 
        public static void 출력(byte[] data, int byteRead)
        {
            Console.WriteLine("출력 진입");
            mbyteSize += byteRead; // 사이즈 누적
            UTF8Encoding encoder = new UTF8Encoding();// 변환
            strBuffer += encoder.GetString(data, 0, byteRead); //  버퍼 누적 ( 잘려서 들어오는 경우가 있을 경우)

            if (mbyteSize <= 문자길이)
            {
                Console.WriteLine (strBuffer);
                strBuffer = string.Empty;
            }
        }
        public static void 보냄(Object Str,Object send)
        {
            Stream = (NetworkStream)Str;
            string str = (string)send;
            byte[] data = Encoding.UTF8.GetBytes(str);
            Stream.Write(data, 0, data.Length);

        }
    }*/
}