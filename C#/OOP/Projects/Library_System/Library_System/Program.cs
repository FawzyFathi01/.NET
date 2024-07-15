/*
 System Library 

Home:- 
	                                      
WeleCome Library 
1- Sin in 
2- Sin Up 

Oredy Rsister (sin in ) 
	ID: —------------------
	Pass: —---------------
	Check 
ID ✔ Pass ✔ ⇒ Enter System 
ID ✔ pass X ⇒ Continue with “this is pass Wrong”
ID X pass X ⇒ “this is id & pass wrong” Return to Welcome sin in, sin up 
With ID Determined go Customer or Go Librad to System 
	           
New Resister (sin up )
	Customer || Librad
    	ID ⇒ Customer, “c+counter”   ID ⇒ Librad,”l+counter
	ID:- السيستم هيتم اعطاه 
	Pass: —------------
	Enter To System 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Customer 
	“Welecom Customer!!“ 
*1/ Display Book                                                               
 Book1:- ID Title Auther Year                                                  
 Book2:- ID Title Auther Year
Return To Welcom Customer                                                    

2/  BrowBook
⇒ Display BookBorrow
“Enter Id Book to Want Brraw:---input—- ”
!! input ⇒ check available? تتم عملية الاستعارة  ⇒ Enrol Book in Baroww Book 
	⇒ How Want Braw Book  (Yes Continue ||  No Return Welcome Customer)
⇒ NotAvailble continue to input (id) +“ is Book Not Valid” + Return to WelCom Customer.	

3/ Return BookBorrow 

4/ Exit —> Return WeleCome Library 
 
		...........................................................................................................

Librad

	“Welecom Librad!!“
1/ Add Book 
	⇒ Enter ID, Title, Auther, Year, 
	⇒ Enrol Books
	⇒ How Want to Add Book  (Yes Continue ||  No Return Welcome Librad)

2/ Remove Book
	⇒ Display Book ( ID, Title, Auther, Year)
	⇒ Enter ID Book:-  Continue until ID Correct  “Sucessed”
	⇒ How to Want to remove Book  (Yes Continue ||  No Return Welcome Librad)
	
3/Display Books (in the Library or Book Brawn )

4/ Display Customer Information

5/Exit ⇒  Return WeleCome Library 

		..........................................................................................................
Notes :- 


1/ Add Method to Customer To Return Book Borrow 
2/ improve Sin in , sin up 
3 Console.Clear()


 */

namespace LibraryBook
{

    internal class Program
    {
        static void Main(string[] args)
        {
            LibrarySystem lb = new LibrarySystem();
            lb.StartApp();


        }
    }
}
