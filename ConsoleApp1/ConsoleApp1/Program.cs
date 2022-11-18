using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] agrs)
        {
            var video = new Video() { Title = "Video 1",Id = 1 }, new Video() { Title = "video 2", Id = 2};
            var videoEncoder = new VideoEncoder();//publisher
            var mailservice = new MailService();//subscriper
            var tettservice = new TextMessage();//subscriper
            videoEncoder.VideoEncoded += mailservice.OnVideoEncodedMessage;
            videoEncoder.VideoEncoded += tettservice.OnVideoEncodedMessage;
            videoEncoder.Encode(video);






        }



        



    }
    public class MailService
    {

        public void OnVideoEncodedMessage(object source,EventArgs e)
        {
            Console.WriteLine("MS: SENDING MESSAGE..");
        }
    }

    public class TextMessage
    {

        public void OnVideoEncodedMessage(object source, EventArgs e)
        {
            Console.WriteLine("TM: SENDING MESSAGE..");
        }
    }






}
