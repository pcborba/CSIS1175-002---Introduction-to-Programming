//CSIS1175-002 - Muhammad Hassan Haider Student ID 300273535 - Paulo Cesar Borba Student ID 300268640
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AS3pauloborba
{
    public partial class frmAssignment3 : Form
    {
        public frmAssignment3()
        {
            InitializeComponent();
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            string[] dbCustomers = File.ReadAllLines("c:\\temp\\AS3customers.csv"); //creating array to hold customers data from Customer data base
            string[] dbData = File.ReadAllLines("c:\\temp\\AS3data.csv"); //creating array to hold customers transactions from Data data base, this will be our Data source of our LINQ query
            string fmt = "{0,-29}{1,8}{2,14:d}{3,15}{4,27}{5,12}{6,6:n1}{7,11:c}"; //creating a string format to use when listing content on the listbox
            int prevId = 0; //Declaring and set the initial value to an int variable in which we will control and follow the previous customer ID, so we can compare it with the current customer Id to change presentation of the registers in each line of listbox
            bool firstReg = true; //Declaring and setting the initial value to a boolean variable that will indicate if we are reading the first register of the array that contains the customers transactions
            double subTotal = 0, total = 0; //Declaring and setting the initial double value to hold the subtotal of each customer, and a similar double variable called total to hold the grand total of all customers transcations
            string custName = ""; //Declaring and setting the initial doub

            var myQuery = from rows in dbData //Creating our query of our LINQ
                          let col = rows.Split(',')
                          let custId = int.Parse(col[0]) //Using the Int.Parse method to convert the string of custId into Integer so we can sort it correctly as required on assignment
                          let inv = col[1]
                          let rentD = DateTime.Parse(col[2])//Using the DateTime.Parse method to convert the string of rental date into DateTime format so we can sort it correctly as required on assignment
                          let bikeT = col[3]
                          let access = col[4]
                          let insur = col[5]
                          let hours = double.Parse(col[6])//Using the Double.Parse method to convert the string of hours into double format so we can consider the fraction value correctly to properly calculate the charge
                          orderby custId, rentD //sorting our query by the columns as required on assingment
                          select new
                          {
                              custId,
                              inv,
                              rentD,
                              bikeT,
                              access,
                              insur,
                              hours,
                          };

            lstResult.Items.Clear(); //Cleaning the listbox, so if user click more than one time on the button the presentation will not be a mess
            foreach (var reg in myQuery) //Executing our query to retrieve the values that we will print on the listbox
            {
                Rental myRent = new Rental(reg.bikeT, reg.access, reg.insur, reg.hours); //Creating our object based on Rental Class, calling the Rental constructor and passing to it the arguments
                if (firstReg == true) //identifying if is this the first register on the query
                {
                    lstResult.Items.Add(string.Format(fmt, "Customer Name & ID", "Inv #", "Rental Date", "Bike Type", "Accessories", "Insured", "Hrs", "Charge")); //Print the 8 columns heading just for the first register
                    lstResult.Items.Add(""); //adding an empty as presented on the model on assingment
                    firstReg = false; //setting the value of boolean variable firstReg to false, so on the next register the head will not be printed 
                    prevId = reg.custId; //setting the preivous id variable to the current id, so we can evaluate to the next registers if we will print the name of the customer or not, the custom ID is our control break
                    for (int i = 0; custName == "" && i<dbCustomers.Length; i++) //doing a loop to match the customer ID, if is there a customer on Customer Database(AS3customers), with the same ID that is presented on the current register in transaction data base(AS3data)
                    {
                        string[] custInfo = dbCustomers[i].Split(',');//declaring an array to splity the value of each row on array dbCustomers, so we can search by the data on the second column of this new array, position [1]
                        if (custInfo[1].Contains(reg.custId.ToString()) == true) //associating the value to customer name, if he or she is present on the customer database;
                        {
                            custName = custInfo[0];
                        }
                    }
                    if(custName!="") //If customer is find on customer database we print he or she name as setting in line bellow
                    {
                        lstResult.Items.Add(string.Format(fmt, custName + " " + reg.custId, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hours, myRent.Charge));
                    }
                    else //else we will inform that this customer is not on the daba base customers and print he or seh transcations as setting in line bellow
                    {
                        lstResult.Items.Add(string.Format(fmt, "*Customer name not found* " + reg.custId, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hours, myRent.Charge));
                    }
                    subTotal = subTotal + myRent.Charge; // for each transaction of the customer we will aggregate the charge of this transaction to he or she total, that is the subtotal to our report
                }
                else
                {
                    if (reg.custId == prevId) //if the customer ID is the same as the previous we will not print the heading, or customer name again, we will jus insert the other information related to this specific transaction
                    {
                        lstResult.Items.Add(string.Format(fmt, " ", reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hours, myRent.Charge));
                        subTotal = subTotal + myRent.Charge; // for each transaction of the customer we will aggregate the charge of this transaction to he or she total, that is the subtotal to our report
                    }
                    else //when customer id is different we need to close the subtotal for the last customer so we do this activities;
                    {
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------")); //add a line with hiphens separating the individuas transactions value to the subtotal
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-total", "", subTotal)); //print a line with the subtotal of the previous customer
                        lstResult.Items.Add(""); //add a blank line as required on assigment
                        total = total + subTotal; //at this time we need to aggregate the sub-total of previous customer to the grand total 
                        subTotal = 0; //before start printing and calculating the transactions of this new customer we need to reset the subtotal
                        prevId = reg.custId; //redefine the previous customer id to the current customer id
                        custName = ""; //reset the variable that hold the customer name
                        for (int i = 0; custName == "" && i < dbCustomers.Length; i++) //here we de did the same search that we did on the firs register of our query, because as this is other customer we need to search he or she name and then print each transcation
                        {
                            string[] custInfo = dbCustomers[i].Split(',');
                            if (custInfo[1].Contains(reg.custId.ToString()) == true)
                            {
                                custName = custInfo[0];
                            }
                        }
                        if (custName != "")
                        {
                            lstResult.Items.Add(string.Format(fmt, custName + " " + reg.custId, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hours, myRent.Charge));
                        }
                        else
                        {
                            lstResult.Items.Add(string.Format(fmt, "*Customer name not found* " + reg.custId, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hours, myRent.Charge));
                        }
                        subTotal = subTotal + myRent.Charge;
                    }
                }
            }
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------")); //when last transaction register is read we print the closing information to this customer as we did to other customer
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-total", "", subTotal));
            lstResult.Items.Add("");
            total = total + subTotal; //we agregate subtotal of the last customer to the grand total
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Grand total", "", total));//finally we print the las line with gran total 
        }
    }
}
