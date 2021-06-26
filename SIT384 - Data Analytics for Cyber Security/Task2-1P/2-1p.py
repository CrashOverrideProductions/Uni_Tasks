#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 2.1P
#   Author:     Justin Bland
#   Date:       18/03/2020

# Define n Factorial Function
def nFactorial(x):
    y = 1
    z = 2
    while z <= x:
        y *= z
        z += 1
    return y
    

# Variable to hold User Input
User_Input = int(0) 

# Get User Input and Display Prompt
try:
    User_Input = int(input("Please enter a Non-Negative Integer: "))
    
    try:
            
        # Verifiy User Inputs
        if User_Input < 0:
            print("Error: Please enter a Non-Negative Integer")
        else:
            # Call nFactorial Function
            Result = int(nFactorial(User_Input))
            print ("Factorial of ", User_Input, " : ",  Result )

# Catch Statments for 
    except:
        print("Error: Something went wrong")

except:
    print("Error: Rectangle width must be an integer, Please try again")      
    


