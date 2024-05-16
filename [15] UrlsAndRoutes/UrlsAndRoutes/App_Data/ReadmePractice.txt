1a. Delete default route
1b. Define static route from Home/Index to Home/Index via route constructor
1c. Define static route from Customer/Index to Customer/Index via MapRoute method
1d. Define static route from Admin/Index to Admin/Index via MapRoute method with named arguments

// use MapRoute from here on out

2. Remap old URL Shop/Index whose controller has been refactored away to Customer/List

3. Define a dynamic route to any controller/action

4. Define a dynamic route that defaults to the list action if no action in the URL is provided

5. Define a dynamic route that defaults to the list action of the CustomerController if no controller nor action in the URL is provided

6. Unit tests

7. Comment out previous routes and define a route that must begin with /Public but otherwise matches any controller/action with no default and unit test

8. Comment out previous routes and define a route the controller name must begin with 'X' but otherwise matches any controller/action with no default and unit test

9. Comment out previous routes and remap old URL /Shop to /Customer but leave the action dynamic and unit test

10. Fix the routing and unit test

11. Define 2 custom segment variables, the second with a default value and use 2 different ways to obtain them. 
	Render them in a new view Home/CustomVariables.

12. Define the 'order' segment variable as optional and give it a default value outside of the routing definition.

13. Define a route with a variable length and render values. -> done

14. Given a new controller Home in AdditionalControllers, route any URL starting with /Home to the new Controller and any other 
	requests to the old HomeController. -> done

15. All request to /Home shall be handled by the HomeController in the AdditionalControllers namespace, all other requests by
	the Controllers namespace. -> done

16. All request to /Home shall be handled by the HomeController in the AdditionalControllers namespace, if a match cannot be found 
	there, prevent the routing system from looking in other namespaces. -> done

17. Define a route that only matches controllers that start with the letter H and matches only actions that start with
	either Index or About. Additionally match only requests that use the GET-Http method. -> done

18. Constrain the given route so that it matches only when the id is an int between and including 10 and 20.
	-> done

19. Constrain the given route so that it matches only when the id consists of characters a-z and is at least 6 characters long.
	-> done

20. Define a route that always routes all Firefox users to Home/Index regardless of the URL. -> done

21. Define a route that maps the request /test to Customer/Index using attribute routing. -> done

22. Define a route that maps the request /Users/Add/"any string/"any int" to Customer/Create using attribute routing.

23. Refactor route /User/Add/'any string'/'any int' so that any int is constrained to ints and refactor route
	/Users/Add/any string/any string so that the 2nd any string only takes exactly 6 letters.