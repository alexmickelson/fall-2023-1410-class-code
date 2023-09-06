
$15 hr
10 hrs a week for 40 weeks (not summer)
40 hrs a week for 12 weeks (summer)

15 × (10×40+40×12) = 13,200

## Life Goals

1. publish a book
2. Buy a house
3. Be financially stable

- Start writing
- finish writing
- find a publisher
- edit book
- get an editor
- early access readers for feedback
- implement the feedback

# Sorting algorithm

- get a list of unsorted numbers
  - get them from user input
    - make sure they are valid numbers
    - make sure the list is more than 1
- loop through a list of numbers
  - order numbers one by one
- print / ouput / return the results

DETERMINISTIC

```c#
// NON-Deterministic - could get different results for different inputs
List<int> GetListFromUser()
{
  // get multiple numbers from user
  // check for validity
}

List<int> SortFunction(List<int> inputList)
{
  // for loop and nested for loop
  // order numbers one by one 
}

void PrintFunction(List<int> inputList)
{
  // output numbers one by one to the console
}

```

Char vs Int

Ascii value

key length: 2
message length: 4

message: abcd
key: bc

output: bd

messageIndex % key.Length
3 % 2 = 1

## Menu Breakdown

1. present options to the user
2. Get menu option from the user
3. function to handle selected options
   1. user selected add number to list
      1. get new number from the user
      2. store it in the list
   2. user selects to print the list
      1. get numbers from list and output them
         1. separated by spaces and commas
