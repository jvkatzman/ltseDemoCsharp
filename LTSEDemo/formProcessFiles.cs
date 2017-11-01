using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LTSEDemo
{
    public partial class processExcFiles : Form
    {
        public processExcFiles()
        {
            InitializeComponent();
        }

        private void btnProcessFiles_Click(object sender, EventArgs e)
        {

            Helpers helpers = new Helpers();

            // obtain symbol list
            string[] symbols =  helpers.convertTextFileToList("symbols.txt");

            // obtain firm list
            string[] firms = helpers.convertTextFileToList("firms.txt");

            // process trades file
            string[] trades = helpers.convertTextFileToList("trades.csv");

            List<TradesClass> tradelistAccepted;
            List<TradesClass> tradelistRejected;
            helpers.convertTradeToList("trades.csv", symbols, out tradelistAccepted, out tradelistRejected);
            helpers.formatOutputBrokerSeqID( tradelistAccepted,  tradelistRejected);
            helpers.formatOutputAllData(tradelistAccepted, tradelistRejected);

            //Tell user results on screens
            int totalRecordCount = tradelistAccepted.Count + tradelistRejected.Count;
            textTotalRecords.Text = "The total number of records processed: " + totalRecordCount.ToString();
            textAccepted.Text = "The total number of accepted records processed: " + tradelistAccepted.Count.ToString();
            textRejected.Text = "The total number of rejected records processed: " + tradelistRejected.Count.ToString();
            textNotes.Text = "Results can be found in the following files: brokerIDAccepted.txt, brokerIDRejected.txt, AllDataAccepted.txt, AllDataRejected.txt";
            Console.WriteLine("process trades");
        }
    }
}
