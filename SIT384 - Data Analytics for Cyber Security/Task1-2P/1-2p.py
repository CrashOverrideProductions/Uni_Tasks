#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 1.2P
#   Author:     Justin Bland
#   Date:       11/03/2020

# Get User Input and Display Prompt
try:
    Rect_Width = int(input("Please enter rectangle width: "))
    
    try:
        Rect_Height = int(input("Please enter rectangle height: "))

        try:
            
            # Verifiy User Inputs
            if Rect_Width <= 0:
                    print("Error: Rectangle width must be greater than 0")
            else:
                if Rect_Height <= 0:
                    print("Error: Rectangle height must be greater than 0")
                else:
                      
                    # Loop to Generate Output
                    for x in range(Rect_Height):
                        for y in range(Rect_Width):
                            print ('*', end = ' ')
                        print ('')

# Catch Statments for 
        except:
            print("Error: Something went wrong")

    except:
        print("Error: Rectangle height must be an integer, Please try again")  

except:
    print("Error: Rectangle width must be an integer, Please try again")      
    


