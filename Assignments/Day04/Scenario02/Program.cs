/*
User Story

As a product engineer, I want to track user activity and interactions so that I can improve
engagement analytics.

Requirements

Use List<string> to store posts
Use Dictionary<string, int> to track likes per post
Use HashSet<int> to track unique user IDs
Use Stack<string> to track recent actions (undo functionality)
Use Queue<string> to process notifications

Expected Outcome

Maintain unique users
Track likes efficiently
Implement undo feature
Process notifications sequentially
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> posts = new List<string>();
        Dictionary<string, int> likes = new Dictionary<string, int>();
        HashSet<int> uniqueUsers = new HashSet<int>();
        Stack<string> recentActions = new Stack<string>();
        Queue<string> notifications = new Queue<string>();

        // Adding posts
        posts.Add("Hello World!");
        posts.Add("Welcome to my profile!");

        // Tracking likes
        likes["Hello World!"] = 10;
        likes["Welcome to my profile!"] = 5;

        // Tracking unique users
        uniqueUsers.Add(1); // User ID 1
        uniqueUsers.Add(2); // User ID 2

        // Recent actions
        recentActions.Push("Liked a post");
        recentActions.Push("Commented on a post");

        // Processing notifications
        notifications.Enqueue("You have a new follower!");
        notifications.Enqueue("Your post received a like!");

        Console.WriteLine($"Total unique users: {uniqueUsers.Count}");
        Console.WriteLine($"Likes for 'Hello World!': {likes["Hello World!"]}");
        Console.WriteLine($"Most recent action: {recentActions.Peek()}");
        Console.WriteLine($"Next notification: {notifications.Dequeue()}");
    }
}