using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace LTSEDemo
{
    class Helpers
    {

        public string[] convertTextFileToList(string filename)
        {
            string[] newList = File.ReadAllLines(filename);
            return newList;
        }
        public void convertTradeToList(string filename, string[] symbols, out List<TradesClass> tradelistAccepted, out List<TradesClass> tradelistRejected)
        {

            List<TradesClass> tradelistAcc = new List<LTSEDemo.TradesClass>();
            List<TradesClass> tradelistRej = new List<LTSEDemo.TradesClass>();
            List<string> brokerIds = new List<string>();
            Dictionary<string, int> dictBrkOrdPerMin = new Dictionary<string, int>();

            Boolean validRecord = true;

            foreach (var line in File.ReadLines(filename).Skip(1))
            {

                validRecord = true;
                var data = line.Split(',');
                // do not use records that have no data in ‘broker’, ‘symbol’, ‘type’, ‘quantity’, ‘sequence id’, ‘side’, and ‘price’
                if (data[1] == ""  ||
                    data[2] == "" ||
                    data[3] == "" ||
                    data[4] == "" ||
                    data[5] == "" ||
                    data[6] == "" ||
                    data[7] == "")
                {
                    validRecord = false;
                }// no data in field

                // check for duplicate broker/sequence id
                string newbrokerIds = data[2] + data[1];
                if (brokerIds.Contains(newbrokerIds) )
                {
                    validRecord = false;
                }

                // check that the symbol exits in symbol
                if (!symbols.Contains(data[4]))
                {
                    validRecord = false;
                }// symbol test

                // Each broker may only submit three orders per minute
                DateTime tempGetDate = Convert.ToDateTime(data[0]);
                string brokerhhmm = data[1] + tempGetDate.ToString("hhmm");

                if (dictBrkOrdPerMin.ContainsKey(brokerhhmm))
                {   if (dictBrkOrdPerMin[brokerhhmm] == 3)
                    {
                        validRecord = false;
                    }
                    else
                    { 
                    dictBrkOrdPerMin[brokerhhmm] = dictBrkOrdPerMin[brokerhhmm] + 1;
                    }
                }
                else 
                {
                    dictBrkOrdPerMin.Add(brokerhhmm, 1);
                }

                

                if (validRecord)
                {
                    tradelistAcc.Add(new TradesClass(
                        Convert.ToDateTime(data[0]),    //Time_stamp
                        data[1],                        //broker
                        Convert.ToInt32(data[2]),       //sequence_id
                        data[3],                        //trade_type
                        data[4],                        //Symbol
                        Convert.ToInt32(data[5]),       //Quantity
                        float.Parse(data[6]),           //Price
                        data[7]                         //Side

                    ));
                }
                else
                {
                    tradelistRej.Add(new TradesClass(
                        Convert.ToDateTime(data[0]),    //Time_stamp
                        data[1],                        //broker
                        Convert.ToInt32(data[2]),       //sequence_id
                        data[3],                        //trade_type
                        data[4],                        //Symbol
                        Convert.ToInt32(data[5]),       //Quantity
                        float.Parse(data[6]),           //Price
                        data[7]                         //Side

                    ));
                }// valid record

            }// foreach

            tradelistAccepted = tradelistAcc;
            tradelistRejected = tradelistRej;

            }// convertTradeToList

        public void formatOutputBrokerSeqID(List<TradesClass> tradelistAccepted, List<TradesClass> tradelistRejected)
        {
            // create file with broker/sequence ID that were accepted
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"brokerIDAccepted.txt"))
            {
                var delimiter = "\t";
                string[] arr = { "Broker", "Sequence ID" };
                var line = string.Join(delimiter, arr);
                file.WriteLine(line);

                foreach (TradesClass trade in tradelistAccepted)
                {
                    string broker = trade.broker;
                    string seqID = trade.sequence_id.ToString();
                    string[] arr2 = { broker,seqID };
                    var line2 = string.Join(delimiter, arr2);

                    file.WriteLine(line2);
                }
            }// streamwriter accepted broker/seq

            // create file with broker/sequence ID that were rejected
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"brokerIDRejected.txt"))
            {
                var delimiter = "\t";
                string[] arr = { "Broker", "Sequence ID" };
                var line = string.Join(delimiter, arr);
                file.WriteLine(line);

                foreach (TradesClass trade in tradelistRejected)
                {
                    string broker = trade.broker;
                    string seqID = trade.sequence_id.ToString();
                    string[] arr2 = { broker, seqID };
                    var line2 = string.Join(delimiter, arr2);

                    file.WriteLine(line2);
                }
            }// streamwriter accepted broker/seq

        }// formatOutput

        public void formatOutputAllData(List<TradesClass> tradelistAccepted, List<TradesClass> tradelistRejected)
        {
            // create file with all data that were accepted
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"AllDataAccepted.txt"))
            {
                var delimiter = "\t";
                string[] arr = { "Time Stamp", "Broker", "Sequence ID", "Trade Type", "Symbol", "Quantity", "Price", "Side" };
                var line = string.Join(delimiter, arr);
                file.WriteLine(line);

                foreach (TradesClass trade in tradelistAccepted)
                {
                    string Time_stamp= trade.Time_stamp.ToString();
                    string broker = trade.broker;
                    string sequence_id = trade.sequence_id.ToString();
                    string trade_type = trade.trade_type;
                    string Symbol = trade.Symbol;
                    string Quantity = trade.Quantity.ToString();
                    string Price = trade.Price.ToString();
                    string Side = trade.Side;
                    string[] arr2 = { Time_stamp,broker, sequence_id,trade_type,Symbol,Quantity,Price,Side };
        
                    var line2 = string.Join(delimiter, arr2);

                    file.WriteLine(line2);
                }
            }// streamwriter accepted broker/seq

            // create file with with all data that were rejected
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"AllDataRejected.txt"))
            {
                var delimiter = "\t";
                string[] arr = { "Time Stamp", "Broker", "Sequence ID", "Trade Type", "Symbol", "Quantity", "Price", "Side" };
                var line = string.Join(delimiter, arr);
                file.WriteLine(line);

                foreach (TradesClass trade in tradelistRejected)
                {
                    string Time_stamp = trade.Time_stamp.ToString();
                    string broker = trade.broker;
                    string sequence_id = trade.sequence_id.ToString();
                    string trade_type = trade.trade_type;
                    string Symbol = trade.Symbol;
                    string Quantity = trade.Quantity.ToString();
                    string Price = trade.Price.ToString();
                    string Side = trade.Side;
                    string[] arr2 = { Time_stamp, broker, sequence_id, trade_type, Symbol, Quantity, Price, Side };

                    var line2 = string.Join(delimiter, arr2);

                    file.WriteLine(line2);
                }
            }// streamwriter accepted broker/seq

        }// formatOutput

    }// class
}// end
