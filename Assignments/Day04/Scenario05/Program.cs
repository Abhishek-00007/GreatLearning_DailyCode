/*
User Story

As a system administrator, I want to schedule and prioritize tasks so that system performance is
optimized.

Problem Statement

Design a task scheduling system.

Requirements

Use Queue<string> for task execution order
Use Stack<string> for undoing last executed task
Use List<string> for all tasks
Use SortedDictionary<int, string> for priority-based tasks
Use HashSet<string> to ensure no duplicate tasks

Expected Outcome

Execute tasks in order
Undo last operation
Maintain priority-based scheduling
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Queue for task execution order
        Queue<string> taskQueue = new Queue<string>();
        taskQueue.Enqueue("Task 1");
        taskQueue.Enqueue("Task 2");
        taskQueue.Enqueue("Task 3");

        Console.WriteLine("Task Execution Order:");
        while (taskQueue.Count > 0)
        {
            Console.WriteLine(taskQueue.Dequeue());
        }

        // Stack for undoing last executed task
        Stack<string> undoStack = new Stack<string>();
        undoStack.Push("Task 1");
        undoStack.Push("Task 2");
        undoStack.Push("Task 3");

        Console.WriteLine("\nUndo Last Executed Task:");
        if (undoStack.Count > 0)
        {
            Console.WriteLine(undoStack.Pop());
        }

        // List for all tasks
        List<string> allTasks = new List<string> { "Task 1", "Task 2", "Task 3" };
        Console.WriteLine("\nAll Tasks:");
        foreach (var task in allTasks)
        {
            Console.WriteLine(task);
        }

        // SortedDictionary for priority-based tasks
        SortedDictionary<int, string> priorityTasks = new SortedDictionary<int, string>();
        priorityTasks.Add(1, "High Priority Task");
        priorityTasks.Add(2, "Medium Priority Task");
        priorityTasks.Add(3, "Low Priority Task");

        Console.WriteLine("\nPriority-Based Tasks:");
        foreach (var kvp in priorityTasks)
        {
            Console.WriteLine($"Priority: {kvp.Key}, Task: {kvp.Value}");
        }

        // HashSet to ensure no duplicate tasks
        HashSet<string> uniqueTasks = new HashSet<string>();
        uniqueTasks.Add("Task 1");
        uniqueTasks.Add("Task 2");
        uniqueTasks.Add("Task 1"); // Duplicate

        Console.WriteLine("\nUnique Tasks:");
        foreach (var task in uniqueTasks)
        {
            Console.WriteLine(task);
        }
    }
}