using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Threading;


namespace GoToCric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public Scores scoreObj = new Scores();
        public string URI = "";
        public bool i = false;
        BackgroundWorker worker = null;
        private delegate void Delegate();

        private void GoBtn_Click(object sender, EventArgs e)
        {
            //if (i) Thread.Sleep(30000);
            string tempURI = this.URL.Text;
            int indexS = tempURI.LastIndexOf("/");
            int indexD = tempURI.LastIndexOf(".");
            tempURI = tempURI.Substring(indexS + 1, indexD - indexS - 1);
            URI = "http://www.espncricinfo.com/netstorage/" + tempURI + ".json?xhr=1";
            getCricData(sender, e);
            
           
        }
        private void getCricData(object sender, EventArgs e)
        {
            if (i) Thread.Sleep(15000);
            Delegate del = new Delegate(getData);
            this.Invoke(del);
            worker = new BackgroundWorker();
            worker.DoWork += (o, p) => getCricData(sender, e);
            worker.RunWorkerAsync();
            
            i = true;
        }
         
        public void getData()
        {
            try
            {
                HttpClient client = new HttpClient();

                var webReq = (HttpWebRequest)WebRequest.Create(URI);
                using (HttpWebResponse webResp = (HttpWebResponse)webReq.GetResponse())
                {
                    Stream scoreStream = webResp.GetResponseStream();
                    var scoreRead = new StreamReader(scoreStream);
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    var scores = js.Deserialize<dynamic>(scoreRead.ReadToEnd());
                    //tempTweet.userName = i.ContainsKey("user") ? (i["user"].ContainsKey("name") ? i["user"]["name"] : "") : "";
                    scoreObj.btsMan1 = scores["centre"]["batting"][0]["known_as"] + " (Bat)";
                    scoreObj.btsMan2 = scores["centre"]["batting"][1]["known_as"] + " (Bat)";
                    scoreObj.btsMan1Scr = scores["centre"]["batting"][0]["runs"] + " runs / " + scores["centre"]["batting"][0]["balls_faced"] + " balls";
                    scoreObj.btsMan2Scr = scores["centre"]["batting"][1]["runs"] + " runs / " + scores["centre"]["batting"][1]["balls_faced"] + " balls";

                    scoreObj.bowl1 = scores["centre"]["bowling"][0]["known_as"] + " (Bow)";
                    scoreObj.bowl2 = scores["centre"]["bowling"][1]["known_as"] + " (Bow)";
                    scoreObj.bowl1Scr = scores["centre"]["bowling"][0]["conceded"] + " runs / " + scores["centre"]["bowling"][0]["overs"] + " overs";
                    scoreObj.bowl2Scr = scores["centre"]["bowling"][1]["conceded"] + " runs / " + scores["centre"]["bowling"][1]["overs"] + " overs";

                    scoreObj.runRate = scores["centre"]["common"]["innings"]["run_rate"];
                    scoreObj.target = scores["centre"]["common"]["innings"]["target"];
                    scoreObj.reqRate = scores["live"]["innings"]["required_run_rate"];

                    scoreObj.game = scores["match"]["team1_short_name"] + " vs " + scores["match"]["team2_short_name"];
                    string curSum = scores["match"]["current_summary"];
                    scoreObj.fullSummary = scores["match"]["current_summary"];
                    scoreObj.summary = curSum.Substring(0, curSum.IndexOf("ov")) + ")";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            this.Summary.Text = scoreObj.fullSummary;
            //this.Summary.Refresh();
            this.Text = scoreObj.game;

            this.BtsMan1.Text = scoreObj.btsMan1;
            this.BtsMan2.Text = scoreObj.btsMan2;
            this.Bowl1.Text = scoreObj.bowl1;
            this.Bowl2.Text = scoreObj.bowl2;
            this.btScr1.Text = scoreObj.btsMan1Scr;
            this.btScr2.Text = scoreObj.btsMan2Scr;
            this.RateScr.Text = scoreObj.runRate;
            this.ReqScr.Text = scoreObj.reqRate;
            this.TargetScr.Text = scoreObj.target;
            this.bowScr1.Text = scoreObj.bowl1Scr;
            this.bowScr2.Text = scoreObj.bowl2Scr;
            this.Refresh();
            //InitializeComponent();
        }

        public class Scores
        {
            public string btsMan1;
            public string btsMan2;
            public string bowl1;
            public string bowl2;
            public string btsMan1Scr;
            public string btsMan2Scr;
            public string bowl1Scr;
            public string bowl2Scr;
            public string runRate;
            public string reqRate;
            public string target;
            public string scores;
            public string overs;
            public string game;
            public string summary;
            public string fullSummary;

        } 
    }
}
