//CSIS1175-002 - Muhammad Hassan Haider Student ID 300273535 - Paulo Cesar Borba Student ID 300268640
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS3pauloborba
{
    class Rental
    {
        private string _bikeT, _access, _insur, _bikeDesc, _accessDesc, _insurDesc;//Declaring the private variables to hold values sent when class is called and to insert the description of the results
        private double _amt, _hours;//Creating the constructor for our class
        public Rental(string bikeT, string access, string insur, double hours)
        {
            _bikeT = bikeT;//initializing the values private strings with values passed through the creator by the calling
            _access = access;
            _insur = insur;
            _hours = hours;
        }
        public string BikeType //creating the method to identify the bike type
        {
            get
            {
                if (_bikeT == "1")
                {
                    _bikeDesc = "Single - speed";
                }
                if (_bikeT == "2")
                {
                    _bikeDesc = "Seven - speed";
                }
                if (_bikeT == "3")
                {
                    _bikeDesc = "Tandem";
                }
                if (_bikeT == "4")
                {
                    _bikeDesc = "Mountain";
                }
                return _bikeDesc;
            }
        }
        public string Accessories //creating the method to identify the accessories requested by the customer
        {
            get
            {
                if (_access.Contains("N"))//in this case just one sentence will be associated to the variable
                {
                    _accessDesc = " Not accessory requested  "; 
                }
                else //Else more than one sentence can be associated to the variable, so we will add the new value and preserve the current value that exist in description variable
                {
                    if (_access.Contains("C"))
                    {
                        _accessDesc = _accessDesc + " Child seat &";
                    }
                    if (_access.Contains("L"))
                    {
                        _accessDesc = _accessDesc + " Lock &";
                    }
                    if (_access.Contains("R"))
                    {
                        _accessDesc = _accessDesc + " Rack &";
                    }
                }
                return _accessDesc.Substring(0, _accessDesc.Length - 2);//returning the description value to accessories without 2 last character to clean de blank space and & of the string
            }
        }
        public string Insurance//creating the method to identify if insurance is contracted or not
        {
            get
            {
                if (_insur == "Y")
                {
                    _insurDesc = "Yes";
                }
                if (_insur == "N")
                {
                    _insurDesc = "No";
                }
                return _insurDesc;//returning the description value to insurance
            }
        }
        public double Charge//creating the method to calculate the bill that will be charged 
        {
            get
            {
                if (_hours <= 5) //identifying if hours will be charged just with bases rate and setting the value to the _amt
                {
                    _amt = _hours * 12;
                }
                else //If mor than 5 hours were consumed the code will identify how many hours will be charged regularly and how many hours will be charged with discount and setting the value to the _amt
                {
                    _amt = (5 * 12) + ((_hours - 5) * 10);
                }
                return _amt; //returning the amount that will be charged
            }
        }
    }
}
