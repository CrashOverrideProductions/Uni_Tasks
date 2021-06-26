#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 1.1P
#   Author:     Justin Bland
#   Date:       12/03/2020

# Define Tuple
Tuple_List = ("Monday", "Tuesday","Wednesday", "Thursday", "Friday", "Saturday", "Sunday")

# Define Set
Set_List = {"Monday", "Tuesday","Wednesday" , "Thursday", "Friday", "Saturday", "Sunday"}

# Define Dictionary
Dict_List = {"Monday":1, "Tuesday":2, "Wednesday":3, "Thursday":4, "Friday":5, "Saturday":6, "Sunday":7}

# Print Tuple (Data Type and Data)
print(type(Tuple_List))

x = 0
while x < len(Tuple_List):
    print(Tuple_List[x])
    x = x + 1
    
# Print Set (Data Type and Data)
print(type(Set_List))
for y in Set_List:
    print(y)

# Print Dictionary (Data Type and Data)
print(type(Dict_List))
for z in Dict_List:
    print(z)
