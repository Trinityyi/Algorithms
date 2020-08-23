# Algorithms in C#

Implementation of commonly-used algorithms using C#. *Work in progress*

## Usage

Run the project from the command line and pass it an algorithm and data like so:

```sh
algorithms <algo_number> <algo_data>
```

Where `<algo_number>` is a number corresponding to the implemented algorithms (see below) and `<algo_data>` is an array of space-separated integer values.

This will run the selected algorithm and produce a **CSV** file with the following columns:

|step_no|step_description|operand_indices|current_state|
|---|---|---|---|

## Implemented algorithms

1. [Bubble sort](https://github.com/Trinityyi/Algorithms/blob/master/Sort/BubbleSort.cs) - [Wiki](https://en.wikipedia.org/wiki/Bubble_sort)
2. [Insertion sort](https://github.com/Trinityyi/Algorithms/blob/master/Sort/InsertionSort.cs) - [Wiki](https://en.wikipedia.org/wiki/Insertion_sort)
3. [Selection sort](https://github.com/Trinityyi/Algorithms/blob/master/Sort/SelectionSort.cs) - [Wiki](https://en.wikipedia.org/wiki/Selection_sort)
