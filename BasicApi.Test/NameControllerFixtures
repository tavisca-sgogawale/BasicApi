using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicApi.Controllers;
using System.Net;
using System.Text;

namespace BasicApi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void  Test_to_check_responce()
        {
            //HttpWebRequest request = WebRequest.Create("http://localhost:64452/hello/names/shubham") as HttpWebRequest;

            ////request.Accept = "application/xrds+xml";  
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //WebHeaderCollection header = response.Headers;
            //string responseText;
            //var encoding = ASCIIEncoding.ASCII;
            //using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
            //{
            //     responseText = reader.ReadToEnd();
            //}
            NamesController nc = new NamesController();
            //nc.Get
            Assert.Equals( "hii", nc.Get("shubham"));
                
        }
    }
}
