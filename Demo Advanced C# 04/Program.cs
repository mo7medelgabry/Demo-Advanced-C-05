using Demo_Advanced_C__04.FIFA;
using Demo_Advanced_C__04.YouTube;
using System;
using System.Collections;

namespace Demo_Advanced_C__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EX01
            //Ball ball = new Ball() { Id = 1};
            //Console.WriteLine(ball);
            //ball.Location=new Location() {X=1,Y=1 , Z=1};
            //Console.WriteLine(ball);
            //Player P01 = new Player() { Name = "Messi", TeamName = "Inter Miami" };
            //Player P02 = new Player() { Name = "Alba", TeamName = "Inter Miami" };

            //Player P03 = new Player() { Name = "Vini", TeamName = "Real Madrid" };
            //Player P04 = new Player() { Name = "Rodrigo", TeamName = "Real Madrid" };
            //Player P05 = new Player() { Name = "Kroos", TeamName = "Real Madrid" };

            //Refree R01 = new Refree() { RefreeName = "Ibarhim Nour EL-Din" };

            //ball.Location = new Location() {X=1, Y=1 , Z=1};
            //ball.BallLocationChange += P01.Run;
            //ball.BallLocationChange += P02.Run;
            //ball.BallLocationChange += P03.Run;
            //ball.BallLocationChange += P04.Run;
            //ball.BallLocationChange += R01.Look;
            //ball.Location = new Location() { X=1, Y=4, Z=2};
            //Console.WriteLine("\nChanging ");
            //ball.BallLocationChange -= P04.Run;
            //ball.BallLocationChange += P05.Run;

            //ball.Location=new Location() { X=5, Y=6, Z=7};
            #endregion

            #region EX02
            //Channel channel01 = new Channel() { ChanelName = "CBC"};
            //channel01.AddVideo(video: new Videos() { Title = "Title01", Description = "Desc01" });

            //Subscribers subscriber01 = new Subscribers() { SubName = "Mohamed" };
            //Subscribers subscriber02 = new Subscribers() { SubName = "Ali" };
            //Subscribers subscriber03 = new Subscribers() { SubName = "Mahmoud" };
            //Subscribers subscriber04 = new Subscribers() { SubName = "Salma" };
            //Subscribers subscriber05 = new Subscribers() { SubName = "Maryam" };
            //Subscribers subscriber06 = new Subscribers() { SubName = "Omar" };
            //channel01.UploadVideo += subscriber01.Notify;
            //channel01.UploadVideo += subscriber02.Notify;
            //channel01.UploadVideo += subscriber03.Notify;
            //channel01.UploadVideo += subscriber04.Notify;
            //channel01.UploadVideo += subscriber05.Notify;
            //channel01.AddVideo(video: new Videos() { Title = "Title02", Description = "Desc02" });

            //Console.WriteLine("========================================");
            //channel01.UploadVideo-= subscriber01.Notify;
            //channel01.UploadVideo+= subscriber06.Notify;

            //channel01.AddVideo(video: new Videos() { Title = "Title03", Description = "Desc03" });

            #endregion

            #region Hashtables
            
            Hashtable Note = new Hashtable();
            Console.WriteLine($"Count {Note.Count}");
            Note.Add(key:"Ahmed",value:111111);
            Note.Add(key:"Ai",value:222222);
            Note.Add(key:"Mohamed",value:3333333);
            Note.Add(key:"Omar",value:44444444);
            Console.WriteLine("======================================");
            Console.WriteLine($"Count {Note.Count}");

            foreach(DictionaryEntry item in Note)
            {
                Console.WriteLine(value:$"Key {item.Key},Value {item.Value}");
            }



            #endregion










        }
    }
}
