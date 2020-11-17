# CHRobinsonAPI
CHRobinson Interview API to find minimum countries needed to cross to get to a target country in continental North America.

# How to use
Type in the URL of the deployed API (in my case, https://chr-bataineh.azurewebsites.net) and add a forward slash "/" and the initials of a North American country in UPPER CASE.

This will return a list of the minimum numbers of countries you must enter to get there. The source of the trip will always be the USA. The country entered into the URL will
always be the destination from the USA.

# Example
 https://chr-bataineh.azurewebsites.net/PAN

 `["USA","MEX","GTM","HND","NIC","CRI","PAN"]`
 
# Implementation Overview
This API uses a dictionary, inverse dictionary, and a modified Djikstra's algorithm to calculate the shortest path. All countries are connected in an adjacency matrix with 
unweighted edges. The dictionary converts the received string to it's representative integer. Each country's representative integers are used in the breadth-first search to
maintain simplicity and better readability.

The inverse dictionary then takes the collected path and converts them back to the countries string abreviations. This is the list that is returned from the API.

<b>All North American Countries the API supports:</b>

United States, Canada, Mexico, Belize, Guatemala, El Salvador, Honduras, Nicaragua, Costa Rica, Panama

<b>Dictionary for reference:</b>

(USA, 0) (CAN, 1) (MEX, 2) (BLZ, 3) (GTM, 4) (SLV, 5) (HND, 6) (NIC, 7) (CRI, 8) (PAN, 9)

# Assumptions
1. The API will not need to be interactively modified, so only GET requests are allowed.
2. Security is not essential, therefore there are no credentials needed to access the API.
3. Hardcoded data is fine for this product (dictionaries, adjacency list) rather than pulling from a file / database.
