Npv Web Application
------------------------------------------------

INSTALLATION
Angular JS
Castle Windsor
MVC5
WebApi2
More details can be found in packages.config.

USER GUIDE
This Application provides simple Net Present Value for a given series of Cash Flows. 

Here is simple steps to use this application. 
1. Run this application throught Visual studio. Or for IIS host, go to root url. e.g. http://localhost:1847/
2. NPV calculator page will be displayed
3. NPV inputs field will be needed to be filled:
	a. Cash ($) : Cash Amount
	b. Cash series (#) : Number of times Cash ($) to be made
	c. Lower Bound (%) : Lower Bound Discount Rate
	d. Upper Bound (%) : Upper Bound Discount Rate
	e. Discount Rate Increment (%) : Discount Rate Increments
4. Press Calculate Button to calculate NPV for a given series of Cash Flows.  
   For example:
	 Lower Bound Discount Rate: 1.00%
	 Upper Bound Discount Rate: 15.00%
	 Discount Rate Increment: 0.25%
	 NPV for a given series of Cash Flows will be calculated at the following Discount Rate Levels: 1.00%,
	1.25%, 1.50%, 1.75%, 2.00% ... 14.00%, 14.25%, 14.50%, 14.75%, 15.00%

5. Press Reset Button to clear UI input