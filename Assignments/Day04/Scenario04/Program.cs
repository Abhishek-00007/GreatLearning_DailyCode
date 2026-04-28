using System;
using System.Collections.Generic;

/*User Story

As a music app developer, I want to manage playlists dynamically so that users can enjoy
sorted and flexible music experiences.
Problem Statement
Implement advanced collections for playlist management.

Requirements

Use LinkedList<string> to manage playlist songs (easy insertion/removal)
Use SortedList<int, string> to store songs sorted by rating
Use SortedDictionary<string, string> to map artist → song (sorted by artist name)

Expected Outcome
Add/remove songs efficiently
Maintain sorted playlist by rating
Retrieve songs artist-wise in sorted order
*/

class Program
{
    static void Main(string[] args)
    {
        // LinkedList to manage playlist songs
        LinkedList<string> playlist = new LinkedList<string>();
        playlist.AddLast("Song A");
        playlist.AddLast("Song B");
        playlist.AddLast("Song C");

        Console.WriteLine("Playlist:");
        foreach (var song in playlist)
        {
            Console.WriteLine(song);
        }

        // SortedList to store songs sorted by rating
        SortedList<int, string> ratedSongs = new SortedList<int, string>();
        ratedSongs.Add(5, "Song A");
        ratedSongs.Add(4, "Song B");
        ratedSongs.Add(3, "Song C");

        Console.WriteLine("\nRated Songs:");
        foreach (var kvp in ratedSongs)
        {
            Console.WriteLine($"Rating: {kvp.Key}, Song: {kvp.Value}");
        }

        // SortedDictionary to map artist → song
        SortedDictionary<string, string> artistSongs = new SortedDictionary<string, string>();
        artistSongs.Add("Artist A", "Song A");
        artistSongs.Add("Artist B", "Song B");
        artistSongs.Add("Artist C", "Song C");

        Console.WriteLine("\nArtist to Song Mapping:");
        foreach (var kvp in artistSongs)
        {
            Console.WriteLine($"Artist: {kvp.Key}, Song: {kvp.Value}");
        }
    }
}