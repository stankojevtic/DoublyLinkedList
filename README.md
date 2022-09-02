# DoublyLinkedList Project

The project is written in .NET 6, IDE used for this project is Visual Studio 2022. 
No additional installations or dependencies are needed in order to execute the project.

Project specification:
Implement the custom double linked list (https://en.wikipedia.org/wiki/Doubly_linked_list):
  - Having AddFirst method
  - Having AddLast method
  - Having Remove method
  - Implement IEnumerable interface
  - Implement Quick Sort (https://en.wikipedia.org/wiki/Quicksort)
  - Use SOLID, KISS and DRY practices
  - Implement unit tests (tests are implemented using xUnit tool)
  
A doubly linked list is a linked data structure that consists of a set of sequentially linked records called nodes. 
Each node contains three fields: two link fields (references to the previous and to the next node in the sequence of nodes) 
and one data field. The beginning and ending nodes' previous and next links, respectively, point to some kind of terminator, 
typically a sentinel node or null, to facilitate traversal of the list.
