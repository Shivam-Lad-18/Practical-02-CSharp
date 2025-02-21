namespace Bank
{
    // Creating an Class Customer_Account
    class Customer_Account
    {
        // Declaring three variables for class
        static string bank_name;
        public string customer_name;
        public long customer_accountNo;

        // Constructor to initialize the varaiables
        Customer_Account(string customer_name, long customer_accountNo)
        {
            this.customer_name = customer_name;
            this.customer_accountNo = customer_accountNo;
        }

        // Function to display the account details of the customer
        void printInfo()
        {
            // Printing the details on console
            Console.WriteLine($"\nYour account detials are as under.\n\n\n" +
                $"\t- Bank Name : {bank_name}\n" +
                $"\t- Customer Name: {this.customer_name}\n" +
                $"\t- Customer Account Number: {this.customer_accountNo}");
        }

        // Main method to create an object of class
        static void Main(string[] args)
        {
            // Initializing the bank name of class
            Customer_Account.bank_name = "State Bank of India";
            // Calling constructor to create an new object
            Customer_Account account1 = new Customer_Account("John Doe", 93864876743);
            // Calling method to display details of customer
            account1.printInfo();
        }
    }
}