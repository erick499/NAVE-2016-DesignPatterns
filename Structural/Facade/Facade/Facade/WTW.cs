using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Facade
{
    class WTW
    {
        public float[] _l;
        public string[] date;
        WebRequest wrGETURL;
        string sURL;
        //read text and sets values in an int array
        public WTW(string start, string end)
        {
            //set sURL value
            date = new string[2] { start, end };
            sURL = "https://api.coindesk.com/v1/bpi/historical/close.json?start=" + date[0] + "&end=" + date[1];
            _l = new float[2];
            //pegar os valores na api e colocar no array _l
            wrGETURL = WebRequest.Create(sURL);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            string sLine = "";
            int i = 0;
            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    Console.WriteLine("{0}:{1}", i, sLine);
            }
            Console.ReadLine();
        }
    }
}
