# 
# LTSE Demo
> This software is written in c# windows format.

#### The code can be executed on a windows machine using .net framework 4.5.2 or greater:  
> Copy into a clean directory:
> - \ltseDemoCsharp\LTSEDemo\bin\Debug\LTSEDemo.exe
> - firms.txt
> - symbols.txt
> - trades.csv

>	Double click on LTSEDemo.exe
		Press the “Process Exchange Files”  Button
    
>	After execution, there will be 4 new files in the same directory:
> - brokerIDAccepted.txt
> - brokerIDRejected.txt
> - AllDataAccepted.txt
> - AllDataRejected.txt

#### The code can be viwed using Visual studio community:  
> - Download and install visual studio community  
> - Locate LTSEDemo/LTSEDemo.sln  - double click ths file and visual studio will open



#### Requirements
The goal of this program will be to determine which orders are valid orders and which orders are invalid orders.

There are three files attached.  One is the list of symbols trading on a fictional exchange, the second is a list of the brokers sending orders to a fictional exchange, and the third is a series of messages sent over the course of an hour in csv format.  Please write a program that reads in this third file and filters the orders sent on the basis of a few rules:
1. Only orders that have values for the fields of ‘broker’, ‘symbol’, ‘type’, ‘quantity’, ‘sequence id’, ‘side’, and ‘price’ should be accepted.

2. Only orders for symbols actually traded on the exchange should be accepted
3. Each broker may only submit three orders per minute: any additional orders in  should be rejected
4. Within a single broker’s trades ids must be unique. If ids repeat for the same broker, only the first message with a given id should be accepted.

The output should be two files with lists of the broker and id of accepted and rejected orders, in the order in which the orders were sent.
