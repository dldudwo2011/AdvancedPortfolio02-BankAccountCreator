/*
 * 
 *        Purpose: Write a program that allows the user to create a bank account by setting its accountID, initial balance, and annual interest rate. It will also allow the
 *                 user to withdraw and deposit funds as well as deposit monthly interest to the bank account. The user will also be allowed to check the current bank account
 *                 by having an option to display its current information. The user will also have access to display all the transactions done with the account.
 *        
 *        
 *        Input: accountID (int), initial account balance (double), annual interest rate (double), amount to deposit or withdraw (double),  user choice to option (int)
 *        
 *        
 *        Process:  Create 10 methods which are GetSafeDouble(), GetSafeInt(), CreateBankAccount(), DisplayAccountInformation(), DisplayMenu(), DisplayCreateBankAccountMenu(),
 *                  WithdrawFundsAndWriteToFile(), DepositFundsAndWriteToFile(),  AddInterestAndWriteToFile(), ReadFromFileAndDisplayTransaction().
 *                  
 *                  GetSafeDouble() and GetSafeInt() methods will be used to prompt the user to enter a valid double or int values by displaying the message (string argument)
 *                  
 *                  CreateBankAccount() method will be used to display the "Create bank account menu" repeatedly until the user chooses to quit. This method creates a BankAccount object
 *                  that is customized by the user. Inside this method, a new BankAccount object will be created and do-while loops and  "Switch statement" will be implemented for each of the possible
 *                  user choice. GetSafeInt() and GetSafeDouble() methods will also be implemented to prompt the user to enter a valid input and prevent errors.
 *                  
 *                  Switch case 1 will be the accountID (int), it will prompt the user for the accountID and save the info to the BankAccount object created earlier.
 *                  GetSafeInt() method will be used.
 *                  
 *                  Switch case 2 will be the initial account balance (double), it will prompt the user for the initial balance and save the info to the BankAccount object created earlier.
 *                  GetSafeDouble() method will be used
 *                  
 *                  Switch case 3 will be the annual interest rate (double), it will prompt the user for the initial balance and save the info to the BankAccount object created earlier.
 *                  GetSafeDouble() method will be used.
 *                  
 *                  Switch case 4 will be the option to quit by simply setting the control variable for the loop (quit) to true. It will move the user back to the main menu.
 *                  
 *                  DisplayAccountInformation() method will be used to display the current account's information. It will take the BankAccount object as its parameter and simply display 
 *                  the accountID, DateCreated, Balance, and AnnualInterestRate values of that object. Console.WriteLine method and string interpolation will be used.
 *                  
 *                  DisplayMenu() method will be used to display the main menu with all the choices. Console.WriteLine() method will be used.
 *                  
 *                  DisplayCreateBankAccountMenu() method will be used to display the create bank account menu for the CreateBankAccount() method. Console.WriteLine() method will be used.
 *                  
 *                  WithdrawFundsAndWriteToFile() method will take a BankAccount object and file path (string) as its parameter. It will prompt the user for the amount to withdraw and
 *                  withdraw the specific amount of funds from the BankAccount object. It will then write to a file that is in the file path it received as its parameter. StreamWriter
 *                  class will be used and the append option of the class will be enabled. It will then write to the file about the transaction (accountID, withdrawal amount, transaction date, 
 *                  and ending balance) using the write method of the class. Try and catch block will be implemented to prevent any exceptions caused in the writing process.
 *                  
 *                  DepositFundsAndWriteToFile() method will be the same as WithdrawFundsAndWriteToFile() except it deposits instead of withdraw.
 *                  
 *                  AddInterestAndWriteToFile() method will be similar to the WithdrawFundsAndWriteToFile() except it calculates the monthly interest using the class method and deposits 
 *                  monthly interest to the bank account object.
 *                  
 *                  ReadFromFileAndDisplayTransaction() method will take file path (string) as its only parameter. The file path will be "C:\Users\skske\Documents". It will
 *                  then read all the information in the file line by line and display the transactions. StreamReader class and Console.WriteLine method will be used.
 *                  
 *                  In the main method, a bool variable named "quit" will be created for a do-while loop for a menu. A new bank account object with its default values will be created
 *                  to be used for other methods. The file path of the transaction file will be defined in a string variable. A StreamWriter class will be declared and used to create 
 *                  the transaction file in the file path.
 *                  
 *                  After all the variables are created a do-while loop will be declared to consistently display the menu until the user chooses to quit. It will be done by calling the
 *                  DisplayMenu() method and by using GetSafeInt() method to prompt the user for the choice and store the value. Inside the do-while loop, a switch statement will be declared.
 *                  
 *                  
 *                  Switch case 1 is out of the concern of this portfolio so it is not defined
 *                  
 *                  Switch case 2 is the option to create a bank account. In this case, CreateBankAccount() method will be called and its return value (BankAccount object) will be stored
 *                  to the bank account object created outside of the loop to update the bank account object with the user-entered values.
 *                  
 *                  Switch case 3 is the option to display the account's information. In this case, DisplayAccountInformation() method will be called 
 *                  and the bank account object created outside of the loop will be passed as its parameter.
 *                  
 *                  Switch case 4 is the option to withdraw a certain amount from the bank account. In this case, WithdrawFundsAndWriteToFile() method will be called.
 *                  BankAccount object created earlier and the filepath will be passed to its parameter.
 *                  
 *                  Switch case 5 is the option to deposit a certain amount to the bank account. In this case, DepositFundsAndWriteToFile() method will be called. 
 *                  BankAccount object created earlier and the filepath will be passed to its parameter.
 *                  
 *                  Switch case 6 is the option to add interest to a bank account. In this case, AddInterestAndWriteToFile() method will be called and BankAccount object created earlier
 *                  and the filepath will be passed to its parameter.
 *                  
 *                  Switch case 7 is the option to display transactions of the bank account. In this case,  ReadFromFileAndDisplayTransaction() method will be called and the file path 
 *                  defined outside of the loop will be passed as its parameter.
 *                  
 *                  Switch case 8 is the option to quit while saving the current account's information to a csv file. In this case, StreamWriter class will be created to
 *                  create a file named "(accountID).csv" to the same directory the transaction file is stored. It will then write the current account's information (account ID, 
 *                  balance, annual interest rate, date created) as a line. Try and catch statements will be used to catch any exceptions caused in the writing process. After finishing
 *                  writing to the file, the "quit" variable will be set to true so the loop will end. It will display a goodbye message at the end.             
 *  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------        
 *        Output: 1. Bank Account Menu
 *                        1. Load Account & Transactions from File
 *                        2. Create Bank Account
 *                        3. Display Account Information
 *                        4. Withdraw Funds
 *                        5. Deposit Funds
 *                        6. Add Interest
 *                        7. Display Transactions
 *                        8. Save Account & Transactions to File and Exit Program
 *                   Option:
 *                
 *                
 *                2. If the user selects 2
 *                        1. Create Bank Account Menu
 *                               1. Enter Account ID
 *                               2. Enter Initial Account Balance
 *                               3. Set Annual Interest Rate
 *                               4. Exit Account Creation
 *                           Option:
 *                               
 *                        2. If the user selects 1
 *                              1. Enter account ID:
 *                          
 *                           If the user selects 2
 *                              1. Enter initial account balance:
 *                              
 *                           If the user selects 3
 *                              1. Enter annual interest rate:
 *                           
 *                           if the user selects 4
 *                              1. (returned to the main menu)
 *                              
 *                   If the user selects 3
 *                        1. Account ID: (accountID)
 *                           Created: (date created)
 *                           Balance: $(current balance)
 *                           Annual Interest Rate: (annual interest rate in percentage)%
 *                   
 *                   If the user selects 4
 *                        1. Enter withdrawal amount:
 *                        
 *                   If the user selects 5
 *                        1. Enter deposit amount: 
 *                        
 *                   If the user selects 6
 *                        1. Added $(monthly interest amount) in interest  
 *                        
 *                   If the user selects 7
 *                        1. Account     Type       Amount                              Date                   Ending Balance
 *                          (accountID)  (type)   (amount involved in transaction)     (date of transation)    (remaining balance)
 *                              .           .                    .                              .                       .
 *                              .           .                    .                              .                       .
 *                              .           .                    .                              .                       .
 *                        
 *                   If the user selects 8
 *                        1. Goodbye ...  
 *   ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------        
 *        Test plan
 *        
 *        Test case 1: Create a bank account (menu option 2) and check it by displaying the account information (menu option 3)
 *        Test data: 12345 for accountID, 500 for initial account balance, 2.75 for annual interest rate
 *        Expected result: 1. Account ID: 12345
 *                            Created: 2021-04-11
 *                            Balance: $500
 *                            Annual Interest Rate: 2.75%
 *        
 *        Test case 2: Withdraw funds (menu option 4) from the bank account and check it by displaying the account information (menu option 3)
 *        Test data: 255.75 for the withdrawal amount
 *        Expected result: 1. Account ID: 12345
 *                            Created: 2021-04-11
 *                            Balance: $244.25
 *                            Annual Interest Rate: 2.75%
 *        
 *        Test case 3: Deposit funds to the bank account (menu option 5) and check it by displaying the account information (menu option 3)
 *        Test data: 355.84 for the deposit amount
 *        Expected result: 1. Account ID: 12345
 *                            Created: 2021-04-11
 *                            Balance: $600.09
 *                            Annual Interest Rate 2.75%
 *        
 *        Test case 4: Deposit monthly interest to the bank account (menu option 6) and check it by displaying the account information (menu option 3)
 *        Test data: N/A
 *        Expected result: 1. Added $1.38 in interest
 *        
 *                         2. Account ID: 12345
 *                            Created: 2021-04-11
 *                            Balance: $601.47
 *                            Annual Interest Rate 2.75%
 *        
 *        
 *        Test case 5: Display all the transactions performed in the previous tests (menu option 7)
 *        Test data: N/A
 *        Expected result: 1. Account     Type       Amount                              Date                   Ending Balance
 *                            12345        W          $255.75                           2021-04-11              $244.25
 *                            12345        D          $355.84                           2021-04-11              $600.09
 *                            12345        I          $1.38                             2021-04-11              $601.47
 *        
 *        Test case 6: Save account & transactions to file and exit program (menu option 8). Check to see if the csv file for account information and transactions are created and saved.
 *        Test data: N/A
 *        Expected result: 1. Goodbye ...
 *        
 *                         2. *Transaction file and account information file are created in the file path - C:\Users\skske\Documents      
 *  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------       
 *        Author: Youngjae Lee
 *        
 *        Last modified date: 2021 Apr 11
 */

using System;
using System.IO;
using System.Collections.Generic;


namespace AdvancedPortfolioPart2_Youngjae_Lee
{
    class Program
    {
        //getting the user-input(double) method
        static double GetSafeDouble(string message)
        {
            double doubleValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(message);
                validInput = double.TryParse(Console.ReadLine(), out doubleValue);
                if (!validInput)
                {
                    Console.WriteLine("  Invalid input! You must enter a double value for the answer");
                    Console.WriteLine();
                }
            }

            return doubleValue;
        }

        //getting the user-input(int) method
        static int GetSafeInt(string message)
        {
            int intValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(message);
                validInput = int.TryParse(Console.ReadLine(), out intValue);
                if (!validInput)
                {
                    Console.WriteLine("  Invalid input! You must enter an int value for the answer");
                    Console.WriteLine();
                }
            }

            return intValue;
        }


        //displays menu options to prompt accountID, balance, and annual interest rate. It returns a BankAccount object with what user had entered.
        static BankAccount CreateBankAccount()
        {
            //create a BankAccount object
            BankAccount bankAccount = new BankAccount();

            //setting DateCreated field to current date
            bankAccount.DateCreated = DateTime.Now;

            //setting exit initially to false
            bool exit = false;

            do
            {
                //calling the DisplayCreateBankAccountMenu to display options
                DisplayCreateBankAccountMenu();

                //prompting user for choice and storing in userChoice variable
                int userChoice = GetSafeInt("Option: ");

                //setting invalidInput initially to true
                bool invalidInput = true;
                switch (userChoice)
                {

                    //accountID
                    case 1:
                        
                        do
                        {
                            try
                            {
                                //prompt for account ID and store it in the class field
                                bankAccount.AccountID = GetSafeInt("Enter account ID: ");
                                invalidInput = false;
                            }

                            //catching exception that occurs if the accountID entered is not greater than zero
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        } while (invalidInput);

                        //resetting invalidInput to true
                        invalidInput = true;
                        break;

                    //balance
                    case 2:

                        do
                        {
                            try
                            {
                                //prompt for balance and store it in the class field
                                bankAccount.Balance = GetSafeDouble("Enter initial account balance: ");
                                invalidInput = false;
                            }

                            //catching exception that occurs if the balance entered is not greater than zero
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        } while (invalidInput);

                        //resetting invalidInput to true
                        invalidInput = true;
                        break;

                    //annual interest rate
                    case 3:
                        do
                        {
                            try
                            {
                                //prompt for annualInterestRate and store it in the class field
                                bankAccount.AnnualInterestRate = GetSafeDouble("Enter annual interest rate: ");
                                invalidInput = false;
                            }


                            //catching exception that occurs if the annual interest rate entered is not greater than zero
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        } while (invalidInput);

                        //resetting invalidInput to true
                        invalidInput = true;
                        break;

                    //quit
                    case 4:

                        //setting exit to true
                        exit = true;
                        break;

                    //setting default case to display invalid input message
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;


                }

            } while (!exit);

            //returning the BankAccount object
            return bankAccount;
        }

        //displays account information
        static void DisplayAccountInformation(BankAccount bankAccount)
        {
            Console.WriteLine($"Account ID : {bankAccount.AccountID}");
            Console.WriteLine($"Created: {bankAccount.DateCreated}");
            Console.WriteLine($"Balance: ${Math.Round((bankAccount.Balance),2)}");
            Console.WriteLine($"Annual Interest Rate: {bankAccount.AnnualInterestRate}%");
        }

        //displays menu
        static void DisplayMenu()
        {
            Console.WriteLine("Bank Account Menu");
            Console.WriteLine("\t1. Load Account & Transactions from File");
            Console.WriteLine("\t2. Create Bank Account");
            Console.WriteLine("\t3. Display Account Information");
            Console.WriteLine("\t4. Withdraw Funds");
            Console.WriteLine("\t5. Deposit Funds");
            Console.WriteLine("\t6. Add Interest");
            Console.WriteLine("\t7. Display Transactions");
            Console.WriteLine("\t8. Save Account & Transactions to File and Exit Program");
        }

        //displays CreateBankAccount menu
        static void DisplayCreateBankAccountMenu()
        {
            Console.WriteLine("Create Bank Account Menu");
            Console.WriteLine("\t1. Enter Account ID");
            Console.WriteLine("\t2. Enter Initial Account Balance");
            Console.WriteLine("\t3. Set Annual Interest Rate");
            Console.WriteLine("\t4. Exit Account Creation");

        }

        //withdraws funds and write the transaction to the file
        static void WithdrawFundsAndWriteToFile(BankAccount bankAccount, string filepath)
        {

            //prompts the user to enter for the amount to withdraw and stores the input value
            double amount = GetSafeDouble("Enter withdrawal amount: ");

            //calling WithDraw() class method to withdraw
            bankAccount.WithDraw(amount);
            try
            {
                //create a stream writer class and set append (bool) to true so it will append
                StreamWriter writer = new StreamWriter(filepath, true);

                //writing to the file
                writer.Write($"{bankAccount.AccountID},W,{Math.Round(amount,2)},{DateTime.Now},{Math.Round((bankAccount.Balance),2)}");

                //add a line
                writer.WriteLine();

                //close the file
                writer.Close();
            }

            //catches any exception in writing to file
            catch (Exception ex)
            {
                //displays the error message
                Console.WriteLine($"Error writing to file path {filepath} with exception {ex.Message}");
            }
        }

        //deposits funds and write the transaction to the file
        static void DepositFundsAndWriteToFile(BankAccount bankAccount, string filepath)
        {

            //prompts the user to enter for the amount to deposit and stores the input value
            double amount = GetSafeDouble("Enter deposit amount: ");

            //calling Deposit() class method to deposit
            bankAccount.Deposit(amount);
            try
            {
                //create a stream writer class and set append (bool) to true so it will append
                StreamWriter writer = new StreamWriter(filepath, true);

                //writing to the file
                writer.Write($"{bankAccount.AccountID},D,{Math.Round(amount,2)},{DateTime.Now},{Math.Round((bankAccount.Balance),2)}");

                //add a line
                writer.WriteLine();

                //close the file
                writer.Close();
            }

            //catches any exception in writing to file
            catch (Exception ex)
            {
                //displays the error message
                Console.WriteLine($"Error writing to file path {filepath} with exception {ex.Message}");
            }
        }

        //calculates monthly interest and add the amount to the balance
        static void AddInterestAndWriteToFile(BankAccount bankAccount, string filepath)
        {

            //calculates monthly interest using CalculateMonthlyInterest() class method
            double monthlyInterest = bankAccount.CalculateMonthlyInterest();

            //calling Deposit() class method to deposit the monthly interest
            bankAccount.Deposit(monthlyInterest);

            //displaying the amount added to the balance
            Console.WriteLine($"Added ${Math.Round((monthlyInterest),2)} in interest");

            try
            {
                //create a stream writer class and set append (bool) to true so it will append
                StreamWriter writer = new StreamWriter(filepath, true);

                //writing to the file
                writer.Write($"{bankAccount.AccountID},I,{Math.Round((monthlyInterest), 2)},{DateTime.Now},{Math.Round((bankAccount.Balance),2)}");

                //add a line
                writer.WriteLine();

                //close the file
                writer.Close();
            }

            //catches any exception in writing to file
            catch (Exception ex)
            {
                //displays the error message
                Console.WriteLine($"Error writing to file path {filepath} with exception {ex.Message}");
            }

        }


        static void ReadFromFileAndDisplayTransaction(string filepath)
        {
            try
            {
                //constructing a StreamReader instance for writing to a csv file
                StreamReader reader = new StreamReader(filepath);

                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4, 30}","Account", "Type", "Amount", "Date", "Ending Balance");

                //creating a string variable to store the line read from the csv file
                string lineText;

                //reading one line at time until we reach the end of the file (EOF)
                while ((lineText = reader.ReadLine()) != null)
                {
                    //splitting the line values into an array of value 
                    string[] lineArray = lineText.Split(',');

                    //storing the first element (The account ID) of the lineArray array
                    string accountID = lineArray[0];

                    //storing the second element (The type) of the lineArray array
                    string type = lineArray[1];

                    //storing the third element (The amount) of the lineArray array
                    string amount = lineArray[2];

                    //storing the fourth element (The date) of the lineArray array
                    string date = lineArray[3];

                    //storing the fifth element (The ending balance) of the lineArray array
                    string endingBalance = lineArray[4];

                    //displaying the accountID, type, amount, date, and ending balance
                    Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4, 11}", $"{accountID}", $"{type}", $"${amount}", $"{date}", $"${endingBalance}");
                }

                //closing the file
                reader.Close();
            }

            //catches any exception in reading file
            catch (Exception ex)
            {
                //displays the error message
                Console.WriteLine($"Error reading from file path {filepath} with exception {ex.Message}");
            }
        }
                        

        static void Main(string[] args)
        {
            //setting quit variable initially to false
            bool quit = false;

            //creating a bankaccount with its default value
            BankAccount bankAccount = new BankAccount();

            //hardcoding the file path
            string filepath = "C:\\Users\\skske\\Documents\\transaction.csv";

            //create a StreamWriter object to create a file in the file path specified
            StreamWriter writer = new StreamWriter(filepath);

            //closing the file
            writer.Close();


            do
            {
                //display menu
                DisplayMenu();

                //prompt the user for the choice and storing it in the userChoice variable
                int userChoice = GetSafeInt("Option: ");

                //switch statement
                switch (userChoice)
                {
                    //if the user wants to create a bank account
                    case 2:

                        //calling the CreateBankAccount() method and updating the bankAccount object based on its return value
                        bankAccount = CreateBankAccount();
                        break;

                    //if the user wants to display bank account information
                    case 3:
                        
                        //displays account information
                        DisplayAccountInformation(bankAccount);
                        break;

                    //if the user wants to withdraw
                    case 4:

                        //withdraws funds and write to file
                        WithdrawFundsAndWriteToFile(bankAccount, filepath);
                        break;

                    //if the user wants to deposit
                    case 5:

                        //deposits funds and write to file
                        DepositFundsAndWriteToFile(bankAccount, filepath);
                        break;

                    case 6:

                        //deposits monthly interest and write to file
                        AddInterestAndWriteToFile(bankAccount, filepath);
                        break;

                    //if the user wants to display transactions
                    case 7:

                        //reads from file and displays transactions
                        ReadFromFileAndDisplayTransaction(filepath);
                        break;

                    //if the user wants to save account & transactions to file and exit program
                    case 8:

                        try
                        {
                            //constructing a StreamWriter instance for writing to a csv file
                            StreamWriter writerForAccount = new StreamWriter($"C:\\Users\\skske\\Documents\\{bankAccount.AccountID}.csv");

                            //writing the account information to file
                            writerForAccount.Write($"{bankAccount.AccountID}, {bankAccount.Balance}, {bankAccount.AnnualInterestRate}, {bankAccount.DateCreated}");

                            //add a line
                            writerForAccount.WriteLine();

                            //close the file
                            writerForAccount.Close();
                        }

                        //catches any exceptions made from writing to file
                        catch (Exception ex)
                        {
                            //display the error message
                            Console.WriteLine($"Error writing to the file with exception {ex.Message}");
                        }

                        //good-bye message
                        Console.WriteLine("Goodbye ...");

                        //setting quit to true
                        quit = true;
                        break;

                    //setting default case to display invalid input message
                    default:
                        Console.WriteLine("Invalid input. Please try again");
                        break;


                }
            } while (!quit);

        }
    }
}
