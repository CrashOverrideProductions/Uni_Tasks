#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 2.3P
#   Author:     Justin Bland
#   Date:       18/03/2020

# Import RegEx
import re

# Allowed Characters in Email Address
Allowed_Chars = ".+@[a-zA-Z0-9-.][\w]"

# Function to Verifiy Email is Valid
def Check_Email(x):
    return bool(re.match(Allowed_Chars,x))

# Get User Input 
User_Input = input("Please input your email address: ")

# Call Check_Email Function and Show Results
if Check_Email(User_Input):
    print("Email is valid")
    Split_List = User_Input.split("@")
    print("Email Address -  ", User_Input)
    print("Username -       ",Split_List[0]) 
    print("Host -           ", Split_List[1])
else:
    print("Email is not valid")