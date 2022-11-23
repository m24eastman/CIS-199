// R6979
// Program 4
// December 1, 2020
// CIS 199-01

using System.IO;
using System;

class ServiceOrder
{ 
    public ServiceOrder(int serviceZipCode, string model, string serial, int appt, string technician, bool warranty)
    { // precondition is that it sets up variables to be used later in code
        this.serviceZipCode = serviceZipCode;
        this.model = model;
        this.serial = serial;
        this.appt = appt;
        this.technician = technician;
        this.warranty = warranty;
    } // postcondition is that all variables are set to this properties

    string model, serial, technician; // sets a string variable for the model number, serial number, and technician name
    int serviceZipCode, appt; // sets an integer variable for the service zip code and appointment length
    bool warranty; // declared a bool variable for if customer has warranty or not
    double Cost; // set a double integer for the cost

    void setserviceZipCode(int serviceZipCode) // precondition is that a method will be used that does not return a value
    {
        if (serviceZipCode <= 9999 && serviceZipCode >= 0000)
            this.serviceZipCode = serviceZipCode;
        else
            this.serviceZipCode = 40204;
    } // postcondition is when if statements and else statments run properly

    int getserviceZipCode() // method that will return service zip code
    {
        return serviceZipCode;
    } // service zip code is returned

    void setString(string model, string serial, string technician) // if statements are made for model, serial, and technician
    {
        if (model.Length == 5)
            this.model = model;
        if (serial.Length == 10)
            this.serial = serial;
        if (!(String.IsNullOrWhiteSpace(technician)))
            this.technician = technician;
    } // all if statements are ran and set to thier variable

    string getStrings() // method will return string values
    {
        return "\nModel Number: " + model + "\tSerial Number: " + serial + "\tTechnician Name: " + technician;
    } // all string values are returned

    void setappt(int appt) // method will run if statement but will not return it
    {
        if (appt >= 15 && appt <= 180)
            this.appt = appt;
    } // if statement made it so appointment time is between 15 and 180 minutes

    int getappt() // method should return appointment time
    {
        return appt;
    } // method succesfully ran appointment time

    void setwarranty(bool warranty) // method to set the bool variable for warranty 
    {
        this.warranty = warranty;
    } // method did not return a value, but set the warrranty value

    bool getwarranty() // method to return bool warranty
    {
        return warranty;
    } // method successfully return warranty

    double flatFee = 25; // appointment flat fee is 25 dollars
    double minFee = 1.50; // an extra $1.50 per minute of appointment
    double warrantyFee = 20; // if customer has warranty, cost is $20

    double CalcCost() // method to calculate costs that contains if statements for fee
    {
        if (warranty == false)
            Cost = flatFee + minFee * appt;
        else
            Cost = warrantyFee;
        return Cost;
    } // all if statements are ran and calculates the total cost of customer

    public new string ToString() //method to return all info required
    {
        return "Service Location Zip Code: " + serviceZipCode + "\nModel Number: " + model + "\nSerial Number: " + serial + "\nTechnician Name: " + technician + "\nAppointment Length: " + appt + "minutes\nWarranty Coverage: " + warranty;
    } // method returned all information successfully to user

    public static void DisplayServiceOrder(ServiceOrder[] obj) // method to determine the output for service number and cost
    {
        for(int i = 0; i<obj.Length;i++)
        {
            Console.WriteLine("\nService Number: " + (i + 1));
            Console.WriteLine(obj[i].ToString());
            Console.WriteLine("Cost: " + obj[i].CalcCost());
        } // service number and cost will be outputted correctly for the user
    }

    static void Main() // all information below is the information to be used in program, this includes model number, serial number, appointment time, name, and if the user has warranty or not
    {
        ServiceOrder[] obj = new ServiceOrder[6];
        obj[0] = new ServiceOrder(69698, "304022", "F984685321", 35, "Santiago", true);
        obj[1] = new ServiceOrder(56834, "67453", "F967436784", 60, "Christi", true);
        obj[2] = new ServiceOrder(72937, "29301", "F029384756", 45, "Spencer", false);
        obj[3] = new ServiceOrder(37284, "00023", "F946273948", 80, "Stephanie", false);
        obj[4] = new ServiceOrder(27183, "38473", "F749283019", 30, "Hayden", false);
        obj[5] = new ServiceOrder(27754, "18273", "F029381726", 25, "Jack", false);
        ServiceOrder.DisplayServiceOrder(obj);

        obj[0].setString("304022", "F984685321", "Santiago");
        obj[1].setappt(200);
        obj[2].setserviceZipCode(123456);
        obj[3].setwarranty(true);
        obj[4].setString("38473", "F749283019", null);
        obj[5].setappt(130);
        Console.WriteLine("\nUpdated details are: ");
        ServiceOrder.DisplayServiceOrder(obj);
    } // method successfully outputs all the information to the user.
}