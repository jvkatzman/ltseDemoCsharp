using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTSEDemo
{


    public class TradesClass
    {
        public DateTime Time_stamp;
        public string broker;
        public int sequence_id;
        public string trade_type;
        public string Symbol;
        public int Quantity;
        public float Price;
        public string Side;
        
        public TradesClass(DateTime new_Time_stamp,
                            string  new_broker,
                            int     new_sequence_id,
                            string  new_trade_type,
                            string  new_Symbol,
                            int     new_Quantity,
                            float   new_Price,
                            string  new_Side
                            )
        {
            Time_stamp =   new_Time_stamp;
            broker =       new_broker;
            sequence_id =  new_sequence_id;
            trade_type =   new_trade_type;
            Symbol=        new_Symbol;
            Quantity=      new_Quantity;
            Price =        new_Price;
            Side =         new_Side;
         }




    }
}
